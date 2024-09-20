using System;

namespace lab1{
    class Employee{
       
        public string Name;
        public string Email;
        public decimal Salary;

        public Employee(string name, string email, decimal salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee Email: {Email}");
            Console.WriteLine($"Employee Salary: {Salary:C}"); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("samjhana", "smagar00Agmail.com", 50000m);
            emp.DisplayEmployeeInfo();
            Console.ReadKey();
        }
    }
}
