using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSM
{
    public partial class UserAdministration : MetroFramework.Forms.MetroForm
    {
        public UserAdministration()
        {
            InitializeComponent();
        }

        private void UserAdministration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hSMDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.hSMDataSet.tblUsers);
            tblUsersBindingSource.DataSource = this.hSMDataSet.tblUsers;


        }

       

     
    }
}
