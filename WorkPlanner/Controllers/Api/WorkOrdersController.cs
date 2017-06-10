using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using WorkPlanner.Dtos;
using WorkPlanner.Models;

namespace WorkPlanner.Controllers.Api
{
    public class WorkOrdersController : ApiController
    {
        private ApplicationDbContext _context;

        public WorkOrdersController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<WorkOrderDto> GetWorkOrders()
        {
            return _context.WorkOrders.ToList().Select(Mapper.Map<WorkOrder, WorkOrderDto>);
        }

        public IHttpActionResult GetWorkOrder(int id)
        {
            var workOrder = _context.WorkOrders.SingleOrDefault(w => w.Id == id);

            if (workOrder == null)
                return NotFound();

            return Ok(Mapper.Map<WorkOrder, WorkOrderDto>(workOrder));
        }

        [HttpPost]
        public IHttpActionResult CreateWorkOrder(WorkOrderDto workOrderDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var workOrder = Mapper.Map<WorkOrderDto, WorkOrder>(workOrderDto);
            _context.WorkOrders.Add(workOrder);
            _context.SaveChanges();

            workOrderDto.Id = workOrder.Id;

            return Created(new Uri(Request.RequestUri + "/" + workOrder.Id), workOrderDto);
        }

        [HttpPut]
        public void UpdateWorkorder(int id, WorkOrderDto workOrderDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var workOrderInDb = _context.WorkOrders.SingleOrDefault(w => w.Id == id);

            if (workOrderInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(workOrderDto, workOrderInDb);

            _context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteWorkorder(int id)
        {
            var workOrderInDb = _context.WorkOrders.SingleOrDefault(w => w.Id == id);

            if (workOrderInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.WorkOrders.Remove(workOrderInDb);
            _context.SaveChanges();
        }
    }
}
