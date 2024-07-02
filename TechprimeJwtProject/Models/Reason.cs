using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechprimeJwtProject.Models
{
    [Table("reason")]
    public class Reason
    {
        [Key]
        public int Reasonid { get; set; }
        public string Reasonname { get; set;}
       // public ICollection<Project> Projects { get; set; }
    }
}
