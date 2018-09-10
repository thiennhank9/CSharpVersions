using static System.Console;

namespace _6NullPropagator
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                Name = "ABC",
                studentDetails = new Details()
                {
                    Email = "abc@xyz.com",
                    Address = "HCMC"
                }
            };

            Student student2 = new Student()
            {
                Name = "CBA"
            };

            WriteLine("Student 1:");
            ShowInfo(student1);
            WriteLine("\nStudent 2:");
            ShowInfo(student2);
        }

        static void ShowInfo(Student student)
        {
            WriteLine(student?.Name ?? "No name");
            WriteLine(student?.studentDetails?.Address ?? "No address");
            WriteLine(student?.studentDetails?.Email ?? "No email provided");
        }
    }

    class Student
    {
        public string Name { get; set; }
        public Details studentDetails { get; set; }
    }

    class Details
    {
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
