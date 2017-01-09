using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConcentrator
{
    public class DITag : Tag
    {
        private int scanTime;

        public DITag()
        {
        }

        public DITag(int scanTime)
        {
            this.scanTime = scanTime;
        }

        public DITag(string id, string description, string address, int scanTime) : base(id, description, address)
        {
            this.scanTime = scanTime;
        }

        public int ScanTime
        {
            get { return scanTime; }
            set { scanTime = value; }
        }
    }
}
