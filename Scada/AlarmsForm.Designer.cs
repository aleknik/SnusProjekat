namespace Scada
{
    partial class AlarmsForm
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
            this.listViewAlarms = new System.Windows.Forms.ListView();
            this.activationPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alarmType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddAlarm = new System.Windows.Forms.Button();
            this.buttonRemoveAlarm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewAlarms
            // 
            this.listViewAlarms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.activationPoint,
            this.alarmType,
            this.message});
            this.listViewAlarms.FullRowSelect = true;
            this.listViewAlarms.Location = new System.Drawing.Point(15, 90);
            this.listViewAlarms.Name = "listViewAlarms";
            this.listViewAlarms.Size = new System.Drawing.Size(745, 206);
            this.listViewAlarms.TabIndex = 0;
            this.listViewAlarms.UseCompatibleStateImageBehavior = false;
            this.listViewAlarms.View = System.Windows.Forms.View.Details;
            // 
            // activationPoint
            // 
            this.activationPoint.Text = "Activation value";
            this.activationPoint.Width = 143;
            // 
            // alarmType
            // 
            this.alarmType.Text = "Type";
            this.alarmType.Width = 119;
            // 
            // message
            // 
            this.message.Text = "Message";
            this.message.Width = 258;
            // 
            // buttonAddAlarm
            // 
            this.buttonAddAlarm.Location = new System.Drawing.Point(12, 12);
            this.buttonAddAlarm.Name = "buttonAddAlarm";
            this.buttonAddAlarm.Size = new System.Drawing.Size(100, 50);
            this.buttonAddAlarm.TabIndex = 1;
            this.buttonAddAlarm.Text = "Add alarm";
            this.buttonAddAlarm.UseVisualStyleBackColor = true;
            this.buttonAddAlarm.Click += new System.EventHandler(this.buttonAddAlarm_Click);
            // 
            // buttonRemoveAlarm
            // 
            this.buttonRemoveAlarm.Location = new System.Drawing.Point(657, 12);
            this.buttonRemoveAlarm.Name = "buttonRemoveAlarm";
            this.buttonRemoveAlarm.Size = new System.Drawing.Size(100, 50);
            this.buttonRemoveAlarm.TabIndex = 2;
            this.buttonRemoveAlarm.Text = "Remove alarm";
            this.buttonRemoveAlarm.UseVisualStyleBackColor = true;
            this.buttonRemoveAlarm.Click += new System.EventHandler(this.buttonRemoveAlarm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alarms";
            // 
            // AlarmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemoveAlarm);
            this.Controls.Add(this.buttonAddAlarm);
            this.Controls.Add(this.listViewAlarms);
            this.Name = "AlarmsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlarmsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAlarms;
        private System.Windows.Forms.Button buttonAddAlarm;
        private System.Windows.Forms.Button buttonRemoveAlarm;
        private System.Windows.Forms.ColumnHeader activationPoint;
        private System.Windows.Forms.ColumnHeader alarmType;
        private System.Windows.Forms.ColumnHeader message;
        private System.Windows.Forms.Label label1;
    }
}