using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation14_EventCardCreator.DataTypes
{
    public class EventProperty
    {
        public string Name;
        public string Value;
        public EventProperty(string name,string value) 
        {
            Name = name;
            Value = value;
        }
    }
}
