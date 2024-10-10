namespace Supermarket_mvp.Views
{
    partial class ProductView
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
            tabPageProductList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProduct = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageProductDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            CxtProductCategorie_Id = new ComboBox();
            TxtProductPrice = new TextBox();
            TxtProductStock = new TextBox();
            TxtProductName = new TextBox();
            TxtProductId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            tabPageProductDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 110);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 35);
            label1.Name = "label1";
            label1.Size = new Size(155, 35);
            label1.TabIndex = 1;
            label1.Text = "Product";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductList);
            tabControl1.Controls.Add(tabPageProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 110);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(860, 416);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProductList
            // 
            tabPageProductList.Controls.Add(BtnClose);
            tabPageProductList.Controls.Add(BtnDelete);
            tabPageProductList.Controls.Add(BtnEdit);
            tabPageProductList.Controls.Add(BtnNew);
            tabPageProductList.Controls.Add(DgProduct);
            tabPageProductList.Controls.Add(BtnSearch);
            tabPageProductList.Controls.Add(TxtSearch);
            tabPageProductList.Controls.Add(label2);
            tabPageProductList.Location = new Point(4, 29);
            tabPageProductList.Name = "tabPageProductList";
            tabPageProductList.Padding = new Padding(3);
            tabPageProductList.Size = new Size(852, 383);
            tabPageProductList.TabIndex = 0;
            tabPageProductList.Text = "Product List";
            tabPageProductList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(637, 314);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(179, 52);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(637, 245);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(179, 52);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(637, 171);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(179, 52);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(637, 100);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(179, 52);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            DgProduct.AllowUserToAddRows = false;
            DgProduct.AllowUserToDeleteRows = false;
            DgProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(37, 100);
            DgProduct.Name = "DgProduct";
            DgProduct.ReadOnly = true;
            DgProduct.RowHeadersWidth = 51;
            DgProduct.Size = new Size(555, 266);
            DgProduct.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(533, 36);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(59, 41);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(37, 50);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(471, 27);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 18);
            label2.Name = "label2";
            label2.Size = new Size(228, 29);
            label2.TabIndex = 0;
            label2.Text = "Search Product";
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(BtnCancel);
            tabPageProductDetail.Controls.Add(BtnSave);
            tabPageProductDetail.Controls.Add(CxtProductCategorie_Id);
            tabPageProductDetail.Controls.Add(TxtProductPrice);
            tabPageProductDetail.Controls.Add(TxtProductStock);
            tabPageProductDetail.Controls.Add(TxtProductName);
            tabPageProductDetail.Controls.Add(TxtProductId);
            tabPageProductDetail.Controls.Add(label7);
            tabPageProductDetail.Controls.Add(label6);
            tabPageProductDetail.Controls.Add(label5);
            tabPageProductDetail.Controls.Add(label4);
            tabPageProductDetail.Controls.Add(label3);
            tabPageProductDetail.Location = new Point(4, 29);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(3);
            tabPageProductDetail.Size = new Size(852, 383);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Product Detail";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(249, 273);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(130, 69);
            BtnCancel.TabIndex = 11;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(53, 273);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(130, 69);
            BtnSave.TabIndex = 10;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // CxtProductCategorie_Id
            // 
            CxtProductCategorie_Id.FormattingEnabled = true;
            CxtProductCategorie_Id.Location = new Point(249, 196);
            CxtProductCategorie_Id.Name = "CxtProductCategorie_Id";
            CxtProductCategorie_Id.Size = new Size(143, 28);
            CxtProductCategorie_Id.TabIndex = 9;
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Location = new Point(43, 196);
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.Size = new Size(125, 27);
            TxtProductPrice.TabIndex = 8;
            // 
            // TxtProductStock
            // 
            TxtProductStock.Location = new Point(249, 130);
            TxtProductStock.Name = "TxtProductStock";
            TxtProductStock.Size = new Size(148, 27);
            TxtProductStock.TabIndex = 7;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(43, 130);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(125, 27);
            TxtProductName.TabIndex = 6;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(43, 56);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.ReadOnly = true;
            TxtProductId.Size = new Size(104, 27);
            TxtProductId.TabIndex = 5;
            TxtProductId.Text = "0";
            TxtProductId.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 173);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 4;
            label7.Text = "Product Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(249, 173);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 3;
            label6.Text = "Product Categorie_Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 97);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 2;
            label5.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 97);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 1;
            label4.Text = "Product Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 33);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 0;
            label3.Text = "Product Id";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 526);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "Product Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductList.ResumeLayout(false);
            tabPageProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageProductList;
        private TabPage tabPageProductDetail;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProduct;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtProductId;
        private TextBox TxtProductPrice;
        private TextBox TxtProductStock;
        private TextBox TxtProductName;
        private ComboBox CxtProductCategorie_Id;
        private Button BtnCancel;
        private Button BtnSave;
    }
}