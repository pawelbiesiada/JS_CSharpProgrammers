using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Exercises.MyExercises
{
    public record User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public abstract class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }

        public virtual void CalculatingSalary()
        {
            string response = "Obliczam wypłatę dla " + EmployeeName;
            Console.Write(response);
            Console.Write(Environment.NewLine);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            Employee employee = obj as Employee;
            if (employee == null)
                return false;

            return EmployeeId == employee.EmployeeId && EmployeeName.Equals(employee.EmployeeName);
        }

        public override int GetHashCode()
        {
            return 13 * EmployeeId * EmployeeName.GetHashCode();
        }
    }

    public class Director : Employee
    {
        public void GetBonus()
        {
            Console.WriteLine("Wypłacam bonus");
        }

        public override void CalculatingSalary()
        {
            base.CalculatingSalary();

            int salary = 10000;
            string response = " kwota:" + salary.ToString();
            Console.WriteLine(response);
        }
    }
    public class Secretary : Employee
    {
        public override void CalculatingSalary()
        {
            base.CalculatingSalary();

            int salary = 7000;
            string response = " kwota:" + salary.ToString();
            Console.WriteLine(response);
        }
    }
    public class Programmer : Employee
    {
        public override void CalculatingSalary()
        {
            base.CalculatingSalary();

            int salary = 7500;
            string response = " kwota:" + salary.ToString();
            Console.WriteLine(response);
        }
    }


    public class EmployeeTest
    {
        public void Test()
        {
            var employees = new Employee[]
            {
                new Director {EmployeeId = 1, EmployeeName = "John" },
                new Secretary {EmployeeId = 2, EmployeeName = "Mark" },
                new Secretary {EmployeeId = 3, EmployeeName = "Paul" },
                new Programmer {EmployeeId = 4, EmployeeName = "Matt" },
                new Programmer {EmployeeId = 5, EmployeeName = "Pitt" },
             new Director { EmployeeId = 1, EmployeeName = "John" },
             new Secretary { EmployeeId = 1, EmployeeName = "John" },
        };

            employees.Distinct();


            foreach (var emp in employees)
            {
                emp.CalculatingSalary();

                if(emp is Director)
                {
                    ((Director)emp).GetBonus();
                }
            }
        }
    }
}
