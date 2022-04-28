// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using WindowHiding.Pattern;

namespace WindowHiding
{
    /// <summary>
    ///     Interaction logic for ChildWindow.xaml
    /// </summary>
    public partial class ChildWindow : Window
    {
        private bool _close;


        private Client client;
        private ConcreteComponent simple;

        public ChildWindow()
        {
            InitializeComponent();

              client = new Client();
              simple = new ConcreteComponent();

            client.ClientCode(simple);
            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);

            // Get date/time when window is first shown
            //firstShownTextBlock.Text = DateTime.Now.ToString(CultureInfo.InvariantCulture);
            firstShownTextBlock.Text = client.ClientCode(decorator1);            //Burada design pattern uygulanmakta simple compenentin uzerine decorator1
        }                                                                   //buda clientin icerisinde gerceklesmekte ve string olarak result olur.

        // Shadow Window.Close to make sure we bypass the Hide call in 
        // the Closing event handler
        public new void Close()
        {
            _close = true;
            base.Close();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            client = new Client();
            simple = new ConcreteComponent();

            client.ClientCode(simple);
            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);

            // Get date/time the window is shown now (ie when it becomes visible)
            if ((bool)e.NewValue)
            {
                //shownThisTimeTextBlock.Text = DateTime.Now.ToString(CultureInfo.InvariantCulture);
                shownThisTimeTextBlock.Text = client.ClientCode(decorator2);                  //Burada design pattern uygulanmakta simple compenentin uzerine decorator1 
            }                                                                            //sonrada decorator2 ezpand eder.
        }                                                                           //buda clientin icerisinde gerceklesmekte ve string olarak result olur.
                                                                                             
        private void Window_Closing(object sender, CancelEventArgs e)
        {
            // If Close() was called, close the window (instead of hiding it)
            if (_close) return;

            // Hide the window (instead of closing it)
            e.Cancel = true;
            Hide();
        }
    }
}
