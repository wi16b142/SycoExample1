using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    [DataContract]
    public class sbCrewMember
    {
        public sbCrewMember(string name, string licenceNumber)
        {
            Name = name;
            LicenceNumber = licenceNumber;
        }

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string  LicenceNumber { get; set; }
    }
}
