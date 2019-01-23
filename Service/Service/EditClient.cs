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
    public partial class EditClient : Form
    {
        
        public EditClient(string id)
        {
            InitializeComponent();

            using (DataClasses1DataContext ctx = new DataClasses1DataContext())
            {
                int convert = Int32.Parse(id);
                Client a = ctx.Client.SingleOrDefault(x => x.id_cli == convert);

                edit.Text = id;
                name.Text = a.name;
                fname.Text = a.fname;
                lname.Text = a.lname;
                tel.Text = a.tel;
                street.Text = a.street_name;
                postcode.Text = a.post_code;
                number.Text = a.number;
            };
        }

    private void Button2_Click(object sender, EventArgs e)
        {
            ManagerSection.Edit_Client(name.Text, fname.Text, lname.Text, tel.Text, street.Text, postcode.Text, number.Text, edit.Text);
            this.Close();
            
        }

    }
}
