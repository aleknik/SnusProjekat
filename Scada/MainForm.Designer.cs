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
            this.buttonRemoveTag = new System.Windows.Forms.Button();
            this.listViewAlarms = new System.Windows.Forms.ListView();
            this.tagID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonAddTAg
            // 
            this.buttonAddTAg.Location = new System.Drawing.Point(12, 88);
            this.buttonAddTAg.Name = "buttonAddTAg";
            this.buttonAddTAg.Size = new System.Drawing.Size(75, 23);
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
            this.valueColumn});
            this.tagListView.FullRowSelect = true;
            this.tagListView.Location = new System.Drawing.Point(12, 146);
            this.tagListView.Name = "tagListView";
            this.tagListView.Size = new System.Drawing.Size(737, 200);
            this.tagListView.TabIndex = 4;
            this.tagListView.UseCompatibleStateImageBehavior = false;
            this.tagListView.View = System.Windows.Forms.View.Details;
            this.tagListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tagListView_MouseDoubleClick);
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            // 
            // TypeColumn
            // 
            this.TypeColumn.Text = "Type";
            // 
            // valueColumn
            // 
            this.valueColumn.Text = "Value";
            this.valueColumn.Width = 120;
            // 
            // buttonRemoveTag
            // 
            this.buttonRemoveTag.Location = new System.Drawing.Point(633, 88);
            this.buttonRemoveTag.Name = "buttonRemoveTag";
            this.buttonRemoveTag.Size = new System.Drawing.Size(75, 23);
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
            this.listViewAlarms.Location = new System.Drawing.Point(12, 352);
            this.listViewAlarms.Name = "listViewAlarms";
            this.listViewAlarms.Size = new System.Drawing.Size(737, 185);
            this.listViewAlarms.TabIndex = 6;
            this.listViewAlarms.UseCompatibleStateImageBehavior = false;
            this.listViewAlarms.View = System.Windows.Forms.View.Details;
            this.listViewAlarms.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewAlarms_MouseDoubleClick);
            // 
            // tagID
            // 
            this.tagID.Text = "Tag ID";
            this.tagID.Width = 84;
            // 
            // message
            // 
            this.message.Text = "message";
            this.message.Width = 110;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 128;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 549);
            this.Controls.Add(this.listViewAlarms);
            this.Controls.Add(this.buttonRemoveTag);
            this.Controls.Add(this.tagListView);
            this.Controls.Add(this.buttonAddTAg);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scada";
            this.ResumeLayout(false);

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
    }
}

