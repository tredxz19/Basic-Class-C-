using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_PRACTICE_CSHARP
{
    class Person
    {
        public string name;
        public int age;
        public void introduceYourself()
        {
            Console.WriteLine("I'm " + name + " and I'm " + age + " years old.");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            void personInfo()
            {
                Person personObject = new Person();
                Console.Write("Name:");
                personObject.name = Console.ReadLine();
                Console.Write("Age:");
                personObject.age = Convert.ToInt32(Console.ReadLine());
                personObject.introduceYourself();
                personInfo();
                Console.Read();
                
            }
            personInfo();
        }
    }
}
