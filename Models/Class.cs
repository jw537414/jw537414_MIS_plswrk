using jw537414_MIS_plswrk.Models;
using System.ComponentModel.DataAnnotations;

public class Class
{
    [Key]
    public int classID { get; set; }
    public string className { get; set; }
    public string description { get; set; }



    public int studentID { get; set; }
    public virtual Student Student { get; set; }
    // the next two properties link the orderDetail to the Product
    public int teacherID { get; set; }
    public virtual Teacher Teacher { get; set; }
 }
