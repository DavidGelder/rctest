using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TXTextControl.ReportingCloud;

namespace reportingcloudtestM.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string sApiKey = "vt9BNpa7SCPK6gSVhBPaPMZk6tlVPlYaAnO9RaghRe8";

            ReportingCloud rc = new ReportingCloud(sApiKey);
            List<Template> templates = rc.ListTemplates();

            return View(templates);
        }
    }
}