﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://www.projem.com/InfoProje/InfoService", ConfigurationName="InfoService")]
public interface InfoService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.projem.com/InfoProje/InfoService/InfoService/Lesson", ReplyAction="http://www.projem.com/InfoProje/InfoService/InfoService/LessonResponse")]
    string Lesson();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.projem.com/InfoProje/InfoService/InfoService/Lesson", ReplyAction="http://www.projem.com/InfoProje/InfoService/InfoService/LessonResponse")]
    System.Threading.Tasks.Task<string> LessonAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.projem.com/InfoProje/InfoService/InfoService/Project", ReplyAction="http://www.projem.com/InfoProje/InfoService/InfoService/ProjectResponse")]
    string Project();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.projem.com/InfoProje/InfoService/InfoService/Project", ReplyAction="http://www.projem.com/InfoProje/InfoService/InfoService/ProjectResponse")]
    System.Threading.Tasks.Task<string> ProjectAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.projem.com/InfoProje/InfoService/InfoService/Date", ReplyAction="http://www.projem.com/InfoProje/InfoService/InfoService/DateResponse")]
    string Date();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.projem.com/InfoProje/InfoService/InfoService/Date", ReplyAction="http://www.projem.com/InfoProje/InfoService/InfoService/DateResponse")]
    System.Threading.Tasks.Task<string> DateAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface InfoServiceChannel : InfoService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class InfoServiceClient : System.ServiceModel.ClientBase<InfoService>, InfoService
{
    
    public InfoServiceClient()
    {
    }
    
    public InfoServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public InfoServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public InfoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public InfoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string Lesson()
    {
        return base.Channel.Lesson();
    }
    
    public System.Threading.Tasks.Task<string> LessonAsync()
    {
        return base.Channel.LessonAsync();
    }
    
    public string Project()
    {
        return base.Channel.Project();
    }
    
    public System.Threading.Tasks.Task<string> ProjectAsync()
    {
        return base.Channel.ProjectAsync();
    }
    
    public string Date()
    {
        return base.Channel.Date();
    }
    
    public System.Threading.Tasks.Task<string> DateAsync()
    {
        return base.Channel.DateAsync();
    }
}
