using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataRepository;
using Shared;

namespace ServiceDefinitionCrew
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service_Crew : IService_Crew
    {
        DataHandler dh = new DataHandler();
        public List<MyTask> QueryAllTasks()
        {
            return dh.QueryAllTasks();
        }

        public List<MyType> QueryAllTypes(string task)
        {
            return dh.QueryAllTypes(task);
        }

        public List<MyCrewMember> QueryCrewMembers(string task, string type)
        {
            return dh.QueryCrewMembers(task, type);
        }
    }
}
