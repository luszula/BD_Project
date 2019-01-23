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
	public partial class ClientSelect : Form
	{
		public int _ID = 0;
		public ClientSelect()
		{
			InitializeComponent();
		}

		private int GetCurrentId()
		{
			int id;
			try
			{
				int index = clientDataGridView.CurrentRow.Index;
				string currIndex = clientDataGridView.Rows[clientDataGridView.CurrentRow.Index].Cells[0].Value.ToString();
				Int32.TryParse(currIndex, out id);
			}
			catch (Exception ex)
			{
				id = 0;
			}
			return id;

		}

		private void clientDisplayButton_Click(object sender, EventArgs e)
		{
			var data = BizzLayer.ManagerSection.GetClientData();
			clientDataGridView.DataSource = data;
		}

		private void clientSelectButton_Click(object sender, EventArgs e)
		{
			_ID = GetCurrentId();
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void clientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			clientSelectButton.Enabled = true;
		}
	}
}
