using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTeste
{
    class Init
    {
        public static void aaah(string[] args)
        {
            Logger.WriteMessage += LoggingMethods.LogToConsole;
            var fileOutput = new FileLogger("./log.txt");
            Logger.LogMessage(ESeverity.Critical, "Teste", "Deu erro");
        }
    }
}
