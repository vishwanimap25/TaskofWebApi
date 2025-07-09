using AutoMapper;
using Hospital_OPD___Appointment_Management_System__HAMS_.Interfaces.Repositories;
using Hospital_OPD___Appointment_Management_System__HAMS_.Modal.Dto.Doctor_dto_folder;
using Hospital_OPD___Appointment_Management_System__HAMS_.Modal.Entities;

namespace Hospital_OPD___Appointment_Management_System__HAMS_.Interfaces.Services
{
    public class DoctorService : IDoctorServices
    {
        private readonly DoctorRepository _repo;
        private readonly IMapper _mapper;
                                               
        public DoctorService(DoctorRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<DoctorReadDto> CreateDoctor(DoctorCreateDto dto)
        {
            var doctor = _mapper.Map<Doctor>(dto);
            await _repo.AddAsync(doctor);
            await _repo.SaveChangesAsync();
            return _mapper.Map<DoctorReadDto>(doctor);
        }

        public async Task<bool> DeleteDoctor(int id)
        {
            var doctor = await _repo.GetIdByAsync(id);
            if(doctor == null) {return false;}
            _repo.Delete(doctor);
            return await _repo.SaveChangesAsync();
        }

        public async  Task<IEnumerable<DoctorReadDto>> GetAllDoctors()
        {
            var doctor = await _repo.GetAllAsync();
            return _mapper.Map<IEnumerable<DoctorReadDto>>(doctor);
        }

        public async Task<DoctorReadDto> GetDoctorById(int id)
        {
            var doctor = await _repo.GetIdByAsync(id);
            return _mapper.Map<DoctorReadDto>(doctor);
        }

        public async Task<bool> UpdateDoctor(int id, DoctorCreateDto dto)
        {
            var doctor = await _repo.GetIdByAsync(id);
            if(doctor == null) { return false;}
            _repo.Update(doctor);
            return await _repo.SaveChangesAsync();
        }
    }
}
