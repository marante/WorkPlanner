using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WorkPlanner.Models;

namespace WorkPlanner.ViewModel
{
    public class WorkOrderFormViewModel
    {
        public IEnumerable<Status> Status { get; set; }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "OBJ-NR")]
        public string ObjectNumber { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Adress")]
        public string Address { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Arbetsbeskrivning")]
        public string WorkDescription { get; set; }

        public string Start { get; set; }

        [Display(Name = "Fakturerat")]
        public DateTime? DateOfInvoice { get; set; }

        [Display(Name = "Kommentarer")]
        public string Comments { get; set; }

        [Required]
        [Display(Name = "Status")]
        public int? StatusId { get; set; }

        public WorkOrderFormViewModel()
        {
            Id = 0;
        }

        public WorkOrderFormViewModel(WorkOrder workOrder)
        {
            Id = workOrder.Id;
            ObjectNumber = workOrder.ObjectNumber;
            Address = workOrder.Address;
            WorkDescription = workOrder.WorkDescription;
            Start = workOrder.Start;
            DateOfInvoice = workOrder.DateOfInvoice;
            Comments = workOrder.Comments;
            StatusId = workOrder.StatusId;
        }
    }
}