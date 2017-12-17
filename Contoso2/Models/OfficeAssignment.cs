using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contoso2.Models
{
    public class OfficeAssignment
    {
        public int ID { get; set; }
 
        public string Location { get; set; }
        public int InstructorID { get; set; }

        public Instructor Instructor { get; set; }



    }
}