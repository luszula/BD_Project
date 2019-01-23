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
    public partial class ClientDataWindow : Form
    {
        public ClientDataWindow()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AddClient nw = new AddClient();
            nw.ShowDialog();

            var data = BizzLayer.ManagerSection.GetClientAllData();
            dataGridView2.DataSource = data;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string currIndex = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString();

                EditClient nw = new EditClient(currIndex);
                nw.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Proszę wybrać klienta");
            }

            dataGridView2.DataSource = (from a in ManagerSection.Find_user(idszukaj.Text, companyszukaj.Text, nameszukaj.Text, lnameszukaj.Text)
                                        select new { ID_Klienta = a.id_cli, Nazwa_firmy = a.name, Imię = a.fname, Nazwisko = a.lname, Telefon = a.tel, Ulica = a.street_name, Kod_pocztowy = a.post_code, Numer_domu = a.number });

        }

        private void szukaj_Click(object sender, EventArgs e)
        {

            dataGridView2.DataSource = (from a in ManagerSection.Find_user(idszukaj.Text, companyszukaj.Text, nameszukaj.Text, lnameszukaj.Text)
                                        select new { ID_Klienta = a.id_cli, Nazwa_firmy = a.name, Imię = a.fname, Nazwisko = a.lname, Telefon = a.tel, Ulica = a.street_name, Kod_pocztowy = a.post_code, Numer_domu = a.number });

        }
    }
}
