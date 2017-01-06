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
    public partial class AddTagForm : Form
    {
        private DataConcentratorManager dataConcentratorManager;
        private Panel activePanel;
        private Tag tag;

        public Tag Tag
        {
            get { return tag; }
        }

        public AddTagForm(DataConcentratorManager dataConcentratorManager)
        {
            InitializeComponent();

            this.dataConcentratorManager = dataConcentratorManager;
            InitAdresses();

            panelTypeSelect.Show();
            panelTagCreate.Hide();

            activePanel = panelTypeSelect;
        }

        void InitAdresses()
        {
            InitAnalogInputAddresses(comboBoxAiAddress);
            InitDigitalInputAddresses(comboBoxDiAddress);
            InitAnalogOutputAddresses(comboBoxAoAddress);
        }


        void InitAnalogInputAddresses(ComboBox comboBox)
        {
            comboBox.Items.AddRange(dataConcentratorManager.PlcSimulatorManager.GetAnalogInputs());

        }

        void InitAnalogOutputAddresses(ComboBox comboBox)
        {
            comboBox.Items.AddRange(dataConcentratorManager.PlcSimulatorManager.GetAnalogOutputs());

        }

        void InitDigitalInputAddresses(ComboBox comboBox)
        {
            comboBox.Items.AddRange(dataConcentratorManager.PlcSimulatorManager.GetDigitalInputs());

        }

        void InitDigitalOutputAddresses(ComboBox comboBox)
        {
            comboBox.Items.AddRange(dataConcentratorManager.PlcSimulatorManager.GetDigitalOutputs());

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem == null)
            {
                errorProvider1.SetError(comboBoxType, "Select tag type");
                return;
            }


            panelTagCreate.Show();
            panelAnalogInput.Hide();
            panelDigitalInput.Hide();
            panelAnalogOutput.Hide();
            switch ((string)comboBoxType.SelectedItem)
            {
                case "Analog input":
                    panelAnalogInput.Show();
                    activePanel = panelAnalogInput;
                    break;
                case "Digital input":
                    panelDigitalInput.Show();
                    activePanel = panelDigitalInput;
                    break;
                case "Analog output":
                    panelAnalogOutput.Show();
                    activePanel = panelAnalogOutput;
                    break;
                case "Digital output":
                    panelDigitalOutput.Show();
                    activePanel = panelDigitalOutput;
                    break;
            }
            panelTypeSelect.Hide();
            errorProvider1.Clear();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelTypeSelect.Show();
            panelTagCreate.Hide();
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (activePanel == panelAnalogInput)
            {
                if (!CheckAIFields())
                    return;

                string id = textBoxAiID.Text;
                string desc = textBoxAiDesc.Text;
                string address = comboBoxAiAddress.SelectedItem.ToString();
                int scanTime = Int32.Parse(textBoxAiScanTime.Text);
                string unit = textBoxAiUnit.Text;
                tag = new AITag(id, desc, address, scanTime, unit);
            }
            else if (activePanel == panelDigitalInput)
            {
                if (!CheckDIFields())
                    return;

                string id = textBoxDiID.Text;
                string desc = textBoxDiDesc.Text;
                string address = comboBoxDiAddress.SelectedItem.ToString();
                int scanTime = Int32.Parse(textBoxDiScanTime.Text);
                tag = new DITag(id, desc, address, scanTime);
            }
            else if (activePanel == panelAnalogOutput)
            {
                if (!CheckAOFields())
                    return;

                string id = textBoxAoID.Text;
                string desc = textBoxAoDesc.Text;
                string address = comboBoxAoAddress.SelectedItem.ToString();
                double init = double.Parse(textBoxAoInitVal.Text);
                string unit = textBoxAoUnit.Text;
                tag = new AOTag(id, desc, address, init, unit);
            }
            else if (activePanel == panelDigitalOutput)
            {
                if (!CheckDOFields())
                    return;

                string id = textBoxDoID.Text;
                string desc = textBoxDoDesc.Text;
                string address = comboBoxDoAddress.SelectedItem.ToString();
                double init = double.Parse(textBoxDoInitVal.Text);
                tag = new DOTag(id, desc, address, init);
            }

            this.DialogResult = DialogResult.OK;
        }

        

        private bool CheckAIFields()
        {
            bool ok = true;
            if (!Utils.IsTextBoxNumber(textBoxAiScanTime))
            {
                errorProvider1.SetError(textBoxAiScanTime, "This is a number only field");
                ok = false;
            }              
            if (Utils.IsEmpty(textBoxAiID, errorProvider1))
            {
                errorProvider1.SetError(textBoxAiID, "Field is required");
                ok = false;
            }
            if (Utils.IsEmpty(textBoxAiDesc, errorProvider1))
            {
                errorProvider1.SetError(textBoxAiDesc, "Field is required");
                ok = false;
            }
            if (Utils.IsEmpty(textBoxAiUnit, errorProvider1))
            {
                errorProvider1.SetError(textBoxAiUnit, "Field is required");
                ok = false;
            }
            if (Utils.IsEmpty(comboBoxAiAddress, errorProvider1))
            {
                errorProvider1.SetError(comboBoxAiAddress, "Field is required");
                ok = false;
            }

            return ok;
        }

        private bool CheckAOFields()
        {
            bool ok = true;
            if (!Utils.IsTextBoxNumber(textBoxAoInitVal))
            {
                errorProvider1.SetError(textBoxAoInitVal, "This is a number only field");
                ok = false;
            }
            if (Utils.IsEmpty(textBoxAoID, errorProvider1))
            {
                errorProvider1.SetError(textBoxAoID, "Field is required");
                ok = false;
            }
            if (Utils.IsEmpty(textBoxAoDesc, errorProvider1))
            {
                errorProvider1.SetError(textBoxAoDesc, "Field is required");
                ok = false;
            }
            if (Utils.IsEmpty(textBoxAoUnit, errorProvider1))
            {
                errorProvider1.SetError(textBoxAoUnit, "Field is required");
                ok = false;
            }
            if (Utils.IsEmpty(comboBoxAoAddress, errorProvider1))
            {
                errorProvider1.SetError(comboBoxAoAddress, "Field is required");
                ok = false;
            }

            return ok;
        }

        private bool CheckDIFields()
        {
            bool ok = true;
            if (!Utils.IsTextBoxNumber(textBoxDiScanTime))
            {
                errorProvider1.SetError(textBoxDiScanTime, "This is a number only field");
                ok = false;
            }
            if (Utils.IsEmpty(textBoxDiID, errorProvider1))
            {
                errorProvider1.SetError(textBoxAiID, "Field is required");
                ok = false;
            }
            if (Utils.IsEmpty(textBoxDiDesc, errorProvider1))
            {
                errorProvider1.SetError(textBoxDiDesc, "Field is required");
                ok = false;
            }
            if (Utils.IsEmpty(comboBoxDiAddress, errorProvider1))
            {
                errorProvider1.SetError(comboBoxDiAddress, "Field is required");
                ok = false;
            }

            return ok;
        }

        private bool CheckDOFields()
        {
            bool ok = true;
            if (!Utils.IsTextBoxNumber(textBoxDoInitVal))
            {
                errorProvider1.SetError(textBoxDoInitVal, "This is a number only field");
                ok = false;
            }
            if (Utils.IsEmpty(textBoxDoID, errorProvider1))
            {
                errorProvider1.SetError(textBoxDoID, "Field is required");
                ok = false;
            }
            if (Utils.IsEmpty(textBoxDoDesc, errorProvider1))
            {
                errorProvider1.SetError(textBoxDoDesc, "Field is required");
                ok = false;
            }
            if (Utils.IsEmpty(comboBoxDoAddress, errorProvider1))
            {
                errorProvider1.SetError(comboBoxDoAddress, "Field is required");
                ok = false;
            }
            return ok;
        }
    }
}
