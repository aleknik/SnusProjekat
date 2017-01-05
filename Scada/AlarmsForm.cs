using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataConcentrator;

namespace Scada
{
    public partial class AlarmsForm : Form
    {
        private DataConcentratorManager dataConcentratorManager;
        private AITag tag;
        public AlarmsForm(string id, DataConcentratorManager dataConcentratorManager)
        {
            InitializeComponent();
            this.dataConcentratorManager = dataConcentratorManager;
            this.tag = (AITag) dataConcentratorManager.GetTagById(id);
            Alarm alarm = new Alarm("asda", 10, ActivationType.Fe, "proba");
            dataConcentratorManager.AddAlarm(tag.Id, alarm);

            InitListView();
        }

        private void InitListView()
        {
            foreach (Alarm alarm in tag.Alarms)
            {
                AddAlarmToListView(alarm);
            }
        }

        private void AddAlarmToListView(Alarm alarm)
        {
            ListViewItem item = new ListViewItem(alarm.ActivationPoint.ToString());
            item.Tag = tag;
            item.SubItems.Add(alarm.Type.ToString());
            item.SubItems.Add(alarm.Message);
            listViewAlarms.Items.Add(item);
        }
    }
}
