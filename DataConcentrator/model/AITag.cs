using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConcentrator
{
    public class AITag : Tag
    {
        private int scanTime;
        private List<Alarm> alarms;
        private string unit;

        public AITag()
        {
            alarms = new List<Alarm>();
        }

        public AITag(string id, string description, string address, int scanTime, string unit)
            : base(id, description, address)
        {
            alarms = new List<Alarm>();
            this.scanTime = scanTime;
            this.unit = unit;
        }

        public int ScanTime
        {
            get { return scanTime; }
            set { scanTime = value; }
        }

        public List<Alarm> Alarms
        {
            get { return alarms; }
            set { alarms = value; }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public void RemoveAlarm(string id)
        {
            Alarm alarm = null;
            foreach (Alarm alarm1 in Alarms)
            {
                if (alarm1.Id == id)
                {
                    alarm = alarm1;
                    break;
                }
            }

            alarms.Remove(alarm);
        }
    }
}