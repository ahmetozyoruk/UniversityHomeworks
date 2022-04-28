using System;
using System.Windows.Automation;

namespace FocusTracker.Facade_Pattern
{

 public class Subsystem1
    {
        public AutomationElement GetTopLevelWindow(AutomationElement element)
        {
            var walker = TreeWalker.ControlViewWalker;
            AutomationElement elementParent;
            var node = element;
            try // In case the element disappears suddenly, as menu items are 
                // likely to do.
            {
                if (node == AutomationElement.RootElement)
                {
                    return node;
                }
                // Walk up the tree to the child of the root.
                while (true)
                {
                    elementParent = walker.GetParent(node);
                    if (elementParent == null)
                    {
                        return null;
                    }
                    if (elementParent == AutomationElement.RootElement)
                    {
                        break;
                    }
                    node = elementParent;
                }
            }
            catch (ElementNotAvailableException)
            {
                node = null;
            }
            catch (ArgumentNullException)
            {
                node = null;
            }
            return node;
        }
    }
}