namespace Flat_UI_Mullti
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            panelMenu = new Panel();
            btn_Settings = new Button();
            btn_Notification = new Button();
            btn_Reporting = new Button();
            btn_Customers = new Button();
            btn_Orders = new Button();
            btn_Product = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btn_Settings);
            panelMenu.Controls.Add(btn_Notification);
            panelMenu.Controls.Add(btn_Reporting);
            panelMenu.Controls.Add(btn_Customers);
            panelMenu.Controls.Add(btn_Orders);
            panelMenu.Controls.Add(btn_Product);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 655);
            panelMenu.TabIndex = 0;
            // 
            // btn_Settings
            // 
            btn_Settings.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Settings.Dock = DockStyle.Top;
            btn_Settings.FlatAppearance.BorderSize = 0;
            btn_Settings.FlatStyle = FlatStyle.Flat;
            btn_Settings.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Settings.ForeColor = Color.Gainsboro;
            btn_Settings.Image = (Image)resources.GetObject("btn_Settings.Image");
            btn_Settings.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Settings.Location = new Point(0, 445);
            btn_Settings.Name = "btn_Settings";
            btn_Settings.Padding = new Padding(12, 0, 0, 0);
            btn_Settings.Size = new Size(220, 71);
            btn_Settings.TabIndex = 6;
            btn_Settings.Text = "Setting";
            btn_Settings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Settings.UseVisualStyleBackColor = true;
            btn_Settings.Click += btn_Settings_Click;
            // 
            // btn_Notification
            // 
            btn_Notification.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Notification.Dock = DockStyle.Top;
            btn_Notification.FlatAppearance.BorderSize = 0;
            btn_Notification.FlatStyle = FlatStyle.Flat;
            btn_Notification.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Notification.ForeColor = Color.Gainsboro;
            btn_Notification.Image = (Image)resources.GetObject("btn_Notification.Image");
            btn_Notification.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Notification.Location = new Point(0, 374);
            btn_Notification.Name = "btn_Notification";
            btn_Notification.Padding = new Padding(12, 0, 0, 0);
            btn_Notification.Size = new Size(220, 71);
            btn_Notification.TabIndex = 5;
            btn_Notification.Text = "Notification";
            btn_Notification.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Notification.UseVisualStyleBackColor = true;
            btn_Notification.Click += btn_Notification_Click;
            // 
            // btn_Reporting
            // 
            btn_Reporting.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Reporting.Dock = DockStyle.Top;
            btn_Reporting.FlatAppearance.BorderSize = 0;
            btn_Reporting.FlatStyle = FlatStyle.Flat;
            btn_Reporting.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Reporting.ForeColor = Color.Gainsboro;
            btn_Reporting.Image = (Image)resources.GetObject("btn_Reporting.Image");
            btn_Reporting.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Reporting.Location = new Point(0, 303);
            btn_Reporting.Name = "btn_Reporting";
            btn_Reporting.Padding = new Padding(12, 0, 0, 0);
            btn_Reporting.Size = new Size(220, 71);
            btn_Reporting.TabIndex = 4;
            btn_Reporting.Text = "Reporting";
            btn_Reporting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Reporting.UseVisualStyleBackColor = true;
            btn_Reporting.Click += btn_Reporting_Click;
            // 
            // btn_Customers
            // 
            btn_Customers.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Customers.Dock = DockStyle.Top;
            btn_Customers.FlatAppearance.BorderSize = 0;
            btn_Customers.FlatStyle = FlatStyle.Flat;
            btn_Customers.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Customers.ForeColor = Color.Gainsboro;
            btn_Customers.Image = (Image)resources.GetObject("btn_Customers.Image");
            btn_Customers.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Customers.Location = new Point(0, 232);
            btn_Customers.Name = "btn_Customers";
            btn_Customers.Padding = new Padding(12, 0, 0, 0);
            btn_Customers.Size = new Size(220, 71);
            btn_Customers.TabIndex = 3;
            btn_Customers.Text = "Customers";
            btn_Customers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Customers.UseVisualStyleBackColor = true;
            btn_Customers.Click += btn_Customers_Click;
            // 
            // btn_Orders
            // 
            btn_Orders.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Orders.Dock = DockStyle.Top;
            btn_Orders.FlatAppearance.BorderSize = 0;
            btn_Orders.FlatStyle = FlatStyle.Flat;
            btn_Orders.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Orders.ForeColor = Color.Gainsboro;
            btn_Orders.Image = (Image)resources.GetObject("btn_Orders.Image");
            btn_Orders.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Orders.Location = new Point(0, 161);
            btn_Orders.Name = "btn_Orders";
            btn_Orders.Padding = new Padding(12, 0, 0, 0);
            btn_Orders.Size = new Size(220, 71);
            btn_Orders.TabIndex = 2;
            btn_Orders.Text = "Orders";
            btn_Orders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Orders.UseVisualStyleBackColor = true;
            btn_Orders.Click += btn_Orders_Click;
            // 
            // btn_Product
            // 
            btn_Product.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Product.Dock = DockStyle.Top;
            btn_Product.FlatAppearance.BorderSize = 0;
            btn_Product.FlatStyle = FlatStyle.Flat;
            btn_Product.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Product.ForeColor = Color.Gainsboro;
            btn_Product.Image = (Image)resources.GetObject("btn_Product.Image");
            btn_Product.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Product.Location = new Point(0, 90);
            btn_Product.Name = "btn_Product";
            btn_Product.Padding = new Padding(12, 0, 0, 0);
            btn_Product.Size = new Size(220, 71);
            btn_Product.TabIndex = 1;
            btn_Product.Text = "Products";
            btn_Product.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Product.UseVisualStyleBackColor = true;
            btn_Product.Click += btn_Product_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 90);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(928, 90);
            panelTitleBar.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(882, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 34);
            btnClose.TabIndex = 4;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Image = (Image)resources.GetObject("btnMaximize.Image");
            btnMaximize.Location = new Point(842, 12);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(34, 34);
            btnMaximize.TabIndex = 3;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(802, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(34, 34);
            btnMinimize.TabIndex = 2;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Image = (Image)resources.GetObject("btnCloseChildForm.Image");
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(85, 90);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("AngsanaUPC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(375, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(86, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(220, 90);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(928, 565);
            panelDesktopPane.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 655);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "FormMainMenu";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btn_Product;
        private Button btn_Settings;
        private Button btn_Notification;
        private Button btn_Reporting;
        private Button btn_Customers;
        private Button btn_Orders;
        private PictureBox pictureBox1;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Panel panelDesktopPane;
        private Button btnCloseChildForm;
        private Button btnMinimize;
        private Button btnClose;
        private Button btnMaximize;
    }
}
