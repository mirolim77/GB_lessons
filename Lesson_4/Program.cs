using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] fulNames = new string[2, 3];

            for (int i = 0; i < fulNames.Length / 3; i++)
            {
                (fulNames[i, 0], fulNames[i, 1], fulNames[i, 2]) = InputGetName();
            }

            Console.WriteLine();

            for (int i = 0; i < fulNames.Length / 3; i++)
            {
                Console.WriteLine(GetFullName(fulNames[i, 0], fulNames[i, 1], fulNames[i, 2]));
            }


        }



        public static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return "Firstname: " + firstName + " LastName: " + lastName + " patronymic: " + patronymic;

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
