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
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
            textPass.PasswordChar='*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        public Personel active { get; set; }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textLogin.Text;
            string pass = textPass.Text;

            if(pass == "" || login == "")
            {
                MessageBox.Show("Pozostawiono puste pola");
            }
            else
            {
                Personel attempt = LoginSection.Login(login, pass);

                if (attempt != null)
                {
                    this.active = attempt;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Błędne dane logowania.");
                }
            }       
        }

        private void textLogin_TextChanged(object sender, EventArgs e)
        {
            if(textLogin.Text != "" && textPass.Text != "")
            {
                buttonLogin.Enabled = true;
            }else
            {
                buttonLogin.Enabled = false;
            }
        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {
            if (textLogin.Text != "" && textPass.Text != "")
            {
                buttonLogin.Enabled = true;
            }
            else
            {
                buttonLogin.Enabled = false;
            }
        }
    }
}
