using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConcentrator
{
    public class AOTag : Tag
    {
        private double initialValue;
        private string unit;

        public AOTag()
        {
        }

        public AOTag(double initialValue, string unit)
        {
            this.initialValue = initialValue;
            this.unit = unit;
        }

        public AOTag(string id, string description, string address, double initialValue, string unit) : base(id, description, address)
        {
            this.initialValue = initialValue;
            this.unit = unit;
        }

        public double InitialValue
        {
            get { return initialValue; }
            set { initialValue = value; }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
    }
}
