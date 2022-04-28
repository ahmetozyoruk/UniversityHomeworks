// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows;
using System.Windows.Controls;
using Target.Command_Pattern;

namespace Target
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            //var targetButton = sender as Button;
            //MessageBox.Show(targetButton?.Content + " invoked.");

            // The client code can parameterize an invoker with any commands.
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            
            //invoker.SetCommand(new SimpleCommand(sender, " Invoked"));
            
            invoker.SetCommand(new ComplexCommand(receiver, sender ," sended this", " method"));

            invoker.DoSomethingImportant();
        }
    }
}