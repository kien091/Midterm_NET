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
    public partial class UC_Schedule : UserControl
    {
        public UC_Schedule()
        {
            InitializeComponent();
        }

        private void UC_Schedule_Load(object sender, EventArgs e)
        {
            ReloadData();
        }
        private void dgv_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Customer.Columns[e.ColumnIndex].Name == "View")
            {
                int id = 0;
                Int32.TryParse(dgv_Customer.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out id);
                ScheduleForm schedule = new ScheduleForm(id);
                schedule.Show();
            }
        }
        public void ReloadData()
        {
            SqlConnection connection = DbConnection.GetConnection();
            dgv_Customer.DataSource = CustomerModel.GetDataToLoadDataGridView(connection);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ReloadData();
            FilterDataGridView(tbSearch.Text);
        }
        private void FilterDataGridView(string txtSearch)
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgv_Customer.Rows)
            {
                bool visibleRow = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == "View") continue;
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
                dgv_Customer.Rows.Remove(rows[i]);
            }
        }
    }
}
