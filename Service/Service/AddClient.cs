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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Tel.Text == "" || StreetName.Text == "" || Post.Text == "" || Number.Text == "")
            {
                MessageBox.Show("Pozostawiono puste pola");
              
            }
            else if((Fname.Text == "" || Lname.Text == "") && CName.Text  == "")
            {
                MessageBox.Show("Pozostawiono puste pola");
            }
            else 
            {
                ManagerSection.Create_Client(Fname.Text, Lname.Text, Tel.Text, StreetName.Text, Post.Text, Number.Text, CName.Text);
                MessageBox.Show("Dodano klienta");
                this.Close();
            }
        }

    }
}
