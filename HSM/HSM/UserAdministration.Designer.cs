using System;
using System.Windows.Forms;

namespace HSM
{
    partial class UserAdministration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtCancel = new MetroFramework.Controls.MetroTile();
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.mtEdit = new MetroFramework.Controls.MetroTile();
            this.mtDelete = new MetroFramework.Controls.MetroTile();
            this.mtSave = new MetroFramework.Controls.MetroTile();
            this.EditPanel = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hSMDataSet = new HSM.HSMDataSet();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtEmail = new MetroFramework.Controls.MetroTextBox();
            this.mtPhone = new MetroFramework.Controls.MetroTextBox();
            this.mtID = new MetroFramework.Controls.MetroTextBox();
            this.mtLast = new MetroFramework.Controls.MetroTextBox();
            this.mtPass = new MetroFramework.Controls.MetroTextBox();
            this.mtUser = new MetroFramework.Controls.MetroTextBox();
            this.mtClass = new MetroFramework.Controls.MetroTextBox();
            this.mtFunc = new MetroFramework.Controls.MetroTextBox();
            this.mtFirst = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dataGridViewUserAdmin = new System.Windows.Forms.DataGridView();
            this.tblUsersTableAdapter = new HSM.HSMDataSetTableAdapters.tblUsersTableAdapter();
            this.EditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hSMDataSet)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // mtCancel
            // 
            this.mtCancel.Location = new System.Drawing.Point(615, 10);
            this.mtCancel.Name = "mtCancel";
            this.mtCancel.Size = new System.Drawing.Size(105, 56);
            this.mtCancel.TabIndex = 2;
            this.mtCancel.Text = "Cancel";
            // 
            // mtAdd
            // 
            this.mtAdd.AutoSize = true;
            this.mtAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtAdd.Location = new System.Drawing.Point(138, 10);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(105, 56);
            this.mtAdd.TabIndex = 2;
            this.mtAdd.Text = "Add";
            this.mtAdd.TileImage = global::HSM.Properties.Resources._1231;
            this.mtAdd.UseTileImage = true;
            this.mtAdd.Click += new System.EventHandler(this.mtAdd_Click);
            // 
            // mtEdit
            // 
            this.mtEdit.Location = new System.Drawing.Point(259, 10);
            this.mtEdit.Name = "mtEdit";
            this.mtEdit.Size = new System.Drawing.Size(105, 56);
            this.mtEdit.TabIndex = 2;
            this.mtEdit.Text = "Edit";
            this.mtEdit.Click += new System.EventHandler(this.mtEdit_Click);
            // 
            // mtDelete
            // 
            this.mtDelete.Location = new System.Drawing.Point(380, 10);
            this.mtDelete.Name = "mtDelete";
            this.mtDelete.Size = new System.Drawing.Size(105, 56);
            this.mtDelete.TabIndex = 2;
            this.mtDelete.Text = "Delete";
            this.mtDelete.Click += new System.EventHandler(this.mtDelete_Click);
            // 
            // mtSave
            // 
            this.mtSave.Location = new System.Drawing.Point(501, 10);
            this.mtSave.Name = "mtSave";
            this.mtSave.Size = new System.Drawing.Size(105, 56);
            this.mtSave.TabIndex = 2;
            this.mtSave.Text = "Save";
            this.mtSave.Click += new System.EventHandler(this.mtSave_Click);
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.pictureBox1);
            this.EditPanel.Controls.Add(this.metroLabel10);
            this.EditPanel.Controls.Add(this.metroLabel7);
            this.EditPanel.Controls.Add(this.metroLabel9);
            this.EditPanel.Controls.Add(this.metroLabel3);
            this.EditPanel.Controls.Add(this.mtEmail);
            this.EditPanel.Controls.Add(this.mtPhone);
            this.EditPanel.Controls.Add(this.mtID);
            this.EditPanel.Controls.Add(this.mtLast);
            this.EditPanel.Controls.Add(this.mtPass);
            this.EditPanel.Controls.Add(this.mtUser);
            this.EditPanel.Controls.Add(this.mtClass);
            this.EditPanel.Controls.Add(this.mtFunc);
            this.EditPanel.Controls.Add(this.mtFirst);
            this.EditPanel.Controls.Add(this.metroLabel6);
            this.EditPanel.Controls.Add(this.metroLabel5);
            this.EditPanel.Controls.Add(this.metroLabel4);
            this.EditPanel.Controls.Add(this.metroLabel2);
            this.EditPanel.Controls.Add(this.metroLabel1);
            this.EditPanel.HorizontalScrollbarBarColor = true;
            this.EditPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.EditPanel.HorizontalScrollbarSize = 10;
            this.EditPanel.Location = new System.Drawing.Point(0, 82);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(1244, 164);
            this.EditPanel.TabIndex = 4;
            this.EditPanel.VerticalScrollbarBarColor = true;
            this.EditPanel.VerticalScrollbarHighlightOnWheel = false;
            this.EditPanel.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tblUsersBindingSource, "foto", true));
            this.pictureBox1.Location = new System.Drawing.Point(615, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 141);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.hSMDataSet;
            // 
            // hSMDataSet
            // 
            this.hSMDataSet.DataSetName = "HSMDataSet";
            this.hSMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(308, 96);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(102, 25);
            this.metroLabel10.TabIndex = 11;
            this.metroLabel10.Text = "Password :";
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(308, 66);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(115, 25);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "User Name :";
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(308, 36);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(134, 25);
            this.metroLabel9.TabIndex = 9;
            this.metroLabel9.Text = "Classification :";
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(308, 6);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 25);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Function :";
            this.metroLabel3.UseStyleColors = true;
            // 
            // mtEmail
            // 
            this.mtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "Email", true));
            this.mtEmail.Location = new System.Drawing.Point(137, 130);
            this.mtEmail.Name = "mtEmail";
            this.mtEmail.Size = new System.Drawing.Size(469, 23);
            this.mtEmail.TabIndex = 8;
            // 
            // mtPhone
            // 
            this.mtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "Phone", true));
            this.mtPhone.Location = new System.Drawing.Point(137, 100);
            this.mtPhone.Name = "mtPhone";
            this.mtPhone.Size = new System.Drawing.Size(148, 23);
            this.mtPhone.TabIndex = 8;
            // 
            // mtID
            // 
            this.mtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "ID_num", true));
            this.mtID.Location = new System.Drawing.Point(137, 70);
            this.mtID.Name = "mtID";
            this.mtID.Size = new System.Drawing.Size(148, 23);
            this.mtID.TabIndex = 8;
            // 
            // mtLast
            // 
            this.mtLast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "last_name", true));
            this.mtLast.Location = new System.Drawing.Point(137, 40);
            this.mtLast.Name = "mtLast";
            this.mtLast.Size = new System.Drawing.Size(148, 23);
            this.mtLast.TabIndex = 8;
            // 
            // mtPass
            // 
            this.mtPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "password", true));
            this.mtPass.Location = new System.Drawing.Point(458, 98);
            this.mtPass.Name = "mtPass";
            this.mtPass.Size = new System.Drawing.Size(148, 23);
            this.mtPass.TabIndex = 8;
            // 
            // mtUser
            // 
            this.mtUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "user", true));
            this.mtUser.Location = new System.Drawing.Point(458, 69);
            this.mtUser.Name = "mtUser";
            this.mtUser.Size = new System.Drawing.Size(148, 23);
            this.mtUser.TabIndex = 8;
            // 
            // mtClass
            // 
            this.mtClass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "classification", true));
            this.mtClass.Location = new System.Drawing.Point(458, 40);
            this.mtClass.Name = "mtClass";
            this.mtClass.Size = new System.Drawing.Size(148, 23);
            this.mtClass.TabIndex = 8;
            // 
            // mtFunc
            // 
            this.mtFunc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "function", true));
            this.mtFunc.Location = new System.Drawing.Point(458, 11);
            this.mtFunc.Name = "mtFunc";
            this.mtFunc.Size = new System.Drawing.Size(148, 23);
            this.mtFunc.TabIndex = 8;
            // 
            // mtFirst
            // 
            this.mtFirst.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "first_name", true));
            this.mtFirst.Location = new System.Drawing.Point(137, 10);
            this.mtFirst.Name = "mtFirst";
            this.mtFirst.Size = new System.Drawing.Size(148, 23);
            this.mtFirst.TabIndex = 8;
            this.mtFirst.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(18, 126);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 25);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "E-mail :";
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(18, 96);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(122, 25);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Phone Num :";
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(18, 66);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(115, 25);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "ID Number :";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(18, 36);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Last Name :";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(18, 6);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "First Name :";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.dataGridViewUserAdmin);
            this.metroPanel1.Controls.Add(this.EditPanel);
            this.metroPanel1.Controls.Add(this.mtSave);
            this.metroPanel1.Controls.Add(this.mtDelete);
            this.metroPanel1.Controls.Add(this.mtEdit);
            this.metroPanel1.Controls.Add(this.mtAdd);
            this.metroPanel1.Controls.Add(this.mtCancel);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1244, 484);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint_1);
            // 
            // dataGridViewUserAdmin
            // 
            this.dataGridViewUserAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUserAdmin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUserAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUserAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUserAdmin.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUserAdmin.Location = new System.Drawing.Point(0, 252);
            this.dataGridViewUserAdmin.Name = "dataGridViewUserAdmin";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUserAdmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewUserAdmin.Size = new System.Drawing.Size(1241, 229);
            this.dataGridViewUserAdmin.TabIndex = 5;
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // UserAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 557);
            this.Controls.Add(this.metroPanel1);
            this.Name = "UserAdministration";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Text = "UserAdministration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserAdministration_Load);
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hSMDataSet)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        private void mtDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void metroPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void mtAdd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void mtSave_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void mtEdit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MetroFramework.Controls.MetroTile mtCancel;
        private MetroFramework.Controls.MetroTile mtAdd;
        private MetroFramework.Controls.MetroTile mtEdit;
        private MetroFramework.Controls.MetroTile mtDelete;
        private MetroFramework.Controls.MetroTile mtSave;
        private MetroFramework.Controls.MetroPanel EditPanel;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView dataGridViewUserAdmin;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox mtEmail;
        private MetroFramework.Controls.MetroTextBox mtPhone;
        private MetroFramework.Controls.MetroTextBox mtID;
        private MetroFramework.Controls.MetroTextBox mtLast;
        private MetroFramework.Controls.MetroTextBox mtFirst;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox mtPass;
        private MetroFramework.Controls.MetroTextBox mtUser;
        private MetroFramework.Controls.MetroTextBox mtClass;
        private MetroFramework.Controls.MetroTextBox mtFunc;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private HSMDataSet hSMDataSet;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private HSMDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
    }
}