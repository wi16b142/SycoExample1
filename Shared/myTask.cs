using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    [DataContract]
    public class MyTask
    {
        public MyTask()
        {
            Description = "";
        }

        public MyTask(string description, int duration, int priority)
        {
            Description = description;
            Duration = duration;
            Priority = priority;
        }

        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Duration { get; set; }
        [DataMember]
        public int Priority { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
