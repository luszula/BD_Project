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
    public partial class WorkerWindow : Form
    {
        public WorkerWindow(int workerID)
        {
            worker = workerID;
            InitializeComponent();
        }

        public int worker { get; set; }
        public List<WorkerSection> activity { get; set; }

        private void WorkerWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void appoitmentsButton_Click(object sender, EventArgs e)
        {
            activity = WorkerSection.Appoitments(worker);
            display.Columns.Clear();
            display.DataSource = activity;
            for (int i = 0; i < 7; i++)
            {
                display.AutoResizeColumn(i);
            }
            display.ClearSelection();
            updateButton.Enabled = false;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int selected = display.CurrentCell.RowIndex;
            int selectedId = activity[selected].Id;
            WorkerUpdate dataChange = new WorkerUpdate(worker, selectedId);
            dataChange.Show(this);
        }

        private void display_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(display.SelectedCells.Count > 0)
            {
                updateButton.Enabled = true;
            }
        }
    }
}
