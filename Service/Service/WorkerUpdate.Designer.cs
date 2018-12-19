namespace Service
{
    partial class WorkerUpdate
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
            this.textId = new System.Windows.Forms.TextBox();
            this.updateBox = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textId
            // 
            this.textId.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textId.Enabled = false;
            this.textId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textId.ForeColor = System.Drawing.Color.Black;
            this.textId.HideSelection = false;
            this.textId.Location = new System.Drawing.Point(45, 24);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(170, 19);
            this.textId.TabIndex = 0;
            this.textId.Text = "PlaceHolder";
            this.textId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updateBox
            // 
            this.updateBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateBox.FormattingEnabled = true;
            this.updateBox.Location = new System.Drawing.Point(245, 26);
            this.updateBox.Name = "updateBox";
            this.updateBox.Size = new System.Drawing.Size(170, 21);
            this.updateBox.TabIndex = 1;
            this.updateBox.SelectedIndexChanged += new System.EventHandler(this.updateBox_SelectedIndexChanged);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.White;
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(45, 60);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(170, 30);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Zatwierdź";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(245, 60);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(170, 30);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // WorkerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(459, 104);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.updateBox);
            this.Controls.Add(this.textId);
            this.MaximumSize = new System.Drawing.Size(475, 143);
            this.MinimumSize = new System.Drawing.Size(475, 143);
            this.Name = "WorkerUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerUpdate";
            this.Load += new System.EventHandler(this.WorkerUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.ComboBox updateBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
    }
}