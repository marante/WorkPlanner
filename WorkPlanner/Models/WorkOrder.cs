using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkPlanner.Models
{
    public class WorkOrder
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; }
        public string WorkDescription { get; set; }
        public string Start { get; set; }
        public DateTime? DateOfInvoice { get; set; }
        public string Comments { get; set; }
    }
}