
using System;
using System.Collections.Generic;
using System.Windows;

namespace CustomWindowUI.Pattern
{

	class ConcreteStrategyA : Window, IStrategy
    {
		public void DoAlgorithm(object data)
        {
            Window window = (Window)data;
            window.Close();
		}
	    }
}
