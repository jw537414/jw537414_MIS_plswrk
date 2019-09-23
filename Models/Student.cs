using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace jw537414_MIS_plswrk.Models 
{
    public class Student
    {
        [Display(Name = "Student ID")]
        public int studentID { get; set; }

        [Display(Name = "Student first name")]
        public string firstName { get; set; }

        [Display(Name = "Student last name")]
        public string lastName { get; set; }

        [Display(Name = "Student email")]
        public string email { get; set; }

        [Display(Name = "Student phone number")]
        public string phone { get; set; }

        public ICollection<Class> Class { get; set; }

    }
}