using System;

namespace DataConcentrator
{
    public class AlarmDto
    {
        private string id;
        private string tagId;
        private string message;
        private DateTime time;

        public AlarmDto()
        {
        }

        public AlarmDto(string tagId, string message, DateTime time)
        {
            id = Guid.NewGuid().ToString();
            this.tagId = tagId;
            this.message = message;
            this.time = time;
        }

        public AlarmDto(string id, string tagId, string message, DateTime time)
        {
            this.id = id;
            this.tagId = tagId;
            this.message = message;
            this.time = time;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string TagId
        {
            get { return tagId; }
            set { tagId = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
    }
}