using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConcentrator
{
    public interface IDataConcentrator
    {
        bool AddTag(Tag tag);
        bool RemoveTag(string id);
        bool AddAlarm(string tagId, Alarm alarm);
        bool RemoveAlarm(string tagId, string alarmId);
        bool WrtiteToTag(string id, double value);
    }
}
