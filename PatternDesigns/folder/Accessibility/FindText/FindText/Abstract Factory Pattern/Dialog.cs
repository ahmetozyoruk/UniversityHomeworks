using Microsoft.Win32;
using System;
using System.IO;

namespace FindText.Abstract_Factory_Pattern
{

class Dialog : IDialog
    {
        public OpenFileDialog openFileDialog()
        {
            return new OpenFileDialog
            {
                Filter = "FlowDocument Files (*.xaml)|*.xaml|All Files (*.*)|*.*",
                InitialDirectory = "Content"
            };
        }

        public SaveFileDialog UsefulFunctionA()
        {
            return new SaveFileDialog();
        }
    }


}
