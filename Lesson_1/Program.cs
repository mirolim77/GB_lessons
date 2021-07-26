using System;
using System.Security.Principal;


namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Environment.UserName;

            Console.WriteLine("Hello! " + userName +" "+ DateTime.Now);
        }
    }
}
