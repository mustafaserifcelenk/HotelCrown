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
    public partial class UC_Customers : UserControl
    {
        public UC_Customers()
        {
            InitializeComponent();
            cboGender.DataSource = Enum.GetValues(typeof(Gender));
            ListCustomers();
            ClearForm();
        }

        private void ClearForm()
        {
            txtFullName.Clear();
            txtIdentityNumber.Clear();
            txtMobileNo.Clear();
            //cboGender.SelectedValue = -1;
            rtxtDescriptions.Clear();
            dtBirthDate.Value = DateTime.Now;

        }

        private void ListCustomers()
        {
            using (HotelCrownContext db = new HotelCrownContext())
            {
                dgvCustomers.DataSource = db.Customers.ToList();
            }
        }

        private void btnAlloteRoom_Click(object sender, EventArgs e)
        {

            string fullName = txtFullName.Text;
            int identityNo = int.Parse(txtIdentityNumber.Text);
            int mobileNo = int.Parse(txtMobileNo.Text);
            Gender gender = (Gender)cboGender.SelectedValue;
            DateTime birthDate = dtBirthDate.Value;
            string description = rtxtDescriptions.Text;

            using (HotelCrownContext db = new HotelCrownContext())
            {
                db.Customers.Add(new Customer()
                {
                    FullName = fullName,
                    IdentityNumber = identityNo,
                    PhoneNumber = mobileNo,
                    Gender = gender,
                    BirthDate = birthDate,
                    Description = description
                });
                db.SaveChanges();
            }
            ListCustomers();
            ClearForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAlloteRoom.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Enabled = false;
            btnUpdate.Visible = true;
            btnCancel.Visible = true;
            Customer selectedCustomer = (Customer)dgvCustomers.SelectedRows[0].DataBoundItem;

            using (HotelCrownContext db = new HotelCrownContext())
            {
                var editingPerson = db.Customers.FirstOrDefault(x => x.Id == selectedCustomer.Id);
                txtFullName.Text = editingPerson.FullName;
                txtIdentityNumber.Text = editingPerson.IdentityNumber.ToString();
                txtMobileNo.Text = editingPerson.IdentityNumber.ToString();
                //cboGender.SelectedValue = editingPerson.Gender;
                dtBirthDate.Value = (DateTime)editingPerson.BirthDate;
                rtxtDescriptions.Text = editingPerson.Description;
                db.SaveChanges();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnAlloteRoom.Visible = true;
            btnEdit.Visible = true;
            btnDelete.Enabled = true;
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
            string fullName = txtFullName.Text;
            int identityNo = int.Parse(txtIdentityNumber.Text);
            int mobileNo = int.Parse(txtMobileNo.Text);
            Gender gender = (Gender)cboGender.SelectedValue;
            DateTime birthDate = dtBirthDate.Value;
            string description = rtxtDescriptions.Text;

            Customer selectedCustomer = (Customer)dgvCustomers.SelectedRows[0].DataBoundItem;

            using (HotelCrownContext db = new HotelCrownContext())
            {
                var editingPerson = db.Customers.FirstOrDefault(x => x.Id == selectedCustomer.Id);
                editingPerson.FullName = fullName;
                editingPerson.IdentityNumber = identityNo;
                editingPerson.PhoneNumber = mobileNo;
                editingPerson.Gender = gender;
                editingPerson.BirthDate = birthDate;
                editingPerson.Description = description;
                db.SaveChanges();
            }
            ListCustomers();
            ClearForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAlloteRoom.Visible = true;
            btnEdit.Visible = true;
            btnDelete.Enabled = true;
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0) return;

            int selectedIndex = dgvCustomers.SelectedRows[0].Index;

            Customer deletingCustomer = (Customer)dgvCustomers.SelectedRows[0].DataBoundItem;
            using (HotelCrownContext db = new HotelCrownContext())
            {
                db.Customers.Attach(deletingCustomer);
                db.Customers.Remove(deletingCustomer);
                db.SaveChanges();
            }
            ListCustomers();
            ClearForm();

        }
    }
}
