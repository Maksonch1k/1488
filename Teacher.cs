using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Teacher:Person
    {
        public string Faculty {  get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }

        public Teacher(string name, string surname, DateTime birthYear, string faculty, string position, int experience)
        {
            Faculty = faculty;
            Position = position;
            Experience = experience;
        }

        public override int Age()
        {
            throw new NotImplementedException();
        }
        
    }
}
