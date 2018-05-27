using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    [DataContract]
    public class MyType
    {
        public MyType()
        {
            Description = "";
        }

        public MyType(string description)
        {
            Description = description;
        }

        [DataMember]
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
