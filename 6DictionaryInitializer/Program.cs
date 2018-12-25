using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6DictionaryInitializer
{
    public class User
    {
        private string name;
        public User(string str)
        {
            name = str;
        }
        public void printName()
        {
            Console.WriteLine(name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Old
            Dictionary<string, User> usersOld = new Dictionary<string, User>()
            {
                { "admin", new User("admin") }
            };

            // New
            Dictionary<string, User> usersNew = new Dictionary<string, User>()
            {
                ["admin"] = new User("admin")
            };

            usersNew["admin"].printName();
        }

    }
}
