namespace Service
{
    partial class ClientDataWindow
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idszukaj = new System.Windows.Forms.TextBox();
            this.companyszukaj = new System.Windows.Forms.TextBox();
            this.nameszukaj = new System.Windows.Forms.TextBox();
            this.lnameszukaj = new System.Windows.Forms.TextBox();
            this.szukaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 1;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(118, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "Edytuj";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 157);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1054, 444);
            this.dataGridView2.TabIndex = 5;
            // 
            // idszukaj
            // 
            this.idszukaj.Location = new System.Drawing.Point(12, 116);
            this.idszukaj.Name = "idszukaj";
            this.idszukaj.Size = new System.Drawing.Size(100, 20);
            this.idszukaj.TabIndex = 7;
            // 
            // companyszukaj
            // 
            this.companyszukaj.Location = new System.Drawing.Point(118, 116);
            this.companyszukaj.Name = "companyszukaj";
            this.companyszukaj.Size = new System.Drawing.Size(100, 20);
            this.companyszukaj.TabIndex = 8;
            // 
            // nameszukaj
            // 
            this.nameszukaj.Location = new System.Drawing.Point(224, 116);
            this.nameszukaj.Name = "nameszukaj";
            this.nameszukaj.Size = new System.Drawing.Size(100, 20);
            this.nameszukaj.TabIndex = 9;
            // 
            // lnameszukaj
            // 
            this.lnameszukaj.Location = new System.Drawing.Point(330, 116);
            this.lnameszukaj.Name = "lnameszukaj";
            this.lnameszukaj.Size = new System.Drawing.Size(100, 20);
            this.lnameszukaj.TabIndex = 10;
            // 
            // szukaj
            // 
            this.szukaj.BackColor = System.Drawing.Color.White;
            this.szukaj.Location = new System.Drawing.Point(450, 108);
            this.szukaj.Name = "szukaj";
            this.szukaj.Size = new System.Drawing.Size(75, 35);
            this.szukaj.TabIndex = 11;
            this.szukaj.Text = "Szukaj";
            this.szukaj.UseVisualStyleBackColor = false;
            this.szukaj.Click += new System.EventHandler(this.szukaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID Klienta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(115, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nazwa firmy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(221, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Imię";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(327, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nazwisko";
            // 
            // ClientDataWindow
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 613);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szukaj);
            this.Controls.Add(this.lnameszukaj);
            this.Controls.Add(this.nameszukaj);
            this.Controls.Add(this.companyszukaj);
            this.Controls.Add(this.idszukaj);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Name = "ClientDataWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.DataGridView dataGridView1;
        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox idszukaj;
        private System.Windows.Forms.TextBox companyszukaj;
        private System.Windows.Forms.TextBox nameszukaj;
        private System.Windows.Forms.TextBox lnameszukaj;
        private System.Windows.Forms.Button szukaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}