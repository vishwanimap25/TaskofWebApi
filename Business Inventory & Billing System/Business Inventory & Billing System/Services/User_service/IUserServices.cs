using Business_Inventory___Billing_System.Models.Dto_s;
using Business_Inventory___Billing_System.Models.Entities;

namespace Business_Inventory___Billing_System.Services.User_service
{
    public interface IUserServices
    {
        public Task<bool> RegisterUser(UserRegistrationDto register);
        public Task<Users> LoginUser(UserLoginDto login);
    }
}
