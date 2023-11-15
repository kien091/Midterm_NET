using Rental_Car_System.Db;
using Rental_Car_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Rental_Car_System
{
    public partial class CarForm : Form
    {
        private UC_Car UC_Car { get; set; }
        private int id { get; set; }
        private string action { get; set; }
        private string fullPathImage = "";
        public CarForm(UC_Car uC_Car)
        {
            this.UC_Car = uC_Car;
            InitializeComponent();
        }
        public CarForm(UC_Car uC_Car, int id, string action)
        {
            this.id = id;
            this.action = action;
            this.UC_Car = uC_Car;
            InitializeComponent();
        }

        private void cbXang_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGasoline.Checked) 
            {
                cbElectric.Enabled = false;
                cbDiesel.Enabled = false;
            }
            else
            {
                cbElectric.Enabled = true;
                cbDiesel.Enabled = true;
            }
        }

        private void cbDien_CheckedChanged(object sender, EventArgs e)
        {
            if (cbElectric.Checked)
            {
                cbGasoline.Enabled = false;
                cbDiesel.Enabled = false;
            }
            else
            {
                cbGasoline.Enabled = true;
                cbDiesel.Enabled = true;
            }
        }

        private void cbDiesel_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDiesel.Checked)
            {
                cbGasoline.Enabled = false;
                cbElectric.Enabled = false;
            }
            else
            {
                cbGasoline.Enabled = true;
                cbElectric.Enabled = true;
            }
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            if (this.action == "view")
            {
                LoadData();
                foreach (Control control in gbContainer.Controls)
                {
                    control.Enabled = false;
                }
                btnSave.Visible = false;
                btnBrowser.Visible = false;
            }
            else if (this.action == "edit")
            {
                LoadData();
            }
        }
        private void LoadData()
        {
            SqlConnection connection = DbConnection.GetConnection();
            CarModel model = CarModel.findCarById(connection, this.id);

            // load data
            if (model.image != "")
                pbImage.Image = Image.FromFile(model.image);
            tbName.Text = model.name.ToString();
            cbBrand.Text = model.brand.ToString();
            tbModel.Text = model.model.ToString();
            cbType.Text = model.type.ToString();
            tbPrice.Text = model.hireprice.ToString();
            if (model.fuel.ToString() == "Gasoline")
            {

                cbGasoline.Checked = true;
                cbDiesel.Enabled = false;
                cbElectric.Enabled= false;
            }
            else if(model.fuel.ToString() == "Electric")
            {
                cbElectric.Checked = true;
                cbDiesel.Enabled = false;
                cbGasoline.Enabled = false;
            }
            else
            {
                cbDiesel.Checked = true;
                cbElectric.Enabled = false;
                cbGasoline.Enabled = false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
                lbNotice.Text = "Please enter car name!";
            else if (cbBrand.Text == "")
                lbNotice.Text = "Please choose car brand!";
            else if (tbModel.Text == "")
                lbNotice.Text = "Please enter car model!";
            else if (tbPrice.Text == "")
                lbNotice.Text = "Please enter hire price!";
            else if (!Int32.TryParse(tbPrice.Text, out int result))
                lbNotice.Text = "Please enter a number hire price!";
            else if (cbType.Text == "")
                lbNotice.Text = "Please choose car type!";
            else if (!cbDiesel.Checked && !cbGasoline.Checked && !cbElectric.Checked)
                lbNotice.Text = "Please choose car fuel!";
            else
            {
                string fuel = "";
                if (cbGasoline.Checked)
                    fuel = "Gasonline";
                else if (cbElectric.Checked)
                    fuel = "Electric";
                else
                    fuel = "Diesel Oil";
                CarModel car = new CarModel(this.id, tbName.Text, fullPathImage, cbBrand.Text, tbModel.Text, cbType.Text, fuel, Convert.ToInt32(tbPrice.Text), cbHiring.Checked);
                SqlConnection connection = DbConnection.GetConnection();

                if (this.action == "edit")
                {
                    car.updateCar(connection);
                    // Reload data in dgv
                    this.UC_Car.ReloadData();
                    this.Hide();
                }
                else
                {
                    car.InsertCar(connection);

                    // Reload data in dgv
                    this.UC_Car.ReloadData();
                    this.Hide();
                }
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceImagePath = openFileDialog.FileName;
                string targetFolderPath = Path.Combine(Application.StartupPath, "car");
                string targetImagePath = Path.Combine(targetFolderPath, Path.GetFileName(sourceImagePath));
                if (!Directory.Exists(targetFolderPath))
                    Directory.CreateDirectory(targetFolderPath);
                if (!File.Exists(targetImagePath))
                    File.Copy(sourceImagePath, targetImagePath);

                fullPathImage = targetImagePath;
                pbImage.Image = Image.FromFile(targetImagePath);
            }
        }
    }
}
