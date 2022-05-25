using System;

namespace Classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public void ListEmployees()
        {
           Console.WriteLine($"{FirstName} {LastName} works for Acme as {Title} since {StartDate}.");
        }
    }
}