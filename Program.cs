using System;

namespace Basis_.Net_Core_Konsolen_App
{
    class Program
    {
        static void Main(string[] args)
        {
            #region vars
            string command;
            char[] chars = { '*', ' ', '\'', '"', '#' };
            #endregion

            #region main
            DekoWorker.SetLogo();
            DekoWorker.SetSpacer();
            while (true)
            {
                DekoWorker.SetCommand();
                command = Console.ReadLine().ToLower();
                command = command.Trim(chars);
                switch (command)
                {
                    case "exit":
                        Console.WriteLine();
                        return;
                    case "help":
                        Console.WriteLine("\nCommands: ");
                        Console.WriteLine("         exit                    /beendet die ausführung des Programms");
                        Console.WriteLine("         clear                   /leert die Console");
                        Console.WriteLine("         help                    /öffnet die Command hilfe\n");
                        DekoWorker.SetSpacer();
                        break;
                    case "clear":
                        Console.Clear();
                        DekoWorker.SetLogo();
                        Console.WriteLine();
                        DekoWorker.SetSpacer();
                        break;                    
                    default:
                        Console.WriteLine("Command Unknown!\n");
                        DekoWorker.SetSpacer();
                        break;
                }
            }
            #endregion
        }
    }
}
