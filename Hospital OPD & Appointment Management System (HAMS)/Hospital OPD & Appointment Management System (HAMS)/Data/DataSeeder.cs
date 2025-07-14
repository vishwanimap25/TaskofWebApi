﻿using Hospital_OPD___Appointment_Management_System__HAMS_.Modal.Entities;

namespace Hospital_OPD___Appointment_Management_System__HAMS_.Data
{
    public static class DataSeeder
    {
        public static void SeedAdminUser(ApplicationDBcontext context)
        {
            if(!context.User.Any(u => u.Role == "Admin"))
            {
                var admin = new User
                {
                    Username = "admin",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("Admin@123"),  // use a strong default password
                    Role = "Admin"
                };

                context.User.Add(admin);
                context.SaveChanges();
            }

        }
    }
}
