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
    public partial class FormAddAlarm : Form
    {
        private Alarm alarm;

        public FormAddAlarm()
        {
            InitializeComponent();
            InitTypes();

        }

        private void InitTypes()
        {
            foreach (string name in Enum.GetNames(typeof(ActivationType)))
            {
                comboBoxAlarmType.Items.Add(name);
            }
        }

        public Alarm Alarm
        {
            get { return alarm; }
            set { alarm = value; }
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            double point = Convert.ToDouble(textBoxAlarmPoint.Text);
            ActivationType type = (ActivationType) Enum.Parse(typeof(ActivationType), comboBoxAlarmType.SelectedItem.ToString());
            string message = textBoxAlarmMessage.Text;

            alarm = new Alarm(point, type, message);
        }
    }
}
