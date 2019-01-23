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
    public partial class ActivitySelect : Form
    {
        public int _ID = 0;

        public ActivitySelect()
        {
            InitializeComponent();
        }

        private int GetCurrentId()
        {
            int id;
            try
            {
                int index = DataGridView.CurrentRow.Index;
                string currIndex = DataGridView.Rows[DataGridView.CurrentRow.Index].Cells[0].Value.ToString();
                Int32.TryParse(currIndex, out id);
            }
            catch
            {
                id = 0;
            }
            return id;

        }

        private void DisplayButton_Click_1(object sender, EventArgs e)
        {
            var data = BizzLayer.ManagerSection.ActivityData();
            DataGridView.DataSource = data;
        }

        private void SelectButton_Click_1(object sender, EventArgs e)
        {
            _ID = GetCurrentId();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void DataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SelectButton.Enabled = true;
        }
    }
}
