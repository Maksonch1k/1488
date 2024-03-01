using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthYear { get; set; }
        public string Faculty {  get; set; }

        public Person()
        {
           
        }
        public Person(string name, string surname, DateTime birthYear, string faculty)
        {
            this.Name = name;
            this.Surname = surname;
            this.BirthYear = birthYear;
            this.Faculty = faculty;
        }
        //вывод инфы о персоне
        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name} {Surname}");
            Console.WriteLine($"Год рождения: {BirthYear}");

           
        }
        public abstract int Age();


    }
}
