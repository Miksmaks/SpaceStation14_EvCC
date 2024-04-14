using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using SpaceStation14_EventCardCreator.DataTypes;
using static System.Windows.Forms.LinkLabel;

namespace SpaceStation14_EventCardCreator.Services
{
    public static class XMLService
    {
        public static bool CreateBase() 
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() != DialogResult.OK) { return false; }
            if (File.Exists(folder.SelectedPath + "\\EventBase.xml")) 
            {
                MessageBox.Show("Файл уже существует","Ошибка создания",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            XDocument xdoc = new XDocument();
            XElement main = new XElement("EventBase");
            XElement EventBase_EventList = new XElement("EventList");
            XElement EventBase_ClassList = new XElement("ClassList");
            main.Add(EventBase_EventList);
            main.Add(EventBase_ClassList);
            xdoc.Add(main);
            xdoc.Save(folder.SelectedPath + "\\EventBase.xml");
            SaveLoadService.FileName = folder.SelectedPath + "\\EventBase.xml";
            SaveLoadService.status = BaseStatus.Saved;
            return true;
        }
        public static bool LoadBase()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "XML base|*.xml";
            file.Multiselect = false;
            if (file.ShowDialog() != DialogResult.OK) { return false; }
            if (!File.Exists(file.FileName))
            {
                MessageBox.Show("Файл не найден", "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            XDocument xdoc = XDocument.Load(file.FileName);
            XElement main = xdoc.Root;
            XElement EventBase_EventList = main.Element("EventList");
            XElement EventBase_ClassList = main.Element("ClassList");
            SaveLoadService.E_list.Clear();
            SaveLoadService.C_list.Clear();
            foreach (XElement i in EventBase_EventList.Elements())
            {
                EventMainProperties EMProps = new EventMainProperties();
                XElement MainP = i.Element("MainProperties");
                EMProps.EventName = MainP.Element("Name").Value;
                EMProps.CreateDate = MainP.Element("CreateDate").Value;
                EMProps.Author = MainP.Element("Author").Value;
                EMProps.Score = MainP.Element("Score").Value;
                EMProps.Photo = MainP.Element("Photo").Value;
                EMProps.Scheme = MainP.Element("Scheme").Value;
                EMProps.ShortDescription = MainP.Element("ShortDescription").Value;
                EMProps.Description = MainP.Element("Description").Value;
                XElement Props = i.Element("Properties");
                EventLine ELine = new EventLine(EMProps);
                foreach (XElement j in Props.Elements()) 
                {
                    ELine.Properties.Add(new EventProperty(j.Element("Name").Value, j.Element("Value").Value));
                }
                SaveLoadService.E_list.Add(ELine);
            }
            foreach (XElement i in EventBase_ClassList.Elements())
            {
                EventClass EClass = new EventClass(i.Element("Name").Value);
                XElement VList = i.Element("ValueList");
                foreach (XElement j in VList.Elements())
                {
                    EClass.Rates.Add(j.Value);
                }
                SaveLoadService.C_list.Add(EClass);
            }
            SaveLoadService.FileName = file.FileName;
            SaveLoadService.status = BaseStatus.Saved;
            return true;
        }

        public static void DeleteBase() 
        {
            // удалить файл базы
            // очистить данные
        }

        public static void UpdateBase()
        {
            XDocument xdoc = XDocument.Load(SaveLoadService.FileName);
            xdoc.Root.RemoveAll();
            XElement EventBase_EventList = new XElement("EventList");
            XElement EventBase_ClassList = new XElement("ClassList");
            foreach (EventLine i in SaveLoadService.E_list)
            {
                EventMainProperties m_obj = i.MainProperties;
                List<EventProperty> obj = i.Properties;
                XElement ev = new XElement("Event");
                XElement e_mp = new XElement("MainProperties");
                XElement e_p = new XElement("Properties");
                e_mp.Add(new XElement("Name",m_obj.EventName));
                e_mp.Add(new XElement("CreateDate", m_obj.CreateDate));
                e_mp.Add(new XElement("Author", m_obj.Author));
                e_mp.Add(new XElement("Score", m_obj.Score));
                e_mp.Add(new XElement("Photo", m_obj.Photo));
                e_mp.Add(new XElement("Scheme", m_obj.Scheme));
                e_mp.Add(new XElement("ShortDescription", m_obj.ShortDescription));
                e_mp.Add(new XElement("Description", m_obj.Description));
                foreach (EventProperty j in obj)
                {
                    XElement p = new XElement("Property");
                    p.Add(new XElement("Name",j.Name));
                    p.Add(new XElement("Value", j.Value));
                    e_p.Add(p);
                }
                ev.Add(e_mp);
                ev.Add(e_p);
                EventBase_EventList.Add(ev);
            }
            foreach (EventClass i in SaveLoadService.C_list)
            {
                XElement ec = new XElement("EventClass");
                ec.Add(new XElement("Name",i.Name));
                XElement e_vl = new XElement("ValueList");
                foreach (string j in i.Rates)
                {
                    e_vl.Add(new XElement("Value", j));
                }
                ec.Add(e_vl);
                EventBase_ClassList.Add(ec);
            }
            xdoc.Root.Add(EventBase_EventList);
            xdoc.Root.Add(EventBase_ClassList);
            xdoc.Save(SaveLoadService.FileName);
            SaveLoadService.status = BaseStatus.Saved;
        }
    }
}

// не забудь добавить в главные свойства - фото процесса ивента