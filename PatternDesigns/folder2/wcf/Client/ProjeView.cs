using System;
using System.Diagnostics;

namespace Client
{
    public class ProjeView : IProjeView
    {
        public void DisplayProjeView(IProje proje) 
        {
            Console.WriteLine("Proje");
            Console.WriteLine("*******************************");
            Console.WriteLine("Lesson Name - {0}", proje.Lesson);
            Console.WriteLine("What's Proje:  - {0}", proje.project);
            Console.WriteLine("What's last time:         - {0}", proje.Time);
        } 
    }
}