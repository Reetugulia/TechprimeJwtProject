using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TechprimeJwtProject.Models
{
    [Table("Category")]
    public class Category
    {
       
            [Key]
            public int Categoryid { get; set; }
            public string Categoryname { get; set; }
      //  public ICollection<Project> Projects { get; set; }

    }
}
