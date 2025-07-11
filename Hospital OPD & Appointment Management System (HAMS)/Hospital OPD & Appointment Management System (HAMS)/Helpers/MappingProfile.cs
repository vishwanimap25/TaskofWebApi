using AutoMapper;
using Hospital_OPD___Appointment_Management_System__HAMS_.Modal.Dto.Doctor_dto_folder;
using Hospital_OPD___Appointment_Management_System__HAMS_.Modal.Dto.Patient_dto_folder;
using Hospital_OPD___Appointment_Management_System__HAMS_.Modal.Entities;

namespace Hospital_OPD___Appointment_Management_System__HAMS_.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //(1) For Doctor Mapping
            CreateMap<Doctor, DoctorReadDto>();
            CreateMap<DoctorCreateDto, Doctor>();

            //(2) For Patient Mapping
            CreateMap<PatientCreateDto, Patient>();
        }


    }
}
