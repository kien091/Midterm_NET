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
    public partial class ReservationForm1 : Form
    {
        private UC_Reservation UC_Reservation { get; set; }
        private int id { get; set; }
        private string action { get; set; }
        private double price = 0;
        List<String> fearure = new List<String>();
        public ReservationForm1(UC_Reservation uC_Reservation)
        {
            this.UC_Reservation = uC_Reservation;
            InitializeComponent();
        }
        public ReservationForm1(UC_Reservation uC_Reservation, int id, string action)
        {
            this.UC_Reservation = uC_Reservation;
            this.id = id;
            this.action = action;
            InitializeComponent();
        }
        public ReservationForm1()
        {
            InitializeComponent();
        }

        private void cbGasonline_CheckedChanged(object sender, EventArgs e)
        {
            ReloadData();
            if (cbGasoline.Checked)
            {
                cbElectric.Enabled = false;
                cbDiesel.Enabled = false;
                FilterDataGridView("Gasonline");
            }
            else
            {
                cbElectric.Enabled = true;
                cbDiesel.Enabled = true;
            }
        }

        private void cbElectric_CheckedChanged(object sender, EventArgs e)
        {
            ReloadData();
            if (cbElectric.Checked)
            {
                cbGasoline.Enabled = false;
                cbDiesel.Enabled = false;
                FilterDataGridView("Electric");
            }
            else
            {
                cbGasoline.Enabled = true;
                cbDiesel.Enabled = true;
            }
        }

        private void cbDiesel_CheckedChanged(object sender, EventArgs e)
        {
            ReloadData();
            if (cbDiesel.Checked)
            {
                cbGasoline.Enabled = false;
                cbElectric.Enabled = false;
                FilterDataGridView("Diesel Oil");
            }
            else
            {
                cbGasoline.Enabled = true;
                cbElectric.Enabled = true;
            }
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            lbNotice.Text = "";
            SqlConnection connection = DbConnection.GetConnection();
            List<string> carTypes = CarModel.GetCarTypes(connection);

            cbType.Items.Clear();
            cbType.Items.AddRange(carTypes.ToArray());

            dtpHireDate.CustomFormat = "dd/MM/yyyy";
            dtpReturnDate.CustomFormat = "dd/MM/yyyy";

            ReloadData();

            dtpHireDate.Value = DateTime.Now;
            dtpHireDate.MinDate = DateTime.Now;
            dtpReturnDate.Value = DateTime.Now.AddDays(1);
            dtpReturnDate.MinDate = DateTime.Now.AddDays(1);
            
        }
        public void ReloadData()
        {
            SqlConnection connection = DbConnection.GetConnection();
            dgv_Car.DataSource = CarModel.GetDataToLoadDGVReservation(connection);
            dgv_Car.Columns["Type"].Visible = false;
            dgv_Car.Columns["Fuel"].Visible = false;
        }
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadData();
            FilterDataGridView(cbType.Text);
        }

        private void FilterDataGridView(string str)
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgv_Car.Rows)
            {
                bool visibleRow = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string compareStr = cell.Value.ToString().ToLower();
                    str = str.ToLower();
                    if (compareStr.Contains(str))
                    {
                        visibleRow = true;
                        break;
                    }
                }
                if (!visibleRow)
                {
                    rows.Add(row);
                }
            }
            for (int i = rows.Count - 1; i >= 0; i--)
            {
                dgv_Car.Rows.Remove(rows[i]);
            }
        }

        private void cbBanDo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBanDo.Checked)
            {
                fearure.Add(cbBanDo.Text);
                price += 15;
            }
            else
            {
                fearure.Remove(cbBanDo.Text);
                price -= 15;
            }
            lbTotalPrice.Text = "$" + price.ToString();
        }

        private void cbCameraCapLe_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCameraCapLe.Checked)
            {
                fearure.Add(cbCameraCapLe.Text);
                price += 11;
            }
            else
            {
                fearure.Remove(cbCameraCapLe.Text);
                price -= 11;
            }
            lbTotalPrice.Text = "$" + price.ToString();
        }

        private void cbCamBienLop_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCamBienLop.Checked)
            {
                fearure.Add(cbCamBienLop.Text);
                price += 16;
            }
            else
            {
                fearure.Remove(cbCamBienLop.Text);
                price -= 16;
            }
            lbTotalPrice.Text = "$" + price.ToString();
        }

        private void cbCuaSoTroi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCuaSoTroi.Checked)
            {
                fearure.Add(cbCuaSoTroi.Text);
                price += 13;
            }
            else
            {
                fearure.Remove(cbCuaSoTroi.Text);
                price -= 13;
            }
            lbTotalPrice.Text = "$" + price.ToString();
        }

        private void cbKheCamUSB_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKheCamUSB.Checked)
            {
                fearure.Add(cbKheCamUSB.Text);
                price += 4;
            }
            else
            {
                fearure.Remove(cbKheCamUSB.Text);
                price -= 4;
            }
            lbTotalPrice.Text = "$" + price.ToString();
        }

        private void cbNapThungXe_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNapThungXe.Checked)
            {
                fearure.Add(cbNapThungXe.Text);
                price += 11;
            }
            else
            {
                fearure.Remove(cbNapThungXe.Text);
                price -= 11;
            }
            lbTotalPrice.Text = "$" + price.ToString();
        }

        private void cbBlueTooth_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBlueTooth.Checked)
            {
                fearure.Add(cbBlueTooth.Text);
                price += 21;
            }
            else
            {
                fearure.Remove(cbBlueTooth.Text);
                price -= 21;
            }
            lbTotalPrice.Text = "$" + price.ToString();
        }

        private void cbCameraHanhTrinh_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCameraHanhTrinh.Checked)
            {
                fearure.Add(cbCameraHanhTrinh.Text);
                price += 25;
            }
            else
            {
                fearure.Remove(cbCameraHanhTrinh.Text);
                price -= 25;
            }
            lbTotalPrice.Text = "$" + price.ToString();
        }

        private void cbCamBienVaCham_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCamBienVaCham.Checked)
            {
                fearure.Add(cbCamBienVaCham.Text);
                price += 10;
            }
            else
            {
                fearure.Remove(cbCamBienVaCham.Text);
                price -= 10;
            }
            lbTotalPrice.Text = "$" + price.ToString();
        }

        private void cbDinhViGPS_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDinhViGPS.Checked)
            {
                fearure.Add(cbDinhViGPS.Text);
                price += 23;
            }
            else
            {
                fearure.Remove(cbDinhViGPS.Text);
                price -= 23;
            }
            lbTotalPrice.Text = "$" + price.ToString();
        }

        private void cbLopDuPhong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLopDuPhong.Checked)
            {
                fearure.Add(cbLopDuPhong.Text);
                price += 18;
            }
            else
            {
                fearure.Remove(cbLopDuPhong.Text);
                price -= 18;
            }
            lbTotalPrice.Text = "$" + price.ToString();
        }

        private void cbCamera360_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCamera360.Checked)
            {
                fearure.Add(cbCamera360.Text);
                price += 17;
            }
            else
            {
                fearure.Remove(cbCamera360.Text);
                price -= 17;
            }
            lbTotalPrice.Text = "$" + price.ToString();
        }

        private void cbCameraLui_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCameraLui.Checked)
            {
                fearure.Add(cbCameraLui.Text);
                price += 29;
            }
            else
            {
                fearure.Remove(cbCameraLui.Text);
                price -= 29;
            }
            lbTotalPrice.Text = "$" + price.ToString();
        }

        private void cbCanhBaoTocDo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCanhBaoTocDo.Checked)
            {
                fearure.Add(cbCanhBaoTocDo.Text);
                price += 11;
            }
            else
            {
                fearure.Remove(cbCanhBaoTocDo.Text);
                price -= 11;
            }
            lbTotalPrice.Text = "$" + price.ToString();
        }

        private void dgv_Car_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Car.Columns[e.ColumnIndex].Name == "Reservation")
            {
                SqlConnection connection = DbConnection.GetConnection();

                string carName = dgv_Car.Rows[e.RowIndex].Cells["fName"].Value.ToString();
                int idCar = Convert.ToInt32(dgv_Car.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                CarModel fCar = CarModel.findCarById(connection, idCar);

                CustomerModel customer = CustomerModel.FindCustomerByPhoneNumber(connection, tbPhoneNumber.Text);
                if (checkValidateReservation(tbPhoneNumber.Text, dtpHireDate.Value, dtpReturnDate.Value))
                {
                    double totalPrice = price + fCar.hireprice * (dtpReturnDate.Value.Date - dtpHireDate.Value.Date).TotalDays;
                    string feauresStr = "";
                    for (int i = 0; i < fearure.Count; i++)
                    {
                        feauresStr += (fearure[i] + ",");
                    }

                    // id user
                    int idUser = 1;

                    ReservationModel reservation = new ReservationModel(dtpHireDate.Value.Date, dtpReturnDate.Value.Date, feauresStr, Convert.ToInt32(totalPrice), 1, customer.id, idCar);
                    ShowCustomMessageBox(carName, totalPrice, reservation);
                }
            }
        }

        private bool checkValidateReservation(string phoneNumber, DateTime hireDate, DateTime returnDate)
        {
            SqlConnection connection = DbConnection.GetConnection();
            CustomerModel customer = CustomerModel.FindCustomerByPhoneNumber(connection, phoneNumber);

            if (customer == null)
            {
                lbNotice.Text = "Customer don't have in system yet!";
                return false;
            }
            else if(returnDate.Date <= hireDate.Date)
            {
                lbNotice.Text = "Time to hire car isn't valid!";
                return false;
            }
               
            return true;
        }

        private void ShowCustomMessageBox(string carName, double totalPrice, ReservationModel reservationModel)
        {
            string message = $"Are you sure to hire {carName}.\nThis is total price with your choice: {totalPrice}. \n Featues Prices: {price}, Hire Car Price: {totalPrice - price}";
            DialogResult result = MessageBox.Show(message, "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(result == DialogResult.OK)
            {
                reservationModel.InsertReservation(DbConnection.GetConnection());
                lbNotice.Text = "";
            }
        }
    }
}
