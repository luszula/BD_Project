namespace Service
{
	partial class PersReqDisplay
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
            this.PersReqDataGridView = new System.Windows.Forms.DataGridView();
            this.displayButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.PersReqDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersReqDataGridView
            // 
            this.PersReqDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersReqDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersReqDataGridView.Location = new System.Drawing.Point(0, 0);
            this.PersReqDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PersReqDataGridView.Name = "PersReqDataGridView";
            this.PersReqDataGridView.RowTemplate.Height = 24;
            this.PersReqDataGridView.Size = new System.Drawing.Size(596, 310);
            this.PersReqDataGridView.TabIndex = 0;
            // 
            // displayButton
            // 
            this.displayButton.BackColor = System.Drawing.Color.White;
            this.displayButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayButton.Location = new System.Drawing.Point(0, 0);
            this.displayButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(596, 49);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "Wyświetl";
            this.displayButton.UseVisualStyleBackColor = false;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PersReqDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.displayButton);
            this.splitContainer1.Size = new System.Drawing.Size(596, 362);
            this.splitContainer1.SplitterDistance = 310;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // PersReqDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 369);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PersReqDisplay";
            this.Text = "PersReqDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.PersReqDataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView PersReqDataGridView;
		private System.Windows.Forms.Button displayButton;
		private System.Windows.Forms.SplitContainer splitContainer1;
	}
}