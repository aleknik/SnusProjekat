using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using PLCSimulator;
using System.Threading;
using System.Xml.Serialization;

namespace DataConcentrator
{
    public delegate void ValueChangedHandler(string id, double value);

    public class DataConcentratorManager : IDataConcentrator
    {
        PLCSimulatorManager plcSimulatorManager;

        public PLCSimulatorManager PlcSimulatorManager
        {
            get { return plcSimulatorManager; }
            set { plcSimulatorManager = value; }
        }

        private Dictionary<string, Tag> tags;
        private Dictionary<string, Thread> tagThreads;
        public event ValueChangedHandler valueChanged;

        public DataConcentratorManager()
        {
            plcSimulatorManager = new PLCSimulatorManager();
            plcSimulatorManager.StartPLCSimulator();

            tags = new Dictionary<string, Tag>();
            tagThreads = new Dictionary<string, Thread>();

            XmlDeserialisation();

        }

        public Tag GetTagById(string id)
        {
            return tags[id];
        }

        public void XmlSerialisation()
        {
            try
            {
                List<Tag> tagList = tags.Values.ToList();

                XmlSerializer serializer = new XmlSerializer(typeof(List<Tag>));

                using (TextWriter textWriter = new StreamWriter("Configuration.xml"))

                {

                    serializer.Serialize(textWriter, tagList);
                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<Tag> XmlDeserialisation()
        {
            try
            {
                List<Tag> tagDtos = new List<Tag>();

                XmlSerializer serializer = new XmlSerializer(typeof(List<Tag>));

                using (TextReader textReader = new StreamReader("Configuration.xml"))

                {

                    tagDtos = (List<Tag>)serializer.Deserialize(textReader);
                    return tagDtos;

                }
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        public bool AddTag(Tag tag)
        {
            if (!tags.ContainsKey(tag.Id))
            {
                tags.Add(tag.Id, tag);
                if (tag.GetType() == typeof(AITag))
                {
                    Thread thread = new Thread(new ParameterizedThreadStart(ScanAnalog));
                    thread.IsBackground = true;
                    thread.Start(tag);
                    tagThreads.Add(tag.Id, thread);
                }
                else if (tag.GetType() == typeof(DITag))
                {
                    Thread thread = new Thread(new ParameterizedThreadStart(ScanDigital));
                    thread.IsBackground = true;
                    thread.Start(tag);
                    tagThreads.Add(tag.Id, thread);
                }
                return true;
            }
            return false;
        }

        public bool RemoveTag(string id)
        {
            if (!tags.ContainsKey(id))
            {
                return false;
            }

            tags.Remove(id);
            tagThreads[id].Abort();
            tagThreads.Remove(id);

            return true;
        }

        public bool AddAlarm(string tagId, Alarm alarm)
        {
            if (!tags.ContainsKey(tagId))
                return false;

            Tag tag = tags[tagId];
            if (tag.GetType() != typeof(AITag))
                return false;

            AITag aiTag = (AITag) tag;

            if (aiTag.Alarms.Contains(alarm))
                return false;

            aiTag.Alarms.Add(alarm);

            return true;

        }

        public bool RemoveAlarm(string tagId, string alarmId)
        {
            throw new NotImplementedException();
        }

        public bool WrtiteToTag(string id, double value)
        {
            Tag tag = tags[id];
            plcSimulatorManager.Write(tag.Address, value);
            OnValueChanged(tag.Id, value);
            return true;
        }

        public void ScanAnalog(object o)
        {
            AITag tag = (AITag) o;
            while (true)
            {
                double value = plcSimulatorManager.Read(tag.Address);
                OnValueChanged(tag.Id, value);

                Thread.Sleep(tag.ScanTime);
            }
        }

        public void ScanDigital(object o)
        {
            DITag tag = (DITag)o;
            while (true)
            {
                double value = plcSimulatorManager.Read(tag.Address);
                OnValueChanged(tag.Id, value);

                Thread.Sleep(tag.ScanTime);
            }
        }

        public void OnValueChanged(string id, double value)
        {
            if (valueChanged != null)
            {
                valueChanged(id, value);
            }
        }

        public void close()
        {
            foreach (Thread tagThread in tagThreads.Values)
            {
                tagThread.Abort();
            }
        }

        public static string GetTagType(Tag tag)
        {
            if (tag.GetType() == typeof(AITag))
            {
                return "AI";
            }
            if (tag.GetType() == typeof(AOTag))
            {
                return "AO";
            }
            if (tag.GetType() == typeof(DITag))
            {
                return "DI";
            }
            if (tag.GetType() == typeof(DOTag))
            {
                return "DO";
            }
            return "";
        }
    }
}
