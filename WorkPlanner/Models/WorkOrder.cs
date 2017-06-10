using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkPlanner.Models
{
    public class WorkOrder
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "OBJ-NR")]
        public string ObjectNumber { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Adress")]
        public string Address { get; set; }

        //Navigation Properties
        public Status Status { get; set; }

        [Display(Name = "Status")]
        [Required]
        public int StatusId { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Arbetsbeskrivning")]
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