using HotelCrown.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCrown.All_User_Control
{
    public partial class UC_AddRoom : UserControl
    {
        public UC_AddRoom()
        {
            InitializeComponent();
            ListRooms();
            ListFeatures();
            ListCapacity();
        }

        private void ListCapacity()
        {
            using (HotelCrownContext db = new HotelCrownContext())
            {
                cboBed.DataSource = db.Rooms.ToList();
            }
        }

        private void ListFeatures()
        {
            using (HotelCrownContext db = new HotelCrownContext())
            {
                clbFeatures.DataSource = db.Features.ToList();
            }
            clbFeatures.DisplayMember = "FeatureName";
            clbFeatures.ValueMember = "FeatureId";
        }

        private void ListRooms()
        {
            using (HotelCrownContext db = new HotelCrownContext())
            {
                dgvNewRoom.DataSource = db.Rooms.ToList();
            }
        }

        private void Clear()
        {
            txtPrice.Clear();
            txtPrice.Clear();
            cboBed.SelectedIndex = -1;
            for (int i = 0; i < clbFeatures.Items.Count; i++)
            {
                clbFeatures.SetItemChecked(i, false);
            }
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAddRoom_Click_1(object sender, EventArgs e)
        {
            if (txtRoomNo.Text == "" || txtPrice.Text == "" || cboBed.Text == "")
            {
                MessageBox.Show("Fill All Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roomNo = int.Parse(txtRoomNo.Text);
            List<Feature> features = clbFeatures.CheckedItems.OfType<Feature>().ToList();
            int price = int.Parse(txtPrice.Text);
            string bedNumber = cboBed.Text;

            using (HotelCrownContext db = new HotelCrownContext())
            {
                db.Rooms.Add(new Room
                {
                    RoomNo = roomNo,
                    Capacity = bedNumber,
                    Price = price,
                    Features = features
                });
                db.SaveChanges();
            }
            ListRooms();
            Clear();
        }
    }
}
