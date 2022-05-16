using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pre_Task.Enum;

namespace Pre_Task
{
    internal class Employee
    {
        public EmployeesName Name { get; }
        public int Age { get; }
        public ProgrammingLanguages ProgrammingLanguage { get; }

        public Employee()
        {
            Random random = new Random();
            Name = (EmployeesName)random.Next(0, 7);
            Age = random.Next(18, 40);
            ProgrammingLanguage = (ProgrammingLanguages)random.Next(0, 4);
        }

        public override string ToString()
        {
            return string.Format("Employye's name is {0}, age is {1}, programming language is {2}", Name, Age, ProgrammingLanguage);
        }

    }
}
