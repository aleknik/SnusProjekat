namespace Scada
{
    partial class FormAddAlarm
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxAlarmPoint = new System.Windows.Forms.TextBox();
            this.textBoxAlarmMessage = new System.Windows.Forms.TextBox();
            this.comboBoxAlarmType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(197, 226);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "Create";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(12, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxAlarmPoint
            // 
            this.textBoxAlarmPoint.Location = new System.Drawing.Point(136, 36);
            this.textBoxAlarmPoint.Name = "textBoxAlarmPoint";
            this.textBoxAlarmPoint.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlarmPoint.TabIndex = 2;
            // 
            // textBoxAlarmMessage
            // 
            this.textBoxAlarmMessage.Location = new System.Drawing.Point(136, 89);
            this.textBoxAlarmMessage.Name = "textBoxAlarmMessage";
            this.textBoxAlarmMessage.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlarmMessage.TabIndex = 3;
            // 
            // comboBoxAlarmType
            // 
            this.comboBoxAlarmType.FormattingEnabled = true;
            this.comboBoxAlarmType.Location = new System.Drawing.Point(136, 62);
            this.comboBoxAlarmType.Name = "comboBoxAlarmType";
            this.comboBoxAlarmType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlarmType.TabIndex = 4;
            // 
            // FormAddAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.comboBoxAlarmType);
            this.Controls.Add(this.textBoxAlarmMessage);
            this.Controls.Add(this.textBoxAlarmPoint);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Name = "FormAddAlarm";
            this.Text = "FormAddAlarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxAlarmPoint;
        private System.Windows.Forms.TextBox textBoxAlarmMessage;
        private System.Windows.Forms.ComboBox comboBoxAlarmType;
    }
}