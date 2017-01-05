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
        }

        public AITag(int scanTime, List<Alarm> alarms, string unit)
        {
            this.scanTime = scanTime;
            this.alarms = alarms;
            this.unit = unit;
        }

        public AITag(string id, string description, string address, int scanTime, string unit) : base(id, description, address)
        {
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
    }
}
