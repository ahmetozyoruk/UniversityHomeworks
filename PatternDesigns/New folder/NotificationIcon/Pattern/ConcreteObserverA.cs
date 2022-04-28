
using System;
using System.Collections.Generic;
using System.Threading;

namespace NotificationIcon.Pattern
{
 class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {            
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
        }
    }
}
