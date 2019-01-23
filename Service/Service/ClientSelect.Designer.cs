namespace Service
{
	partial class ClientSelect
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
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.clientSelectButton = new System.Windows.Forms.Button();
            this.clientDisplayButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.clientDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientDataGridView.Location = new System.Drawing.Point(0, 0);
            this.clientDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.RowTemplate.Height = 24;
            this.clientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientDataGridView.Size = new System.Drawing.Size(481, 211);
            this.clientDataGridView.TabIndex = 0;
            this.clientDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientDataGridView_CellContentClick);
            // 
            // clientSelectButton
            // 
            this.clientSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clientSelectButton.BackColor = System.Drawing.Color.White;
            this.clientSelectButton.Enabled = false;
            this.clientSelectButton.Location = new System.Drawing.Point(294, 10);
            this.clientSelectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientSelectButton.Name = "clientSelectButton";
            this.clientSelectButton.Size = new System.Drawing.Size(100, 41);
            this.clientSelectButton.TabIndex = 1;
            this.clientSelectButton.Text = "Wybierz";
            this.clientSelectButton.UseVisualStyleBackColor = false;
            this.clientSelectButton.Click += new System.EventHandler(this.clientSelectButton_Click);
            // 
            // clientDisplayButton
            // 
            this.clientDisplayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clientDisplayButton.BackColor = System.Drawing.Color.White;
            this.clientDisplayButton.Location = new System.Drawing.Point(56, 10);
            this.clientDisplayButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientDisplayButton.Name = "clientDisplayButton";
            this.clientDisplayButton.Size = new System.Drawing.Size(100, 41);
            this.clientDisplayButton.TabIndex = 2;
            this.clientDisplayButton.Text = "Wyświetl";
            this.clientDisplayButton.UseVisualStyleBackColor = false;
            this.clientDisplayButton.Click += new System.EventHandler(this.clientDisplayButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.clientDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.clientSelectButton);
            this.splitContainer1.Panel2.Controls.Add(this.clientDisplayButton);
            this.splitContainer1.Size = new System.Drawing.Size(481, 274);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 3;
            // 
            // ClientSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 274);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientSelect";
            this.Text = "ClientSelect";
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView clientDataGridView;
		private System.Windows.Forms.Button clientSelectButton;
		private System.Windows.Forms.Button clientDisplayButton;
		private System.Windows.Forms.SplitContainer splitContainer1;
	}
}