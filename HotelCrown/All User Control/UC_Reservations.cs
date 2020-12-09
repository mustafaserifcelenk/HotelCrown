using HotelCrown.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCrown.All_User_Control
{
    public partial class UC_Reservations : UserControl
    {
        int customerId;
        DateTime checkIn;
        DateTime checkOut;
        public UC_Reservations()
        {
            InitializeComponent();
            ListResarvation();
        }

        private void ListResarvation()
        {
            using (HotelCrownContext db = new HotelCrownContext())
            {
                dgvReservations.DataSource = db.Reservations.ToList();
            }
        }

        private void btnNewReservation_Click(object sender, EventArgs e)
        {
            ListResarvation();

            checkIn = dtCheckIn.Value;
            checkOut = dtCheckOut.Value;

            AddingMode();

        }

        private void NormalMode()
        {
            btnNewReservation.Visible = true;
            btnAddCustomer.Visible = false;
            btnEdit.Visible = true;
            btnCancel.Visible = false;
            btnDelete.Enabled = true;
            btnInAll.Enabled = true;
            btnInNo.Enabled = true;
            btnInYes.Enabled = true;
            btnOutAll.Enabled = true;
            btnOutNo.Enabled = true;
            btnOutYes.Enabled = true;
            txtSearchBox.Enabled = true;

            if (btnNewReservation.Text == "Add Reservation")
            {
                ListAdditionalRooms();
            }
        }

        private void AddingMode()
        {
            btnNewReservation.Visible = false;
            btnAddCustomer.Visible = true;
            btnEdit.Visible = false;
            btnCancel.Visible = true;
            btnDelete.Enabled = false;
            btnInAll.Enabled = false;
            btnInNo.Enabled = false;
            btnInYes.Enabled = false;
            btnOutAll.Enabled = false;
            btnOutNo.Enabled = false;
            btnOutYes.Enabled = false;
            txtSearchBox.Enabled = false;

            if (btnNewReservation.Text == "Add Reservation")
            {
                ListAdditionalRooms();
            }
        }

        private void ListAdditionalRooms()
        {
            using (HotelCrownContext db = new HotelCrownContext())
            {
                dgvReservations.DataSource = db.Reservations.Where(x => x.CheckInDate.Value >= checkOut || x.CheckOutDate.Value <= checkIn).ToList();
            }
        }

        private void dtCheckIn_ValueChanged(object sender, EventArgs e)
        {
            if (dtCheckIn.Value >= dtCheckOut.Value)
            {
                MessageBox.Show("Check-out date value must be higher than check-in date value.");
                return;
            }
            checkIn = dtCheckIn.Value;
            checkOut = dtCheckOut.Value;
            ListAdditionalRooms();
        }

        private void dtCheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (dtCheckIn.Value >= dtCheckOut.Value)
            {
                MessageBox.Show("Check-out date value must be higher than check-in date value.");
                return;
            }
            checkIn = dtCheckIn.Value;
            checkOut = dtCheckOut.Value;
            ListAdditionalRooms();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //using (CustomerRegistration customerRegistration = new CustomerRegistration())
            //{

            Reservation reservation = (Reservation)dgvReservations.SelectedRows[0].DataBoundItem;
            CustomerRegistration frm = new CustomerRegistration(reservation);
            frm.ChangesDone += Frm_ChangesDone;
            frm.ShowDialog();

            //customerId = customerRegistration.customerId;
            //}
        }

        private void Frm_ChangesDone(object sender, EventArgs e)
        {
            ListResarvation();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NormalMode();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count == 0) return;

            int selectedIndex = dgvReservations.SelectedRows[0].Index;

            Reservation deletingReservation = (Reservation)dgvReservations.SelectedRows[0].DataBoundItem;

            using (HotelCrownContext db = new HotelCrownContext())
            {
                db.Reservations.Attach(deletingReservation);
                db.Reservations.Remove(deletingReservation);
                db.SaveChanges();
            }
            ListAdditionalRooms();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnNewReservation.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            dtExtendOut.Visible = true;
            cboServices.Visible = true;
            nudQuantity.Visible = true;
            BtnEditMode.Visible = true;
            PanelControls.Visible = false;
            PanelEdit.Visible = true;
        }

        private void BtnEditMode_Click(object sender, EventArgs e)
        {
            btnNewReservation.Visible = true;
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            dtExtendOut.Visible = false;
            cboServices.Visible = false;
            nudQuantity.Visible = false;
            BtnEditMode.Visible = false;
            PanelControls.Visible = true;
            PanelEdit.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            btnNewReservation.Visible = true;
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            dtExtendOut.Visible = false;
            cboServices.Visible = false;
            nudQuantity.Visible = false;
            BtnEditMode.Visible = false;
            PanelControls.Visible = true;
            PanelEdit.Visible = false;
        }
    }
}
