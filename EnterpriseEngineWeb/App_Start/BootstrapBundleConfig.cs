// <copyright file="BootstrapBundleConfig.cs" company="EnterpriseEngine">
// Copyright © EnterpriseEngine 2013
// </copyright>
using System.Web.Optimization;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(EnterpriseEngineWeb.App_Start.BootstrapBundleConfig), "RegisterBundles")]

namespace EnterpriseEngineWeb.App_Start
{
    /// <summary>
    /// Bootstrap Bundle Config
    /// </summary>
    public class BootstrapBundleConfig
    {
        /// <summary>
        /// Registers the bundles.
        /// </summary>
        public static void RegisterBundles()
        {
            // Add @Styles.Render("~/Content/bootstrap") in the <head/> of your _Layout.cshtml view
            // Add @Scripts.Render("~/bundles/bootstrap") after jQuery in your _Layout.cshtml view
            // When <compilation debug="true" />, MVC4 will render the full readable version. When set to <compilation debug="false" />, the minified version will be rendered automatically
            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap*"));
            BundleTable.Bundles.Add(new StyleBundle("~/Content/bootstrap").Include("~/Content/bootstrap.css", "~/Content/bootstrap-responsive.css"));
        }
    }
}
