
using System;
using System.Collections.Generic;
using System.Windows;

namespace CustomWindowUI.Pattern
{
	 class ConcreteStrategyB : Window, IStrategy
    {
		public void DoAlgorithm(object data)
		{
            Window window = (Window)data;
		  window.DragMove();
		}
	    }
}
