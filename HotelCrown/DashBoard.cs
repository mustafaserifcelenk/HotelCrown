using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCrown
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnReservation_Click(object sender, EventArgs e)
        {
            pnlMoving.Left = btnReservation.Left + 6;
            uC_AddRoom1.Visible = false;
            uC_Reservations1.Visible = true;
            uC_Customers1.Visible = false;
            uC_Features1.Visible = false;
            uC_Services1.Visible = false;

        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            pnlMoving.Left = btnRoom.Left + 12;
            uC_AddRoom1.Visible = true;
            uC_Reservations1.Visible = false;
            uC_Customers1.Visible = false;
            uC_Features1.Visible = false;
            uC_Services1.Visible = false;

        }

        private void btnFeatures_Click(object sender, EventArgs e)
        {
            pnlMoving.Left = btnFeatures.Left + 12;
            uC_AddRoom1.Visible = false;
            uC_Reservations1.Visible = false;
            uC_Customers1.Visible = false;
            uC_Features1.Visible = true;
            uC_Services1.Visible = false;

        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            pnlMoving.Left = btnServices.Left + 12;
            uC_AddRoom1.Visible = false;
            uC_Reservations1.Visible = false;
            uC_Customers1.Visible = false;
            uC_Features1.Visible = false;
            uC_Services1.Visible = true;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            pnlMoving.Left = btnCustomers.Left + 12;
            uC_AddRoom1.Visible = false;
            uC_Reservations1.Visible = false;
            uC_Customers1.Visible = true;
            uC_Features1.Visible = false;
            uC_Services1.Visible = false;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            //uC_AddRoom1.Visible = false;
        }
    }
}
