// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using CustomWindowUI.Pattern;

namespace CustomWindowUI
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CustomWindowChrome : Window
    {
        // The client code picks a concrete strategy and passes it to the
        // context. The client should be aware of the differences between
        // strategies in order to make the right choice.
        Context context = new Context();

        public CustomWindowChrome()
        {
            InitializeComponent();
        }

        private void CloseButtonRectangle_Click(object sender, RoutedEventArgs e)
        {
            //Close();
            context.SetStrategy(new ConcreteStrategyA());           //burada strategy deseni uygulaniyor. Burada ne yapilacagi bilinmiyor fakat 
            context.DoSomeBusinessLogic(this);                      //concreteStrategyA class ile bu window kapansin diyor.
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //DragMove();
            context.SetStrategy(new ConcreteStrategyB());                //burada strategy deseni uygulaniyor. Burada ne yapilacagi bilinmiyor fakat 
            context.DoSomeBusinessLogic(this);                           //concreteStrategyB class ile bu window suruklensin diyor.
        }

        private void ResizeThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            // Resize window width (honoring minimum width)
            var desiredWidth = (int)(ActualWidth + e.HorizontalChange);
            var minWidth = (int)(MinWidth + resizeThumb.Width + resizeThumb.Margin.Right);
            Width = Math.Max(desiredWidth, minWidth);

            // Resize window height (honoring minimum height)
            var desiredHeight = (int)(ActualHeight + e.VerticalChange);
            var minHeight = (int)(MinHeight + resizeThumb.Height + resizeThumb.Margin.Bottom);
            Height = Math.Max(desiredHeight, minHeight);
        }
    }
}
