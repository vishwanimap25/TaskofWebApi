using Hospital_OPD___Appointment_Management_System__HAMS_.Modal.Entities;

namespace Hospital_OPD___Appointment_Management_System__HAMS_.Modal.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; } //foregin key
        public int DoctorId { get; set; } //foregin key
        public DateTime AppointmentDate { get; set; }
        public string TimeSlot { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }



        //navigation property
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }

    }
}

