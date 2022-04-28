using System;
using System.Windows.Automation;

namespace FocusTracker.Facade_Pattern
{
 public class Subsystem2
    {
        private Subsystem1 _subsystem1;

        public Subsystem1 Subsystem1
        {
            get { return _subsystem1; }
            set { _subsystem1 = value; }
        }

        private AutomationElement _lastTopLevelWindow;

        public AutomationElement LastTopLevelWindow
        {
            get { return _lastTopLevelWindow; }
            set { _lastTopLevelWindow = value; }
        }


        public void OnFocusChanged(object src, AutomationFocusChangedEventArgs e)
        {
            try
            {
                var elementFocused = src as AutomationElement;
                var topLevelWindow = _subsystem1.GetTopLevelWindow(elementFocused);
                if (topLevelWindow == null)
                {
                    return;
                }

                // If top-level window has changed, announce it.
                if (topLevelWindow != _lastTopLevelWindow)
                {
                    _lastTopLevelWindow = topLevelWindow;
                    Console.WriteLine("Focus moved to top-level window:");
                    Console.WriteLine("  " + topLevelWindow.Current.Name);
                    Console.WriteLine();
                }
                else
                {
                    // Announce focused element.
                    Console.WriteLine("Focused element: ");
                    Console.WriteLine("  Type: " +
                                      elementFocused.Current.LocalizedControlType);
                    Console.WriteLine("  Name: " + elementFocused.Current.Name);
                    Console.WriteLine();
                }
            }
            catch (ElementNotAvailableException)
            {
            }
        }
    }

}