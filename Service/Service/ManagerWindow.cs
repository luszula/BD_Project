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
            ClientDataWindow nw = new ClientDataWindow();
            nw.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivityWindow nw = new ActivityWindow();
            nw.ShowDialog();
        }
    }
}
