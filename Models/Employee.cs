using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUDHTNLHELPERS.Models
{
    public class Employee
    {

        [Display(Name = "Ssn")]
        public int id { get; set; }

        [Display(Name = "First name")]
        [Required (ErrorMessage ="first name is required ya 3m ent")]
        [StringLength(20,ErrorMessage ="aw3a t3dy 20")]
        public string fname { get; set; }


        [Display(Name = "last name")]
        public string lname { get; set; }

        [Range(18,60)]
        public int? age { get; set; }
        [Range (1600,3000)]
        public decimal? salary { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress][Required (ErrorMessage = "first name is required ya 3m ent")]
       [System.Web.Mvc.Remote("Emailexists","Default",ErrorMessage ="email EXists !!!)")]
        public string Email { get; set; }
        [Display(Name = "password")]
        [DataType(DataType.Password)]
        public string pwd { get; set; }
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("pwd")]
         public string cpwd { get; set; }
            [DataType(DataType.Url)]
            [Url]
        public string URL { get; set; }

        [DataType(DataType.Date)]
        
        [Display(Name ="Date of birth")]

        public DateTime? DOB { get; set; }
        
        [DataType(DataType.MultilineText)]
        public string address { get; set; }
        [ForeignKey("Department")]
        public int? Deptid { get; set; }

        public virtual Department Department { get; set; }









    }
}