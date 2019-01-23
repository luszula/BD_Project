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
        public EditActivity(string id)
        {
            InitializeComponent();

            using (DataClasses1DataContext ctx = new DataClasses1DataContext())
            {
                activity.Text = id;
            };
        }

    private void button1_Click(object sender, EventArgs e)
        {
            if (worker.Text != "" && worker.Text != "0")
            {
                ManagerSection.Edit_Activity(activity.Text, worker.Text);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = 0;
            ActivitySelect actDialog = new ActivitySelect();
            if (actDialog.ShowDialog(this) == DialogResult.OK)
            {
                id = actDialog._ID;
            }
            activity.Text = id.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = 0;
            WorkerSelect workerDialog = new WorkerSelect();
            if (workerDialog.ShowDialog(this) == DialogResult.OK)
            {
                id = workerDialog._ID;
            }
            worker.Text = id.ToString();
        }
    }

}
