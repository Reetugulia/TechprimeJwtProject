using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechprimeJwtProject.Models
{
    [Table("status")]
    public class Status
    {
        [Key]
        public int Id { get; set; }
        public String StatusType {  get; set; }
    }
}
