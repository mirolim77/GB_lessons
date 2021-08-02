using System;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int[,] arrayy = new int[2, 8];


            for (int i = 0; i < arrayy.GetLength(0); i++)
            {
                for (int j = 0; j < arrayy.GetLength(1); j++)
                {
                    arrayy[i, j] = rd.Next(10, 55);
                }
            }

            for (int i = 0; i < arrayy.GetLength(0); i++)
            {
                for (int j = 0; j < arrayy.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write("array[" + i + "][" + j + "]= " + arrayy[i, j] + ";  ");
                    }
                   
                }
            }
            Console.WriteLine('\n');
            //end   task1


            //start   task 2

            //string[,] phonebook = new string[5, 3];

            //for (int i = 0; i < phonebook.GetLength(0); i++)
            //{
            //    for (int j = 0; j < phonebook.GetLength(1); j++)
            //    {
            //        switch (j)
            //        {
            //            case 0: Console.Write("input Name: "); phonebook[i, j] = Console.ReadLine(); break;
            //            case 1: Console.Write("input phone number: "); phonebook[i, j] = Console.ReadLine(); break;
            //            case 2: Console.Write("input mail: "); phonebook[i, j] = Console.ReadLine(); break;
            //            default:
            //                break;
            //        }
            //    }
            //}
            //Console.WriteLine();

            //string person = ""; 
            //for (int i = 0; i < phonebook.GetLength(0); i++)
            //{
            //    for (int j = 0; j < phonebook.GetLength(1); j++)
            //    {
            //        person += phonebook[i, j]+ "    ";
            //    }
            //    Console.Write("person: "+i+"  "+person + '\n');
            //    person = "";
            //}
            //end task 2

            //start task 3
            string tekst = "";
            tekst =  Console.ReadLine();
            for (int i= tekst.Length;  i > 0; i--)
            {
                //var t = tekst[i-1];
                Console.Write(tekst[i-1]);
            }
            Console.WriteLine("-----"+'\n');


            Console.WriteLine("Start  Battleship"+'\n');
            char[,] array_war = new char[10, 10];
            for (int i = 0; i < array_war.GetLength(0); i++)
            {
                for (int j = 0; j < array_war.GetLength(0); j++)
                {
                    Console.Write(GetRandomCharacter("XO", rd));
                }
                Console.WriteLine();
            }



        }
        public static char GetRandomCharacter(string text, Random rng)
        {
            int index = rng.Next(text.Length);
            return text[index];
        }
        // end task 3

    }

}
