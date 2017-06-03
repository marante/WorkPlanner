using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkPlanner.Models;

namespace WorkPlanner.Controllers
{
    public class WorkOrdersController : Controller
    {
        private ApplicationDbContext _context;

        public WorkOrdersController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: WorkOrders
        public ViewResult Index()
        {
            var orders = _context.WorkOrders.ToList();
            return View(orders);
        }
    }
}