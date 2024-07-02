using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TechprimeJwtProject.Models
{
    [Table("location")]
    public class Location
    {
       
            [Key]
            public int Locationid { get; set; }
            public string Locationname { get; set; }
       // public ICollection<Project> Projects { get; set; }

    }
}
