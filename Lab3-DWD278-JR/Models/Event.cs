using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3_DWD278_JR.Models
{
    public class Event
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string State { get; set; }

    }
}