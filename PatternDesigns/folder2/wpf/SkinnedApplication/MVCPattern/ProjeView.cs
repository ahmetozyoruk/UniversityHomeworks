using System.Diagnostics;

namespace SkinnedApplication.MVCPattern
{
    public class ProjeView : IProjeView
    {
        public void DisplayProjeView(IProje proje) 
        {
            Trace.WriteLine("Proje");
            Trace.WriteLine("*******************************");
            Trace.WriteLine("Lesson Name - {0}", proje.Lesson);
            Trace.WriteLine("What's Proje:  - {0}", proje.project);
            Trace.WriteLine("What's last time:         - {0}", proje.Time);
        } 
    }
}