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
    public class seaq2_ResultController : Controller
    {
        private DATABASE1Entities db = new DATABASE1Entities();

        // GET: seaq2_Result
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult seaq2Query(string name_of_the_violation, string brand_of_the_automobile)
        {
            var query = "exec seaq2 '" + name_of_the_violation + "', '" + brand_of_the_automobile + "'";
            Console.WriteLine(query);
            var data = db.Database.SqlQuery<seaq2_Result>(query);
            return View(data.ToList());
        }
    }
}
