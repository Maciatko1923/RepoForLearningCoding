using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Basics
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Reading data from keyboard, m - new line, t -tabulacja
            Console.WriteLine("WHATS YOUR NAME?");
            String name = Console.ReadLine();

            if (name.Length == 0)
            {
                Console.Error.WriteLine("\n\t error:name has no letters");

            }
            if (name.Length == 2)
            {
                Console.WriteLine("this is not a name");
            }

            if (name[0] == name[1])
            {
                Console.WriteLine("first two letters are the same");
            }

            var sex = ReturnedSex(name);
            //static means you can call the method without creating the object

            if (sex) Console.WriteLine(name + " is for girl");
            Console.ReadLine();
        }
        public static bool ReturnedSex(String name)
        {
            Boolean IsItGirl = false;

            if (name[name.Length - 1] == 'a')
            {
                IsItGirl = true;
            }
            else
            {
                IsItGirl = false;
            }
            return IsItGirl;
        }
    }
}
