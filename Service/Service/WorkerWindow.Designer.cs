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
            this.button1 = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.DataGridView();
            this.id_act = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seq_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activity_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(670, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Display
            // 
            this.Display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Display.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_act,
            this.seq_name,
            this.description,
            this.status,
            this.Activity_Type});
            this.Display.Location = new System.Drawing.Point(12, 105);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(757, 195);
            this.Display.TabIndex = 2;
            // 
            // id_act
            // 
            this.id_act.DataPropertyName = "id_act";
            this.id_act.HeaderText = "ID";
            this.id_act.Name = "id_act";
            this.id_act.ReadOnly = true;
            // 
            // seq_name
            // 
            this.seq_name.DataPropertyName = "seq_name";
            this.seq_name.HeaderText = "Kolejność";
            this.seq_name.Name = "seq_name";
            this.seq_name.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Opis";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // Activity_Type
            // 
            this.Activity_Type.DataPropertyName = "Activity_Type";
            this.Activity_Type.HeaderText = "Czynność";
            this.Activity_Type.Name = "Activity_Type";
            this.Activity_Type.ReadOnly = true;
            // 
            // WorkerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.button1);
            this.Name = "WorkerWindow";
            this.Text = "WorkerWindow";
            this.Load += new System.EventHandler(this.WorkerWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Display;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_act;
        private System.Windows.Forms.DataGridViewTextBoxColumn seq_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activity_Type;
    }
}