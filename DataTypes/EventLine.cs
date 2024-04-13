using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation14_EventCardCreator.DataTypes
{
    public class EventLine
    {
        public EventMainProperties MainProperties;
        public List<EventProperty> Properties;
        public EventLine(EventMainProperties main) 
        {
            MainProperties = main;
            Properties = new List<EventProperty>();
        }
    }
}
