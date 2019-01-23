namespace Service
{
	partial class ActivityManager
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
            this.ActivityDataGridView = new System.Windows.Forms.DataGridView();
            this.reqSearchButton = new System.Windows.Forms.Button();
            this.perSearchButton = new System.Windows.Forms.Button();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.statusConfirmButton = new System.Windows.Forms.Button();
            this.activityDisplayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ActivityDataGridView
            // 
            this.ActivityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActivityDataGridView.Location = new System.Drawing.Point(35, 39);
            this.ActivityDataGridView.Name = "ActivityDataGridView";
            this.ActivityDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActivityDataGridView.Size = new System.Drawing.Size(533, 286);
            this.ActivityDataGridView.TabIndex = 0;
            this.ActivityDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // reqSearchButton
            // 
            this.reqSearchButton.BackColor = System.Drawing.Color.White;
            this.reqSearchButton.Location = new System.Drawing.Point(34, 336);
            this.reqSearchButton.Name = "reqSearchButton";
            this.reqSearchButton.Size = new System.Drawing.Size(100, 49);
            this.reqSearchButton.TabIndex = 3;
            this.reqSearchButton.Text = "Wyszukaj zgłoszenie";
            this.reqSearchButton.UseVisualStyleBackColor = false;
            this.reqSearchButton.Click += new System.EventHandler(this.reqSearchButton_Click);
            // 
            // perSearchButton
            // 
            this.perSearchButton.BackColor = System.Drawing.Color.White;
            this.perSearchButton.Location = new System.Drawing.Point(161, 336);
            this.perSearchButton.Name = "perSearchButton";
            this.perSearchButton.Size = new System.Drawing.Size(100, 49);
            this.perSearchButton.TabIndex = 4;
            this.perSearchButton.Text = "Wyszukaj personel";
            this.perSearchButton.UseVisualStyleBackColor = false;
            this.perSearchButton.Click += new System.EventHandler(this.perSearchButton_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(463, 366);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(105, 21);
            this.statusComboBox.TabIndex = 5;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // statusConfirmButton
            // 
            this.statusConfirmButton.BackColor = System.Drawing.Color.White;
            this.statusConfirmButton.Location = new System.Drawing.Point(463, 336);
            this.statusConfirmButton.Name = "statusConfirmButton";
            this.statusConfirmButton.Size = new System.Drawing.Size(105, 23);
            this.statusConfirmButton.TabIndex = 6;
            this.statusConfirmButton.Text = "Zatwierdź";
            this.statusConfirmButton.UseVisualStyleBackColor = false;
            this.statusConfirmButton.Click += new System.EventHandler(this.statusConfirmButton_Click);
            // 
            // activityDisplayButton
            // 
            this.activityDisplayButton.BackColor = System.Drawing.Color.White;
            this.activityDisplayButton.Location = new System.Drawing.Point(353, 336);
            this.activityDisplayButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.activityDisplayButton.Name = "activityDisplayButton";
            this.activityDisplayButton.Size = new System.Drawing.Size(105, 23);
            this.activityDisplayButton.TabIndex = 9;
            this.activityDisplayButton.Text = "Wyświetl czynności";
            this.activityDisplayButton.UseVisualStyleBackColor = false;
            this.activityDisplayButton.Click += new System.EventHandler(this.activityDisplayButton_Click);
            // 
            // ActivityManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 399);
            this.Controls.Add(this.activityDisplayButton);
            this.Controls.Add(this.statusConfirmButton);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.perSearchButton);
            this.Controls.Add(this.reqSearchButton);
            this.Controls.Add(this.ActivityDataGridView);
            this.Name = "ActivityManager";
            this.Text = "ActivityManager";
            this.Load += new System.EventHandler(this.ActivityManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActivityDataGridView)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView ActivityDataGridView;
		private System.Windows.Forms.Button reqSearchButton;
		private System.Windows.Forms.Button perSearchButton;
		private System.Windows.Forms.ComboBox statusComboBox;
		private System.Windows.Forms.Button statusConfirmButton;
		private System.Windows.Forms.Button activityDisplayButton;
	}
}