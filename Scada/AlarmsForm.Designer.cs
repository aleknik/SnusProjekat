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
            this.buttonAddAlarm = new System.Windows.Forms.Button();
            this.buttonRemoveAlarm = new System.Windows.Forms.Button();
            this.activationPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alarmType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewAlarms
            // 
            this.listViewAlarms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.activationPoint,
            this.alarmType,
            this.message});
            this.listViewAlarms.Location = new System.Drawing.Point(12, 89);
            this.listViewAlarms.Name = "listViewAlarms";
            this.listViewAlarms.Size = new System.Drawing.Size(745, 206);
            this.listViewAlarms.TabIndex = 0;
            this.listViewAlarms.UseCompatibleStateImageBehavior = false;
            this.listViewAlarms.View = System.Windows.Forms.View.Details;
            // 
            // buttonAddAlarm
            // 
            this.buttonAddAlarm.Location = new System.Drawing.Point(12, 44);
            this.buttonAddAlarm.Name = "buttonAddAlarm";
            this.buttonAddAlarm.Size = new System.Drawing.Size(100, 23);
            this.buttonAddAlarm.TabIndex = 1;
            this.buttonAddAlarm.Text = "Add alarm";
            this.buttonAddAlarm.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveAlarm
            // 
            this.buttonRemoveAlarm.Location = new System.Drawing.Point(663, 44);
            this.buttonRemoveAlarm.Name = "buttonRemoveAlarm";
            this.buttonRemoveAlarm.Size = new System.Drawing.Size(100, 23);
            this.buttonRemoveAlarm.TabIndex = 2;
            this.buttonRemoveAlarm.Text = "Remove alarm";
            this.buttonRemoveAlarm.UseVisualStyleBackColor = true;
            // 
            // activationPoint
            // 
            this.activationPoint.Text = "Activation value";
            this.activationPoint.Width = 100;
            // 
            // alarmType
            // 
            this.alarmType.Text = "Type";
            this.alarmType.Width = 77;
            // 
            // message
            // 
            this.message.Text = "Message";
            this.message.Width = 258;
            // 
            // AlarmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 392);
            this.Controls.Add(this.buttonRemoveAlarm);
            this.Controls.Add(this.buttonAddAlarm);
            this.Controls.Add(this.listViewAlarms);
            this.Name = "AlarmsForm";
            this.Text = "AlarmsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAlarms;
        private System.Windows.Forms.Button buttonAddAlarm;
        private System.Windows.Forms.Button buttonRemoveAlarm;
        private System.Windows.Forms.ColumnHeader activationPoint;
        private System.Windows.Forms.ColumnHeader alarmType;
        private System.Windows.Forms.ColumnHeader message;
    }
}