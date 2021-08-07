using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;

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
                using (Process myProcess = new Process())
                {
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }








            try
            {

            Process[] processlist = Process.GetProcesses();
            foreach (Process theprocess in processlist)
            {
                Console.WriteLine("Process: {0} ID: {1}  Memory: {2} ", theprocess.ProcessName, theprocess.Id, theprocess.PagedSystemMemorySize64);
            }

                Console.WriteLine("Input process id or name: ");
                string inputCommand = Console.ReadLine();
                using (Process ProcessKiller = Process.Start("taskkill.exe"))
                {
                    if (Char.IsDigit(inputCommand[0]))
                    {                     
                        try
                        {
                            // Process ProcessKiller = Process.Start("taskkill.exe");
                            ProcessKiller.StartInfo.Arguments = " /PID " + inputCommand;
                        }
                        catch (Exception p)
                        {
                            Console.WriteLine(p.Message);
                        }
                    }
                    else
                    {
                        ProcessKiller.StartInfo.Arguments = " /IM " + inputCommand;
                    }
                }               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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

       


        static void ShowAllprocessAndLog()
        {
             
            Process notepad = Process.Start("tasklist.exe");
            
        }



        public static string GetCommandLine(this Process process)
        {
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT CommandLine FROM Win32_Process WHERE ProcessId = " + process.Id))
            using (ManagementObjectCollection objects = searcher.Get())
            {
                return objects.Cast<ManagementBaseObject>().SingleOrDefault()?["CommandLine"]?.ToString();
            }

        }




    }
}
