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
    public partial class EditActivity : Form
    {
        public EditActivity()
        {
            InitializeComponent(); 
        }

        private void EditActivity_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext ctx = new DataClasses1DataContext();
            dataGridView1.DataSource = (from a in ctx.Personel
                                        where (a.role == "wor")
                                        select new { a.id_pers, a.fname, a.lname, a.role, a.uname });

            using (DataClasses1DataContext cont = new DataClasses1DataContext())
            {
                var q = cont.Activity.Select(c => new { c.id_act });
                activity.DataSource = q.ToList();
                activity.DisplayMember = "id_act";

                var qq = (from a in ctx.Personel
                          where (a.role == "wor")
                          select new { a.id_pers });
                worker.DataSource = qq.ToList();
                worker.DisplayMember = "id_pers";
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerSection.Edit_Activity(activity.Text, worker.Text);
            this.Close();
        }
    }

}
