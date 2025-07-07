using Business_Inventory___Billing_System.Db_context;
using Business_Inventory___Billing_System.Models.Dto_s;
using Business_Inventory___Billing_System.Models.Entities;
using Business_Inventory___Billing_System.Services.User_service;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Generators;

namespace Business_Inventory___Billing_System.Services.User
{
    public class UserServices : IUserServices
    {
        private readonly AppDBcontext context;

        public UserServices(AppDBcontext context)
        {
            this.context = context;
        }


        //User Registration
        public async Task<bool> RegisterUser(UserRegistrationDto register)
        {
            if (register.Password != register.ConfirmPassword)
            {
                return false;
            }

            var userExites = await context.Users.AnyAsync(u => u.Email == register.Email);
            if (userExites)
            {
                return false;
            }
            //string hashedPassword = BCrypt.Net.BCrypt.HashPassword(register.Password);
            var user = new Users
            {
                FullName = register.FullName,
                Email = register.Email,
                Password = register.Password,
                ConfirmPassword = register.ConfirmPassword,
                Role = "Admin"
            };



            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
            return true;
        }


        //User Login
        public async Task<Users> LoginUser(UserLoginDto login)
        {
            var userss = await context.Users.FirstOrDefaultAsync(u => u.Email == login.Email);

            if (userss == null)
            {
                return null;
            }

            return userss;
        }


    }

}

