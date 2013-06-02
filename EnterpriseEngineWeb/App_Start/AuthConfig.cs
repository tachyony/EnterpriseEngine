﻿// <copyright file="AuthConfig.cs" company="EnterpriseEngine">
// Copyright © EnterpriseEngine 2013
// </copyright>
namespace EnterpriseEngineWeb
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using EnterpriseEngineWeb.Models;
    using Microsoft.Web.WebPages.OAuth;

    /// <summary>
    /// Auth Config
    /// </summary>
    public static class AuthConfig
    {
        /// <summary>
        /// Registers the auth.
        /// </summary>
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            // OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            // OAuthWebSecurity.RegisterTwitterClient(
            //    consumerKey: "",
            //    consumerSecret: "");

            // OAuthWebSecurity.RegisterFacebookClient(
            //    appId: "",
            //    appSecret: "");

            // OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
