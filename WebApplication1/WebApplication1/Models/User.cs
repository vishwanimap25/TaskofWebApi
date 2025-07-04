using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Column("StudentName", TypeName = "varchar(100)")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
