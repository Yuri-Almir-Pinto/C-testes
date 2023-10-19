using System;
using System.Collections.Generic;


namespace AppTeste
{
    public static class Logger
    {

        public static Action<string>? WriteMessage;
        public static ESeverity LogLevel { get; set; } = ESeverity.Warning;

        public static void LogMessage(ESeverity s, string component, string message)
        {
            if (s < LogLevel)
            {
                return;
            }
            var outputMsg = $"{DateTime.Now}\t{s}\t{component}\t{message}";
            if (WriteMessage is not null)
                WriteMessage(message);
        }


    }
}
