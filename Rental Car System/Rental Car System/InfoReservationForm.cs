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
    public partial class InfoReservationForm : Form
    {
        private int id { get; set; }
        public InfoReservationForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void InfoReservationForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = DbConnection.GetConnection();
            ReservationModel reservation = ReservationModel.findReservationById(connection, id);
            CustomerModel customer = CustomerModel.findCustomerById(connection, reservation.idCustomer);
            CarModel car = CarModel.findCarById(connection, reservation.idCar);

            tbCusName.Text = customer.name;
            tbCusEmail.Text = customer.email;
            tbCusPhone.Text = customer.phone;

            tbCarName.Text = car.name;
            tbCarBrand.Text = car.brand;
            tbCarType.Text = car.type;
            tbCarFuel.Text = car.fuel;
            tbCarPrice.Text = car.hireprice.ToString();

            dtpHire.Value = reservation.hireDate;
            dtpReturn.Value = reservation.returnDate;
            tbTotal.Text = reservation.totalPrices.ToString();

            tbHireCar.Text = ((reservation.returnDate.Date - reservation.hireDate.Date).Days * car.hireprice).ToString();
            tbFeatures.Text = (reservation.totalPrices - Convert.ToInt32(tbHireCar.Text)).ToString();
            tbTotal.Text = reservation.totalPrices.ToString();
        }
    }
}
