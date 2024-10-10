namespace Supermarket_mvp.Views
{
    partial class MainView
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
            BtnCategorie = new Button();
            BtnCustomer = new Button();
            BtnExit = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            BtnProduct = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnProduct);
            panel1.Controls.Add(BtnCategorie);
            panel1.Controls.Add(BtnCustomer);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 450);
            panel1.TabIndex = 0;
            // 
            // BtnCategorie
            // 
            BtnCategorie.BackgroundImage = Properties.Resources.Categorie;
            BtnCategorie.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategorie.Dock = DockStyle.Top;
            BtnCategorie.Location = new Point(0, 207);
            BtnCategorie.Name = "BtnCategorie";
            BtnCategorie.Size = new Size(157, 59);
            BtnCategorie.TabIndex = 2;
            BtnCategorie.UseVisualStyleBackColor = true;
            // 
            // BtnCustomer
            // 
            BtnCustomer.BackgroundImage = Properties.Resources.providers;
            BtnCustomer.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCustomer.Dock = DockStyle.Top;
            BtnCustomer.Location = new Point(0, 136);
            BtnCustomer.Name = "BtnCustomer";
            BtnCustomer.Size = new Size(157, 71);
            BtnCustomer.TabIndex = 2;
            BtnCustomer.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.BackgroundImage = Properties.Resources.cerrar;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Dock = DockStyle.Bottom;
            BtnExit.Location = new Point(0, 384);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(157, 66);
            BtnExit.TabIndex = 2;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = Properties.Resources.buy;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Dock = DockStyle.Top;
            BtnPayMode.Location = new Point(0, 62);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(157, 74);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtnProduct
            // 
            BtnProduct.BackgroundImage = Properties.Resources.products;
            BtnProduct.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProduct.Dock = DockStyle.Top;
            BtnProduct.Location = new Point(0, 266);
            BtnProduct.Name = "BtnProduct";
            BtnProduct.Size = new Size(157, 66);
            BtnProduct.TabIndex = 2;
            BtnProduct.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarket";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnPayMode;
        private PictureBox pictureBox1;
        private Button BtnExit;
        private Button BtnCustomer;
        private Button BtnCategorie;
        private Button BtnProduct;
    }
}