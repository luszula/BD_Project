namespace Service
{
    partial class AdminWindow
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
            this.Users_DataGridviev = new System.Windows.Forms.DataGridView();
            this.Lname_text_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Fname_text_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Uname_text_box = new System.Windows.Forms.TextBox();
            this.Find_user_button = new System.Windows.Forms.Button();
            this.New_user_button = new System.Windows.Forms.Button();
            this.Mod_User_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Exit_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Users_DataGridviev)).BeginInit();
            this.SuspendLayout();
            // 
            // Users_DataGridviev
            // 
            this.Users_DataGridviev.AllowUserToAddRows = false;
            this.Users_DataGridviev.AllowUserToDeleteRows = false;
            this.Users_DataGridviev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_DataGridviev.Location = new System.Drawing.Point(15, 115);
            this.Users_DataGridviev.Name = "Users_DataGridviev";
            this.Users_DataGridviev.ReadOnly = true;
            this.Users_DataGridviev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Users_DataGridviev.Size = new System.Drawing.Size(548, 213);
            this.Users_DataGridviev.TabIndex = 0;
            // 
            // Lname_text_box
            // 
            this.Lname_text_box.Location = new System.Drawing.Point(74, 26);
            this.Lname_text_box.Name = "Lname_text_box";
            this.Lname_text_box.Size = new System.Drawing.Size(109, 20);
            this.Lname_text_box.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Szukaj:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Imię:";
            // 
            // Fname_text_box
            // 
            this.Fname_text_box.Location = new System.Drawing.Point(224, 26);
            this.Fname_text_box.Name = "Fname_text_box";
            this.Fname_text_box.Size = new System.Drawing.Size(85, 20);
            this.Fname_text_box.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "UserName:";
            // 
            // Uname_text_box
            // 
            this.Uname_text_box.Location = new System.Drawing.Point(382, 26);
            this.Uname_text_box.Name = "Uname_text_box";
            this.Uname_text_box.Size = new System.Drawing.Size(100, 20);
            this.Uname_text_box.TabIndex = 8;
            // 
            // Find_user_button
            // 
            this.Find_user_button.Location = new System.Drawing.Point(512, 24);
            this.Find_user_button.Name = "Find_user_button";
            this.Find_user_button.Size = new System.Drawing.Size(75, 23);
            this.Find_user_button.TabIndex = 9;
            this.Find_user_button.Text = "Szukaj";
            this.Find_user_button.UseVisualStyleBackColor = true;
            this.Find_user_button.Click += new System.EventHandler(this.Find_user_button_Click);
            // 
            // New_user_button
            // 
            this.New_user_button.Location = new System.Drawing.Point(28, 76);
            this.New_user_button.Name = "New_user_button";
            this.New_user_button.Size = new System.Drawing.Size(75, 23);
            this.New_user_button.TabIndex = 10;
            this.New_user_button.Text = "Dodaj";
            this.New_user_button.UseVisualStyleBackColor = true;
            this.New_user_button.Click += new System.EventHandler(this.New_user_button_Click);
            // 
            // Mod_User_Button
            // 
            this.Mod_User_Button.Location = new System.Drawing.Point(119, 76);
            this.Mod_User_Button.Name = "Mod_User_Button";
            this.Mod_User_Button.Size = new System.Drawing.Size(75, 23);
            this.Mod_User_Button.TabIndex = 11;
            this.Mod_User_Button.Text = "Edytuj";
            this.Mod_User_Button.UseVisualStyleBackColor = true;
            this.Mod_User_Button.Click += new System.EventHandler(this.Mod_User_Button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Zarządzaj użytkownikami:";
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(512, 76);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 14;
            this.Exit_Button.Text = "Wyjdź";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // AdminWindow
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(604, 361);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Mod_User_Button);
            this.Controls.Add(this.New_user_button);
            this.Controls.Add(this.Find_user_button);
            this.Controls.Add(this.Uname_text_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Fname_text_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lname_text_box);
            this.Controls.Add(this.Users_DataGridviev);
            this.Name = "AdminWindow";
            this.Load += new System.EventHandler(this.AdminWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Users_DataGridviev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Lname_text_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Fname_text_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Uname_text_box;
        private System.Windows.Forms.Button Find_user_button;
        private System.Windows.Forms.Button New_user_button;
        private System.Windows.Forms.Button Mod_User_Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.DataGridView Users_DataGridviev;
    }
}