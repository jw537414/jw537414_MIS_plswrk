using jw537414_MIS_plswrk.Models;
using System.ComponentModel.DataAnnotations;

public class Class
{
    [Key]
    [Display(Name ="Class ID")]
    public int classID { get; set; }
    [Display(Name = "Class name")]
    [Required(ErrorMessage = "Class first name is required.")]
    [StringLength(20)]
    public string className { get; set; }
    [Display(Name = "Class description")]
    [Required(ErrorMessage = "Class description is required.")]
    [StringLength(200)]
    public string description { get; set; }


    [Display(Name = "Student ID")]
    public int studentID { get; set; }
    public virtual Student Student { get; set; }
    // the next two properties link the orderDetail to the Product
    [Display(Name = "Teacher ID")]
    public int teacherID { get; set; }
    public virtual Teacher Teacher { get; set; }
 }
