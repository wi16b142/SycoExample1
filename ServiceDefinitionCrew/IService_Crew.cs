using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceDefinitionCrew
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService_Crew
    {
        [OperationContract]
        List<MyTask> QueryAllTasks();
        [OperationContract]
        List<MyType> QueryAllTypes(string task);
        [OperationContract]
        List<MyCrewMember> QueryCrewMembers(string task, string type);
    }
}
