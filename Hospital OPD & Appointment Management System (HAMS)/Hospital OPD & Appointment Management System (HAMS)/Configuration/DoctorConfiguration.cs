using Hospital_OPD___Appointment_Management_System__HAMS_.Modal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital_OPD___Appointment_Management_System__HAMS_.Configuration
{
    public class DoctorConfiguration //: IEntityTypeConfiguration<Doctor>
    {
        //public void Configure(EntityTypeBuilder<Doctor> builder)
        //{
        //    builder.HasKey(d => d.Id);
        //    builder.Property(d => d.FullName).IsRequired();
        //    builder.Property(d => d.Specialization).IsRequired();
        //    builder.Property(d => d.Email).IsRequired();
        //    builder.Property(d => d.PhoneNumber).IsRequired().HasMaxLength(10);
        //    builder.Property(d => d.Gender).IsRequired().HasMaxLength(10);

        //    builder.HasMany(d => d.Appointments)
        //        .WithOne(a => a.Doctor)
        //        .HasForeignKey(a => a.DoctorId)
        //        .OnDelete(DeleteBehavior.Restrict);

        //}

        
    }
}
