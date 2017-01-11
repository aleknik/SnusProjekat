using System;
using System.Collections.Generic;
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

        public static bool CheckScanTime(TextBox textBox, ErrorProvider errorProvider)
        {
            if (IsTextBoxNumber(textBox))
            {
                int test = 0;
                if (Int32.TryParse(textBox.Text, out test))
                {
                    return true;
                }
            }
            errorProvider.SetError(textBox, "Field must be an integer greater then 0");
            return false;
        }
    }
}