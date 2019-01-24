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
	public partial class ActivityManager : Form
	{
		public ActivityManager()
		{
			InitializeComponent();
		}

		private void LoadStatusComboBox(/*object comboName*/)
		{
			using (DataClasses1DataContext connection = new DataClasses1DataContext())
			{
				List<string> list = (from act in connection.Activity
									 select act.status).ToList();

				statusComboBox.DataSource = list;
			}
		}

		private int GetCurrentId() {

			int index = ActivityDataGridView.CurrentRow.Index;
			string currIndex = ActivityDataGridView.Rows[ActivityDataGridView.CurrentRow.Index].Cells[0].Value.ToString();

			int id;
			Int32.TryParse(currIndex, out id);
			return id;
		}

		private void reqSearchButton_Click(object sender, EventArgs e)
		{
			PersReqDisplay disp = new PersReqDisplay();
			disp.setTable = false;
			disp.ShowDialog(this);
		}

		private void perSearchButton_Click(object sender, EventArgs e)
		{
			PersReqDisplay disp = new PersReqDisplay();
			disp.ShowDialog(this);
		}

		private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void ActivityManager_Load(object sender, EventArgs e)
		{
			List<string> statusList = new List<string>();
			statusList.Add("opn");
			statusList.Add("fin");
			statusList.Add("can");
			statusList.Add("pro");

			statusComboBox.DataSource = statusList;
		}

		private void reqTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			perSearchButton.Enabled = true;
			reqSearchButton.Enabled = true;

		}

		private void statusConfirmButton_Click(object sender, EventArgs e)
		{
			int currentId = GetCurrentId();
			string selectedtem = statusComboBox.SelectedItem.ToString();
			string val = BizzLayer.ManagerSection.EditStatus(currentId, selectedtem);
            MessageBox.Show(val);

			var data = BizzLayer.ManagerSection.GetActivityData();
			ActivityDataGridView.DataSource = data;
		}

		private void activityDisplayButton_Click(object sender, EventArgs e)
		{
			var data = BizzLayer.ManagerSection.GetActivityData();
			ActivityDataGridView.DataSource = data;
		}
	}


}
