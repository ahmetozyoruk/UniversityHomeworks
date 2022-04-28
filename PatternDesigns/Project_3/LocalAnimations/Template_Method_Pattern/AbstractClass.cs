using System;
using System.Diagnostics;
using System.Windows;

namespace LocalAnimations.Template_Method_Pattern
{

    public abstract class AbstractClass 
    {
        public Window sViewer { get; set; }

        protected AbstractClass(Window sViewer)
        {
            this.sViewer = sViewer;
        }

        public void IslemSirasi()
        {
            ilkelislem_1();
            ilkelislem_2();
            somutSinifIslemi();
            Hook();
        }


        protected void ilkelislem_1()
        {
            Trace.WriteLine("AbstractClass: ilkelislem_1 methodu cagrildi.");

            Window sViewer = new SampleViewer();


        }

        protected void ilkelislem_2()
        {
            Trace.WriteLine("AbstractClass: ilkelislem_2 methodu cagrildi.");

        }

        protected abstract void somutSinifIslemi();

        protected virtual void Hook() { }

    }
}