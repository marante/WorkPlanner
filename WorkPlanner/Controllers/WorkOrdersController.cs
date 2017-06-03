using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkPlanner.Controllers
{
    public class WorkOrdersController : Controller
    {
        // GET: WorkOrders
        public ActionResult Index()
        {
            return View();
        }
    }
}