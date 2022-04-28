using System;

namespace Target.Command_Pattern
{

    class Invoker
    {

        private ICommand _command;

        // Initialize commands.
        public void SetCommand(ICommand command)
        {
            this._command = command;
        }


        // The Invoker does not depend on concrete command or receiver classes.
        // The Invoker passes a request to a receiver indirectly, by executing a
        // command.
        public void DoSomethingImportant()
        {
            _command.Execute();
        }
    }
}