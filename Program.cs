using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company c1 = new Company("Acme", new DateTime(1983, 10, 21));

            // Create three employees
            Employee e1 = new Employee()
            {
                FirstName = "Racheal",
                LastName = "Green",
                Title = "Chief Fashion Officer",
                StartDate = new DateTime(2000, 2, 14)
            };
            Employee e2 = new Employee()
            {
                FirstName = "Joey",
                LastName = "Tribbiani",
                Title = "Chief Medical Officer",
                StartDate = new DateTime(2001, 10, 26)
            };
            Employee e3 = new Employee()
            {
                FirstName = "Monica",
                LastName = "Geller",
                Title = "Head Chef",
                StartDate = new DateTime(2002, 11, 21)
            };

            // Assign the employees to the company
            List<Employee> Employees = new List<Employee>();
            Employees.Add(e1);
            Employees.Add(e2);
            Employees.Add(e3);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            foreach (var employee in Employees)
            {
                employee.ListEmployees();
            }
        }
    }
}
