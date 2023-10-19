using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTeste.Event_Tests
{
    class Events
    {
        public static event EventHandler<EventArgsHandler> eventHandler;

        public static void callEvents(EventArgsHandler eventArgs)
        {
            eventHandler?.Invoke(new object(), eventArgs);
        }
    }
}
