using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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

            InitListView();
        }

        private void InitListView()
        {
            foreach (Alarm alarm in tag.Alarms)
            {
                if (alarm != null)
                    AddAlarmToListView(alarm);
            }
        }

        private void AddAlarm(Alarm alarm)
        {
            if (dataConcentratorManager.AddAlarm(tag.Id, alarm))
            {
                AddAlarmToListView(alarm);
            }
        }

        private void AddAlarmToListView(Alarm alarm)
        {
            ListViewItem item = new ListViewItem(alarm.ActivationPoint.ToString());
            item.Tag = alarm;
            item.SubItems.Add(alarm.Type.ToString());
            item.SubItems.Add(alarm.Message);
            listViewAlarms.Items.Add(item);
        }

        private void buttonAddAlarm_Click(object sender, EventArgs e)
        {
            FormAddAlarm form = new FormAddAlarm();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                AddAlarm(form.Alarm);
            }
        }

        private void buttonRemoveAlarm_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in listViewAlarms.SelectedItems)
            {
                Alarm alarm = (Alarm) selectedItem.Tag;
                dataConcentratorManager.RemoveAlarm(tag.Id, alarm.Id);
                listViewAlarms.Items.Remove(selectedItem);
            }
        }
    }
}