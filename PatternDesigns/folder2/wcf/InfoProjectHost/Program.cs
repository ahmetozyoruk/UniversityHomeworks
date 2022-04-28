using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Description;
using System.ServiceModel;
using InfoProject;

namespace InfoProjectHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:4501/projem/InfoPRojeService/");

            ServiceHost host = new ServiceHost(
                typeof(InfoProje),
                baseAddress
            );

            host.AddServiceEndpoint(
                typeof(IInfoProje), new WSHttpBinding(), baseAddress.ToString()
            );

            ServiceMetadataBehavior metadataBehavior = new ServiceMetadataBehavior();
            metadataBehavior.HttpGetEnabled = true;

            host.Description.Behaviors.Add(metadataBehavior);

            host.Open();
            Console.WriteLine(host.State.ToString());
            Console.WriteLine("Service acik Durdurmak icin bir tusa basiniz");
            Console.ReadLine();
            host.Close();
        }
        //svcutil /out:Proxy.cs http://localhost:4501/projem/InfoPRojeService/ /config:App.config
    }
}
