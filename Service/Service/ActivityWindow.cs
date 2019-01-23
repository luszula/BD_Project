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

            try
            {
                string currIndex = dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[0].Value.ToString();

                EditActivity nw = new EditActivity(currIndex);
                nw.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Proszę wybrać aktywność");
            }
        }

        private void ActivityWindow_Load(object sender, EventArgs e)
        {
            var data = BizzLayer.ManagerSection.GetRequestData();
            dataGridView1.DataSource = data;
        }

        private void ActivityWindow_Activated(object sender, EventArgs e)
        {
            var data = BizzLayer.ManagerSection.ActivityData();
            dataGridView3.DataSource = data;
        }
    }
}
