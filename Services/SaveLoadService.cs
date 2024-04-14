using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceStation14_EventCardCreator.DataTypes;

namespace SpaceStation14_EventCardCreator.Services
{
    public enum BaseStatus 
    {
        Saved,
        Edit,
        Unknown
    }
    public static class SaveLoadService
    {
        public static string FileName = "";
        public static BaseStatus status = BaseStatus.Unknown;
        public static List<EventClass> C_list = new List<EventClass>();
        public static List<EventLine> E_list = new List<EventLine>();
    }
}
