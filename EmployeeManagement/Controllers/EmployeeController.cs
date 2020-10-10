using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {


        //Object Initializer Syntax
        Person emp1 = new Person() { FirstName = "kamal", Surname = "Pandit", Address = "Kapan", Salary = 45000.0 };
        Person emp2 = new Person() { FirstName = "Ashish", Surname = "Kuinkel", Address = "Kharibot", Salary = 30000.0 };
        Person emp3 = new Person() { FirstName = "Roshan", Surname = "Rai", Address = "Jorpati", Salary = 30000.0 };
        Person emp4 = new Person() { FirstName = "Ranjit", Surname = "Tamang", Address = "Kapan", Salary = 25000.0 };
        Person emp5 = new Person() { FirstName = "Subash", Surname = "Pandit", Address = "Sindhupalchowk", Salary = 100000.0 };
        Person emp6 = new Person() { FirstName = "Cosmik", Surname = "Koirala", Address = "Kapan", Salary = 35000.0 };
        Person emp7 = new Person() { FirstName = "Bibek", Surname = "Lama", Address = "Jorpati", Salary = 60000.0 };
        Person emp8 = new Person() { FirstName = "Paras", Surname = "Tiwari", Address = "Chabahil", Salary = 75000.0 };

        List<Person> employees = new List<Person>() { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8};

        return View(employees);
    }
}