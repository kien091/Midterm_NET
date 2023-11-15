using Rental_Car_System.Db;
using Rental_Car_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Car_System
{
    public partial class ScheduleForm : Form
    {
        private int id { get; set; }
        public ScheduleForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = DbConnection.GetConnection();
            CustomerModel model = CustomerModel.findCustomerById(connection, this.id);

            // load data
            if (model.avatar != "")
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

            dgvSchedule.DataSource = ReservationModel.GetDataToLoadDGVSchedule(connection, id);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
