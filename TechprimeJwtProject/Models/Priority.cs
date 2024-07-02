using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechprimeJwtProject.Models
{
    [Table("priority")]
    public class Priority
    {
        [Key]
        public int Priorityid {  get; set; }
        public string Priorityname { get; set; }
      //  public ICollection<Project> Projects { get; set; }
    }
}
