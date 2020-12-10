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

namespace HotelCrown
{
    public partial class CustomerRegistration : Form
    {
        public event EventHandler ChangesDone;
        private readonly Room reservation;
        //public int customerId { get; set; }
        public CustomerRegistration(Room context)
        {
            reservation = context;
            InitializeComponent();
            ListCustomers();
            ListServices();
        }

        private void ListServices()
        {
            using (HotelCrownContext db = new HotelCrownContext())
            {
                cboServices.DataSource = db.ReservationServices.ToList();
            }
        }

        private void ListCustomers()
        {
            using (HotelCrownContext db = new HotelCrownContext())
            {
                dgvCustomers.DataSource = db.Customers.ToList();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlloteRoom_Click(object sender, EventArgs e)
        {
            Customer alloteCustomer = (Customer)dgvCustomers.SelectedRows[0].DataBoundItem;

            DateTime controlIn = new DateTime(2020, 12, 6, 12, 04, 00);
            DateTime controlOut = new DateTime(2020, 12, 6, 12, 04, 00);
            DateTime checkInDate = dtCheckInDate.Value;
            DateTime checkOutDate = dtCheckOutDate.Value;
            DateTime checkedInTime = dtCheckInTime.Value;
            DateTime checkedOutTime = dtCheckOutTime.Value;
            string service = cboServices.Text;
            int quantity = int.Parse(nudQuantity.Text);
            int customerId = alloteCustomer.Id;

            int roomId = reservation.RoomId;
            string checkedIn = (cbxCheckedIn.Checked) ? "Yes" : "No";
            string checkedOut = (cbxCheckedOut.Checked) ? "Yes" : "No";

            using (HotelCrownContext db = new HotelCrownContext())
            {
                string serveCustomer = cboServices.Text;
                ReservationService serviceCustomer = db.ReservationServices.FirstOrDefault(x => x.ServiceName == serveCustomer);
                Customer reserveCustomer = db.Customers.FirstOrDefault(x => x.Id == customerId);

                db.Reservations.Add(new Reservation()
                {
                    CheckInDate = checkInDate,
                    CheckOutDate = checkOutDate,
                    CheckedInTime = checkedInTime,
                    CheckedOutTime = checkedOutTime,
                    CheckedIn = checkedIn,
                    CheckedOut = checkedOut,
                    RoomId = roomId,
                    Customers = new List<Customer> { reserveCustomer },
                    ReservationServices = new List<ReservationService> { serviceCustomer }
                }) ;
                db.SaveChanges();
            }
            WhenChangesDone(EventArgs.Empty);
            Close();
        }

        protected virtual void WhenChangesDone(EventArgs args)
        {
            ChangesDone?.Invoke(this, args);
        }

        private void cbxCheckedIn_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxCheckedIn.Checked) dtCheckInTime.Enabled = false;
            else dtCheckInTime.Enabled = true;
        }

        private void cbxCheckedOut_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxCheckedOut.Checked) dtCheckOutTime.Enabled = false;
            else dtCheckOutTime.Enabled = true;
        }
    }
}
