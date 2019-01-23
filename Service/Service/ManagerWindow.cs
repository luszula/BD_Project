using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public partial class ManagerWindow : Form
    {
        public ManagerWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientDataWindow nw1 = new ClientDataWindow();
            nw1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivityWindow nw2 = new ActivityWindow();
            nw2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagerObject nw3 = new ManagerObject();
            nw3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivityManager nw4 = new ActivityManager();
            nw4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Request nw5 = new Request();
            nw5.ShowDialog();
        }
    }
}
