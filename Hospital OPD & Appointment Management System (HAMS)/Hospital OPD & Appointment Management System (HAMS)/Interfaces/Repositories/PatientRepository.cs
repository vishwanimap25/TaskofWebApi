using Hospital_OPD___Appointment_Management_System__HAMS_.Data;
using Hospital_OPD___Appointment_Management_System__HAMS_.Modal.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hospital_OPD___Appointment_Management_System__HAMS_.Interfaces.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ApplicationDBcontext context;

        public PatientRepository(ApplicationDBcontext context)
        {
            this.context = context;
        }

        public async Task AddAsync(Patient patient)
        {
            await context.Patient.AddAsync(patient);
        }

        public void Delete(Patient patient)
        {
            context.Patient.Remove(patient);
        }

        public async Task<IEnumerable<Patient>> GetAllAsync()
        {
           return await context.Patient.ToListAsync();
        }

        public async Task<Patient> GetIdByAsync(int id)
        {
            return await context.Patient.FindAsync(id);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await context.SaveChangesAsync() > 0;
        }

        public void Update(Patient patient)
        {
            context.Patient.Update(patient);
        }
    }
}
