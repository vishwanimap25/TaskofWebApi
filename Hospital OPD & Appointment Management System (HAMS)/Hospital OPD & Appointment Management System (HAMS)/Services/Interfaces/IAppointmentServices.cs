using Hospital_OPD___Appointment_Management_System__HAMS_.Modal.Dto.Appointment_dto_folder;

namespace Hospital_OPD___Appointment_Management_System__HAMS_.Services.Interfaces
{
    public interface IAppointmentServices
    {
        Task<IEnumerable<AppointmentReadDto>> GetAllAppointmentsAync();
        Task<AppointmentReadDto> GetAppointmentByIdAsync();
        Task<AppointmentReadDto> CreateAppointmentsAync(AppointmentCreateDto dto);
        Task UpdateAppointmentAsync(int id, AppointmentCreateDto dto);
        Task<bool> DeleteAppointmentAsync(int id);
    }
}
