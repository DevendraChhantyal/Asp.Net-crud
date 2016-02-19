using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Deven.Web.Application123.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Fees { get; set; }
        public int Duration { get; set; }
        public  string DurationType { get; set; }
        public bool Status { get; set; }


    }
}