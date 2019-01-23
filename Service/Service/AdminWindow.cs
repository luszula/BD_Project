using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer;

namespace Service
{
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        

        private void Find_user_button_Click(object sender, EventArgs e)
        {            
           Users_DataGridviev.DataSource= (from p in AdminSection.Find_user(Uname_text_box.Text,Lname_text_box.Text,Fname_text_box.Text)
                                         select new { Last_Name = p.lname, First_Name = p.fname, User_Name = p.uname, Rola = p.role, Data_wygaśnięcia=p.dt_exp });
                
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void New_user_button_Click(object sender, EventArgs e)
        {
           // this.Hide();
            Add_Mod_user_window nw= new Add_Mod_user_window(0);
            nw.ShowDialog();
            Users_DataGridviev.DataSource = (from p in AdminSection.Find_user(Uname_text_box.Text,Lname_text_box.Text, Fname_text_box.Text )
                                             select new { Last_Name = p.lname, First_Name = p.fname, User_Name = p.uname, Rola = p.role, Data_wygaśnięcia = p.dt_exp });

        }

        private void Mod_User_Button_Click(object sender, EventArgs e)
        {
            try
            {
                int numer = Convert.ToInt32(Users_DataGridviev.CurrentRow.Index);
                string zmienna = Users_DataGridviev.Rows[numer].Cells[2].Value.ToString();
                Add_Mod_user_window nw = new Add_Mod_user_window(1, zmienna);
                nw.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Proszę wybrać użytkownika");
            }
            Users_DataGridviev.DataSource = (from p in AdminSection.Find_user(Uname_text_box.Text,Lname_text_box.Text, Fname_text_box.Text)
                                             select new { Last_Name = p.lname, First_Name = p.fname, User_Name = p.uname, Rola = p.role, Data_wygaśnięcia = p.dt_exp });

        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {
           // Users_DataGridviev.DataSource = (from p in AdminSection.Find_user(Lname_text_box.Text, Fname_text_box.Text, Uname_text_box.Text)
           //                                  select new { Last_Name = p.lname, First_Name = p.fname, User_Name = p.uname, Rola = p.role, Data_wygaśnięcia = p.dt_exp });
        }

        //private void Delete_User_Button_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int numer = Convert.ToInt32(Users_DataGridviev.CurrentRow.Index);
        //        string zmienna = Users_DataGridviev.Rows[numer].Cells[2].Value.ToString();
        //        
        //        DialogResult result = MessageBox.Show("Na pewno chcesz usunąć tego użytkownika?", "Potwierdzenie", MessageBoxButtons.YesNo);
        //        if (result == DialogResult.Yes)
        //        {
        //            AdminSection.Delete_user(zmienna);
        //        }
        //        else if (result == DialogResult.No)
        //        {
        //           
        //        }
        //        Users_DataGridviev.DataSource = (from p in AdminSection.Find_user(Lname_text_box.Text, Fname_text_box.Text, Uname_text_box.Text)
        //                                    select new { Last_Name = p.lname, First_Name = p.fname, User_Name = p.uname, Rola = p.role, Data_wygaśnięcia = p.dt_exp });
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Proszę wybrać użytkownika");
        //    }
        //}
    }
}
