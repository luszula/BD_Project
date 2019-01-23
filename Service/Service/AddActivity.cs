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
    public partial class AddActivity : Form
    {
        public AddActivity()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                if (seq.Text == "" || description.Text == ""  || status.Text == "" || startdate.Text == ""  || idreq.Text == "" || type.Text == "")
                {
                    MessageBox.Show("Pozostawiono puste pola");
                }

                else 
                {
                    int convert = Int32.Parse(idreq.Text);

                    DateTime dDate;

                    if (DateTime.TryParse(startdate.Text, out dDate))
                    {
                        String.Format("dd/MM/yyyy HH:mm", dDate);
                        DateTime start = DateTime.Parse(startdate.Text);
                        ManagerSection.Create_Activity(seq.Text, description.Text, status.Text, start, convert, type.Text);
                        MessageBox.Show("Dodano czynność");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Zły format daty");
                    }
                    
                }

         }

        private void AddActivity_Load(object sender, EventArgs e)
        {
            status.Text = "opn";
            DateTime actualdate = DateTime.Now;
            string convert=actualdate.ToString("dd/MM/yyyy HH:mm");
            startdate.Text = convert;


            using (DataClasses1DataContext ctx = new DataClasses1DataContext())
            {
                var q = ctx.Activity_Type.Select(c => new { c.act_type, c.act_name });
                type.DataSource = q.ToList();
                type.DisplayMember = "act_type";
                type.ValueMember = "act_name";
                type.SelectedIndex = -1;

                var qq = ctx.Request.Select(d => new { d.id_req });
                idreq.DataSource = qq.ToList();
                idreq.DisplayMember = "id_req";
                idreq.SelectedIndex = -1;
            };

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddActivityType nw = new AddActivityType();
            nw.ShowDialog();
        }

        private void type_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext ctx = new DataClasses1DataContext())
            {
                var q = ctx.Activity_Type.Select(c => new { c.act_type });
                type.DataSource = q.ToList();
                type.DisplayMember = "act_type";
            };
        }
    }
}
