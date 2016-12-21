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
    public partial class UserInfo : MetroFramework.Forms.MetroForm
    {
        public UserInfo()
        {
            InitializeComponent();
        }
       // public UserAdministration UserInfo { get { return bindingSourceUserInfo.Current as UserAdministration; } }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hSMDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.hSMDataSet.tblUsers);
            tblUsersBindingSource.DataSource = this.hSMDataSet.tblUsers;
            

        }

       
        

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
        
        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void mtSave_Click(object sender, EventArgs e)
        {
            try
            {
                tblUsersBindingSource.EndEdit();
                tblUsersTableAdapter.Update(this.hSMDataSet.tblUsers);
            }
            catch (Exception ns)
            {
                MessageBox.Show(ns.Message,"Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tblUsersBindingSource.ResetBindings(false);
            }
        }

        private void mtEdit_Click(object sender, EventArgs e)
        {
            txtFirstName.Focus();
        }

        private void mtCancel_Click(object sender, EventArgs e)
        {
            tblUsersBindingSource.ResetBindings(false);
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBoxUserInfo.Image = Image.FromFile(ofd.FileName);
            }catch(Exception nb)
            {
                MessageBox.Show(nb.Message, "can't browse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    

        private void mtNew_Click(object sender, EventArgs e)
        {
            txtFirstName.Focus();
            this.hSMDataSet.tblUsers.AddtblUsersRow(this.hSMDataSet.tblUsers.NewtblUsersRow());
            tblUsersBindingSource.MoveLast();
        }

        private void mtDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete???", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                tblUsersBindingSource.RemoveCurrent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tblUsersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
