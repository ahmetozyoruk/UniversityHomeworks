using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IProje projectModel = new Proje();
            IProjeView projectView = new ProjeView();

            Console.WriteLine("Servis calisiyorsa tiklayiniz");
            Console.ReadLine();

            InfoServiceClient client = new InfoServiceClient("WSHttpBinding_InfoService");
 
            projectModel.Lesson = client.Lesson();
            projectModel.project = client.Project();
            projectModel.Time = client.Date();
 
            ProjeController projeContreller = new ProjeController(projectModel, projectView);
            projeContreller.DisplayProjeInfo();
 
            Console.ReadLine();
        }
    }
}