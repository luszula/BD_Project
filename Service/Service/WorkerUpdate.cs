using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer;

namespace Service
{
    public partial class WorkerUpdate : Form
    {
        public WorkerUpdate(int workerId)
        {
            InitializeComponent();
            worker = workerId;
        }

        public int worker { get; set; }

        private void WorkerUpdate_Load(object sender, EventArgs e)
        {
            List<int> ids = WorkerSection.AppoitmentsIds(worker);
            idBox.DataSource = ids;
        }
    }
}
