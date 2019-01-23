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
        public WorkerUpdate(int workerId, int selection)
        {
            InitializeComponent();
            worker = workerId;
            select = selection;
        }

        public int select { get; set; }
        public int worker { get; set; }

        private void WorkerUpdate_Load(object sender, EventArgs e)
        {
            textId.Text = select.ToString();
            List<string> options = new List<string> { "----", "Praca", "Zakończone", "Niepowodzenie" };
            updateBox.DataSource = options;
        }

        private void updateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(updateBox.SelectedIndex == 0)
            {
                updateButton.Enabled = false;
            }
            else
            {
                updateButton.Enabled = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            bool success;
            switch (updateBox.SelectedIndex)
            {
                case 1:
                    success = WorkerSection.UpdateApoitment(select, "pro", null, false);
                    break;
                case 2:
                    success = WorkerSection.UpdateApoitment(select, "fin", null, true);
                    break;
                case 3:
                    Result data = new Result();
                    data.ShowDialog(this);
                    if(data.result == "" || data.result == null)
                    {
                        success = true;
                        break;
                    }
                    success = WorkerSection.UpdateApoitment(select, "can", data.result, true);
                    break;
                default:
                    success = false;
                    break;
            }

            if (success == false)
            {
                MessageBox.Show("tup");
            }

            this.Close();

        }
    }
}
