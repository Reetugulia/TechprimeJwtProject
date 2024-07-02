using System.ComponentModel.DataAnnotations.Schema;

namespace TechprimeJwtProject.Models
{
    [Table("division")]
    public class Division
    {
        public int Divisionid {  get; set; }
        public string Divisionname { get; set; }
       // public ICollection<Project> Projects { get; set; }
    }
}
