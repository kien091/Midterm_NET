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
    public partial class UC_Reservation : UserControl
    {
        public UC_Reservation()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReservationForm1 reservation = new ReservationForm1(this);
            reservation.Show();
        }

        private void UC_Reservation_Load(object sender, EventArgs e)
        {
            ReloadData();
        }
        private void dgv_Reservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Reservation.Columns[e.ColumnIndex].Name == "View")
            {
                int id = 0;
                Int32.TryParse(dgv_Reservation.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out id);
                InfoReservationForm reservation = new InfoReservationForm(id);
                reservation.Show();
            }
            else if (dgv_Reservation.Columns[e.ColumnIndex].Name == "Delete")
            {
                int id = 0;
                Int32.TryParse(dgv_Reservation.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out id);
                SqlConnection connection = DbConnection.GetConnection();
                ReservationModel deleteReservation = new ReservationModel(id);
                deleteReservation.deleteReservation(connection);
                ReloadData();
            }
        }
        public void ReloadData()
        {
            SqlConnection connection = DbConnection.GetConnection();
            dgv_Reservation.DataSource = ReservationModel.GetDataToLoadDataGridView(connection);
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ReloadData();
            FilterDataGridView(tbSearch.Text);
        }
        private void FilterDataGridView(string txtSearch)
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgv_Reservation.Rows)
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
                dgv_Reservation.Rows.Remove(rows[i]);
            }
        }
    }
}
