// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using NotificationIcon.Pattern;

namespace NotificationIcon
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

        private void Click(object sender, RoutedEventArgs e)
        {
            // Configure and show a notification icon in the system tray
            //_notifyIcon = new NotifyIcon
            //{
            //    BalloonTipText = @"Hello, NotifyIcon!",
            //    Text = @"Hello, NotifyIcon!",
            //    Icon = new Icon("NotifyIcon.ico"),
            //    Visible = true
            //};
            //_notifyIcon.ShowBalloonTip(1000);


            var subject = new Subject();                            // Observer deseni ile normalde click oldugunda 
            var observerA = new ConcreteObserverA();        //burada {yukaridaki commend icerisindeki } yapilan is subject somebusinesslogic de yapiliyor.
            subject.Attach(observerA);                  //click oldugunda ise yapilan is observer olan class lara bildirimde bulunuyor. 
            subject.SomeBusinessLogic();

        }
    }
}
