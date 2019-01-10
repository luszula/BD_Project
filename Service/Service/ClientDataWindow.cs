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
    public partial class ClientDataWindow : Form
    {
        public ClientDataWindow()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AddClient nw = new AddClient();
            nw.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditClient nw = new EditClient();
            nw.ShowDialog();
        }

        private void ClientDataWindow_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext ctx = new DataClasses1DataContext();
            dataGridView2.DataSource = (from row in ctx.Client select row);
        }

        private void ClientDataWindow_Activated(object sender, EventArgs e)
        {
            DataClasses1DataContext ctx = new DataClasses1DataContext();
            dataGridView2.DataSource = (from row in ctx.Client select row);
        }
    }
}
