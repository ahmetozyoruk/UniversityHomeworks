using System;
using System.Windows;
using System.Diagnostics;
using System.Windows.Controls;

namespace LocalAnimations.Template_Method_Pattern
{

    public class SomutSinif_1 : AbstractClass
    {

        public Window sViewer { get; set; }
        public Window window1 { get; set; }

        public SomutSinif_1(Window sViewer, Window window) : base(sViewer)
        {
            this.sViewer = sViewer;
            this.window1 = window;
        }

        protected override void somutSinifIslemi()
        {

            Trace.WriteLine("SoumtSinif_1: somutSinifIslemi_2 methodu cagrildi.");

            window1 = sViewer;
        }

        protected override void Hook()
        {
            Trace.WriteLine("SoumtSinif_1: Hook methodu cagrildi.");

            sViewer.Show();
        }

    }
}