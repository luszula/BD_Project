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
using System.Data.SqlClient;
namespace Service
{
    public partial class id_obiekt : Form
    {
        public int IDD = 0;
        public id_obiekt()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            dataGridView1.DataSource = ManagerSection.Get_Data3();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string id_pracowniczka = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            IDD = Int32.Parse(id_pracowniczka);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                string imie = textBox1.Text;
            dataGridView1.DataSource = ManagerSection.Szukaj_2(imie);
                dataGridView1.Update();
                dataGridView1.Refresh();
                if (textBox1.Text == "")
                {
                    GetData();
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
