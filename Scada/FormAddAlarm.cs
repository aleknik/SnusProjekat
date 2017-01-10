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
            errorProvider1.Clear();
            if (!CheckFields())
                return;

            double point = Convert.ToDouble(textBoxAlarmPoint.Text);
            ActivationType type =
                (ActivationType) Enum.Parse(typeof(ActivationType), comboBoxAlarmType.SelectedItem.ToString());
            string message = textBoxAlarmMessage.Text;

            alarm = new Alarm(point, type, message);

            this.DialogResult = DialogResult.OK;
        }


        private bool CheckFields()
        {
            bool ok = true;
            if (!Utils.IsTextBoxNumber(textBoxAlarmPoint))
            {
                errorProvider1.SetError(textBoxAlarmPoint, "This is a number only field");
                ok = false;
            }
            if (Utils.IsEmpty(comboBoxAlarmType, errorProvider1))
            {
                errorProvider1.SetError(comboBoxAlarmType, "Field is required");
                ok = false;
            }
            if (Utils.IsEmpty(textBoxAlarmMessage, errorProvider1))
            {
                errorProvider1.SetError(textBoxAlarmMessage, "Field is required");
                ok = false;
            }

            return ok;
        }
    }
}