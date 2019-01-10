namespace Service
{
    partial class ManagerWindow
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
            this.components = new System.ComponentModel.Container();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tupDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tupDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tupDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tupDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tupDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tupDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataSource = typeof(DataLayer.Activity);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Obsłuż dane o kliencie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Obsługa czynności";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 233);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ManagerWindow";
            this.Text = "ManagerWindow";
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tupDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tupDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tupDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource activityBindingSource;
        private System.Windows.Forms.BindingSource tupDataSetBindingSource;
        //private tupDataSet tupDataSet;
        private System.Windows.Forms.BindingSource tupDataSetBindingSource1;
        private System.Windows.Forms.BindingSource tupDataSet1BindingSource;
        //private tupDataSet1 tupDataSet1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}