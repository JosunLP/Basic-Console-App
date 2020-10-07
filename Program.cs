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
                command = DekoWorker.Input().ToLower();
                command = command.Trim(chars);
                switch (command)
                {
                    case "exit":
                        Console.WriteLine();
                        return;
                    case "help":
                        DekoWorker.SetMenu("{'Commands': [" +
                            "{'Command': 'exit', 'Description': 'beendet die ausführung des Programms'}," +
                            "{'Command': 'clear', 'Description': 'leert die Console'}," +
                            "{'Command': 'help', 'Description': 'öffnet die Command hilfe'}" +
                            "]}");
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
