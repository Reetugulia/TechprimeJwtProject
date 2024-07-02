using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechprimeJwtProject.Models
{
    [Table("types")]
    public class Types
    {
        [Key]
        public int Typeid { get; set; }
        public string? Typename {  get; set; }
       // public ICollection<Project> Projects { get; set; }
    }
}
