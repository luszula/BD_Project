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
    public partial class Add_Mod_user_window : Form
    {
        string UnameGG;
        int choice;
        public Add_Mod_user_window(int choicee, string UnameG = "")
        {
            //if (choice == 0)
            //{
            UnameGG = UnameG;
            choice = choicee;
            InitializeComponent();

            // //   Pass1_text_box.PasswordChar = Pass_text_box.PasswordChar = '*';
            //}
            //else if (choice == 1)
            //{
            //    UnameGG = UnameG;
            //    InitializeComponent_sz();
            //    DataClasses1DataContext conn_str = new DataClasses1DataContext();
            //    var sz_zap = conn_str.Personels.Where(p => (p.uname == UnameG)).First();
            //    Lname_text_box.Text = sz_zap.lname;
            //    Fname_text_box.Text = sz_zap.fname;
            //    Uname_text_box.Text = sz_zap.uname;
            //    Role_text_box.Text = sz_zap.role;
            ////    Pass1_text_box.PasswordChar = Pass_text_box.PasswordChar = '*';
            //    Pass_text_box.Text = Pass1_text_box.Text = "nowe haslo";
            //    string wzor = "dd.MM.yyyy";
            //    string data_z_bazy = "01.01.2000";//ustawia jesli w bazie jest null
            //    DateTime pomo_date;

            //    if (sz_zap.dt_exp != null)
            //    {

            //        data_z_bazy = sz_zap.dt_exp.Value.ToString(wzor);
            //        pomo_date = sz_zap.dt_exp.Value;
            //    }
            //    else
            //    {
            //        pomo_date = DateTime.ParseExact(data_z_bazy, wzor, null);

            //    }
            //    Dt_exp_picker.Value = pomo_date;
            //}
        }
        private void Add_Mod_user_window_Load(object sender, EventArgs e)
        {
            Pass1_text_box.PasswordChar = Pass_text_box.PasswordChar = '*';
            if (choice == 0)
            {
                Add_Mod_user_button.Text = "Dodaj";
                Open_label.Text = "Dodaj nowego użytkownika:";
                Help_Box.Text = "Wartość domyślna daty wygaśnięcia konta jest równoważna z jej brakiem";
            }
            else if (choice == 1)
            {

                Add_Mod_user_button.Text = "Zapisz";
                DataClasses1DataContext conn_str = new DataClasses1DataContext();
                var sz_zap = conn_str.Personel.Where(p => (p.uname == UnameGG)).First();
                Lname_text_box.Text = sz_zap.lname;
                Fname_text_box.Text = sz_zap.fname;
                Role_Combo_Box.Text = sz_zap.role;
                Pass_text_box.Text = Pass1_text_box.Text = "nowe haslo";
                string wzor = "dd.MM.yyyy";
                string data_z_bazy = "01.01.2000";//ustawia jesli w bazie jest null
                Open_label.Text = "Modyfikuj użytkownika: " + sz_zap.uname;
                Help_Box.Text = "Należy wprowadzić tylko wartości wymagające modyfikacji";

                DateTime pomo_date;

                if (sz_zap.dt_exp != null)
                {

                    data_z_bazy = sz_zap.dt_exp.Value.ToString(wzor);
                    pomo_date = sz_zap.dt_exp.Value;
                }
                else
                {
                    pomo_date = DateTime.ParseExact(data_z_bazy, wzor, null);

                }
                Dt_exp_picker.Value = pomo_date;
            }
        }

        private void Add_Mod_user_button_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Na pewno chcesz zapisać tego użytkownika?", "Potwierdzenie", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {

                Lname_label.ForeColor = Fname_label.ForeColor = Pass_label.ForeColor = Role_label.ForeColor = Pass1_label.ForeColor = Color.Black;
                if (Lname_text_box.Text == "" || Fname_text_box.Text == "" || Pass_text_box.Text == "" || Pass1_text_box.Text == "" || Role_Combo_Box.Text == "")
                {
                    MessageBox.Show("Pozostawiono puste pola");
                    if (Lname_text_box.Text == "")
                    {
                        Lname_label.ForeColor = Color.Red;
                    }
                    if (Fname_text_box.Text == "")
                    {
                        Fname_label.ForeColor = Color.Red;
                    }
                    if (Pass_text_box.Text == "")
                    {
                        Pass_label.ForeColor = Color.Red;
                    }
                    if (Pass1_text_box.Text == "")
                    {
                        Pass1_label.ForeColor = Color.Red;
                    }
                    if (Role_Combo_Box.Text == "")
                    {
                        Role_label.ForeColor = Color.Red;
                    }
                }


                else if (Pass1_text_box.Text != Pass_text_box.Text)
                {
                    MessageBox.Show("Podane hasła różnią się.");
                    Pass_label.ForeColor = Color.Red;
                    Pass1_label.ForeColor = Color.Red;
                }
                else
                {
                    if (Add_Mod_user_button.Text == "Dodaj")
                    {

                        DateTime data = Dt_exp_picker.Value;
                        string zwrot = AdminSection.Create_Personel(Lname_text_box.Text, Fname_text_box.Text, Role_Combo_Box.Text, Pass_text_box.Text, data);
                        if (zwrot == "Pomyslnie dodano do BD. ")
                        {
                            DialogResult result = MessageBox.Show(zwrot + "Chcesz dodać następnego uzytkownika?", "Potwierdzenie", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                Lname_text_box.Clear();
                                Fname_text_box.Clear();
                                Pass_text_box.Clear();
                                Pass1_text_box.Clear();
                                Haslo_checkbox.Checked = false;
                            }
                            else if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                        }
                        else
                            MessageBox.Show(zwrot);
                    }
                    else if (Add_Mod_user_button.Text == "Zapisz")
                    {
                        DateTime data = Dt_exp_picker.Value;
                        AdminSection.Modify_Personel(UnameGG, Lname_text_box.Text, Fname_text_box.Text, Role_Combo_Box.Text, Pass_text_box.Text, data);
                        this.Close();
                    }
                }
            }
        }

        private void Haslo_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Haslo_checkbox.Checked)
                Pass1_text_box.PasswordChar = Pass_text_box.PasswordChar = '\0';
            else
                Pass1_text_box.PasswordChar = Pass_text_box.PasswordChar = '*';
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

     
    
