using System;

namespace Basis_.Net_Core_Konsolen_App
{
    public static class DekoWorker
    {
        /// <summary>
        /// Writes Logo in console
        /// </summary>

        public static void SetLogo()
        {
            Console.WriteLine("Today is the " + DateTime.Now  + "\n" +
            "\n\n\nWelcome to \n\n"+
            "  ___                _   _                      \n" +
            " / _ \\              | \\ | |                     \n" +
            "/ / \\ \\_ __  _ __   |  \\| | __ _ _ __ ___   ___ \n" +
            "|  _  | '_ \\| '_ \\  | . ` |/ _` | '_ ` _ \\ / _  \\\n" +
            "| | | | |_) | |_) | | |\\  | (_| | | | | | |  __/\n" +
            "\\_| |_/ .__/| .__/  \\_| \\_/\\__,_|_| |_| |_|\\___|\n" +
            "      | |   | |                                 \n" +
            "      |_|   |_|                                 \n");
        }

        public static void SetSpacer()
        {
            Console.WriteLine("=================================================================================\n");
        }

        public static void SetCommand()
        {
            Console.WriteLine("\nPlease insert a command: \n");
        }

        public static string Input()
        {
            Console.Write("$ ");
            return Console.ReadLine();
        }
    }
}
