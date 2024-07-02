using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechprimeJwtProject.Models
{
    [Table("users")]
    public class Users
    {
        [Key]
        
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class UserLogin
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }

    public class UserConstants
    {
        // fetch the user & its role from DB
        public static List<Users> Users = new()
            {
                    new Users(){ Email="techprime@gmail.com",Password="tech@123"},
                   
            };

    }
}
