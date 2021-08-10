using System;
using System.Diagnostics;
using System.Linq;
using System.Management;

 // dividebyzeroexception - исключение, деление на 0
// argumentexception — исключение, которое возникает, когда среди передаваемых методу аргументов есть недопустимые.
// arithmeticexception — исключение, которое возникает при ошибках операций арифметического приведения или преобразования.
// accessviolationexception — исключение, которое возникает при попытке чтения или записи в защищённую область памяти.
// unauthorizedaccessexception — исключение, которое возникает в случае запрета доступа операционной системой из - за ошибки ввода-вывода или особого типа ошибки безопасности.
// indexoutofrangeexception — исключение, возникающее при попытке обращения к элементу массива с индексом, который находится за пределами массива.
// invalidcastexception — исключение, которое возникает в случае недопустимого приведения или явного преобразования.
// nullreferenceexception — исключение, которое возникает при операциях с объектом, равным null, например при попытке получить доступ к его свойствам.
// outofmemoryexception — исключение, которое возникает при недостаточном объёме памяти для продолжения выполнения программы.
// stackOverflowException — исключение, которое возникает при переполнении стека выполнения из - за чрезмерного количества вложенных вызовов методов.

//try
//{
//    Building building = new Building(3, 1);
//  //  building.Address = "Пушкина 1";
//    string address = GetAddress(building);
//    Console.WriteLine(address);
//}
//catch (AddressException ex) when (ex.Code == ErrorCodes.NoAddress)
//{
//    Console.WriteLine("Здание не содержит адреса");
//}
//catch (AddressException ex) when (ex.Code == ErrorCodes.NoBuilding)
//{
//    Console.WriteLine("Нет строения");
//}



namespace Lesson_6
{
    public static class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Process[] processlist = Process.GetProcesses();
                foreach (Process theprocess in processlist)
                {
                    Console.WriteLine("Process: {0} ID: {1}  Memory: {2} ", theprocess.ProcessName, theprocess.Id, theprocess.PagedSystemMemorySize64);
                }
                Console.WriteLine('\n');
                Console.WriteLine("Input process id or name: ");
                string inputCommand = Console.ReadLine();
                string info = "";
                using (Process ProcessKiller = new Process())
                {
                    ProcessKiller.StartInfo.FileName = (@"C:\Windows\System32\taskkill.exe");

                    if (Char.IsDigit(inputCommand[0]))
                    {
                        try
                        {

                            ProcessKiller.StartInfo.Arguments = " /PID " + inputCommand;
                            info = "PID: ";
                        }
                        catch (Exception p)
                        {
                            Console.WriteLine(p.Message);
                        }
                    }
                    else
                    {
                        ProcessKiller.StartInfo.Arguments = " /IM " + inputCommand;
                        info = "Name: ";
                    }

                    ProcessKiller.StartInfo.UseShellExecute = false;
                    ProcessKiller.StartInfo.RedirectStandardOutput = true;
                    ProcessKiller.Start();
                    Console.WriteLine("ProcessKiller is killed " + info + " " + inputCommand);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("end task 1");

            Console.ReadKey();
            Random r = new Random();
            int[,] SomeArray = new int[4, 4];
            for (int i = 0; i < SomeArray.GetLength(0); i++)
            {
                for (int j = 0; j < SomeArray.GetLength(1); j++)
                {
                    try
                    {
                        SomeArray[i, j] =Int32.Parse(GetRandomCharacter(4,r));
                        Console.Write(String.Format("{0}\t", (SomeArray[i, j])));

                    }
                    catch (MyArrayDataException ex ) when   (ex.Code ==ErrorCodes.ItIsNotInt)
                    {

                        Console.Write("array contains a non-numeric element!");
                    }
                    
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }






         











            //Process notepad = Process.Start("tasklist.exe");
            //notepad.StartInfo.Arguments = "/v txt > task.txt";
            //notepad.StartInfo.UseShellExecute = false;
            //notepad.StartInfo.RedirectStandardOutput = true;
            //Console.WriteLine("Нажмите любую клавишу для завершения процесса...");
            //Console.ReadKey();
            //notepad.Kill();
            //Console.WriteLine(notepad.ExitCode); // -1
            //process processkiller = new process();
            //processkiller.startinfo.filename = "taskkill.exe";
            //processkiller.startinfo.arguments = "-pid "+13660;
            //processkiller.startinfo.useshellexecute = false;
            //processkiller.startinfo.redirectstandardoutput = true;
            //processkiller.start();
            //string output = processkiller.standardoutput.readtoend();



        }







        public static string GetCommandLine(this Process process)
        {
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT CommandLine FROM Win32_Process WHERE ProcessId = " + process.Id))
            using (ManagementObjectCollection objects = searcher.Get())
            {
                #pragma warning disable CA1416 // Проверка совместимости платформы
                                return objects.Cast<ManagementBaseObject>().SingleOrDefault()?["CommandLine"]?.ToString();
                #pragma warning restore CA1416 // Проверка совместимости платформы
            }

        }

        public static string GetRandomCharacter(int length, Random rng)
        {
            const string chars = "A1234567890";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rng.Next(s.Length)]).ToArray());

        }





    }
}
