namespace HSM
{
    partial class Login_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txt_Pass = new MetroFramework.Controls.MetroTextBox();
            this.txt_User = new MetroFramework.Controls.MetroTextBox();
            this.lbl_Password = new MetroFramework.Controls.MetroLabel();
            this.Tile_Login_Click = new MetroFramework.Controls.MetroTile();
            this.lbl_User_Name = new MetroFramework.Controls.MetroLabel();
            this.testConn = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.txt_Pass);
            this.metroPanel1.Controls.Add(this.txt_User);
            this.metroPanel1.Controls.Add(this.lbl_Password);
            this.metroPanel1.Controls.Add(this.Tile_Login_Click);
            this.metroPanel1.Controls.Add(this.lbl_User_Name);
            this.metroPanel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(13, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(568, 257);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            //this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // txt_Pass
            // 
            this.txt_Pass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_Pass.Location = new System.Drawing.Point(375, 131);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(174, 28);
            this.txt_Pass.TabIndex = 9;
            this.txt_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_User
            // 
            this.txt_User.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_User.Location = new System.Drawing.Point(375, 87);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(174, 28);
            this.txt_User.TabIndex = 8;
            this.txt_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_Password.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_Password.Location = new System.Drawing.Point(250, 134);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(97, 25);
            this.lbl_Password.TabIndex = 7;
            this.lbl_Password.Text = "Password:";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Password.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // Tile_Login_Click
            // 
            this.Tile_Login_Click.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tile_Login_Click.Location = new System.Drawing.Point(375, 179);
            this.Tile_Login_Click.Name = "Tile_Login_Click";
            this.Tile_Login_Click.Size = new System.Drawing.Size(174, 49);
            this.Tile_Login_Click.TabIndex = 6;
            this.Tile_Login_Click.Text = "LogIn";
            this.Tile_Login_Click.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tile_Login_Click.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Tile_Login_Click.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Tile_Login_Click.UseTileImage = true;
            this.Tile_Login_Click.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // lbl_User_Name
            // 
            this.lbl_User_Name.AutoSize = true;
            this.lbl_User_Name.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_User_Name.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_User_Name.Location = new System.Drawing.Point(250, 90);
            this.lbl_User_Name.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_User_Name.Name = "lbl_User_Name";
            this.lbl_User_Name.Size = new System.Drawing.Size(115, 25);
            this.lbl_User_Name.Style = MetroFramework.MetroColorStyle.Black;
            this.lbl_User_Name.TabIndex = 2;
            this.lbl_User_Name.Text = "User Name :";
            // 
            // testConn
            // 
            this.testConn.AutoSize = true;
            this.testConn.Location = new System.Drawing.Point(420, 313);
            this.testConn.Name = "testConn";
            this.testConn.Size = new System.Drawing.Size(0, 0);
            this.testConn.TabIndex = 1;
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(594, 343);
            this.Controls.Add(this.testConn);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Login_Page";
            this.Opacity = 0.98D;
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "Form1";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lbl_Password;
        private MetroFramework.Controls.MetroTile Tile_Login_Click;
        private MetroFramework.Controls.MetroLabel lbl_User_Name;
        private MetroFramework.Controls.MetroTextBox txt_Pass;
        private MetroFramework.Controls.MetroTextBox txt_User;
        private MetroFramework.Controls.MetroLabel testConn;
    }
}

