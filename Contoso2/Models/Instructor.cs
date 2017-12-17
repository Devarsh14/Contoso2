using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contoso2.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime HireDate { get; set; }

        public ICollection<Course> Courses { get; set; }
        public ICollection<OfficeAssignment> OfficeAssignment { get; set; }


    }
}