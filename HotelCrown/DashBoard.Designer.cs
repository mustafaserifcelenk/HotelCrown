
namespace HotelCrown
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMoving = new System.Windows.Forms.Panel();
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnServices = new Guna.UI2.WinForms.Guna2Button();
            this.btnFeatures = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnReservation = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Customers1 = new HotelCrown.All_User_Control.UC_Customers();
            this.uC_Reservations1 = new HotelCrown.All_User_Control.UC_Reservations();
            this.uC_Services1 = new HotelCrown.All_User_Control.UC_Services();
            this.uC_AddRoom1 = new HotelCrown.All_User_Control.UC_AddRoom();
            this.uC_Features1 = new HotelCrown.All_User_Control.UC_Features();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pnlMoving);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnServices);
            this.panel1.Controls.Add(this.btnFeatures);
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Controls.Add(this.btnReservation);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1565, 100);
            this.panel1.TabIndex = 0;
            // 
            // pnlMoving
            // 
            this.pnlMoving.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMoving.BackColor = System.Drawing.Color.Red;
            this.pnlMoving.Location = new System.Drawing.Point(29, 92);
            this.pnlMoving.Name = "pnlMoving";
            this.pnlMoving.Size = new System.Drawing.Size(280, 5);
            this.pnlMoving.TabIndex = 5;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.BorderRadius = 6;
            this.btnCustomers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomers.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnCustomers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCustomers.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCustomers.CheckedState.Parent = this.btnCustomers;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.CustomImages.Parent = this.btnCustomers;
            this.btnCustomers.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomers.ForeColor = System.Drawing.Color.DimGray;
            this.btnCustomers.HoverState.Parent = this.btnCustomers;
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCustomers.Location = new System.Drawing.Point(1262, 12);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.ShadowDecoration.Parent = this.btnCustomers;
            this.btnCustomers.Size = new System.Drawing.Size(300, 75);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnServices
            // 
            this.btnServices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnServices.BackColor = System.Drawing.Color.Transparent;
            this.btnServices.BorderRadius = 6;
            this.btnServices.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnServices.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnServices.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnServices.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnServices.CheckedState.Parent = this.btnServices;
            this.btnServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServices.CustomImages.Parent = this.btnServices;
            this.btnServices.FillColor = System.Drawing.Color.Transparent;
            this.btnServices.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnServices.ForeColor = System.Drawing.Color.DimGray;
            this.btnServices.HoverState.Parent = this.btnServices;
            this.btnServices.Image = ((System.Drawing.Image)(resources.GetObject("btnServices.Image")));
            this.btnServices.ImageSize = new System.Drawing.Size(35, 35);
            this.btnServices.Location = new System.Drawing.Point(650, 12);
            this.btnServices.Name = "btnServices";
            this.btnServices.ShadowDecoration.Parent = this.btnServices;
            this.btnServices.Size = new System.Drawing.Size(300, 75);
            this.btnServices.TabIndex = 3;
            this.btnServices.Text = "Services";
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnFeatures
            // 
            this.btnFeatures.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFeatures.BackColor = System.Drawing.Color.Transparent;
            this.btnFeatures.BorderRadius = 6;
            this.btnFeatures.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFeatures.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnFeatures.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFeatures.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFeatures.CheckedState.Parent = this.btnFeatures;
            this.btnFeatures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeatures.CustomImages.Parent = this.btnFeatures;
            this.btnFeatures.FillColor = System.Drawing.Color.Transparent;
            this.btnFeatures.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFeatures.ForeColor = System.Drawing.Color.DimGray;
            this.btnFeatures.HoverState.Parent = this.btnFeatures;
            this.btnFeatures.Image = ((System.Drawing.Image)(resources.GetObject("btnFeatures.Image")));
            this.btnFeatures.ImageSize = new System.Drawing.Size(35, 35);
            this.btnFeatures.Location = new System.Drawing.Point(956, 12);
            this.btnFeatures.Name = "btnFeatures";
            this.btnFeatures.ShadowDecoration.Parent = this.btnFeatures;
            this.btnFeatures.Size = new System.Drawing.Size(300, 75);
            this.btnFeatures.TabIndex = 2;
            this.btnFeatures.Text = "Features";
            this.btnFeatures.Click += new System.EventHandler(this.btnFeatures_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnRoom.BorderRadius = 6;
            this.btnRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRoom.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRoom.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRoom.CheckedState.Parent = this.btnRoom;
            this.btnRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoom.CustomImages.Parent = this.btnRoom;
            this.btnRoom.FillColor = System.Drawing.Color.Transparent;
            this.btnRoom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRoom.ForeColor = System.Drawing.Color.DimGray;
            this.btnRoom.HoverState.Parent = this.btnRoom;
            this.btnRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnRoom.Image")));
            this.btnRoom.ImageSize = new System.Drawing.Size(35, 35);
            this.btnRoom.Location = new System.Drawing.Point(344, 12);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.ShadowDecoration.Parent = this.btnRoom;
            this.btnRoom.Size = new System.Drawing.Size(300, 75);
            this.btnRoom.TabIndex = 1;
            this.btnRoom.Text = "Rooms";
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReservation.BackColor = System.Drawing.Color.Transparent;
            this.btnReservation.BorderRadius = 6;
            this.btnReservation.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReservation.Checked = true;
            this.btnReservation.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnReservation.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReservation.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReservation.CheckedState.Parent = this.btnReservation;
            this.btnReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservation.CustomImages.Parent = this.btnReservation;
            this.btnReservation.FillColor = System.Drawing.Color.Transparent;
            this.btnReservation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReservation.ForeColor = System.Drawing.Color.DimGray;
            this.btnReservation.HoverState.Parent = this.btnReservation;
            this.btnReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnReservation.Image")));
            this.btnReservation.ImageSize = new System.Drawing.Size(35, 35);
            this.btnReservation.Location = new System.Drawing.Point(19, 12);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.ShadowDecoration.Parent = this.btnReservation;
            this.btnReservation.Size = new System.Drawing.Size(300, 75);
            this.btnReservation.TabIndex = 0;
            this.btnReservation.Text = "Reservations";
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.uC_Customers1);
            this.panel2.Controls.Add(this.uC_Reservations1);
            this.panel2.Controls.Add(this.uC_Services1);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Controls.Add(this.uC_Features1);
            this.panel2.Location = new System.Drawing.Point(5, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1656, 541);
            this.panel2.TabIndex = 0;
            // 
            // uC_Customers1
            // 
            this.uC_Customers1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Customers1.BackColor = System.Drawing.Color.Transparent;
            this.uC_Customers1.BackgroundImage = global::HotelCrown.Properties.Resources.silver3;
            this.uC_Customers1.Location = new System.Drawing.Point(-250, -409);
            this.uC_Customers1.Name = "uC_Customers1";
            this.uC_Customers1.Size = new System.Drawing.Size(1906, 947);
            this.uC_Customers1.TabIndex = 2;
            this.uC_Customers1.Visible = false;
            // 
            // uC_Reservations1
            // 
            this.uC_Reservations1.BackColor = System.Drawing.Color.Transparent;
            this.uC_Reservations1.BackgroundImage = global::HotelCrown.Properties.Resources.silver3;
            this.uC_Reservations1.Cursor = System.Windows.Forms.Cursors.Default;
            this.uC_Reservations1.Location = new System.Drawing.Point(0, 0);
            this.uC_Reservations1.Name = "uC_Reservations1";
            this.uC_Reservations1.Size = new System.Drawing.Size(1906, 947);
            this.uC_Reservations1.TabIndex = 1;
            // 
            // uC_Services1
            // 
            this.uC_Services1.BackColor = System.Drawing.Color.Transparent;
            this.uC_Services1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_Services1.BackgroundImage")));
            this.uC_Services1.Location = new System.Drawing.Point(0, 0);
            this.uC_Services1.Name = "uC_Services1";
            this.uC_Services1.Size = new System.Drawing.Size(1906, 947);
            this.uC_Services1.TabIndex = 4;
            this.uC_Services1.Visible = false;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.BackgroundImage = global::HotelCrown.Properties.Resources.silver3;
            this.uC_AddRoom1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1906, 947);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // uC_Features1
            // 
            this.uC_Features1.BackColor = System.Drawing.Color.Transparent;
            this.uC_Features1.BackgroundImage = global::HotelCrown.Properties.Resources.silver3;
            this.uC_Features1.Location = new System.Drawing.Point(0, 0);
            this.uC_Features1.Name = "uC_Features1";
            this.uC_Features1.Size = new System.Drawing.Size(1906, 947);
            this.uC_Features1.TabIndex = 3;
            this.uC_Features1.Visible = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageSize = new System.Drawing.Size(35, 35);
            this.btnMinimize.Location = new System.Drawing.Point(1595, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(35, 35);
            this.btnExit.Location = new System.Drawing.Point(1631, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1670, 671);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
        private Guna.UI2.WinForms.Guna2Button btnServices;
        private Guna.UI2.WinForms.Guna2Button btnFeatures;
        private Guna.UI2.WinForms.Guna2Button btnRoom;
        private Guna.UI2.WinForms.Guna2Button btnReservation;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private System.Windows.Forms.Panel pnlMoving;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Control.UC_Reservations uC_Reservations1;
        private All_User_Control.UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Control.UC_Customers uC_Customers1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Control.UC_Features uC_Features1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_User_Control.UC_Services uC_Services1;
    }
}