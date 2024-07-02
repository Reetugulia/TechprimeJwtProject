using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechprimeJwtProject.Models
{
    [Table("project")]
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string? ProjectName { get; set; }
      
        public int ReasonId { get; set; }

      
        public int TypeId { get; set; }

       
        
        public int DivisionId { get; set; }

     
        public int DepartmentId { get; set; }

       
        public int PriorityId { get; set; }

     
        public int CategoryId { get; set; }

        public int LocationId { get; set; }

        public int StatusId { get; set; }
        public  DateTime StartingDate { get; set; }
        public DateTime EndingndDate { get; set; }


    }
}
