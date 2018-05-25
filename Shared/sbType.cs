using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    [DataContract]
    public class sbType
    {
        public sbType(string description)
        {
            Description = description;
        }

        [DataMember]
        public string Description { get; set; }
    }
}
