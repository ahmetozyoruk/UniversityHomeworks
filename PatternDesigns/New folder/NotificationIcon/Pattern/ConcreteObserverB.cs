
using System;
using System.Collections.Generic;
using System.Threading;

namespace NotificationIcon.Pattern
{

    class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");   
        }
    }
}
