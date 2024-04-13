using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation14_EventCardCreator.DataTypes
{
    public struct EventClass
    {
        public string Name;
        public List<string> Rates;
        public EventClass(string name) 
        {
            Name = name;
            Rates = new List<string>();
        }
        public EventClass(string name, List<string> rates)
        {
            Name = name;
            Rates = rates;
        }
    }
}
