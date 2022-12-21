using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2;

namespace WebApplication2.Controllers
{
    public class seaq_ResultController : Controller
    {
        private DATABASE1Entities db = new DATABASE1Entities();

        // GET: seaq_Result
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult seaqQuery(DateTime start, DateTime end)
        {
            var query = "exec seaq '" + start.ToString("yyyyMMdd HH:mm: ss") + "', '" + end.ToString("yyyyMMdd HH: mm:ss") + "'";
            Console.WriteLine(query);
            var data = db.Database.SqlQuery<seaq_Result>(query);
            return View(data.ToList());
        }

    }
}
