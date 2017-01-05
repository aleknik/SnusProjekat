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
            this.buttonNext = new System.Windows.Forms.Button();
            this.panelTypeSelect = new System.Windows.Forms.Panel();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.panelAnalogInput = new System.Windows.Forms.Panel();
            this.textBoxAiScanTime = new System.Windows.Forms.TextBox();
            this.comboBoxAiAddress = new System.Windows.Forms.ComboBox();
            this.textBoxAiDesc = new System.Windows.Forms.TextBox();
            this.textBoxAiID = new System.Windows.Forms.TextBox();
            this.panelDigitalInput = new System.Windows.Forms.Panel();
            this.textBoxDiScanTime = new System.Windows.Forms.TextBox();
            this.comboBoxDiAddress = new System.Windows.Forms.ComboBox();
            this.textBoxDiDesc = new System.Windows.Forms.TextBox();
            this.textBoxDiID = new System.Windows.Forms.TextBox();
            this.panelTagCreate = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.textBoxAiUnit = new System.Windows.Forms.TextBox();
            this.panelAnalogOutput = new System.Windows.Forms.Panel();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.textBoxAoInitVal = new System.Windows.Forms.TextBox();
            this.comboBoxAoAddress = new System.Windows.Forms.ComboBox();
            this.textBoxAoDesc = new System.Windows.Forms.TextBox();
            this.textBoxAoID = new System.Windows.Forms.TextBox();
            this.panelTypeSelect.SuspendLayout();
            this.panelAnalogInput.SuspendLayout();
            this.panelDigitalInput.SuspendLayout();
            this.panelTagCreate.SuspendLayout();
            this.panelAnalogOutput.SuspendLayout();
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
            this.panelTypeSelect.Controls.Add(this.comboBoxType);
            this.panelTypeSelect.Controls.Add(this.buttonNext);
            this.panelTypeSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTypeSelect.Location = new System.Drawing.Point(0, 0);
            this.panelTypeSelect.Name = "panelTypeSelect";
            this.panelTypeSelect.Size = new System.Drawing.Size(392, 320);
            this.panelTypeSelect.TabIndex = 2;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Analog input",
            "Digital input",
            "Analog output",
            "Digital output"});
            this.comboBoxType.Location = new System.Drawing.Point(121, 129);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(149, 21);
            this.comboBoxType.TabIndex = 1;
            // 
            // panelAnalogInput
            // 
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
            // textBoxAiScanTime
            // 
            this.textBoxAiScanTime.Location = new System.Drawing.Point(135, 168);
            this.textBoxAiScanTime.Name = "textBoxAiScanTime";
            this.textBoxAiScanTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxAiScanTime.TabIndex = 8;
            // 
            // comboBoxAiAddress
            // 
            this.comboBoxAiAddress.FormattingEnabled = true;
            this.comboBoxAiAddress.Location = new System.Drawing.Point(135, 129);
            this.comboBoxAiAddress.Name = "comboBoxAiAddress";
            this.comboBoxAiAddress.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAiAddress.TabIndex = 7;
            // 
            // textBoxAiDesc
            // 
            this.textBoxAiDesc.Location = new System.Drawing.Point(135, 96);
            this.textBoxAiDesc.Name = "textBoxAiDesc";
            this.textBoxAiDesc.Size = new System.Drawing.Size(100, 20);
            this.textBoxAiDesc.TabIndex = 6;
            // 
            // textBoxAiID
            // 
            this.textBoxAiID.Location = new System.Drawing.Point(135, 52);
            this.textBoxAiID.Name = "textBoxAiID";
            this.textBoxAiID.Size = new System.Drawing.Size(100, 20);
            this.textBoxAiID.TabIndex = 5;
            // 
            // panelDigitalInput
            // 
            this.panelDigitalInput.Controls.Add(this.textBoxDiScanTime);
            this.panelDigitalInput.Controls.Add(this.comboBoxDiAddress);
            this.panelDigitalInput.Controls.Add(this.textBoxDiDesc);
            this.panelDigitalInput.Controls.Add(this.textBoxDiID);
            this.panelDigitalInput.Location = new System.Drawing.Point(3, 0);
            this.panelDigitalInput.Name = "panelDigitalInput";
            this.panelDigitalInput.Size = new System.Drawing.Size(389, 261);
            this.panelDigitalInput.TabIndex = 3;
            // 
            // textBoxDiScanTime
            // 
            this.textBoxDiScanTime.Location = new System.Drawing.Point(134, 185);
            this.textBoxDiScanTime.Name = "textBoxDiScanTime";
            this.textBoxDiScanTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiScanTime.TabIndex = 12;
            // 
            // comboBoxDiAddress
            // 
            this.comboBoxDiAddress.FormattingEnabled = true;
            this.comboBoxDiAddress.Location = new System.Drawing.Point(134, 141);
            this.comboBoxDiAddress.Name = "comboBoxDiAddress";
            this.comboBoxDiAddress.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDiAddress.TabIndex = 11;
            // 
            // textBoxDiDesc
            // 
            this.textBoxDiDesc.Location = new System.Drawing.Point(134, 99);
            this.textBoxDiDesc.Name = "textBoxDiDesc";
            this.textBoxDiDesc.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiDesc.TabIndex = 10;
            // 
            // textBoxDiID
            // 
            this.textBoxDiID.Location = new System.Drawing.Point(134, 55);
            this.textBoxDiID.Name = "textBoxDiID";
            this.textBoxDiID.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiID.TabIndex = 9;
            // 
            // panelTagCreate
            // 
            this.panelTagCreate.Controls.Add(this.panelAnalogOutput);
            this.panelTagCreate.Controls.Add(this.panelAnalogInput);
            this.panelTagCreate.Controls.Add(this.panelDigitalInput);
            this.panelTagCreate.Controls.Add(this.buttonBack);
            this.panelTagCreate.Controls.Add(this.buttonFinish);
            this.panelTagCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTagCreate.Location = new System.Drawing.Point(0, 0);
            this.panelTagCreate.Name = "panelTagCreate";
            this.panelTagCreate.Size = new System.Drawing.Size(392, 320);
            this.panelTagCreate.TabIndex = 2;
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
            this.buttonFinish.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonFinish.Location = new System.Drawing.Point(294, 274);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(86, 26);
            this.buttonFinish.TabIndex = 4;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // textBoxAiUnit
            // 
            this.textBoxAiUnit.Location = new System.Drawing.Point(135, 211);
            this.textBoxAiUnit.Name = "textBoxAiUnit";
            this.textBoxAiUnit.Size = new System.Drawing.Size(100, 20);
            this.textBoxAiUnit.TabIndex = 9;
            // 
            // panelAnalogOutput
            // 
            this.panelAnalogOutput.Controls.Add(this.textBoxUnit);
            this.panelAnalogOutput.Controls.Add(this.textBoxAoInitVal);
            this.panelAnalogOutput.Controls.Add(this.comboBoxAoAddress);
            this.panelAnalogOutput.Controls.Add(this.textBoxAoDesc);
            this.panelAnalogOutput.Controls.Add(this.textBoxAoID);
            this.panelAnalogOutput.Location = new System.Drawing.Point(3, 0);
            this.panelAnalogOutput.Name = "panelAnalogOutput";
            this.panelAnalogOutput.Size = new System.Drawing.Size(389, 261);
            this.panelAnalogOutput.TabIndex = 6;
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(134, 200);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnit.TabIndex = 14;
            // 
            // textBoxAoInitVal
            // 
            this.textBoxAoInitVal.Location = new System.Drawing.Point(134, 157);
            this.textBoxAoInitVal.Name = "textBoxAoInitVal";
            this.textBoxAoInitVal.Size = new System.Drawing.Size(100, 20);
            this.textBoxAoInitVal.TabIndex = 13;
            // 
            // comboBoxAoAddress
            // 
            this.comboBoxAoAddress.FormattingEnabled = true;
            this.comboBoxAoAddress.Location = new System.Drawing.Point(134, 118);
            this.comboBoxAoAddress.Name = "comboBoxAoAddress";
            this.comboBoxAoAddress.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAoAddress.TabIndex = 12;
            // 
            // textBoxAoDesc
            // 
            this.textBoxAoDesc.Location = new System.Drawing.Point(134, 85);
            this.textBoxAoDesc.Name = "textBoxAoDesc";
            this.textBoxAoDesc.Size = new System.Drawing.Size(100, 20);
            this.textBoxAoDesc.TabIndex = 11;
            // 
            // textBoxAoID
            // 
            this.textBoxAoID.Location = new System.Drawing.Point(134, 41);
            this.textBoxAoID.Name = "textBoxAoID";
            this.textBoxAoID.Size = new System.Drawing.Size(100, 20);
            this.textBoxAoID.TabIndex = 10;
            // 
            // AddTagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 320);
            this.Controls.Add(this.panelTagCreate);
            this.Controls.Add(this.panelTypeSelect);
            this.Name = "AddTagForm";
            this.Text = "AddTagForm";
            this.panelTypeSelect.ResumeLayout(false);
            this.panelAnalogInput.ResumeLayout(false);
            this.panelAnalogInput.PerformLayout();
            this.panelDigitalInput.ResumeLayout(false);
            this.panelDigitalInput.PerformLayout();
            this.panelTagCreate.ResumeLayout(false);
            this.panelAnalogOutput.ResumeLayout(false);
            this.panelAnalogOutput.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.TextBox textBoxAoInitVal;
        private System.Windows.Forms.ComboBox comboBoxAoAddress;
        private System.Windows.Forms.TextBox textBoxAoDesc;
        private System.Windows.Forms.TextBox textBoxAoID;
    }
}