
using System.ComponentModel.DataAnnotations;
namespace WebApplication5.Model
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        public String? DOC_First_Name { get; set; }
        public string? DOC_Last_Name { get; set; }

        public string? Specialization { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }

    }
}
