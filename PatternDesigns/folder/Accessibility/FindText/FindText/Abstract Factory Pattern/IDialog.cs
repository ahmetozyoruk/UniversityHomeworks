using Microsoft.Win32;
using System;

namespace FindText.Abstract_Factory_Pattern
{

 public interface IDialog
    {
        public OpenFileDialog openFileDialog();
        public SaveFileDialog UsefulFunctionA();
    }

}
