using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using WorkPlanner.Models;
using WorkPlanner.ViewModel;

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
            return View();
        }

        public ViewResult New()
        {
            var statuses = _context.Statuses.ToList();

            var viewModel = new WorkOrderFormViewModel
            {
                Status = statuses
            };

            return View("WorkOrderForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var workOrders = _context.WorkOrders.SingleOrDefault(m => m.Id == id);

            if (workOrders == null)
                return HttpNotFound();

            var viewModel = new WorkOrderFormViewModel(workOrders)
            {
                Status = _context.Statuses.ToList()
            };

            return View("WorkOrderForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(WorkOrder workOrder)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new WorkOrderFormViewModel(workOrder)
                {
                   Status = _context.Statuses.ToList()
                };

                return View("WorkOrderForm", viewModel);
            }
            if (workOrder.Id == 0)
            {
                _context.WorkOrders.Add(workOrder);
            }
            else
            {
                var workOrderInDb = _context.WorkOrders.SingleOrDefault(m => m.Id == workOrder.Id);

                workOrderInDb.ObjectNumber = workOrder.ObjectNumber;
                workOrderInDb.Address = workOrder.Address;
                workOrderInDb.WorkDescription = workOrder.WorkDescription;
                workOrderInDb.Start = workOrder.Start;
                workOrderInDb.StatusId = workOrder.StatusId;
                workOrderInDb.DateOfInvoice = workOrder.DateOfInvoice;
                workOrderInDb.Comments = workOrder.Comments;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "WorkOrders");
        }
    }
}