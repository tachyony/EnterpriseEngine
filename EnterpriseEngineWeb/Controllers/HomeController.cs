// <copyright file="HomeController.cs" company="EnterpriseEngine">
// Copyright © EnterpriseEngine 2013
// </copyright>
namespace EnterpriseEngineWeb.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using EnterpriseEngineWeb.EnterpriseApi;

    /// <summary>
    /// Home Controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Home page.
        /// </summary>
        /// <returns>Action Result</returns>
        public ActionResult Index()
        {
            ViewBag.Message = "Enterprise number guesser.";
            return this.View();
        }

        /// <summary>
        /// Engine result.
        /// </summary>
        /// <returns>Action Result</returns>
        [HttpPost]
        public ActionResult EngineResult()
        {
            DecisionType decType = new DecisionType();
            decType.Result = false;
            decType.RandomString = Request.Form["TheWord"];
            decType.CheckBox = new List<bool>();
            for (int h = 0; h < 132; h++)
            {
                decType.CheckBox.Add(Request.Form["RadioButtonYes" + h].ToString() == "Yes");
            }

            try
            {
                EnterpriseApiClient eapiClient = new EnterpriseApiClient("EnterpriseApi");
                eapiClient.Open();
                DecisionType decisionResult = eapiClient.GetDecision(decType);
                eapiClient.Close();
                ViewBag.RandomString = "Decision result.";
                ViewBag.Result = decType.Result ? "Yes" : "No";
            }
            catch (Exception eek)
            {
                ViewBag.RandomString = eek.Message;
                ViewBag.Result = "No";
            }

            ViewBag.Message = "Decision result.";
            return this.View();
        }
    }
}
