using System;
using System.Windows;
using System.Windows.Controls;
using System.Diagnostics;
using System.Windows.Shapes;

namespace LocalAnimations.Template_Method_Pattern
{

    class SomutSinif_2 : AbstractClass
    {

        public Window sViewer { get; set; }

        public SomutSinif_2(Window sViewer, Window window) : base(sViewer)
        {
            this.sViewer = sViewer;
        }

        protected override void somutSinifIslemi()
        { 
            Trace.WriteLine("SoumtSinif: somutSinifIslemi_2 methodu cagrildi.");

        }



    }
}