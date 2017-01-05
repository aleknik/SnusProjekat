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
    public partial class MainForm : Form
    {
        delegate void SetTextCallback(string id, string text);

        DataConcentratorManager dataConcentratorManager;

        public MainForm(DataConcentratorManager dataConcentratorManager)
        {
            InitializeComponent();
            this.dataConcentratorManager = dataConcentratorManager;
            InitTags();
            dataConcentratorManager.valueChanged += new ValueChangedHandler(RefreshTag);
            dataConcentratorManager.alarmRaised += new AlarmRaisedHandler(ShowAlarm);
        }

        bool AddTag(Tag tag)
        {
            AddTagToListView(tag);
            dataConcentratorManager.AddTag(tag);
            return true;
        }

        void AddTagToListView(Tag tag)
        {
            ListViewItem item = new ListViewItem(tag.Id);
            item.SubItems.Add(DataConcentratorManager.GetTagType(tag));

            double val = 0;
            if (tag.GetType() == typeof(AOTag))
            {
                val = ((AOTag)tag).InitialValue;

            }
            else if (tag.GetType() == typeof(DOTag))
            {
                val = ((DOTag) tag).InitialValue;
            }
            item.SubItems.Add(val.ToString());
            tagListView.Items.Add(item);
        }

        void ShowAlarm(string id)
        {
            AlarmDto alarm = dataConcentratorManager.GetAlarmFromDatabase(id);
            ListViewItem item = new ListViewItem(alarm.TagId);
            item.Tag = alarm;
            item.SubItems.Add(alarm.Message);
            item.SubItems.Add(alarm.Time.ToString());
            item.BackColor = Color.Red;
            item.EnsureVisible();
            listViewAlarms.Invoke(
                new MethodInvoker(delegate() {
                    listViewAlarms.Items.Add(item);
                }));
        }


        void RefreshTag(string id, double value)
        {
            SetText(id, value.ToString());

        }

        private void SetText(string id, string text)
        {
            if (tagListView.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, id, text);
            }
            else
            {
                ListViewItem item = tagListView.FindItemWithText(id);
                item.SubItems[2].Text = text;
            }

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            dataConcentratorManager.XmlSerialisation();
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTagForm form = new AddTagForm(dataConcentratorManager);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                AddTag(form.Tag);
            }
        }

        private void buttonRemoveTag_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in tagListView.SelectedItems)
            {
                tagListView.Items.Remove(selectedItem);
                dataConcentratorManager.RemoveTag(selectedItem.Text);
                
            }
        }

        private void InitTags()
        {
            List<Tag> tags = dataConcentratorManager.XmlDeserialisation();

            foreach (Tag tag in tags)
            {
                AddTag(tag);
            }
        }

        private void tagListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tagListView.SelectedItems.Count == 1)
            {
                string id = tagListView.SelectedItems[0].Text;
                string type = tagListView.SelectedItems[0].SubItems[1].Text;
                if (type == "AI" || type == "DI")
                {
                    Form form = new AlarmsForm(id, dataConcentratorManager);
                    form.Show();
                }
                else if (type == "AO" || type == "DO")
                {
                    WriteToTagForm form = new WriteToTagForm(Convert.ToDouble(tagListView.SelectedItems[0].SubItems[2].Text));
                    form.ShowDialog();
                    if (form.DialogResult == DialogResult.OK)
                    {
                        dataConcentratorManager.WrtiteToTag(id, form.Value);
                    }
                }
            }
        }

        private void listViewAlarms_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewAlarms.SelectedItems.Count == 1)
            {
                AlarmDto alarm = (AlarmDto) listViewAlarms.SelectedItems[0].Tag;
                DialogResult result1 = MessageBox.Show("Acknowledge alarm?",
                    "Alarm for tag: " + alarm.TagId,
                    MessageBoxButtons.YesNo);

                if (result1 == DialogResult.Yes)
                {
                    listViewAlarms.Items.Remove(listViewAlarms.SelectedItems[0]);
                }
            }
        }
    }
}
