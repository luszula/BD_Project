using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BizzLayer;

namespace Service
{
    public partial class AddActivityType : Form
    {
        public AddActivityType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (code.Text == "" || describe.Text == "")
            {
                MessageBox.Show("Pozostawiono puste pola");
            }
            else 
            {
                ManagerSection.Create_ActivityType(code.Text, describe.Text);
                MessageBox.Show("Dodano nowy rodzaj czynności");
                this.Close();
            }
        }

    }
    
}
