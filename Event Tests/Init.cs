using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTeste.Event_Tests
{
    class Init
    {

        public static void Main(string[] Args)
        {
            EventHandler<EventArgsHandler> falling = (sender, eventArgs) =>
            {
                if (eventArgs.eventType == EEventTypes.game_Falling)
                {
                    Physics.falling(eventArgs.message);
                }
            };

            EventHandler<EventArgsHandler> fell = (sender, eventArgs) =>
            {
                if (eventArgs.eventType == EEventTypes.game_Fell)
                {
                    Physics.fell(eventArgs.message);
                }
            };

            Events.eventHandler += falling;
            Events.eventHandler += fell;

            EventArgsHandler eventArgs = new(EEventTypes.game_Fell, "50");

            Events.callEvents(eventArgs);

            
        }
    }
}
