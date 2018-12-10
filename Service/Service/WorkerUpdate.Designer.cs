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
            this.idBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // idBox
            // 
            this.idBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idBox.FormattingEnabled = true;
            this.idBox.Location = new System.Drawing.Point(12, 12);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(121, 21);
            this.idBox.TabIndex = 0;
            // 
            // WorkerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 161);
            this.Controls.Add(this.idBox);
            this.Name = "WorkerUpdate";
            this.Text = "WorkerUpdate";
            this.Load += new System.EventHandler(this.WorkerUpdate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox idBox;
    }
}