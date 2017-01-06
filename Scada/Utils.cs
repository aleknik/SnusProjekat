using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scada
{
    class Utils
    {
        public static bool IsTextBoxNumber(TextBox textBox)
        {
            double parsedValue;
            if (!double.TryParse(textBox.Text, out parsedValue))
            {
                return false;
            }
            return true;
        }

        public static bool IsEmpty(TextBox text, ErrorProvider errorProvider)
        {
            if (text.Text == "")
            {
                errorProvider.SetError(text, "Field is required");
                return true;
            }
            return false;
        }

        public static bool IsEmpty(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (comboBox.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBox, "Field is required");
                return true;
            }
            return false;
        }
    }
}
