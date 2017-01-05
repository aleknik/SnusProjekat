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
                return;

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
            }
            panelTypeSelect.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelTypeSelect.Show();
            panelTagCreate.Hide();
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            if (activePanel == panelAnalogInput)
            {
                string id = textBoxAiID.Text;
                string desc = textBoxAiDesc.Text;
                string address = comboBoxAiAddress.SelectedItem.ToString();
                int scanTime = Int32.Parse(textBoxAiScanTime.Text);
                string unit = textBoxAiUnit.Text;
                tag = new AITag(id, desc, address, scanTime, unit);
            }
            else if (activePanel == panelDigitalInput)
            {
                string id = textBoxDiID.Text;
                string desc = textBoxDiDesc.Text;
                string address = comboBoxDiAddress.SelectedItem.ToString();
                int scanTime = Int32.Parse(textBoxDiScanTime.Text);
                tag = new DITag(id, desc, address, scanTime);
            }
            else if (activePanel == panelAnalogOutput)
            {
                string id = textBoxAoID.Text;
                string desc = textBoxAoDesc.Text;
                string address = comboBoxAoAddress.SelectedItem.ToString();
                double init = double.Parse(textBoxAoInitVal.Text);
                string unit = textBoxAiUnit.Text;
                tag = new AOTag(id, desc, address, init, unit);
            }
        }
    }
}
