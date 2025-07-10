using System.ComponentModel.DataAnnotations;

namespace Hospital_OPD___Appointment_Management_System__HAMS_.Modal.Dto.Doctor_dto_folder
{
    public class DoctorCreateDto
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Specialization { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        
        public string PhoneNumber { get; set; }
        public string Qualification { get; set; }
        [Required]

        public string Gender { get; set; }
        public string AvailbilityDays { get; set; }


        [Required]
        public TimeSpan AvailableFrom { get; set; }  
        [Required]
        public TimeSpan AvailableTo { get; set; }
        public bool IsActive { get; set; }

        public int DepartmentId { get; set; }

    }
}
