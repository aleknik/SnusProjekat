using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DataConcentrator
{
    [Serializable]
    [XmlInclude(typeof(AITag))]
    [XmlInclude(typeof(AOTag))]
    [XmlInclude(typeof(DITag))]
    [XmlInclude(typeof(DOTag))]
    public abstract class Tag
    {
        private string id;
        private string description;
        private string address;

        public Tag()
        {
        }

        public Tag(string id, string description, string address)
        {
            this.id = id;
            this.description = description;
            this.address = address;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
