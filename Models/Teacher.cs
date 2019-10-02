using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace jw537414_MIS_plswrk.Models
{
    public class Teacher
    {
        [Key]
        [Display(Name ="Teacher ID")]
        public int teacherID { get; set; }
        [Display(Name = "Teacher first name")]
        [Required(ErrorMessage = "Teacher first name is required.")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display(Name = "Teacher last name")]
        [Required(ErrorMessage = "Teacher last name is required.")]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "Teacher email")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter most used email address")]
        public string email { get; set; }
        [Display(Name = "Teacher phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}|) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage = "Phone number must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }

        public ICollection<Class> Class { get; set; }
    }
}