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

        
        public Request()
        { 
            InitializeComponent();
            GetData();
            textBox2.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {       }
        private void label4_Click(object sender, EventArgs e)
        {       }
        private void label5_Click(object sender, EventArgs e)
        {       }
        private void label7_Click(object sender, EventArgs e)
        {       }
        private void menu()
        {
           List<string> options2 = new List<string>();
            options2.Add("fin");
            options2.Add("opn");
            options2.Add("can");
            options2.Add("pro");
            comboBox2.DataSource = options2;

            List<string> options3 = new List<string>();

            options3.Add("w trakcie");
            options3.Add("nie powodzenie");
            options3.Add("powodzenie");
   
            comboBox3.DataSource = options3;
        }
        private void Request_Load(object sender, EventArgs e)
        {
            menu();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {         }

        private void GetData()
        { 
           
            dataGridView1.DataSource = ManagerSection.Get_Data();
            dataGridView1.Update();
            dataGridView1.Refresh();
            string drugie_id = dataGridView1.Rows[dataGridView1.RowCount-1].Cells[0].Value.ToString();
            int id = Int32.Parse(drugie_id)+1;
            textBox2.Text = id.ToString(); 
        }

        private void GetData2(int pozdro)
        {

            dataGridView1.DataSource = ManagerSection.Get_Data2(pozdro);
            dataGridView1.Update();
            dataGridView1.Refresh();
            string drugie_id = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value.ToString();
            int id = Int32.Parse(drugie_id) + 1;
            textBox2.Text = id.ToString();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 1 || comboBox3.SelectedIndex == 2)
            {
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                richTextBox1.Enabled = false;
                comboBox2.Enabled = false;
            }
            else
            {
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                richTextBox1.Enabled = true;
                comboBox2.Enabled = true;
            }
        }     
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void dodaj_wiersz(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
           //try
           // string SQLConn = "Data Source=DESKTOP-7C6VI2V;Initial Catalog=projektDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            //DataClasses1DataContext idreq = new DataClasses1DataContext(SQLConn);

            DialogResult result1 = MessageBox.Show("Czy na pewno chcesz dodać rekord", "Potwierdzenie", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {

                if ( textBox3.Text == "" || textBox4.Text == "") {
                    MessageBox.Show("Nie uzupełniono wymaganych pól");
           
                label9.ForeColor = Color.Black;
                if (textBox3.Text == "")
                {
                    //MessageBox.Show("Pozostawiono puste pole");
                    if (textBox3.Text == "")
                    {
                        label9.ForeColor = Color.Red;
                    }

                }

                label8.ForeColor = Color.Black;
                if (textBox4.Text == "")
                {
                    //MessageBox.Show("Pozostawiono puste pole");
                    if (textBox4.Text == "")
                    {
                        label8.ForeColor = Color.Red;
                    }

                }
            }
            else
            {
                
                int id_request = Int32.Parse(textBox2.Text);
                int id_klient = System.Int32.Parse(textBox3.Text);
                int id_obiektu = System.Int32.Parse(textBox4.Text);

                string box3 = comboBox3.SelectedValue.ToString();
                string box2 = comboBox2.SelectedValue.ToString();

                ManagerSection.RequestADD(id_request, richTextBox1.Text, box3, box2, DateTime.Now, id_obiektu, id_klient);
                    label3.ForeColor = Color.Black;
                    label9.ForeColor = Color.Black;
                    label8.ForeColor = Color.Black;
                    GetData();
                    refresh();
                    menu();
                    MessageBox.Show("Dodano");
            }               
            }          
        }
        private void button2_Click(object sender, EventArgs e)
        {
                if (textBox1.Text == "")
                {
                    GetData();
                }
                else
                {
                    int numer_wiersza = Int32.Parse(textBox1.Text);
                    dataGridView1.DataSource = ManagerSection.Szukaj_1(numer_wiersza);
                    dataGridView1.Update();
                    dataGridView1.Refresh();
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
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Akceptowalne tylko numery");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Akceptowalne tylko numery");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length-1);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Akceptowalne tylko numery");
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length-1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Czy na pewno chcesz zaktualizować?", "Potwierdzenie", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {

                if (textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Nie uzupełniono wymaganych pól");
                    

                    label9.ForeColor = Color.Black;
                    if (textBox3.Text == "")
                    {
                        //MessageBox.Show("Pozostawiono puste pole");
                        if (textBox3.Text == "")
                        {
                            label9.ForeColor = Color.Red;
                        }

                    }

                    label8.ForeColor = Color.Black;
                    if (textBox4.Text == "")
                    {
                        //MessageBox.Show("Pozostawiono puste pole");
                        if (textBox4.Text == "")
                        {
                            label8.ForeColor = Color.Red;
                        }

                    }
                }
                else
                {

                    int id_request = Int32.Parse(textBox2.Text);
                    int id_klient = System.Int32.Parse(textBox3.Text);
                    int id_obiektu = System.Int32.Parse(textBox4.Text);

                    string box3 = comboBox3.SelectedValue.ToString();
                    string box2 = comboBox2.SelectedValue.ToString();
                 
                    ManagerSection.RequestEDIT(id_request, richTextBox1.Text, box3, box2, id_obiektu, id_klient, DateTime.Now);
                    label3.ForeColor = Color.Black;
                    label9.ForeColor = Color.Black;
                    label8.ForeColor = Color.Black;

                    GetData();
                    refresh();
                    menu();
                    MessageBox.Show("Zaktualizowano");
                }
            }
    }

        private void button4_Click(object sender, EventArgs e)
        {
            string id_req = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            string id_kienta = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            string id_obj = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            string descripion = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            string status = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            //string result = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            textBox2.Text = id_req;
            textBox3.Text = id_kienta;
            textBox4.Text = id_obj;
            richTextBox1.Text = descripion;
            comboBox2.Text = status;
           // comboBox3.Text = result;
        }

        private void refresh()
        {
            string drugie_id = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value.ToString();
            int id = Int32.Parse(drugie_id) + 1;
            textBox2.Text = id.ToString();
            textBox3.Text = "";
            textBox4.Text = "";
            richTextBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int id = 0;
            id_pracownik nw = new id_pracownik();
            if (nw.ShowDialog(this) == DialogResult.OK)
            {
                id = nw.IDD;
            }
            textBox3.Text = id.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int id = 0;
            id_obiekt nw = new id_obiekt();
            if (nw.ShowDialog(this) == DialogResult.OK)
            {
                id = nw.IDD;
            }
            textBox4.Text = id.ToString();
        }
    }
}
