namespace Service
{
    partial class WorkerWindow
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
            this.display = new System.Windows.Forms.DataGridView();
            this.appoitmentsButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.display.Enabled = false;
            this.display.Location = new System.Drawing.Point(12, 30);
            this.display.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.display.MultiSelect = false;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.display.Size = new System.Drawing.Size(780, 300);
            this.display.TabIndex = 0;
            this.display.TabStop = false;
            // 
            // appoitmentsButton
            // 
            this.appoitmentsButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.appoitmentsButton.Location = new System.Drawing.Point(422, 360);
            this.appoitmentsButton.Name = "appoitmentsButton";
            this.appoitmentsButton.Size = new System.Drawing.Size(370, 50);
            this.appoitmentsButton.TabIndex = 2;
            this.appoitmentsButton.Text = "Zlecenia";
            this.appoitmentsButton.UseVisualStyleBackColor = false;
            this.appoitmentsButton.Click += new System.EventHandler(this.appoitmentsButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.updateButton.Location = new System.Drawing.Point(12, 360);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(370, 50);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Aktualizuj";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // WorkerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(804, 431);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.appoitmentsButton);
            this.Controls.Add(this.display);
            this.Name = "WorkerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerWindow";
            this.Load += new System.EventHandler(this.WorkerWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView display;
        private System.Windows.Forms.Button appoitmentsButton;
        private System.Windows.Forms.Button updateButton;
    }
}