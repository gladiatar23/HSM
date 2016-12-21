namespace HSM
{
    partial class UserInfo
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
            this.components = new System.ComponentModel.Container();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mtSave = new MetroFramework.Controls.MetroTile();
            this.mtNew = new MetroFramework.Controls.MetroTile();
            this.mtCam = new MetroFramework.Controls.MetroTile();
            this.mtEdit = new MetroFramework.Controls.MetroTile();
            this.mtbrowse = new MetroFramework.Controls.MetroTile();
            this.mtDelete = new MetroFramework.Controls.MetroTile();
            this.mtCancel = new MetroFramework.Controls.MetroTile();
            this.pictureBoxUserInfo = new System.Windows.Forms.PictureBox();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hSMDataSet = new HSM.HSMDataSet();
            this.txtIdNum = new MetroFramework.Controls.MetroTextBox();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.txtClassific = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtPhoneNum = new MetroFramework.Controls.MetroTextBox();
            this.txtFunction = new MetroFramework.Controls.MetroTextBox();
            this.txtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsersTableAdapter = new HSM.HSMDataSetTableAdapters.tblUsersTableAdapter();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hSMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoSize = true;
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.mtSave);
            this.metroPanel1.Controls.Add(this.mtNew);
            this.metroPanel1.Controls.Add(this.mtCam);
            this.metroPanel1.Controls.Add(this.mtEdit);
            this.metroPanel1.Controls.Add(this.mtbrowse);
            this.metroPanel1.Controls.Add(this.mtDelete);
            this.metroPanel1.Controls.Add(this.mtCancel);
            this.metroPanel1.Controls.Add(this.pictureBoxUserInfo);
            this.metroPanel1.Controls.Add(this.txtIdNum);
            this.metroPanel1.Controls.Add(this.txtLastName);
            this.metroPanel1.Controls.Add(this.txtPass);
            this.metroPanel1.Controls.Add(this.txtUser);
            this.metroPanel1.Controls.Add(this.txtClassific);
            this.metroPanel1.Controls.Add(this.txtEmail);
            this.metroPanel1.Controls.Add(this.txtPhoneNum);
            this.metroPanel1.Controls.Add(this.txtFunction);
            this.metroPanel1.Controls.Add(this.txtFirstName);
            this.metroPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(16, 64);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(587, 417);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // mtSave
            // 
            this.mtSave.Location = new System.Drawing.Point(236, 371);
            this.mtSave.Name = "mtSave";
            this.mtSave.Size = new System.Drawing.Size(106, 33);
            this.mtSave.TabIndex = 5;
            this.mtSave.Text = "Save";
            this.mtSave.Click += new System.EventHandler(this.mtSave_Click);
            // 
            // mtNew
            // 
            this.mtNew.Location = new System.Drawing.Point(12, 371);
            this.mtNew.Name = "mtNew";
            this.mtNew.Size = new System.Drawing.Size(106, 33);
            this.mtNew.TabIndex = 5;
            this.mtNew.Text = "New";
            this.mtNew.Click += new System.EventHandler(this.mtNew_Click);
            // 
            // mtCam
            // 
            this.mtCam.Location = new System.Drawing.Point(395, 215);
            this.mtCam.Name = "mtCam";
            this.mtCam.Size = new System.Drawing.Size(35, 25);
            this.mtCam.TabIndex = 6;
            this.mtCam.Click += new System.EventHandler(this.metroTile1_Click_1);
            // 
            // mtEdit
            // 
            this.mtEdit.Location = new System.Drawing.Point(124, 371);
            this.mtEdit.Name = "mtEdit";
            this.mtEdit.Size = new System.Drawing.Size(106, 33);
            this.mtEdit.TabIndex = 5;
            this.mtEdit.Text = "Edit";
            this.mtEdit.Click += new System.EventHandler(this.mtEdit_Click);
            // 
            // mtbrowse
            // 
            this.mtbrowse.Location = new System.Drawing.Point(354, 215);
            this.mtbrowse.Name = "mtbrowse";
            this.mtbrowse.Size = new System.Drawing.Size(35, 25);
            this.mtbrowse.TabIndex = 6;
            this.mtbrowse.Click += new System.EventHandler(this.metroTile1_Click_1);
            // 
            // mtDelete
            // 
            this.mtDelete.Location = new System.Drawing.Point(460, 371);
            this.mtDelete.Name = "mtDelete";
            this.mtDelete.Size = new System.Drawing.Size(106, 33);
            this.mtDelete.TabIndex = 5;
            this.mtDelete.Text = "Delete";
            this.mtDelete.Click += new System.EventHandler(this.mtDelete_Click);
            // 
            // mtCancel
            // 
            this.mtCancel.Location = new System.Drawing.Point(348, 371);
            this.mtCancel.Name = "mtCancel";
            this.mtCancel.Size = new System.Drawing.Size(106, 33);
            this.mtCancel.TabIndex = 5;
            this.mtCancel.Text = "Cancel";
            this.mtCancel.Click += new System.EventHandler(this.mtCancel_Click);
            // 
            // pictureBoxUserInfo
            // 
            this.pictureBoxUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxUserInfo.Location = new System.Drawing.Point(331, 15);
            this.pictureBoxUserInfo.Name = "pictureBoxUserInfo";
            this.pictureBoxUserInfo.Size = new System.Drawing.Size(244, 233);
            this.pictureBoxUserInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserInfo.TabIndex = 4;
            this.pictureBoxUserInfo.TabStop = false;
            this.pictureBoxUserInfo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.hSMDataSet;
            this.tblUsersBindingSource.CurrentChanged += new System.EventHandler(this.tblUsersBindingSource_CurrentChanged);
            // 
            // hSMDataSet
            // 
            this.hSMDataSet.DataSetName = "HSMDataSet";
            this.hSMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdNum
            // 
            this.txtIdNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdNum.BackColor = System.Drawing.Color.White;
            this.txtIdNum.CustomForeColor = true;
            this.txtIdNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "ID_num", true));
            this.txtIdNum.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtIdNum.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtIdNum.ForeColor = System.Drawing.Color.Navy;
            this.txtIdNum.Location = new System.Drawing.Point(156, 115);
            this.txtIdNum.Name = "txtIdNum";
            this.txtIdNum.Size = new System.Drawing.Size(143, 35);
            this.txtIdNum.TabIndex = 3;
            this.txtIdNum.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.CustomForeColor = true;
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "last_name", true));
            this.txtLastName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLastName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtLastName.ForeColor = System.Drawing.Color.Navy;
            this.txtLastName.Location = new System.Drawing.Point(156, 65);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(143, 35);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.CustomForeColor = true;
            this.txtPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "password", true));
            this.txtPass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPass.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtPass.ForeColor = System.Drawing.Color.Red;
            this.txtPass.Location = new System.Drawing.Point(432, 315);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(143, 35);
            this.txtPass.TabIndex = 3;
            this.txtPass.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.CustomForeColor = true;
            this.txtUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "user", true));
            this.txtUser.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUser.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtUser.ForeColor = System.Drawing.Color.Navy;
            this.txtUser.Location = new System.Drawing.Point(432, 265);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(143, 35);
            this.txtUser.TabIndex = 3;
            this.txtUser.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txtClassific
            // 
            this.txtClassific.AllowDrop = true;
            this.txtClassific.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtClassific.BackColor = System.Drawing.Color.White;
            this.txtClassific.CustomForeColor = true;
            this.txtClassific.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "classification", true));
            this.txtClassific.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtClassific.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtClassific.ForeColor = System.Drawing.Color.Navy;
            this.txtClassific.Location = new System.Drawing.Point(156, 215);
            this.txtClassific.Name = "txtClassific";
            this.txtClassific.Size = new System.Drawing.Size(143, 35);
            this.txtClassific.TabIndex = 3;
            this.txtClassific.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.CustomForeColor = true;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "Email", true));
            this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmail.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtEmail.ForeColor = System.Drawing.Color.Navy;
            this.txtEmail.Location = new System.Drawing.Point(87, 315);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(209, 35);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPhoneNum.BackColor = System.Drawing.Color.White;
            this.txtPhoneNum.CustomForeColor = true;
            this.txtPhoneNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "Phone", true));
            this.txtPhoneNum.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPhoneNum.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtPhoneNum.ForeColor = System.Drawing.Color.Navy;
            this.txtPhoneNum.Location = new System.Drawing.Point(156, 265);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(143, 35);
            this.txtPhoneNum.TabIndex = 3;
            this.txtPhoneNum.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txtFunction
            // 
            this.txtFunction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFunction.BackColor = System.Drawing.Color.White;
            this.txtFunction.CustomForeColor = true;
            this.txtFunction.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "function", true));
            this.txtFunction.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFunction.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtFunction.ForeColor = System.Drawing.Color.Navy;
            this.txtFunction.Location = new System.Drawing.Point(156, 165);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(143, 35);
            this.txtFunction.TabIndex = 3;
            this.txtFunction.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.CustomForeColor = true;
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "first_name", true));
            this.txtFirstName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFirstName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtFirstName.ForeColor = System.Drawing.Color.Navy;
            this.txtFirstName.Location = new System.Drawing.Point(156, 15);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(143, 32);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.tblUsersBindingSource;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 497);
            this.Controls.Add(this.metroPanel1);
            this.Name = "UserInfo";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "UserInfo";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.UserInfo_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hSMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtIdNum;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private MetroFramework.Controls.MetroTextBox txtFunction;
        private System.Windows.Forms.PictureBox pictureBoxUserInfo;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtPhoneNum;
        private MetroFramework.Controls.MetroTextBox txtClassific;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroTextBox txtFirstName;
        private System.Windows.Forms.BindingSource bindingSource1;
        private HSMDataSet hSMDataSet;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private HSMDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private MetroFramework.Controls.MetroTile mtbrowse;
        private MetroFramework.Controls.MetroTile mtCam;
        private MetroFramework.Controls.MetroTile mtSave;
        private MetroFramework.Controls.MetroTile mtNew;
        private MetroFramework.Controls.MetroTile mtEdit;
        private MetroFramework.Controls.MetroTile mtDelete;
        private MetroFramework.Controls.MetroTile mtCancel;
    }
}