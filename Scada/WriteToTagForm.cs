using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scada
{
    public partial class WriteToTagForm : Form
    {
        private double value;

        public double Value
        {
            get { return value; }
        }

        public WriteToTagForm(double currVal)
        {
            InitializeComponent();
            textBoxValue.Text = currVal.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!CheckField())
                return;
            value = double.Parse(textBoxValue.Text);
            this.DialogResult = DialogResult.OK;
        }


        private bool CheckField()
        {
            bool ok = true;

            if (!Utils.IsTextBoxNumber(textBoxValue))
            {
                ok = false;
            }
            if (Utils.IsEmpty(textBoxValue, errorProvider1))
            {
                ok = false;
            }

            return ok;
        }
    }
}