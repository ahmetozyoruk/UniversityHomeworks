using System;
using System.Windows.Automation;

namespace FocusTracker.Facade_Pattern
{
 public class Facade
    {
        protected Subsystem1 _subsystem1;
        
        protected Subsystem2 _subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            this._subsystem1 = subsystem1;
            this._subsystem2 = subsystem2;
        }

        public void Startup(Tracker tracker)
        {
            this._subsystem2.LastTopLevelWindow = tracker.LastTopLevelWindow;
            this._subsystem2.LastTopLevelWindow = tracker.LastTopLevelWindow;
            
            Automation.AddAutomationFocusChangedEventHandler(_subsystem2.OnFocusChanged);
            
            tracker.LastTopLevelWindow = this._subsystem2.LastTopLevelWindow ;
            tracker.LastTopLevelWindow = this._subsystem2.LastTopLevelWindow;
        }
    }

}