using System.ComponentModel.DataAnnotations;


namespace WebApplication3.Model
{
    public class Marks
    {
        [Key]
        public int I_name { get; set; }
        public String? Subject { get; set; }
        public int marks_alloted { get; set; }

    }
}
