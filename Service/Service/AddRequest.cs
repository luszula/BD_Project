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
    public partial class Request : Form
    {

        int ID_id;
        public Request()
        {
            
            InitializeComponent();
            GetData();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Request_Load(object sender, EventArgs e)
        {

            

            List<string> options2 = new List<string>();
            options2.Add("rozpoczęcie");
            options2.Add("w trakcie");
            options2.Add("zakończono");
            comboBox2.DataSource = options2;

            List<string> options3 = new List<string>();
            options3.Add("nie ustalono");
            options3.Add("powodzenie");
            options3.Add("niepowodzenie");
            comboBox3.DataSource = options3;
        }


   
       
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            //if (comboBox2.SelectedIndex == 1)
            //{
            //    comboBox2.Enabled = false;
            //}
            //else
            //{
            //    comboBox2.Enabled = true;
            //}
        }

        private void GetData()
        {
            
                string SQLConn = "Data Source=DESKTOP-7C6VI2V;Initial Catalog=projektDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
                DataClasses1DataContext data = new DataClasses1DataContext(SQLConn);
                dataGridView1.DataSource = (from a in data.Request select new { a.id_req, a.description, a.status, a.result });

                dataGridView1.Update();
                dataGridView1.Refresh();

            int id = dataGridView1.RowCount + 1;
            ID_id = id;
            textBox2.Text += id;
            
            

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //editButton.Enabled = false;
        }




        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
                textBox2.Enabled = false;
          


        }

        private void dodaj_wiersz(object sender, EventArgs e)
        {



        }



        private void button1_Click(object sender, EventArgs e)
        {
           // string SQLConn = "Data Source=DESKTOP-7C6VI2V;Initial Catalog=projektDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            //DataClasses1DataContext idreq = new DataClasses1DataContext(SQLConn);

            DialogResult result1 = MessageBox.Show("Czy na pewno chcesz dodać rekord", "Potwierdzenie", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                label3.ForeColor  = Color.Black;
                if (richTextBox1.Text == "")
                {
                    MessageBox.Show("Pozostawiono puste pole");
                    if (richTextBox1.Text == "")
                    {
                        label3.ForeColor = Color.Red;
                    }
                   
                }

                else
                {
                    string t = textBox2.Text;
                    int convert = Int32.Parse(t);
                 // ManagerSection.RequestADD(convert, richTextBox1.Text, comboBox3.Text, comboBox2.Text);
                    dataGridView1.Update();
                    dataGridView1.Refresh();


                    MessageBox.Show("Dodano");

                }
                

            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            //string SQLConn = "Data Source=DESKTOP-7C6VI2V;Initial Catalog=projektDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
           // DataClasses1DataContext data = new DataClasses1DataContext(SQLConn);
            //var id = (from a in data.Request select new { a.id_req });


            label7.ForeColor = Color.Black;
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Pozostawiono puste pole");
                    if (textBox1.Text == "")
                    {
                        label7.ForeColor = Color.Red;
                    }

                }

           

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
