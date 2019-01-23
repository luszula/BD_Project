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
	public partial class PersReqDisplay : Form
	{
		public PersReqDisplay()
		{
			InitializeComponent();
		}

		public bool setTable = true;


		private void displayButton_Click(object sender, EventArgs e)
		{
			if (setTable)
			{
				var data = BizzLayer.ManagerSection.GetPersonelData();
				PersReqDataGridView.DataSource = data;
			}
			else
			{
				var data = BizzLayer.ManagerSection.GetRequestData();
				PersReqDataGridView.DataSource = data;
			}
		}
	}
}
