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
        [Required(ErrorMessage = "Student first name is required.")]
        [StringLength(20)]
        public string firstName { get; set; }

        [Display(Name = "Student last name")]
        [Required(ErrorMessage = "Student last name is required.")]
        [StringLength(20)]
        public string lastName { get; set; }

        [Display(Name = "Student email")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter student email address ending in @ohio.edu")]
        public string email { get; set; }

        [Display(Name = "Student phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}|) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage = "Phone number must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }

        public ICollection<Class> Class { get; set; }

    }
}