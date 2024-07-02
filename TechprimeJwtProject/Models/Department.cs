using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechprimeJwtProject.Models
{
    [Table("department")]
    public class Department
    {
        [Key] 
        public int Departmentid {  get; set; }
        public string Departmentname {  get; set; }
      //  public ICollection<Project> Projects { get; set; }
    }
}
