using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers;
[ApiController]
[Route("api")]
public class FirstexampleController : ControllerBase
{
   
    [HttpGet]
    public string GetName(string f_name,string l_name)
    {
        return f_name + " " + l_name;
    }
    [HttpGet("getstudentdetails")]
    public Student GetStudent(int rollno,String name)
    {
        Student student = new Student();
        student.Name = name;
        student.Id = rollno;
        return student;
    }
    [HttpGet("callingarrayclass")]
    public List<int> GetListitems(int n1,int n2,int n3,int n4,int n5)
    {
        List_array li = new List_array();
        li.num1 = n1;
        li.num2 = n2;
        li.num3 = n3;
        li.num4 = n4;
        li.num5 = n5;
        List<int> lis = new List<int>();
        lis.Add(li.num1);
        lis.Add(li.num2);
        lis.Add(li.num3);
        lis.Add(li.num4);
        lis.Add(li.num5);
        return lis;
    }
   
}

