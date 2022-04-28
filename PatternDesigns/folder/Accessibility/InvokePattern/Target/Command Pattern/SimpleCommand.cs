using System;
using System.Windows;
using System.Windows.Controls;

namespace Target.Command_Pattern
{
 class SimpleCommand : ICommand
    {
        private string _payload = string.Empty;
        private object sender = null;

        public SimpleCommand(object sender,string payload)
        {
            this._payload = payload;
            this.sender = sender;
        }

        public void Execute()
        {
            //Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({this._payload})");

            var targetButton = sender as Button;
            MessageBox.Show(targetButton?.Content + _payload);
        }
    }

}