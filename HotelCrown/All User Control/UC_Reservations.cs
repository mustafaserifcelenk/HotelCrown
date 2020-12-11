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
            ListServices();
        }

        private void ListServices()
        {
            using (HotelCrownContext db = new HotelCrownContext())
            {
                cboServices.DataSource = db.Services.ToList();
            }
        }

        private void ListResarvation()
        {
            using (HotelCrownContext db = new HotelCrownContext())
            {

                dgvReservations.DataSource = db.Reservations.SelectMany(x => db.Customers.Select(y => y), (x, y) =>
                    new
                    {
                        x.Room.RoomNo,
                        x.CheckInDate,
                        x.CheckOutDate,
                        x.CheckedIn,
                        x.CheckedOut,
                        //x.AllCustomers : Classta bu objenin değerleri anlamadığım bir şekilde null geliyor
                    }).Distinct().ToList();
            }
        }
        private void ListAdditionalRooms()
        {
            using (HotelCrownContext db = new HotelCrownContext())
            {
                //Rezervasyon için müsait olan odaları listele
                dgvRooms.DataSource = db.Rooms.SelectMany(x => db.Reservations.Where(y => y.CheckInDate >= checkOut || y.CheckOutDate <= checkIn), (x, y) =>
                new
                {
                    x.RoomId,
                    x.RoomNo,
                    x.Price,
                    y.CheckInDate,
                    y.CheckOutDate
                }).Distinct().ToList();
            }
        }

        private void btnNewReservation_Click(object sender, EventArgs e)
        {
            checkIn = dtCheckInRooms.Value;
            checkOut = dtCheckOutRooms.Value;
            AddingMode();
        }

        private void NormalMode()
        {
            dgvReservations.Visible = true;
            dgvRooms.Visible = false;
            dtCheckIn.Visible = true;
            dtCheckOut.Visible = true;
            dtCheckOutRooms.Visible = false;
            dtCheckInRooms.Visible = false;
            dtCheckOut.Visible = false;
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
        }

        private void AddingMode()
        {
            dgvReservations.Visible = false;
            dgvRooms.Visible = true;
            dtCheckIn.Visible = false;
            dtCheckOut.Visible = false;
            dtCheckInRooms.Visible = true;
            dtCheckOutRooms.Visible = true;
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

        }

        private void dtCheckIn_ValueChanged(object sender, EventArgs e)
        {
            if (dtCheckIn.Value >= dtCheckOut.Value)
            {
                MessageBox.Show("Check-out date value must be higher than check-in date value.");
                return;
            }
            checkIn = dtCheckInRooms.Value; // İki tane ikişer date time picker oluşturdum, biri rezervasyon sort için diğeri room sort için
            checkOut = dtCheckOutRooms.Value;
            ListAdditionalRooms();
        }

        private void dtCheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (dtCheckIn.Value >= dtCheckOut.Value)
            {
                MessageBox.Show("Check-out date value must be higher than check-in date value.");
                return;
            }
            checkIn = dtCheckInRooms.Value;
            checkOut = dtCheckOutRooms.Value;
            ListAdditionalRooms();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //ListAdditionalRooms();
            //using (CustomerRegistration customerRegistration = new CustomerRegistration())
            //{
            using (HotelCrownContext db = new HotelCrownContext())
            {
                int key = int.Parse(dgvRooms.SelectedRows[0].Cells[0].Value.ToString());
                MessageBox.Show(key.ToString());
                //Room reservation = (Room)db.Rooms.FirstOrDefault(x => x.RoomId == key);
                CustomerRegistration frm = new CustomerRegistration(key);
                frm.ChangesDone += Frm_ChangesDone;
                frm.ShowDialog();
            }
            //customerId = customerRegistration.customerId;
            //}
        }

        private void Frm_ChangesDone(object sender, EventArgs e)
        {
            dgvRooms.Visible = false;
            dgvReservations.Visible = true;
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
            using (HotelCrownContext db = new HotelCrownContext())
            {
                Reservation selectedOne = (Reservation)dgvReservations.SelectedRows[0].DataBoundItem;
                Reservation editingOne = db.Reservations.FirstOrDefault(x => x.Id == selectedOne.Id);
                editingOne.CheckOutDate = dtExtendOut.Value;
                int quantity = (int)nudQuantity.Value;
                ReservationService reservationService = new ReservationService
                {
                    ServiceName = editingOne.ReservationServices + cboServices.Text,
                    Quantity = quantity
                };
                editingOne.ReservationServices = new List<ReservationService> { reservationService };
                db.SaveChanges();
            }
            ListResarvation();

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

        private void btnOutAll_Click(object sender, EventArgs e)
        {
            ListResarvation();
        }

        private void btnInYes_Click(object sender, EventArgs e)
        {
            using (HotelCrownContext db = new HotelCrownContext())
            {
                dgvReservations.DataSource = db.Reservations.Where(x => x.CheckedIn == "Yes").ToList();
            }
        }

        private void btnInNo_Click(object sender, EventArgs e)
        {
            using (HotelCrownContext db = new HotelCrownContext())
            {
                dgvReservations.DataSource = db.Reservations.Where(x => x.CheckedIn == "No").ToList();
            }
        }


        private void btnInAll_Click(object sender, EventArgs e)
        {
            ListResarvation();

        }

        private void btnOutYes_Click(object sender, EventArgs e)
        {
            using (HotelCrownContext db = new HotelCrownContext())
            {
                dgvReservations.DataSource = db.Reservations.Where(x => x.CheckedOut == "Yes").ToList();
            }
        }

        private void btnOutNo_Click_1(object sender, EventArgs e)
        {
            using (HotelCrownContext db = new HotelCrownContext())
            {
                dgvReservations.DataSource = db.Reservations.Where(x => x.CheckedOut == "No").ToList();
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            string contain = txtSearchBox.Text;
            using (HotelCrownContext db = new HotelCrownContext())
            {
                dgvReservations.DataSource = db.Reservations.Select(x => x.Customers.Any(y => y.FullName.Contains(contain))).ToList();
            }
        }

        private void dtCheckInRooms_ValueChanged(object sender, EventArgs e)
        {
            if (dtCheckIn.Value >= dtCheckOut.Value)
            {
                MessageBox.Show("Check-out date value must be higher than check-in date value.");
                return;
            }
            checkIn = dtCheckInRooms.Value; // İki tane ikişer date time picker oluşturdum, biri rezervasyon sort için diğeri room sort için
            checkOut = dtCheckOutRooms.Value;
            ListAdditionalRooms();
        }

        private void dtCheckOutRooms_ValueChanged(object sender, EventArgs e)
        {
            if (dtCheckIn.Value >= dtCheckOut.Value)
            {
                MessageBox.Show("Check-out date value must be higher than check-in date value.");
                return;
            }
            checkIn = dtCheckInRooms.Value;
            checkOut = dtCheckOutRooms.Value;
            ListAdditionalRooms();
        }
    }
}
