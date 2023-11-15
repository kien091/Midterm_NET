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
    public partial class UC_Car : UserControl
    {
        public UC_Car()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CarForm car = new CarForm(this);
            car.Show();
        }

        private void UC_Car_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void dgv_Car_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Car.Columns[e.ColumnIndex].Name == "View")
            {
                int id = 0;
                Int32.TryParse(dgv_Car.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out id);
                CarForm car = new CarForm(this, id, "view");
                car.Show();
            }
            else if (dgv_Car.Columns[e.ColumnIndex].Name == "Edit")
            {
                int id = 0;
                Int32.TryParse(dgv_Car.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out id);
                CarForm car = new CarForm(this, id, "edit");
                car.Show();
            }
            else if (dgv_Car.Columns[e.ColumnIndex].Name == "Delete")
            {
                int id = 0;
                Int32.TryParse(dgv_Car.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out id);
                SqlConnection connection = DbConnection.GetConnection();
                CarModel deleteCar = new CarModel(id);
                deleteCar.deleteCar(connection);
                ReloadData();
            }
        }

        public void ReloadData()
        {
            SqlConnection connection = DbConnection.GetConnection();
            dgv_Car.DataSource = CarModel.GetDataToLoadDataGridView(connection);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ReloadData();
            FilterDataGridView(tbSearch.Text);
        }

        private void FilterDataGridView(string txtSearch)
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgv_Car.Rows)
            {
                bool visibleRow = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == "View" || cell.Value == "Edit" || cell.Value == "Delete") continue;
                    string compareStr = cell.Value.ToString().ToLower();
                    txtSearch = txtSearch.ToLower();
                    if (compareStr.Contains(txtSearch))
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
    }
}
