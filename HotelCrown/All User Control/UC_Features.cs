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
    public partial class UC_Features : UserControl
    {
        public UC_Features()
        {
            InitializeComponent();
            ListFeatures();
        }

        private void ListFeatures()
        {
            using (HotelCrownContext db = new HotelCrownContext()) 
            {
                dgvFeatures.DataSource = db.Features.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string feature = txtFeatureName.Text;

            using (HotelCrownContext db = new HotelCrownContext())
            {
                db.Features.Add(new Feature()
                {
                    FeatureName = feature
                });
                db.SaveChanges();
            }
                ListFeatures();
                ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFeatures.SelectedRows.Count == 0) return;

            int selectedIndex = dgvFeatures.SelectedRows[0].Index;

            Feature deletingFeature = (Feature)dgvFeatures.SelectedRows[0].DataBoundItem;

            using (HotelCrownContext db = new HotelCrownContext())
            {
                db.Features.Attach(deletingFeature);
                db.Features.Remove(deletingFeature);
                db.SaveChanges();
            }
            ListFeatures();
            ClearForm();
        }

        private void ClearForm()
        {
            txtFeatureName.Clear();
        }

    }
}
