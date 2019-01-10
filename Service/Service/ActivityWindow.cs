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

namespace Service
{
    public partial class ActivityWindow : Form
    {
        public ActivityWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddActivity nw = new AddActivity();
            nw.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditActivity nw = new EditActivity();
            nw.ShowDialog();
        }

        private void ActivityWindow_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext ctx = new DataClasses1DataContext();
            dataGridView1.DataSource = (from a in ctx.Request
                                        select new { a.id_req, a.description, a.result, a.status, a.dt_reg, a.dt_fin_cancel });
            dataGridView3.DataSource = (from a in ctx.Activity
                                        select new { a.id_act, a.seq_name, a.description, a.result, a.status, a.dt_reg, a.dt_fin_cancel, a.id_pers, a.act_type });
        }

        private void ActivityWindow_Activated(object sender, EventArgs e)
        {
            DataClasses1DataContext ctx = new DataClasses1DataContext();
            dataGridView3.DataSource = (from a in ctx.Activity
                                        select new { a.id_act, a.seq_name, a.description, a.result, a.status, a.dt_reg, a.dt_fin_cancel, a.id_pers, a.act_type });
        }
    }
}
