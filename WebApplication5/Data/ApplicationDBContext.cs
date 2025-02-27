using Microsoft.EntityFrameworkCore;
using WebApplication5.Model;

namespace WebApplication5.Data
{
    public class ApplicationDBContext:DbContext
    {
     public DbSet<Patient> Patients { get; set; }
     public DbSet<Doctor> Doctors { get; set; }

     public DbSet<Appointment> Appointments { get; set; }


    }

}
