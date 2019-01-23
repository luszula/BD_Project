using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        public string result { get; set; }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(textArea.Text != "")
            {
                result = textArea.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Pole tekstowe nie może zostać puste.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            result = "";
            this.Close();
        }
    }
}
