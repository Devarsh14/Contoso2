using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contoso2.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }

        public int? InstructorID { get; set; }

        public virtual Instructor Administrator { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

    }
}