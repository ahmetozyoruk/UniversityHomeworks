using System;
using System.Collections.Generic;
using System.Threading;

namespace NotificationIcon.Pattern
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}
