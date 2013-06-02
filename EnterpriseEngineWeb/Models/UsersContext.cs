// <copyright file="UsersContext.cs" company="EnterpriseEngine">
// Copyright © EnterpriseEngine 2013
// </copyright>
namespace EnterpriseEngineWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Globalization;
    using System.Web.Mvc;
    using System.Web.Security;

    /// <summary>
    /// Users Context
    /// </summary>
    public class UsersContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersContext"/> class.
        /// </summary>
        public UsersContext()
            : base("DefaultConnection")
        {
        }

        /// <summary>
        /// Gets or sets the user profiles.
        /// </summary>
        /// <value>
        /// The user profiles.
        /// </value>
        public DbSet<UserProfile> UserProfiles
        {
            get;
            set;
        }
    }

    /// <summary>
    /// User Profile
    /// </summary>
    [Table("UserProfile")]
    public class UserProfile
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        /// <value>
        /// The user id.
        /// </value>
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Register External Login Model
    /// </summary>
    public class RegisterExternalLoginModel
    {
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        [Required]
        [Display(Name = "User name")]
        public string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the external login data.
        /// </summary>
        /// <value>
        /// The external login data.
        /// </value>
        public string ExternalLoginData
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Local Password Model
    /// </summary>
    public class LocalPasswordModel
    {
        /// <summary>
        /// Gets or sets the old password.
        /// </summary>
        /// <value>
        /// The old password.
        /// </value>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the new password.
        /// </summary>
        /// <value>
        /// The new password.
        /// </value>
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the confirm password.
        /// </summary>
        /// <value>
        /// The confirm password.
        /// </value>
        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Login Model
    /// </summary>
    public class LoginModel
    {
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        [Required]
        [Display(Name = "User name")]
        public string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether remember me.
        /// </summary>
        /// <value>
        ///   <c>true</c> if remember me; otherwise, <c>false</c>.
        /// </value>
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    /// <summary>
    /// Register Model
    /// </summary>
    public class RegisterModel
    {
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        [Required]
        [Display(Name = "User name")]
        public string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the confirm password.
        /// </summary>
        /// <value>
        /// The confirm password.
        /// </value>
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword
        {
            get;
            set;
        }
    }

    /// <summary>
    /// External Login
    /// </summary>
    public class ExternalLogin
    {
        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public string Provider
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the display name of the provider.
        /// </summary>
        /// <value>
        /// The display name of the provider.
        /// </value>
        public string ProviderDisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the provider user id.
        /// </summary>
        /// <value>
        /// The provider user id.
        /// </value>
        public string ProviderUserId
        {
            get;
            set;
        }
    }
}
