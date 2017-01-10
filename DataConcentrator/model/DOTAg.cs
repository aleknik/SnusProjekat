using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConcentrator
{
    public class DOTag : Tag
    {
        private double initialValue;

        public DOTag()
        {
        }

        public DOTag(double initialValue)
        {
            this.initialValue = initialValue;
        }

        public DOTag(string id, string description, string address, double initialValue)
            : base(id, description, address)
        {
            this.initialValue = initialValue;
        }

        public double InitialValue
        {
            get { return initialValue; }
            set { initialValue = value; }
        }
    }
}