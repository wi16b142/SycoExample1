using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    [DataContract]
    public class MyCrewMember
    {
        public MyCrewMember()
        {
        }

        public MyCrewMember(string name, string licenceNumber, string taskDesc, string typeDesc)
        {
            Name = name;
            LicenceNumber = licenceNumber;
            TaskDesc = taskDesc;
            TypeDesc = typeDesc;
        }

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string  LicenceNumber { get; set; }
        [DataMember]
        public string TaskDesc { get; set; }
        [DataMember]
        public string TypeDesc { get; set; }

        public override string ToString()
        {
            return String.Format("{0}: {1}, {2}, {3}", Name, LicenceNumber, TaskDesc, TypeDesc);
        }
    }
}
