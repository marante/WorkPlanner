using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WorkPlanner.Models;

namespace WorkPlanner.Dtos
{
    public class WorkOrderDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string ObjectNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        public int StatusId { get; set; }

        [Required]
        [StringLength(255)]
        public string WorkDescription { get; set; }

        [Required]
        [StringLength(255)]
        public string Start { get; set; }

        [Display(Name = "Fakturerat")]
        public DateTime? DateOfInvoice { get; set; }

        [StringLength(255)]
        [Display(Name = "Kommentarer")]
        public string Comments { get; set; }
    }
}