using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[,] fulNames = new string[2, 3];

            for (int i = 0; i < fulNames.Length; i++)
            {
                (string userName, string lastName, string patronymic) = InputGetName();
                for (int j = 0; j < fulNames.GetLength(1); j++)
                {
                    fulNames[i,j] = userName + " " + lastName + " " + patronymic;
                }

            }
          
                
                    

                     


               
          



        }



        public static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return firstName + " " + lastName + " " + patronymic;

        }

        public static (string firstName, string lastName, string patronymic) InputGetName()
        {
            Console.WriteLine("Input FirsName");
            string firstName = Console.ReadLine();
            Console.WriteLine("Input LastName");
            string lastName = Console.ReadLine();
            Console.WriteLine("Input patronymic");
            string patronymic = Console.ReadLine();
            return (firstName, lastName, patronymic);
        }
        enum FullName
        {
            firstName,
            lastName,
            patronymic,
        }

    }


}
