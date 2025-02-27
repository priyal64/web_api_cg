using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication5.Model
{
    public class Appointment
    {
        public int Appointment_Id { get; set; }

        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public virtual Doctor? Doctor { get; set; }

        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public virtual Patient? Patient { get; set; }


    }
}
