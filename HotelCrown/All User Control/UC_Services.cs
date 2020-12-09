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
    public partial class UC_Services : UserControl
    {
        public UC_Services()
        {
            InitializeComponent();
            ListFeatures();

        }

        private void ListFeatures()
        {
            using (HotelCrownContext db = new HotelCrownContext())
            {
                dgvServices.DataSource = db.ReservationServices.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string service = txtServiceName.Text;
            string price = txtPrice.Text;

            using (HotelCrownContext db = new HotelCrownContext())
            {
                db.ReservationServices.Add(new ReservationService()
                {
                    ServiceName = service,
                    UnitPrice = int.Parse(price)
                });
                db.SaveChanges();
            }
            ListFeatures();
            ClearForm();
        }

        private void ClearForm()
        {
            txtPrice.Clear();
            txtServiceName.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count == 0) return;

            int selectedIndex = dgvServices.SelectedRows[0].Index;

            ReservationService deletingService = (ReservationService)dgvServices.SelectedRows[0].DataBoundItem;

            using (HotelCrownContext db = new HotelCrownContext())
            {
                db.ReservationServices.Attach(deletingService);
                db.ReservationServices.Remove(deletingService);
                db.SaveChanges();
            }
            ListFeatures();
            ClearForm();
        }
    }
}
