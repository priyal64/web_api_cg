
using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Model
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        public string? PFirst_Name { get; set; }
        public string? PLast_Name { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }

    }
}
