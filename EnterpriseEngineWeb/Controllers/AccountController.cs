﻿// <copyright file="AccountController.cs" company="EnterpriseEngine">
// Copyright © EnterpriseEngine 2013
// </copyright>
namespace EnterpriseEngineWeb.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Transactions;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Security;
    using DotNetOpenAuth.AspNet;
    using EnterpriseEngineWeb.Filters;
    using EnterpriseEngineWeb.Models;
    using Microsoft.Web.WebPages.OAuth;
    using WebMatrix.WebData;
    
    /// <summary>
    /// Account Controller
    /// </summary>
    [Authorize]
    [InitializeSimpleMembership]
    public class AccountController : Controller
    {
        /// <summary>
        /// Manage Message Id
        /// </summary>
        public enum ManageMessageId
        {
            /// <summary>
            /// Change Password Success
            /// </summary>
            ChangePasswordSuccess,

            /// <summary>
            /// Set Password Success
            /// </summary>
            SetPasswordSuccess,

            /// <summary>
            /// Remove Login Success
            /// </summary>
            RemoveLoginSuccess,
        }

        // GET: /Account/Login

        /// <summary>
        /// Logins the specified return URL.
        /// </summary>
        /// <param name="returnUrl">The return URL.</param>
        /// <returns>Action Result</returns>
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return this.View();
        }

        // POST: /Account/Login

        /// <summary>
        /// Logins the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="returnUrl">The return URL.</param>
        /// <returns>Action Result</returns>
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid && WebSecurity.Login(model.UserName, model.Password, persistCookie: model.RememberMe))
            {
                return this.RedirectToLocal(returnUrl);
            }

            // If we got this far, something failed, redisplay form
            ModelState.AddModelError(string.Empty, "The user name or password provided is incorrect.");
            return this.View(model);
        }

        // POST: /Account/LogOff

        /// <summary>
        /// Logs the off.
        /// </summary>
        /// <returns>Action Result</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            WebSecurity.Logout();
            return this.RedirectToAction("Index", "Home");
        }

        // GET: /Account/Register

        /// <summary>
        /// Registers this instance.
        /// </summary>
        /// <returns>Action Result</returns>
        [AllowAnonymous]
        public ActionResult Register()
        {
            return this.View();
        }

        // POST: /Account/Register

        /// <summary>
        /// Registers the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Action Result</returns>
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                try
                {
                    WebSecurity.CreateUserAndAccount(model.UserName, model.Password);
                    WebSecurity.Login(model.UserName, model.Password);
                    return this.RedirectToAction("Index", "Home");
                }
                catch (MembershipCreateUserException e)
                {
                    ModelState.AddModelError(string.Empty, ErrorCodeToString(e.StatusCode));
                }
            }

            // If we got this far, something failed, redisplay form
            return this.View(model);
        }

        // POST: /Account/Disassociate

        /// <summary>
        /// Disassociates the specified provider.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="providerUserId">The provider user id.</param>
        /// <returns>Action Result</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Disassociate(string provider, string providerUserId)
        {
            string ownerAccount = OAuthWebSecurity.GetUserName(provider, providerUserId);
            ManageMessageId? message = null;

            // Only disassociate the account if the currently logged in user is the owner
            if (ownerAccount == User.Identity.Name)
            {
                // Use a transaction to prevent the user from deleting their last login credential
                using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.Serializable }))
                {
                    bool hasLocalAccount = OAuthWebSecurity.HasLocalAccount(WebSecurity.GetUserId(User.Identity.Name));
                    if (hasLocalAccount || OAuthWebSecurity.GetAccountsFromUserName(User.Identity.Name).Count > 1)
                    {
                        OAuthWebSecurity.DeleteAccount(provider, providerUserId);
                        scope.Complete();
                        message = ManageMessageId.RemoveLoginSuccess;
                    }
                }
            }

            return this.RedirectToAction("Manage", new { Message = message });
        }

        // GET: /Account/Manage

        /// <summary>
        /// Manages the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>Action Result</returns>
        public ActionResult Manage(ManageMessageId? message)
        {
            ViewBag.StatusMessage =
                message == ManageMessageId.ChangePasswordSuccess ? "Your password has been changed."
                : message == ManageMessageId.SetPasswordSuccess ? "Your password has been set."
                : message == ManageMessageId.RemoveLoginSuccess ? "The external login was removed."
                : string.Empty;
            ViewBag.HasLocalPassword = OAuthWebSecurity.HasLocalAccount(WebSecurity.GetUserId(User.Identity.Name));
            ViewBag.ReturnUrl = Url.Action("Manage");
            return this.View();
        }

        // POST: /Account/Manage

        /// <summary>
        /// Manages the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Action Result</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Manage(LocalPasswordModel model)
        {
            bool hasLocalAccount = OAuthWebSecurity.HasLocalAccount(WebSecurity.GetUserId(User.Identity.Name));
            ViewBag.HasLocalPassword = hasLocalAccount;
            ViewBag.ReturnUrl = Url.Action("Manage");
            if (hasLocalAccount)
            {
                if (ModelState.IsValid)
                {
                    // ChangePassword will throw an exception rather than return false in certain failure scenarios.
                    bool changePasswordSucceeded;
                    try
                    {
                        changePasswordSucceeded = WebSecurity.ChangePassword(User.Identity.Name, model.OldPassword, model.NewPassword);
                    }
                    catch (Exception)
                    {
                        changePasswordSucceeded = false;
                    }

                    if (changePasswordSucceeded)
                    {
                        return this.RedirectToAction("Manage", new { Message = ManageMessageId.ChangePasswordSuccess });
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "The current password is incorrect or the new password is invalid.");
                    }
                }
            }
            else
            {
                // User does not have a local password so remove any validation errors caused by a missing
                // OldPassword field
                ModelState state = ModelState["OldPassword"];
                if (state != null)
                {
                    state.Errors.Clear();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        WebSecurity.CreateAccount(User.Identity.Name, model.NewPassword);
                        return this.RedirectToAction("Manage", new { Message = ManageMessageId.SetPasswordSuccess });
                    }
                    catch (Exception e)
                    {
                        ModelState.AddModelError(string.Empty, e);
                    }
                }
            }

            // If we got this far, something failed, redisplay form
            return this.View(model);
        }

        // POST: /Account/ExternalLogin

        /// <summary>
        /// Externals the login.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="returnUrl">The return URL.</param>
        /// <returns>Action Result</returns>
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult ExternalLogin(string provider, string returnUrl)
        {
            return new ExternalLoginResult(provider, Url.Action("ExternalLoginCallback", new { ReturnUrl = returnUrl }));
        }

        // GET: /Account/ExternalLoginCallback

        /// <summary>
        /// Externals the login callback.
        /// </summary>
        /// <param name="returnUrl">The return URL.</param>
        /// <returns>Action Result</returns>
        [AllowAnonymous]
        public ActionResult ExternalLoginCallback(string returnUrl)
        {
            AuthenticationResult result = OAuthWebSecurity.VerifyAuthentication(Url.Action("ExternalLoginCallback", new { ReturnUrl = returnUrl }));
            if (!result.IsSuccessful)
            {
                return this.RedirectToAction("ExternalLoginFailure");
            }

            if (OAuthWebSecurity.Login(result.Provider, result.ProviderUserId, createPersistentCookie: false))
            {
                return this.RedirectToLocal(returnUrl);
            }

            if (User.Identity.IsAuthenticated)
            {
                // If the current user is logged in add the new account
                OAuthWebSecurity.CreateOrUpdateAccount(result.Provider, result.ProviderUserId, User.Identity.Name);
                return this.RedirectToLocal(returnUrl);
            }
            else
            {
                // User is new, ask for their desired membership name
                string loginData = OAuthWebSecurity.SerializeProviderUserId(result.Provider, result.ProviderUserId);
                ViewBag.ProviderDisplayName = OAuthWebSecurity.GetOAuthClientData(result.Provider).DisplayName;
                ViewBag.ReturnUrl = returnUrl;
                return this.View("ExternalLoginConfirmation", new RegisterExternalLoginModel { UserName = result.UserName, ExternalLoginData = loginData });
            }
        }

        // POST: /Account/ExternalLoginConfirmation

        /// <summary>
        /// Externals the login confirmation.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="returnUrl">The return URL.</param>
        /// <returns>Action Result</returns>
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult ExternalLoginConfirmation(RegisterExternalLoginModel model, string returnUrl)
        {
            string provider = null;
            string providerUserId = null;

            if (User.Identity.IsAuthenticated || !OAuthWebSecurity.TryDeserializeProviderUserId(model.ExternalLoginData, out provider, out providerUserId))
            {
                return this.RedirectToAction("Manage");
            }

            if (ModelState.IsValid)
            {
                // Insert a new user into the database
                using (UsersContext db = new UsersContext())
                {
                    UserProfile user = db.UserProfiles.FirstOrDefault(u => u.UserName.ToLower() == model.UserName.ToLower());

                    // Check if user already exists
                    if (user == null)
                    {
                        // Insert name into the profile table
                        db.UserProfiles.Add(new UserProfile { UserName = model.UserName });
                        db.SaveChanges();
                        OAuthWebSecurity.CreateOrUpdateAccount(provider, providerUserId, model.UserName);
                        OAuthWebSecurity.Login(provider, providerUserId, createPersistentCookie: false);
                        return this.RedirectToLocal(returnUrl);
                    }
                    else
                    {
                        ModelState.AddModelError("UserName", "User name already exists. Please enter a different user name.");
                    }
                }
            }

            ViewBag.ProviderDisplayName = OAuthWebSecurity.GetOAuthClientData(provider).DisplayName;
            ViewBag.ReturnUrl = returnUrl;
            return this.View(model);
        }

        // GET: /Account/ExternalLoginFailure

        /// <summary>
        /// Externals the login failure.
        /// </summary>
        /// <returns>Action Result</returns>
        [AllowAnonymous]
        public ActionResult ExternalLoginFailure()
        {
            return this.View();
        }

        /// <summary>
        /// Externals the logins list.
        /// </summary>
        /// <param name="returnUrl">The return URL.</param>
        /// <returns>Action Result</returns>
        [AllowAnonymous]
        [ChildActionOnly]
        public ActionResult ExternalLoginsList(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return this.PartialView("_ExternalLoginsListPartial", OAuthWebSecurity.RegisteredClientData);
        }

        /// <summary>
        /// Removes the external logins.
        /// </summary>
        /// <returns>Action Result</returns>
        [ChildActionOnly]
        public ActionResult RemoveExternalLogins()
        {
            ICollection<OAuthAccount> accounts = OAuthWebSecurity.GetAccountsFromUserName(User.Identity.Name);
            List<ExternalLogin> externalLogins = new List<ExternalLogin>();
            foreach (OAuthAccount account in accounts)
            {
                AuthenticationClientData clientData = OAuthWebSecurity.GetOAuthClientData(account.Provider);

                externalLogins.Add(new ExternalLogin
                {
                    Provider = account.Provider,
                    ProviderDisplayName = clientData.DisplayName,
                    ProviderUserId = account.ProviderUserId,
                });
            }

            ViewBag.ShowRemoveButton = externalLogins.Count > 1 || OAuthWebSecurity.HasLocalAccount(WebSecurity.GetUserId(User.Identity.Name));
            return this.PartialView("_RemoveExternalLoginsPartial", externalLogins);
        }

        /// <summary>
        /// Errors the code to string.
        /// </summary>
        /// <param name="createStatus">The create status.</param>
        /// <returns>Error Code</returns>
        private static string ErrorCodeToString(MembershipCreateStatus createStatus)
        {
            // See http://go.microsoft.com/fwlink/?LinkID=177550 for
            // a full list of status codes.
            switch (createStatus)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "User name already exists. Please enter a different user name.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "A user name for that e-mail address already exists. Please enter a different e-mail address.";

                case MembershipCreateStatus.InvalidPassword:
                    return "The password provided is invalid. Please enter a valid password value.";

                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }

        /// <summary>
        /// Redirects to local.
        /// </summary>
        /// <param name="returnUrl">The return URL.</param>
        /// <returns>Action Result</returns>
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return this.Redirect(returnUrl);
            }
            else
            {
                return this.RedirectToAction("Index", "Home");
            }
        }

        /// <summary>
        /// External Login Result
        /// </summary>
        internal class ExternalLoginResult : ActionResult
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="ExternalLoginResult"/> class.
            /// </summary>
            /// <param name="provider">The provider.</param>
            /// <param name="returnUrl">The return URL.</param>
            public ExternalLoginResult(string provider, string returnUrl)
            {
                this.Provider = provider;
                this.ReturnUrl = returnUrl;
            }

            /// <summary>
            /// Gets the provider.
            /// </summary>
            public string Provider
            {
                get;
                private set;
            }

            /// <summary>
            /// Gets the return URL.
            /// </summary>
            public string ReturnUrl
            {
                get;
                private set;
            }

            /// <summary>
            /// Enables processing of the result of an action method by a custom type that inherits from the <see cref="T:System.Web.Mvc.ActionResult"/> class.
            /// </summary>
            /// <param name="context">The context in which the result is executed. The context information includes the controller, HTTP content, request context, and route data.</param>
            public override void ExecuteResult(ControllerContext context)
            {
                OAuthWebSecurity.RequestAuthentication(this.Provider, this.ReturnUrl);
            }
        }
    }
}
