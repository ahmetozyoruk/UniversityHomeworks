using System;

namespace Target.Command_Pattern
{
    class ComplexCommand : ICommand
    {
        private Receiver _receiver;
        private readonly object _sender;

        // Context data, required for launching the receiver's methods.
        private string _a;

        private string _b;

        // Complex commands can accept one or several receiver objects along
        // with any context data via the constructor.
        public ComplexCommand(Receiver receiver, Object sender, string a, string b)
        {
            this._receiver = receiver;
            this._sender = sender;
            this._a = a;
            this._b = b;
        }

        public void Execute()
        {
            _receiver.DoSomething(_sender, _a, _b);
        }
    }
}