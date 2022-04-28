using System;
using System.Windows;
using System.Windows.Controls;

namespace Target.Command_Pattern
{

    class Receiver
    {
        public void DoSomething(Object sender, string a, string b)
        {
            //Console.WriteLine($"Receiver: Working on ({a}.)");

            var targetButton = sender as Button;
            MessageBox.Show(targetButton?.Content + a + b);
        }
    }
}