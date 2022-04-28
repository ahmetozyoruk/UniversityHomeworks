using System.ServiceModel;

namespace InfoProject
{
    [ServiceContract(Name="InfoService",Namespace="http://www.projem.com/InfoProje/InfoService")]
    public interface IInfoProje
    {
        [OperationContract]
        string Lesson();

        [OperationContract]
        string Project();
        
        [OperationContract]
        string Date();
    }
}