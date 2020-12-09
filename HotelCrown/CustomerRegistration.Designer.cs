
namespace HotelCrown
{
    partial class CustomerRegistration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAlloteRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.dtCheckInDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtCheckOutDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cboServices = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtCheckOutTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtCheckInTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvCustomers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbxCheckedIn = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbxCheckedOut = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Registration";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(1285, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Check-Out Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(1285, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Check-In Date";
            // 
            // btnAlloteRoom
            // 
            this.btnAlloteRoom.CheckedState.Parent = this.btnAlloteRoom;
            this.btnAlloteRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlloteRoom.CustomImages.Parent = this.btnAlloteRoom;
            this.btnAlloteRoom.FillColor = System.Drawing.Color.PaleGreen;
            this.btnAlloteRoom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlloteRoom.ForeColor = System.Drawing.Color.White;
            this.btnAlloteRoom.HoverState.Parent = this.btnAlloteRoom;
            this.btnAlloteRoom.Location = new System.Drawing.Point(1290, 564);
            this.btnAlloteRoom.Name = "btnAlloteRoom";
            this.btnAlloteRoom.ShadowDecoration.Parent = this.btnAlloteRoom;
            this.btnAlloteRoom.Size = new System.Drawing.Size(313, 55);
            this.btnAlloteRoom.TabIndex = 27;
            this.btnAlloteRoom.Text = "Allote Room";
            this.btnAlloteRoom.Click += new System.EventHandler(this.btnAlloteRoom_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Tomato;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(1628, 564);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(284, 55);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtCheckInDate
            // 
            this.dtCheckInDate.CheckedState.Parent = this.dtCheckInDate;
            this.dtCheckInDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckInDate.HoverState.Parent = this.dtCheckInDate;
            this.dtCheckInDate.Location = new System.Drawing.Point(1289, 81);
            this.dtCheckInDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckInDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckInDate.Name = "dtCheckInDate";
            this.dtCheckInDate.ShadowDecoration.Parent = this.dtCheckInDate;
            this.dtCheckInDate.Size = new System.Drawing.Size(623, 46);
            this.dtCheckInDate.TabIndex = 31;
            this.dtCheckInDate.Value = new System.DateTime(2020, 12, 6, 12, 4, 21, 781);
            // 
            // dtCheckOutDate
            // 
            this.dtCheckOutDate.CheckedState.Parent = this.dtCheckOutDate;
            this.dtCheckOutDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckOutDate.HoverState.Parent = this.dtCheckOutDate;
            this.dtCheckOutDate.Location = new System.Drawing.Point(1290, 169);
            this.dtCheckOutDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckOutDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckOutDate.Name = "dtCheckOutDate";
            this.dtCheckOutDate.ShadowDecoration.Parent = this.dtCheckOutDate;
            this.dtCheckOutDate.Size = new System.Drawing.Size(622, 46);
            this.dtCheckOutDate.TabIndex = 32;
            this.dtCheckOutDate.Value = new System.DateTime(2020, 12, 6, 12, 4, 21, 781);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "Quantity";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.Parent = this.txtQuantity;
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.FocusedState.Parent = this.txtQuantity;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.HoverState.Parent = this.txtQuantity;
            this.txtQuantity.Location = new System.Drawing.Point(1289, 493);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionStart = 8;
            this.txtQuantity.ShadowDecoration.Parent = this.txtQuantity;
            this.txtQuantity.Size = new System.Drawing.Size(623, 46);
            this.txtQuantity.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(1286, 470);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 20);
            this.label16.TabIndex = 38;
            this.label16.Text = "Quantity";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(1285, 392);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 20);
            this.label17.TabIndex = 37;
            this.label17.Text = "Services";
            // 
            // cboServices
            // 
            this.cboServices.BackColor = System.Drawing.Color.Transparent;
            this.cboServices.DisplayMember = "ServiceName";
            this.cboServices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServices.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboServices.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboServices.FocusedState.Parent = this.cboServices;
            this.cboServices.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboServices.HoverState.Parent = this.cboServices;
            this.cboServices.ItemHeight = 30;
            this.cboServices.ItemsAppearance.Parent = this.cboServices;
            this.cboServices.Location = new System.Drawing.Point(1287, 415);
            this.cboServices.Name = "cboServices";
            this.cboServices.ShadowDecoration.Parent = this.cboServices;
            this.cboServices.Size = new System.Drawing.Size(625, 36);
            this.cboServices.TabIndex = 36;
            // 
            // dtCheckOutTime
            // 
            this.dtCheckOutTime.CheckedState.Parent = this.dtCheckOutTime;
            this.dtCheckOutTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtCheckOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckOutTime.HoverState.Parent = this.dtCheckOutTime;
            this.dtCheckOutTime.Location = new System.Drawing.Point(1289, 339);
            this.dtCheckOutTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckOutTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckOutTime.Name = "dtCheckOutTime";
            this.dtCheckOutTime.ShadowDecoration.Parent = this.dtCheckOutTime;
            this.dtCheckOutTime.Size = new System.Drawing.Size(623, 46);
            this.dtCheckOutTime.TabIndex = 43;
            this.dtCheckOutTime.Value = new System.DateTime(2020, 12, 6, 12, 4, 21, 781);
            // 
            // dtCheckInTime
            // 
            this.dtCheckInTime.CheckedState.Parent = this.dtCheckInTime;
            this.dtCheckInTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtCheckInTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckInTime.HoverState.Parent = this.dtCheckInTime;
            this.dtCheckInTime.Location = new System.Drawing.Point(1289, 251);
            this.dtCheckInTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckInTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckInTime.Name = "dtCheckInTime";
            this.dtCheckInTime.ShadowDecoration.Parent = this.dtCheckInTime;
            this.dtCheckInTime.Size = new System.Drawing.Size(623, 46);
            this.dtCheckInTime.TabIndex = 42;
            this.dtCheckInTime.Value = new System.DateTime(2020, 12, 6, 12, 4, 21, 781);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(1285, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Checked-Out Time";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(1285, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 20);
            this.label15.TabIndex = 40;
            this.label15.Text = "Checked-In Time";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomers.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomers.Location = new System.Drawing.Point(12, 55);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(1208, 994);
            this.dgvCustomers.TabIndex = 44;
            this.dgvCustomers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCustomers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCustomers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCustomers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomers.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvCustomers.ThemeStyle.ReadOnly = true;
            this.dgvCustomers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCustomers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomers.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCustomers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Location = new System.Drawing.Point(101, 99);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 200);
            this.guna2PictureBox1.TabIndex = 29;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Location = new System.Drawing.Point(1371, 639);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(487, 390);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 45;
            this.guna2PictureBox2.TabStop = false;
            // 
            // cbxCheckedIn
            // 
            this.cbxCheckedIn.AutoSize = true;
            this.cbxCheckedIn.Checked = true;
            this.cbxCheckedIn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCheckedIn.CheckedState.BorderRadius = 0;
            this.cbxCheckedIn.CheckedState.BorderThickness = 0;
            this.cbxCheckedIn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCheckedIn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxCheckedIn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbxCheckedIn.Location = new System.Drawing.Point(1792, 225);
            this.cbxCheckedIn.Name = "cbxCheckedIn";
            this.cbxCheckedIn.Size = new System.Drawing.Size(107, 25);
            this.cbxCheckedIn.TabIndex = 46;
            this.cbxCheckedIn.Text = "Checked-In";
            this.cbxCheckedIn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbxCheckedIn.UncheckedState.BorderRadius = 0;
            this.cbxCheckedIn.UncheckedState.BorderThickness = 0;
            this.cbxCheckedIn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbxCheckedIn.CheckedChanged += new System.EventHandler(this.cbxCheckedIn_CheckedChanged);
            // 
            // cbxCheckedOut
            // 
            this.cbxCheckedOut.AutoSize = true;
            this.cbxCheckedOut.Checked = true;
            this.cbxCheckedOut.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCheckedOut.CheckedState.BorderRadius = 0;
            this.cbxCheckedOut.CheckedState.BorderThickness = 0;
            this.cbxCheckedOut.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCheckedOut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxCheckedOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCheckedOut.Location = new System.Drawing.Point(1792, 311);
            this.cbxCheckedOut.Name = "cbxCheckedOut";
            this.cbxCheckedOut.Size = new System.Drawing.Size(120, 25);
            this.cbxCheckedOut.TabIndex = 47;
            this.cbxCheckedOut.Text = "Checked-Out";
            this.cbxCheckedOut.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbxCheckedOut.UncheckedState.BorderRadius = 0;
            this.cbxCheckedOut.UncheckedState.BorderThickness = 0;
            this.cbxCheckedOut.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbxCheckedOut.CheckedChanged += new System.EventHandler(this.cbxCheckedOut_CheckedChanged);
            // 
            // CustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.cbxCheckedOut);
            this.Controls.Add(this.cbxCheckedIn);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.dtCheckOutTime);
            this.Controls.Add(this.dtCheckInTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cboServices);
            this.Controls.Add(this.dtCheckOutDate);
            this.Controls.Add(this.dtCheckInDate);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAlloteRoom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CustomerRegistration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnAlloteRoom;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtCheckInDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtCheckOutDate;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2ComboBox cboServices;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtCheckOutTime;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtCheckInTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCustomers;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2CheckBox cbxCheckedIn;
        private Guna.UI2.WinForms.Guna2CheckBox cbxCheckedOut;
    }
}