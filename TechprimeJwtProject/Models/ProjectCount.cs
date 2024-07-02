using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechprimeJwtProject.Models
{
    [Table("projectcount")]
    public class ProjectCount
    {
        [Key]
        public int TotalProjects { get; set; }
        public int Closed { get; set; }
        public int Running { get; set; }
        public int Delayed { get; set; }
        public int Cancelled { get; set; }
    }
}
