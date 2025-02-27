using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;
using WebApplication2.Model;
[ApiController]
[Route("api")]
public class WeatherForecastController : ControllerBase
{
    public static List<Student> students = new List<Student>();
    public static List<Account> accounts = new List<Account>();

    public static List<StudentAccount> studentaccounts = new List<StudentAccount>();
    [HttpGet("getstudentslist")]
    public List<Student> GetStudents()
    {
        return students;
    }
    [HttpGet("getonestudentdata")]
    public Student GetStudent(int id)
    {
        Student ans= students.Find(x => x.Id == id);
        return ans;
    }
    [HttpPost("insertstudentdata")]
    public string AddStudent(Student std)
    {
        students.Add(std);
        return "Record successfully submitted";
    }
    [HttpPut("updatestudentdata")]
    public string UpdateStudent(Student s)
    {
        Student one = students.Find(x => x.Id == s.Id);
        one.Name = s.Name;
        return " successfully updated";

    }
    [HttpDelete("deletestudentdata")]
    public string DeleteStudent(Student s)
    {
        Student one = students.Find(x => x.Id == s.Id);

        students.Remove(one);
        return "deleted data";
    }

    //[HttpGet("Accountlist")]
    //public List<Account> GetAccounts()
    //{
    //    return accounts;
    //}

    //[HttpGet("accountofspecific")]
    //public Account GetAccount(int id)
    //{
    //    Account ac = accounts.Find(x => x.Id == id);
    //    return ac;

    //}

    //[HttpPost("Accountinsertion")]




}
