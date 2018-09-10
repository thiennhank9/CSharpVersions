using System;
using static System.Console;

namespace _7ThrowEpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("");
            WriteLine(person.GetFirstName());
        }
    }

    class Person
    {
        public string Name { get; }
        public Person(string name) => Name = name ?? throw new ArgumentNullException(nameof(name));
        public string GetFirstName()
        {
            var parts = Name.Split(' ');
            return (Name.Length > 0) ? parts[0] : throw new InvalidOperationException("No name");
        }
        public string GetLastName() => throw new NotImplementedException();
    }
}
