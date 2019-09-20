using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace jw537414_MIS_plswrk.Models 
{
    public class Student
    {
        [Key]
        public int studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        public ICollection<Class> Class { get; set; }
    }
}