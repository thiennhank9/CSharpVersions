using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Expression_bodiedMember
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            fname = firstName;
            lname = lastName;
        }

        private string fname;
        private string lname;

        public override string ToString() => $"{fname} {lname}".Trim();
        public void DisplayName() => Console.WriteLine(ToString());
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Mandy", "Dejesus");
            Console.WriteLine(p);
            p.DisplayName();
        }
    }
}
