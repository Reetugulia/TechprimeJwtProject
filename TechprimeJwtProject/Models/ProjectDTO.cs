namespace TechprimeJwtProject.Models
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        public string Projectname { get; set; }
        public string typename { get; set; }
        public string reasonname { get; set; }
        public string categoryname {  get; set; }
        public string locationname {  get; set; }
        public string priorityname {  get; set; }
        public string departmentname {  get; set; }
        public string divisionname {  get; set; }
        public string statusType {  get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingndDate { get; set; }
    }
}
