using Rental_Car_System.Db;
using Rental_Car_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Car_System
{
    public partial class CustomerForm : Form
    {
        private UC_Customer UC_Customer { get; set; }
        private int id { get; set; }
        private string action { get; set; }
        private string fullPathImage = "";
        public CustomerForm(UC_Customer uC_Customer)
        {
            this.UC_Customer = uC_Customer;
            InitializeComponent();
        }
        public CustomerForm(UC_Customer uC_Customer, int id, string action)
        {
            this.id = id;
            this.action = action;
            this.UC_Customer = uC_Customer;
            InitializeComponent();
        }

        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {
            if(cbMale.Checked)
                cbFemale.Enabled = false;
            else cbFemale.Enabled = true;
        }

        private void cbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if(cbFemale.Checked)
                cbMale.Enabled = false;
            else cbMale.Enabled = true;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dtpDob.CustomFormat = "dd/MM/yyyy";
            if (this.action == "view")
            {
                LoadData();
                foreach(Control control in gbContainer.Controls)
                {
                    control.Enabled = false;
                }
                btnSave.Visible = false;
                btnBrowser.Visible = false;
            }
            else if(this.action == "edit")
            {
                LoadData();
            }
            
        }
        private void LoadData()
        {
            SqlConnection connection = DbConnection.GetConnection();
            CustomerModel model = CustomerModel.findCustomerById(connection, this.id);

            // load data
            if(model.avatar != "")
                pbAvatar.Image = Image.FromFile(model.avatar);
            tbName.Text = model.name.ToString();
            tbEmail.Text = model.email.ToString();
            tbPhone.Text = model.phone.ToString();
            dtpDob.Value = model.dob;
            if (model.gender.ToString() == "Male")
            {
                cbMale.Checked = true;
                cbFemale.Enabled = false;
            }
            else
            {
                cbFemale.Checked = true;
                cbMale.Enabled = false;
            }
            tbAddress.Text = model.address.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (tbName.Text == "")
                lbNotice.Text = "Please enter customer name!";
            else if (tbEmail.Text == "")
                lbNotice.Text = "Please enter customer email!";
            else if (!reg.IsMatch(tbEmail.Text))
                lbNotice.Text = "Email isn't valid!";
            else if (tbPhone.Text == "")
                lbNotice.Text = "Please enter customer phone number!";
            else if (DateTime.Today.Year - dtpDob.Value.Year < 18)
                lbNotice.Text = "The age of customer minimize is 18!";
            else if (!cbFemale.Checked && !cbMale.Checked)
                lbNotice.Text = "Please choose customer gender!";
            else if (tbAddress.Text == "")
                lbNotice.Text = "Please enter customer address!";
            else
            {
                CustomerModel customer = new CustomerModel(this.id, fullPathImage, tbName.Text, tbEmail.Text, tbPhone.Text, dtpDob.Value, cbMale.Checked ? "Male" : "Female", tbAddress.Text);
                SqlConnection connection = DbConnection.GetConnection();

                if (this.action == "edit")
                {
                    customer.updateCustomer(connection);
                    // Reload data in dgv
                    this.UC_Customer.ReloadData();
                    this.Hide();
                }
                else
                {
                    customer.InsertCustomer(connection);

                    // Reload data in dgv
                    this.UC_Customer.ReloadData();
                    this.Hide();
                }
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceImagePath = openFileDialog.FileName;
                string targetFolderPath = Path.Combine(Application.StartupPath, "avatar");
                string targetImagePath = Path.Combine(targetFolderPath, Path.GetFileName(sourceImagePath));
                if (!Directory.Exists(targetFolderPath))
                    Directory.CreateDirectory(targetFolderPath);
                if(!File.Exists(targetImagePath))
                    File.Copy(sourceImagePath, targetImagePath);

                fullPathImage = targetImagePath;
                pbAvatar.Image = Image.FromFile(targetImagePath);
            }
        }
    }
}
