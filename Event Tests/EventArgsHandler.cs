using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTeste.Event_Tests
{
    class EventArgsHandler
    {
        public EEventTypes eventType;
        public string message;

        public EventArgsHandler(EEventTypes eventType, string message)
        {
            this.eventType = eventType;
            this.message = message;
        }
    }
}
