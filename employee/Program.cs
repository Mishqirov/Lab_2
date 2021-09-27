using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Kolenkiv", "Pavel", "director", 9);
            Employee employee2 = new Employee("Zhaharov", "Andrey", "teacher", 3);
            Employee employee3 = new Employee("Ivanov", "Pavel", "head teacher", 7);
            employee1.MethodInfo();
            employee2.MethodInfo();
            employee3.MethodInfo();
            Console.ReadKey();
        }
    }
    class Employee
    {
        private string surname;
        public string SurName
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private string position;
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }
        private int experience;
        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
            }
        }
        public Employee(string surname, string name, string position, int exp)
        {
            this.SurName = surname;
            this.Name = name;
            this.Position = position;
            this.Experience = exp;
        }
        public void Method()
        {
            int salary = 0;
            if (Position == "director")
            {
                salary += 20000;
            }
            else if (Position == "head teacher")
            {
                salary += 18000;
            }
            else if (Position == "teacher")
            {
                salary += 12000;
            }
            Console.WriteLine($"Salary = {salary}");
        }
        public void MethodInfo()
        {
            Console.WriteLine($"{SurName}, {Name}, {Position},{Experience}");
            Method();
        }
    }
}
