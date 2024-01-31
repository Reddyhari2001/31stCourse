using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _31stCourse.Models
{
    public class Course
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public decimal CFee { get; set; }
        public string Technology { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}