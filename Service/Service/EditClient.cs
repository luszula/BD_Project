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
    public partial class EditClient : Form
    {
        public EditClient()
        {
            InitializeComponent();
        }

    private void Button2_Click(object sender, EventArgs e)
        {
            if (name.Text == "" && fname.Text == "" && lname.Text == "" && tel.Text == "" && street.Text == "" && postcode.Text == "" && number.Text == "")
            {
                MessageBox.Show("Kliknij przycisk pobierz dane");
                button1.ForeColor = Color.Red;
            }
            else
            {   //(button1.Text == "Potwierdź")
                ManagerSection.Edit_Client(name.Text, fname.Text, lname.Text, tel.Text, street.Text, postcode.Text, number.Text, edit.Text);
                this.Close();
            }
        }

        private void EditClient_Load(object sender, EventArgs e)
        {
            
            using (DataClasses1DataContext ctx = new DataClasses1DataContext())
            {
                var q = ctx.Client.Select(c => new { c.id_cli });
                edit.DataSource = q.ToList();
                edit.DisplayMember = "id_cli";
            };
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dbContext = new DataClasses1DataContext())
            {
                int convert = Int32.Parse(edit.Text);
                Client ctx = dbContext.Client.SingleOrDefault(x => x.id_cli == convert);

                name.Text = ctx.name;
                fname.Text = ctx.fname;
                lname.Text = ctx.lname;
                tel.Text = ctx.tel;
                street.Text = ctx.street_name;
                postcode.Text = ctx.post_code;
                number.Text = ctx.number;
            }
        }
    }
}
