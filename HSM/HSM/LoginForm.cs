using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;
using MetroFramework.Fonts;
using System.Data.OleDb;
namespace HSM
{
    public partial class Login_Page : MetroFramework.Forms.MetroForm
    {
        
       
        public Login_Page()
        {
            InitializeComponent();
          
                
                
          
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           OleDbConnection connection = new OleDbConnection();
        connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Desktop\HSM.accdb";
            try
            {
                connection.Open();
                testConn.Text = "Connected";
                connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
           
        }
 
        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Desktop\HSM.accdb";
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = " select* from tblUsers where user='" + txt_User.Text + "' and  password='" + txt_Pass.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count == 1)
            {
                MessageBox.Show("Wellcom");
                this.Hide();
                AdminMenu AdminMenuClick = new AdminMenu();
                AdminMenuClick.ShowDialog();
                
                
            }
            else if (count > 1)
            {
                MessageBox.Show("Duplicate Username and password...Access denied");
            }
            else
            {
                MessageBox.Show("Access denied");
            }
            connection.Close();
        
        }

        
    }
}
