using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Student:Person
    {
        
        public Student(string name, string surname, DateTime birthYear, string faculty) : base(name, surname, birthYear, faculty)
        {
            Faculty = faculty;
        }

        public override int Age()
        {
            throw new NotImplementedException();
        }
    }
}
