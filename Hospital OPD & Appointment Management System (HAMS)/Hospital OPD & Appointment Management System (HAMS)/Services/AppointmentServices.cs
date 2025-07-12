using Hospital_OPD___Appointment_Management_System__HAMS_.Modal.Dto.Appointment_dto_folder;
using Hospital_OPD___Appointment_Management_System__HAMS_.Modal.Entities;
using Hospital_OPD___Appointment_Management_System__HAMS_.Repositories.Interfaces;
using Hospital_OPD___Appointment_Management_System__HAMS_.Services.Interfaces;

namespace Hospital_OPD___Appointment_Management_System__HAMS_.Services
{
    public class AppointmentServices : IAppointmentServices
    {
        private readonly IAppointmentRepository _repo;

        public AppointmentServices(IAppointmentRepository repo)
        {
            _repo = repo;
        }

        public async Task<AppointmentReadDto> CreateAppointmentsAync(AppointmentCreateDto dto)
        {
            var patient = await _repo.GetIdByAsync(dto.PatientId);
            var doctor = await _repo.GetIdByAsync(dto.DoctorId);

            if (patient == null || doctor == null)
            {
                throw new Exception("Patient or Doctor not found");
            }

            var appointment = new Appointment
            {
                PatientId = dto.PatientId,
                DoctorId = dto.DoctorId,
                AppointmentDate = dto.AppointmentDate,
                Reason = dto.Reason,
                Status = dto.Status,
                CreatedAt = DateTime.UtcNow,
            };

            await _repo.AddAsync(appointment);
            await _repo.SaveChangesAsync();

            return new AppointmentReadDto
            {
                Id = appointment.Id,
                PatientId = appointment.PatientId,
                PatientName = patient.PatientName,      
                DoctorId = appointment.DoctorId,
                DoctorName = doctor.DoctorName,         
                AppointmentDate = appointment.AppointmentDate,
                Reason = appointment.Reason,
                Status = appointment.Status,
                CreatedAt = appointment.CreatedAt
            };
        }


        public async Task<bool> DeleteAppointmentAsync(int id)
        {
            var apot = await _repo.GetIdByAsync(id);
            if(apot == null)
            {
                return false;
            }
            _repo.Delete(apot);
            await _repo.SaveChangesAsync();
            return true;
        }

        public Task<IEnumerable<AppointmentReadDto>> GetAllAppointmentsAync()
        {
            
        }

        public Task<AppointmentReadDto> GetAppointmentByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAppointmentAsync(int id, AppointmentCreateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
