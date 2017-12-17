using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Contoso2.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required ]
        [StringLength(50)]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50,ErrorMessage ="First Name can not be more than  50 words")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}