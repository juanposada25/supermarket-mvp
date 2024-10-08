namespace Supermarket_mvp.Views
{
    partial class CustomerView
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPageCustomerList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCustomer = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCustomerDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtCustomerEmail = new TextBox();
            TxtCustomerPhone = new TextBox();
            TxtCustomerBirthday = new TextBox();
            TxtCustomerAddress = new TextBox();
            TxtCustomerDocument = new TextBox();
            TxtCustomerLast_Name = new TextBox();
            TxtCustomerFirst_Name = new TextBox();
            TxtCustomerId = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomer).BeginInit();
            tabPageCustomerDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 99);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 35);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Customer";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCustomerList);
            tabControl1.Controls.Add(tabPageCustomerDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 99);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(887, 421);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCustomerList
            // 
            tabPageCustomerList.Controls.Add(BtnClose);
            tabPageCustomerList.Controls.Add(BtnDelete);
            tabPageCustomerList.Controls.Add(BtnEdit);
            tabPageCustomerList.Controls.Add(BtnNew);
            tabPageCustomerList.Controls.Add(DgCustomer);
            tabPageCustomerList.Controls.Add(BtnSearch);
            tabPageCustomerList.Controls.Add(TxtSearch);
            tabPageCustomerList.Controls.Add(label2);
            tabPageCustomerList.Location = new Point(4, 29);
            tabPageCustomerList.Name = "tabPageCustomerList";
            tabPageCustomerList.Padding = new Padding(3);
            tabPageCustomerList.Size = new Size(879, 388);
            tabPageCustomerList.TabIndex = 0;
            tabPageCustomerList.Text = "Customer List ";
            tabPageCustomerList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(677, 301);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(182, 49);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(677, 230);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(182, 49);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(677, 164);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(182, 51);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(677, 92);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(182, 56);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgCustomer
            // 
            DgCustomer.AllowUserToAddRows = false;
            DgCustomer.AllowUserToDeleteRows = false;
            DgCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomer.Location = new Point(32, 92);
            DgCustomer.Name = "DgCustomer";
            DgCustomer.ReadOnly = true;
            DgCustomer.RowHeadersWidth = 51;
            DgCustomer.Size = new Size(621, 262);
            DgCustomer.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(581, 33);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(72, 40);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(31, 40);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(544, 27);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 17);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Customer";
            // 
            // tabPageCustomerDetail
            // 
            tabPageCustomerDetail.Controls.Add(BtnCancel);
            tabPageCustomerDetail.Controls.Add(BtnSave);
            tabPageCustomerDetail.Controls.Add(TxtCustomerEmail);
            tabPageCustomerDetail.Controls.Add(TxtCustomerPhone);
            tabPageCustomerDetail.Controls.Add(TxtCustomerBirthday);
            tabPageCustomerDetail.Controls.Add(TxtCustomerAddress);
            tabPageCustomerDetail.Controls.Add(TxtCustomerDocument);
            tabPageCustomerDetail.Controls.Add(TxtCustomerLast_Name);
            tabPageCustomerDetail.Controls.Add(TxtCustomerFirst_Name);
            tabPageCustomerDetail.Controls.Add(TxtCustomerId);
            tabPageCustomerDetail.Controls.Add(label10);
            tabPageCustomerDetail.Controls.Add(label9);
            tabPageCustomerDetail.Controls.Add(label8);
            tabPageCustomerDetail.Controls.Add(label7);
            tabPageCustomerDetail.Controls.Add(label6);
            tabPageCustomerDetail.Controls.Add(label5);
            tabPageCustomerDetail.Controls.Add(label4);
            tabPageCustomerDetail.Controls.Add(label3);
            tabPageCustomerDetail.Location = new Point(4, 29);
            tabPageCustomerDetail.Name = "tabPageCustomerDetail";
            tabPageCustomerDetail.Padding = new Padding(3);
            tabPageCustomerDetail.Size = new Size(879, 388);
            tabPageCustomerDetail.TabIndex = 1;
            tabPageCustomerDetail.Text = "Customer Detail";
            tabPageCustomerDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(261, 276);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(167, 73);
            BtnCancel.TabIndex = 17;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(32, 276);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(167, 73);
            BtnSave.TabIndex = 16;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCustomerEmail
            // 
            TxtCustomerEmail.Location = new Point(471, 195);
            TxtCustomerEmail.Name = "TxtCustomerEmail";
            TxtCustomerEmail.Size = new Size(158, 27);
            TxtCustomerEmail.TabIndex = 15;
            // 
            // TxtCustomerPhone
            // 
            TxtCustomerPhone.Location = new Point(263, 195);
            TxtCustomerPhone.Name = "TxtCustomerPhone";
            TxtCustomerPhone.Size = new Size(165, 27);
            TxtCustomerPhone.TabIndex = 14;
            // 
            // TxtCustomerBirthday
            // 
            TxtCustomerBirthday.Location = new Point(32, 195);
            TxtCustomerBirthday.Name = "TxtCustomerBirthday";
            TxtCustomerBirthday.Size = new Size(167, 27);
            TxtCustomerBirthday.TabIndex = 13;
            // 
            // TxtCustomerAddress
            // 
            TxtCustomerAddress.Location = new Point(685, 111);
            TxtCustomerAddress.Multiline = true;
            TxtCustomerAddress.Name = "TxtCustomerAddress";
            TxtCustomerAddress.Size = new Size(170, 81);
            TxtCustomerAddress.TabIndex = 12;
            // 
            // TxtCustomerDocument
            // 
            TxtCustomerDocument.Location = new Point(471, 111);
            TxtCustomerDocument.Name = "TxtCustomerDocument";
            TxtCustomerDocument.Size = new Size(158, 27);
            TxtCustomerDocument.TabIndex = 11;
            // 
            // TxtCustomerLast_Name
            // 
            TxtCustomerLast_Name.Location = new Point(263, 111);
            TxtCustomerLast_Name.Name = "TxtCustomerLast_Name";
            TxtCustomerLast_Name.Size = new Size(165, 27);
            TxtCustomerLast_Name.TabIndex = 10;
            // 
            // TxtCustomerFirst_Name
            // 
            TxtCustomerFirst_Name.Location = new Point(32, 111);
            TxtCustomerFirst_Name.Name = "TxtCustomerFirst_Name";
            TxtCustomerFirst_Name.Size = new Size(167, 27);
            TxtCustomerFirst_Name.TabIndex = 9;
            // 
            // TxtCustomerId
            // 
            TxtCustomerId.Location = new Point(32, 44);
            TxtCustomerId.Name = "TxtCustomerId";
            TxtCustomerId.ReadOnly = true;
            TxtCustomerId.Size = new Size(125, 27);
            TxtCustomerId.TabIndex = 8;
            TxtCustomerId.Text = "0";
            TxtCustomerId.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(471, 172);
            label10.Name = "label10";
            label10.Size = new Size(113, 20);
            label10.TabIndex = 7;
            label10.Text = "Customer Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(685, 88);
            label9.Name = "label9";
            label9.Size = new Size(129, 20);
            label9.TabIndex = 6;
            label9.Text = "Customer Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(263, 172);
            label8.Name = "label8";
            label8.Size = new Size(117, 20);
            label8.TabIndex = 5;
            label8.Text = "Customer Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(471, 88);
            label7.Name = "label7";
            label7.Size = new Size(145, 20);
            label7.TabIndex = 4;
            label7.Text = "Customer Document";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 172);
            label6.Name = "label6";
            label6.Size = new Size(131, 20);
            label6.TabIndex = 3;
            label6.Text = "Customer Birthday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 88);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 2;
            label5.Text = "Customer First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 88);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 1;
            label4.Text = "Customer Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 21);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 0;
            label3.Text = "Customer Id";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 520);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomerView";
            Text = "Customer Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCustomerList.ResumeLayout(false);
            tabPageCustomerList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomer).EndInit();
            tabPageCustomerDetail.ResumeLayout(false);
            tabPageCustomerDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCustomerList;
        private TabPage tabPageCustomerDetail;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private DataGridView DgCustomer;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtCustomerPhone;
        private TextBox TxtCustomerBirthday;
        private TextBox TxtCustomerAddress;
        private TextBox TxtCustomerDocument;
        private TextBox TxtCustomerLast_Name;
        private TextBox TxtCustomerFirst_Name;
        private TextBox TxtCustomerId;
        private TextBox TxtCustomerEmail;
        private Button BtnCancel;
        private Button BtnSave;
    }
}