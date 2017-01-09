namespace Scada
{
    partial class MainForm
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
            this.buttonAddTAg = new System.Windows.Forms.Button();
            this.tagListView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRemoveTag = new System.Windows.Forms.Button();
            this.listViewAlarms = new System.Windows.Forms.ListView();
            this.tagID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddTAg
            // 
            this.buttonAddTAg.Location = new System.Drawing.Point(12, 12);
            this.buttonAddTAg.Name = "buttonAddTAg";
            this.buttonAddTAg.Size = new System.Drawing.Size(114, 50);
            this.buttonAddTAg.TabIndex = 1;
            this.buttonAddTAg.Text = "Add tag";
            this.buttonAddTAg.UseVisualStyleBackColor = true;
            this.buttonAddTAg.Click += new System.EventHandler(this.button1_Click);
            // 
            // tagListView
            // 
            this.tagListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.TypeColumn,
            this.valueColumn,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.tagListView.FullRowSelect = true;
            this.tagListView.Location = new System.Drawing.Point(12, 96);
            this.tagListView.Name = "tagListView";
            this.tagListView.Size = new System.Drawing.Size(737, 200);
            this.tagListView.TabIndex = 1;
            this.tagListView.UseCompatibleStateImageBehavior = false;
            this.tagListView.View = System.Windows.Forms.View.Details;
            this.tagListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tagListView_MouseDoubleClick);
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            this.idColumn.Width = 109;
            // 
            // TypeColumn
            // 
            this.TypeColumn.Text = "Type";
            // 
            // valueColumn
            // 
            this.valueColumn.Text = "Value";
            this.valueColumn.Width = 87;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Address";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Scan time";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Initial value";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Unit";
            this.columnHeader4.Width = 83;
            // 
            // buttonRemoveTag
            // 
            this.buttonRemoveTag.Location = new System.Drawing.Point(650, 12);
            this.buttonRemoveTag.Name = "buttonRemoveTag";
            this.buttonRemoveTag.Size = new System.Drawing.Size(99, 50);
            this.buttonRemoveTag.TabIndex = 5;
            this.buttonRemoveTag.Text = "Remove tag";
            this.buttonRemoveTag.UseVisualStyleBackColor = true;
            this.buttonRemoveTag.Click += new System.EventHandler(this.buttonRemoveTag_Click);
            // 
            // listViewAlarms
            // 
            this.listViewAlarms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tagID,
            this.message,
            this.time});
            this.listViewAlarms.FullRowSelect = true;
            this.listViewAlarms.Location = new System.Drawing.Point(12, 323);
            this.listViewAlarms.Name = "listViewAlarms";
            this.listViewAlarms.Size = new System.Drawing.Size(737, 200);
            this.listViewAlarms.TabIndex = 6;
            this.listViewAlarms.UseCompatibleStateImageBehavior = false;
            this.listViewAlarms.View = System.Windows.Forms.View.Details;
            this.listViewAlarms.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewAlarms_MouseDoubleClick);
            // 
            // tagID
            // 
            this.tagID.Text = "Tag ID";
            this.tagID.Width = 106;
            // 
            // message
            // 
            this.message.Text = "Message";
            this.message.Width = 281;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tags";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Alarms";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewAlarms);
            this.Controls.Add(this.buttonRemoveTag);
            this.Controls.Add(this.tagListView);
            this.Controls.Add(this.buttonAddTAg);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddTAg;
        private System.Windows.Forms.ListView tagListView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader valueColumn;
        private System.Windows.Forms.Button buttonRemoveTag;
        private System.Windows.Forms.ColumnHeader TypeColumn;
        private System.Windows.Forms.ListView listViewAlarms;
        private System.Windows.Forms.ColumnHeader tagID;
        private System.Windows.Forms.ColumnHeader message;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

