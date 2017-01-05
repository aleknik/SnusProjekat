using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConcentrator
{
    public enum ActivationType { Re = 0, Fe }

    public class Alarm
    {
        private string id;
        private double activationPoint;
        private ActivationType type;
        private string message;

        public Alarm()
        {
        }

        public Alarm(string id, double activationPoint, ActivationType type, string message)
        {
            this.id = id;
            this.activationPoint = activationPoint;
            this.type = type;
            this.message = message;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public double ActivationPoint
        {
            get { return activationPoint; }
            set { activationPoint = value; }
        }

        public ActivationType Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
