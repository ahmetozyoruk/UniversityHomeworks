using System;
using System.Globalization;

namespace WindowHiding.Pattern
{
    public class Client
    {
        // The client code works with all objects using the Component interface.
        // This way it can stay independent of the concrete classes of
        // components it works with.
        public string ClientCode(Component component)
        {
	    var time = DateTime.Now.ToString(CultureInfo.InvariantCulture);
            return time + component.Operation();
        }
    }
}
