using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkPlanner.Models
{
    public class Status
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public static readonly byte NotBooked = 1;
        public static readonly byte NotFinished = 6;
        public static readonly byte Started = 7;
        public static readonly byte OnGoing = 8;
        public static readonly byte Finished = 9;
    }
}