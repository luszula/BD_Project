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
    public partial class ManagerObject : Form
    {
        public ManagerObject()
        {
            InitializeComponent();
		}

		private void LoadObjComboBox(bool choice) {

			List<string> list = BizzLayer.ManagerSection.GetDataToCombo();

			if (choice == true)
			{
					nameTypeComboBox.DataSource = list;
			}
			else {
					eNameTypeComboBox.DataSource = list;
			}
		}

		private int GetCurrentId()
		{
			int index = objDataGridView.CurrentRow.Index;
			string currIndex = objDataGridView.Rows[objDataGridView.CurrentRow.Index].Cells[0].Value.ToString();

			int id;
			Int32.TryParse(currIndex, out id);
			return id;
		}


		private void objDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			editButton.Enabled = true;
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			bool choice = true;
			LoadObjComboBox(choice);

			newObjGroupBox.Visible = true;
			editObjGroupBox.Visible = false;
		}

		private void confirmButton_Click(object sender, EventArgs e)
		{
			string nameNew = nameTextBox.Text;
			string name_typeNew = nameTypeComboBox.SelectedItem.ToString();
			int clientIdNew = 0;
			Int32.TryParse(clientIdTextBox.Text,out clientIdNew);


			if (nameNew == "" || name_typeNew == "" || clientIdNew == 0)
			{
				MessageBox.Show("Please, fill the fields!");
			}
			else {

				string val = BizzLayer.ManagerSection.AddNewObject(nameNew, name_typeNew, clientIdNew);
                MessageBox.Show(val);
			}
			var data = BizzLayer.ManagerSection.GetObjData();
			objDataGridView.DataSource = data;
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			newObjGroupBox.Visible = false;
			nameTextBox.Clear();
			clientIdTextBox.Clear();
		}

		private void editButton_Click(object sender, EventArgs e)
		{
			bool choice = false;
			LoadObjComboBox(choice);

			eNameTextBox.Clear();
			eClientIdTextBox.Clear();

			int currentId = GetCurrentId();

			List<string> dataList = BizzLayer.ManagerSection.SetBoxes(currentId);
			eNameTextBox.Text += dataList[0]; 
			eNameTypeComboBox.SelectedItem += dataList[1];
			eClientIdTextBox.Text += dataList[2];

			newObjGroupBox.Visible = false;
			editObjGroupBox.Visible = true;
		}

		private void editConfirmButton_Click(object sender, EventArgs e)
		{
			int currentId = GetCurrentId();
			string selected = eNameTypeComboBox.SelectedItem.ToString();
			string name = eNameTextBox.Text;
			string clientId = eClientIdTextBox.Text;
			BizzLayer.ManagerSection.EditObject(currentId, selected,name,clientId);

			var data = BizzLayer.ManagerSection.GetObjData();
			objDataGridView.DataSource = data;
		}

		private void editCancelButton_Click(object sender, EventArgs e)
		{
			editObjGroupBox.Visible = false;
			eNameTextBox.Clear();
			eClientIdTextBox.Clear();
		}


		private void objSearchButton_Click(object sender, EventArgs e)
		{
			string id = dObjIdTextBox.Text;
			string name = dObjNameTextBox.Text;
			string type = dTypeNameTextBox.Text;
			string client = dClientIdTextBox.Text;

			if (id == "" && name == "" && type == "" && client == "")
			{
				var data = BizzLayer.ManagerSection.GetObjData();
				objDataGridView.DataSource = data;
			}
			else
			{
				var data = BizzLayer.ManagerSection.searchingOptions(id, name, type, client);
				objDataGridView.DataSource = data;
			}
		}

		private void clientSelectButton_Click(object sender, EventArgs e)
		{
			int id = 0;
			ClientSelect clientDialog = new ClientSelect();
			if (clientDialog.ShowDialog(this) == DialogResult.OK)
			{
				id = clientDialog._ID;
			}
			clientIdTextBox.Text = id.ToString();
		}

		private void clientSelectButton2_Click(object sender, EventArgs e)
		{
			int id = 0;
			ClientSelect clientDialog = new ClientSelect();
			if (clientDialog.ShowDialog(this) == DialogResult.OK)
			{
				id = clientDialog._ID;
			}
			eClientIdTextBox.Text = id.ToString();
		}

	}

}
