namespace Scada
{
    partial class AddTagForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonNext = new System.Windows.Forms.Button();
            this.panelTypeSelect = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.panelAnalogInput = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxAiUnit = new System.Windows.Forms.TextBox();
            this.textBoxAiScanTime = new System.Windows.Forms.TextBox();
            this.comboBoxAiAddress = new System.Windows.Forms.ComboBox();
            this.textBoxAiDesc = new System.Windows.Forms.TextBox();
            this.textBoxAiID = new System.Windows.Forms.TextBox();
            this.panelDigitalInput = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxDiScanTime = new System.Windows.Forms.TextBox();
            this.comboBoxDiAddress = new System.Windows.Forms.ComboBox();
            this.textBoxDiDesc = new System.Windows.Forms.TextBox();
            this.textBoxDiID = new System.Windows.Forms.TextBox();
            this.panelTagCreate = new System.Windows.Forms.Panel();
            this.panelAnalogOutput = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAoUnit = new System.Windows.Forms.TextBox();
            this.textBoxAoInitVal = new System.Windows.Forms.TextBox();
            this.comboBoxAoAddress = new System.Windows.Forms.ComboBox();
            this.textBoxAoDesc = new System.Windows.Forms.TextBox();
            this.textBoxAoID = new System.Windows.Forms.TextBox();
            this.panelDigitalOutput = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDoInitVal = new System.Windows.Forms.TextBox();
            this.comboBoxDoAddress = new System.Windows.Forms.ComboBox();
            this.textBoxDoDesc = new System.Windows.Forms.TextBox();
            this.textBoxDoID = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTypeSelect.SuspendLayout();
            this.panelAnalogInput.SuspendLayout();
            this.panelDigitalInput.SuspendLayout();
            this.panelTagCreate.SuspendLayout();
            this.panelAnalogOutput.SuspendLayout();
            this.panelDigitalOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(270, 267);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(110, 41);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // panelTypeSelect
            // 
            this.panelTypeSelect.Controls.Add(this.label15);
            this.panelTypeSelect.Controls.Add(this.comboBoxType);
            this.panelTypeSelect.Controls.Add(this.buttonNext);
            this.panelTypeSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTypeSelect.Location = new System.Drawing.Point(0, 0);
            this.panelTypeSelect.Name = "panelTypeSelect";
            this.panelTypeSelect.Size = new System.Drawing.Size(392, 320);
            this.panelTypeSelect.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(89, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Tag type:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Analog input",
            "Digital input",
            "Analog output",
            "Digital output"});
            this.comboBoxType.Location = new System.Drawing.Point(166, 131);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(149, 21);
            this.comboBoxType.TabIndex = 1;
            // 
            // panelAnalogInput
            // 
            this.panelAnalogInput.Controls.Add(this.label10);
            this.panelAnalogInput.Controls.Add(this.label11);
            this.panelAnalogInput.Controls.Add(this.label12);
            this.panelAnalogInput.Controls.Add(this.label13);
            this.panelAnalogInput.Controls.Add(this.label14);
            this.panelAnalogInput.Controls.Add(this.textBoxAiUnit);
            this.panelAnalogInput.Controls.Add(this.textBoxAiScanTime);
            this.panelAnalogInput.Controls.Add(this.comboBoxAiAddress);
            this.panelAnalogInput.Controls.Add(this.textBoxAiDesc);
            this.panelAnalogInput.Controls.Add(this.textBoxAiID);
            this.panelAnalogInput.Location = new System.Drawing.Point(0, 0);
            this.panelAnalogInput.Name = "panelAnalogInput";
            this.panelAnalogInput.Size = new System.Drawing.Size(392, 261);
            this.panelAnalogInput.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(127, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Units:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(122, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Scan time:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(127, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Address:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(127, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Description:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(127, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Tag name:";
            // 
            // textBoxAiUnit
            // 
            this.textBoxAiUnit.Location = new System.Drawing.Point(205, 212);
            this.textBoxAiUnit.Name = "textBoxAiUnit";
            this.textBoxAiUnit.Size = new System.Drawing.Size(100, 20);
            this.textBoxAiUnit.TabIndex = 9;
            // 
            // textBoxAiScanTime
            // 
            this.textBoxAiScanTime.Location = new System.Drawing.Point(205, 169);
            this.textBoxAiScanTime.Name = "textBoxAiScanTime";
            this.textBoxAiScanTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxAiScanTime.TabIndex = 8;
            // 
            // comboBoxAiAddress
            // 
            this.comboBoxAiAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAiAddress.FormattingEnabled = true;
            this.comboBoxAiAddress.Location = new System.Drawing.Point(205, 130);
            this.comboBoxAiAddress.Name = "comboBoxAiAddress";
            this.comboBoxAiAddress.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAiAddress.TabIndex = 7;
            // 
            // textBoxAiDesc
            // 
            this.textBoxAiDesc.Location = new System.Drawing.Point(205, 97);
            this.textBoxAiDesc.Name = "textBoxAiDesc";
            this.textBoxAiDesc.Size = new System.Drawing.Size(100, 20);
            this.textBoxAiDesc.TabIndex = 6;
            // 
            // textBoxAiID
            // 
            this.textBoxAiID.Location = new System.Drawing.Point(205, 53);
            this.textBoxAiID.Name = "textBoxAiID";
            this.textBoxAiID.Size = new System.Drawing.Size(100, 20);
            this.textBoxAiID.TabIndex = 5;
            // 
            // panelDigitalInput
            // 
            this.panelDigitalInput.Controls.Add(this.label16);
            this.panelDigitalInput.Controls.Add(this.label17);
            this.panelDigitalInput.Controls.Add(this.label18);
            this.panelDigitalInput.Controls.Add(this.label19);
            this.panelDigitalInput.Controls.Add(this.textBoxDiScanTime);
            this.panelDigitalInput.Controls.Add(this.comboBoxDiAddress);
            this.panelDigitalInput.Controls.Add(this.textBoxDiDesc);
            this.panelDigitalInput.Controls.Add(this.textBoxDiID);
            this.panelDigitalInput.Location = new System.Drawing.Point(3, 0);
            this.panelDigitalInput.Name = "panelDigitalInput";
            this.panelDigitalInput.Size = new System.Drawing.Size(389, 261);
            this.panelDigitalInput.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(139, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Scan time:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(144, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Address:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(144, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Description:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(144, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "Tag name:";
            // 
            // textBoxDiScanTime
            // 
            this.textBoxDiScanTime.Location = new System.Drawing.Point(228, 178);
            this.textBoxDiScanTime.Name = "textBoxDiScanTime";
            this.textBoxDiScanTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiScanTime.TabIndex = 12;
            // 
            // comboBoxDiAddress
            // 
            this.comboBoxDiAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiAddress.FormattingEnabled = true;
            this.comboBoxDiAddress.Location = new System.Drawing.Point(228, 134);
            this.comboBoxDiAddress.Name = "comboBoxDiAddress";
            this.comboBoxDiAddress.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDiAddress.TabIndex = 11;
            // 
            // textBoxDiDesc
            // 
            this.textBoxDiDesc.Location = new System.Drawing.Point(228, 92);
            this.textBoxDiDesc.Name = "textBoxDiDesc";
            this.textBoxDiDesc.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiDesc.TabIndex = 10;
            // 
            // textBoxDiID
            // 
            this.textBoxDiID.Location = new System.Drawing.Point(228, 48);
            this.textBoxDiID.Name = "textBoxDiID";
            this.textBoxDiID.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiID.TabIndex = 9;
            // 
            // panelTagCreate
            // 
            this.panelTagCreate.Controls.Add(this.panelDigitalInput);
            this.panelTagCreate.Controls.Add(this.panelAnalogInput);
            this.panelTagCreate.Controls.Add(this.panelAnalogOutput);
            this.panelTagCreate.Controls.Add(this.panelDigitalOutput);
            this.panelTagCreate.Controls.Add(this.buttonBack);
            this.panelTagCreate.Controls.Add(this.buttonFinish);
            this.panelTagCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTagCreate.Location = new System.Drawing.Point(0, 0);
            this.panelTagCreate.Name = "panelTagCreate";
            this.panelTagCreate.Size = new System.Drawing.Size(392, 320);
            this.panelTagCreate.TabIndex = 2;
            // 
            // panelAnalogOutput
            // 
            this.panelAnalogOutput.Controls.Add(this.label9);
            this.panelAnalogOutput.Controls.Add(this.label5);
            this.panelAnalogOutput.Controls.Add(this.label6);
            this.panelAnalogOutput.Controls.Add(this.label7);
            this.panelAnalogOutput.Controls.Add(this.label8);
            this.panelAnalogOutput.Controls.Add(this.textBoxAoUnit);
            this.panelAnalogOutput.Controls.Add(this.textBoxAoInitVal);
            this.panelAnalogOutput.Controls.Add(this.comboBoxAoAddress);
            this.panelAnalogOutput.Controls.Add(this.textBoxAoDesc);
            this.panelAnalogOutput.Controls.Add(this.textBoxAoID);
            this.panelAnalogOutput.Location = new System.Drawing.Point(3, 0);
            this.panelAnalogOutput.Name = "panelAnalogOutput";
            this.panelAnalogOutput.Size = new System.Drawing.Size(389, 261);
            this.panelAnalogOutput.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(129, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Units:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Initial value:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tag name:";
            // 
            // textBoxAoUnit
            // 
            this.textBoxAoUnit.Location = new System.Drawing.Point(202, 200);
            this.textBoxAoUnit.Name = "textBoxAoUnit";
            this.textBoxAoUnit.Size = new System.Drawing.Size(100, 20);
            this.textBoxAoUnit.TabIndex = 14;
            // 
            // textBoxAoInitVal
            // 
            this.textBoxAoInitVal.Location = new System.Drawing.Point(202, 157);
            this.textBoxAoInitVal.Name = "textBoxAoInitVal";
            this.textBoxAoInitVal.Size = new System.Drawing.Size(100, 20);
            this.textBoxAoInitVal.TabIndex = 13;
            // 
            // comboBoxAoAddress
            // 
            this.comboBoxAoAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAoAddress.FormattingEnabled = true;
            this.comboBoxAoAddress.Location = new System.Drawing.Point(202, 118);
            this.comboBoxAoAddress.Name = "comboBoxAoAddress";
            this.comboBoxAoAddress.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAoAddress.TabIndex = 12;
            // 
            // textBoxAoDesc
            // 
            this.textBoxAoDesc.Location = new System.Drawing.Point(202, 85);
            this.textBoxAoDesc.Name = "textBoxAoDesc";
            this.textBoxAoDesc.Size = new System.Drawing.Size(100, 20);
            this.textBoxAoDesc.TabIndex = 11;
            // 
            // textBoxAoID
            // 
            this.textBoxAoID.Location = new System.Drawing.Point(202, 41);
            this.textBoxAoID.Name = "textBoxAoID";
            this.textBoxAoID.Size = new System.Drawing.Size(100, 20);
            this.textBoxAoID.TabIndex = 10;
            // 
            // panelDigitalOutput
            // 
            this.panelDigitalOutput.Controls.Add(this.label4);
            this.panelDigitalOutput.Controls.Add(this.label3);
            this.panelDigitalOutput.Controls.Add(this.label2);
            this.panelDigitalOutput.Controls.Add(this.label1);
            this.panelDigitalOutput.Controls.Add(this.textBoxDoInitVal);
            this.panelDigitalOutput.Controls.Add(this.comboBoxDoAddress);
            this.panelDigitalOutput.Controls.Add(this.textBoxDoDesc);
            this.panelDigitalOutput.Controls.Add(this.textBoxDoID);
            this.panelDigitalOutput.Location = new System.Drawing.Point(0, 0);
            this.panelDigitalOutput.Name = "panelDigitalOutput";
            this.panelDigitalOutput.Size = new System.Drawing.Size(392, 261);
            this.panelDigitalOutput.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Initial value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tag name:";
            // 
            // textBoxDoInitVal
            // 
            this.textBoxDoInitVal.Location = new System.Drawing.Point(205, 157);
            this.textBoxDoInitVal.Name = "textBoxDoInitVal";
            this.textBoxDoInitVal.Size = new System.Drawing.Size(100, 20);
            this.textBoxDoInitVal.TabIndex = 17;
            // 
            // comboBoxDoAddress
            // 
            this.comboBoxDoAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoAddress.FormattingEnabled = true;
            this.comboBoxDoAddress.Location = new System.Drawing.Point(205, 118);
            this.comboBoxDoAddress.Name = "comboBoxDoAddress";
            this.comboBoxDoAddress.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDoAddress.TabIndex = 16;
            // 
            // textBoxDoDesc
            // 
            this.textBoxDoDesc.Location = new System.Drawing.Point(205, 85);
            this.textBoxDoDesc.Name = "textBoxDoDesc";
            this.textBoxDoDesc.Size = new System.Drawing.Size(100, 20);
            this.textBoxDoDesc.TabIndex = 15;
            // 
            // textBoxDoID
            // 
            this.textBoxDoID.Location = new System.Drawing.Point(205, 41);
            this.textBoxDoID.Name = "textBoxDoID";
            this.textBoxDoID.Size = new System.Drawing.Size(100, 20);
            this.textBoxDoID.TabIndex = 14;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 274);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(86, 26);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(294, 274);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(86, 26);
            this.buttonFinish.TabIndex = 4;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // AddTagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 320);
            this.Controls.Add(this.panelTypeSelect);
            this.Controls.Add(this.panelTagCreate);
            this.Name = "AddTagForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTagForm";
            this.panelTypeSelect.ResumeLayout(false);
            this.panelTypeSelect.PerformLayout();
            this.panelAnalogInput.ResumeLayout(false);
            this.panelAnalogInput.PerformLayout();
            this.panelDigitalInput.ResumeLayout(false);
            this.panelDigitalInput.PerformLayout();
            this.panelTagCreate.ResumeLayout(false);
            this.panelAnalogOutput.ResumeLayout(false);
            this.panelAnalogOutput.PerformLayout();
            this.panelDigitalOutput.ResumeLayout(false);
            this.panelDigitalOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Panel panelTypeSelect;
        private System.Windows.Forms.Panel panelAnalogInput;
        private System.Windows.Forms.TextBox textBoxAiScanTime;
        private System.Windows.Forms.ComboBox comboBoxAiAddress;
        private System.Windows.Forms.TextBox textBoxAiDesc;
        private System.Windows.Forms.TextBox textBoxAiID;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Panel panelDigitalInput;
        private System.Windows.Forms.Panel panelTagCreate;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.TextBox textBoxDiScanTime;
        private System.Windows.Forms.ComboBox comboBoxDiAddress;
        private System.Windows.Forms.TextBox textBoxDiDesc;
        private System.Windows.Forms.TextBox textBoxDiID;
        private System.Windows.Forms.TextBox textBoxAiUnit;
        private System.Windows.Forms.Panel panelAnalogOutput;
        private System.Windows.Forms.TextBox textBoxAoUnit;
        private System.Windows.Forms.TextBox textBoxAoInitVal;
        private System.Windows.Forms.ComboBox comboBoxAoAddress;
        private System.Windows.Forms.TextBox textBoxAoDesc;
        private System.Windows.Forms.TextBox textBoxAoID;
        private System.Windows.Forms.Panel panelDigitalOutput;
        private System.Windows.Forms.TextBox textBoxDoInitVal;
        private System.Windows.Forms.ComboBox comboBoxDoAddress;
        private System.Windows.Forms.TextBox textBoxDoDesc;
        private System.Windows.Forms.TextBox textBoxDoID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}