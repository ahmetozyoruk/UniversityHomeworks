using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace NotificationIcon.Pattern
{
	// The Subject owns some important state and notifies observers when the
    // state changes.
    public class Subject : ISubject
    {

        private NotifyIcon _notifyIcon;
        // List of subscribers. In real life, the list of subscribers can be
        // stored more comprehensively (categorized by event type, etc.).
        private List<IObserver> _observers = new List<IObserver>();

        // The subscription management methods.
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        // Trigger an update in each subscriber.
        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        // Usually, the subscription logic is only a fraction of what a Subject
        // can really do. Subjects commonly hold some important business logic,
        // that triggers a notification method whenever something important is
        // about to happen (or after it).
        public void SomeBusinessLogic()
        {
            _notifyIcon = new NotifyIcon
            {
                BalloonTipText = @"Hello, NotifyIcon!",
                Text = @"Hello, NotifyIcon!",
                Icon = new Icon("NotifyIcon.ico"),
                Visible = true
            };
            _notifyIcon.ShowBalloonTip(1000);


            this.Notify();
        }
    }
}

