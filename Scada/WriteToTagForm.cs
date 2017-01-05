using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            value = Int32.Parse(textBoxValue.Text);  
        }
    }
}
