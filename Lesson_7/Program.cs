using System;

namespace Lesson_7
{
    class Program
    {
        class Cross
        {
            static int SIZE_X = 5;
            static int SIZE_Y = 5;

            static char[,] field = new char[SIZE_Y, SIZE_X];

            static char PLAYER_DOT = 'X';
            static char AI_DOT = 'O';
            static char EMPTY_DOT = '.';

            static Random random = new Random();

            private static void InitField()
            {
                for (int i = 0; i < SIZE_Y; i++)
                {
                    for (int j = 0; j < SIZE_X; j++)
                    {
                        field[i, j] = EMPTY_DOT;
                    }
                }
            }


            private static void PrintField()
            {
                Console.Clear();
                Console.WriteLine("-------");
                for (int i = 0; i < SIZE_Y; i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < SIZE_X; j++)
                    {
                        Console.Write(field[i, j] + "|");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("-------");
            }

            private static void SetSym(int y, int x, char sym)
            {
                field[y, x] = sym;
            }

            private static bool IsCellValid(int y, int x)
            {
                if (x < 0 || y < 0 || x > SIZE_X - 1 || y > SIZE_Y - 1)
                {
                    return false;
                }

                return field[y, x] == EMPTY_DOT;
            }

            private static bool IsFieldFull()
            {
                for (int i = 0; i < SIZE_Y; i++)
                {
                    for (int j = 0; j < SIZE_X; j++)
                    {
                        if (field[i, j] == EMPTY_DOT)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            private static void playerMove()
            {
                int x, y;
                do
                {
                    Console.WriteLine("Координат по строке ");
                    Console.WriteLine("Введите координаты вашего хода в диапозоне от 1 до " + SIZE_Y);
                    x = Int32.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("Координат по столбцу ");
                    Console.WriteLine("Введите координаты вашего хода в диапозоне от 1 до " + SIZE_X);
                    y = Int32.Parse(Console.ReadLine()) - 1;
                } while (!IsCellValid(y, x));
                SetSym(y, x, PLAYER_DOT);
            }
            private static bool CheckWinX(char sym)
            {
                int sum = 1;
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1) - 1; j++)
                    {
                        if (field[i, j] == field[i, j + 1] && field[i, j] == sym)
                        {
                            sum++;
                        }
                        else
                        {
                            sum = 1;
                            break;
                        }
                    }
                    if (sum >= SIZE_X)
                    {
                        return true;
                    }
                }

                return false;
            }

            private static bool CheckWinY(char sym)
            {
                int sum = 1;
                for (int i = 0; i < field.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        if (field[i, j] == field[i + 1, j] && field[i, j] == sym)
                        {
                            sum++;
                        }
                        //else
                        //{
                        //    sum = 1;
                        //    break;
                        //}
                    }
                    if (sum >= SIZE_Y)
                    {
                        return true;
                    }
                }

                return false;
            }

            private static bool CheckWinXY(char sym)
            {
                int sum = 1;
                for (int j=0,i = 0; i < field.GetLength(0)-1; i++,j++)
                {                   
                        if (field[i, j] == field[i + 1, j+1] && field[i, j] == sym)
                        {
                            sum++;
                        }
                    if (sum >= SIZE_Y)
                    {
                        return true;
                    }
                }

                return false;
            }




            private static bool CheckWin(char sym)
            {
                if (field[0, 0] == sym && field[0, 1] == sym && field[0, 2] == sym)
                {
                    return true;
                }
                if (field[1, 0] == sym && field[1, 1] == sym && field[1, 2] == sym)
                {
                    return true;
                }
                if (field[2, 0] == sym && field[2, 1] == sym && field[2, 2] == sym)
                {
                    return true;
                }

                if (field[0, 0] == sym && field[1, 0] == sym && field[2, 0] == sym)
                {
                    return true;
                }
                if (field[0, 1] == sym && field[1, 1] == sym && field[2, 1] == sym)
                {
                    return true;
                }
                if (field[0, 2] == sym && field[1, 2] == sym && field[2, 2] == sym)
                {
                    return true;
                }

                if (field[0, 0] == sym && field[1, 1] == sym && field[2, 2] == sym)
                {
                    return true;
                }
                if (field[2, 0] == sym && field[1, 1] == sym && field[0, 2] == sym)
                {
                    return true;
                }
                return false;
            }

            private static void AiMove()
            {
                int x, y;
                do
                {
                    x = random.Next(0, SIZE_X);
                    y = random.Next(0, SIZE_Y);
                } while (!IsCellValid(y, x));
                SetSym(y, x, AI_DOT);
            }


            static void Main(string[] args)
            {
                InitField();
                PrintField();
                do
                {
                    playerMove();
                    Console.WriteLine("Ваш ход на поле");
                    PrintField();
                    if (CheckWinXY(PLAYER_DOT))
                    {
                        Console.WriteLine("Вы выиграли");
                        break;
                    }
                    else if (IsFieldFull()) break;
                    AiMove();
                    Console.WriteLine("Ход Компа на поле");
                    PrintField();
                    if (CheckWinXY(AI_DOT))
                    {
                        Console.WriteLine("Выиграли Комп");
                        break;
                    }
                    else if (IsFieldFull()) break;
                } while (true);
                Console.WriteLine("!Конец игры!");

            }
        }
    }
}
