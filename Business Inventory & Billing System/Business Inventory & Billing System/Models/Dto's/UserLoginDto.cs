using System.ComponentModel.DataAnnotations;

namespace Business_Inventory___Billing_System.Models.Dto_s
{
    public class UserLoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //public bool RememberMe { get; set; }
    }
}
