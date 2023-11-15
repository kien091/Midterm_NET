using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Car_System
{
    public partial class DashboardForm : Form
    {
        static DashboardForm _obj;

        public static DashboardForm Instance
        {
            get
            {
                if (_obj is null)
                {
                    _obj = new DashboardForm();
                }
                return _obj;
            }
        }
        public Panel pnlContain
        {
            get { return pnlContainer; }
            set { pnlContainer = value; }
        }
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            _obj = this;
            foreach (Control control in DashboardForm.Instance.pnlContain.Controls)
            {
                DashboardForm.Instance.pnlContain.Controls.Remove(control);
            }
            UC_Dashboard uc_dashboard = new UC_Dashboard();
            uc_dashboard.Dock = DockStyle.Fill;
            DashboardForm.Instance.pnlContain.Controls.Add(uc_dashboard);
            DashboardForm.Instance.pnlContain.Controls["UC_Dashboard"]?.BringToFront();
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (DashboardForm.Instance.pnlContain.Controls["UC_Customer"] == null)
            {
                foreach (Control control in DashboardForm.Instance.pnlContain.Controls)
                {
                    DashboardForm.Instance.pnlContain.Controls.Remove(control);
                }
                UC_Customer uc_customer = new UC_Customer();
                uc_customer.Dock = DockStyle.Fill;
                DashboardForm.Instance.pnlContain.Controls.Add(uc_customer);
                DashboardForm.Instance.pnlContain.Controls["UC_Customer"]?.BringToFront();
            }

        }
        private void btnCar_Click(object sender, EventArgs e)
        {
            if (DashboardForm.Instance.pnlContain.Controls["UC_Car"] == null)
            {
                foreach (Control control in DashboardForm.Instance.pnlContain.Controls)
                {
                    DashboardForm.Instance.pnlContain.Controls.Remove(control);
                }
                UC_Car uc_car = new UC_Car();
                uc_car.Dock = DockStyle.Fill;
                DashboardForm.Instance.pnlContain.Controls.Add(uc_car);
                DashboardForm.Instance.pnlContain.Controls["UC_Car"]?.BringToFront();
            }
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            if (DashboardForm.Instance.pnlContain.Controls["UC_Reservation"] == null)
            {
                foreach (Control control in DashboardForm.Instance.pnlContain.Controls)
                {
                    DashboardForm.Instance.pnlContain.Controls.Remove(control);
                }
                UC_Reservation uc_reservation = new UC_Reservation();
                uc_reservation.Dock = DockStyle.Fill;
                DashboardForm.Instance.pnlContain.Controls.Add(uc_reservation);
                DashboardForm.Instance.pnlContain.Controls["UC_Reservation"]?.BringToFront();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (DashboardForm.Instance.pnlContain.Controls["UC_Dashboard"] == null)
            {
                foreach (Control control in DashboardForm.Instance.pnlContain.Controls)
                {
                    DashboardForm.Instance.pnlContain.Controls.Remove(control);
                }
                UC_Dashboard uc_dashboard = new UC_Dashboard();
                uc_dashboard.Dock = DockStyle.Fill;
                DashboardForm.Instance.pnlContain.Controls.Add(uc_dashboard);
                DashboardForm.Instance.pnlContain.Controls["UC_Dashboard"]?.BringToFront();
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (DashboardForm.Instance.pnlContain.Controls["UC_Schedule"] == null)
            {
                foreach (Control control in DashboardForm.Instance.pnlContain.Controls)
                {
                    DashboardForm.Instance.pnlContain.Controls.Remove(control);
                }
                UC_Schedule uc_schedule = new UC_Schedule();
                uc_schedule.Dock = DockStyle.Fill;
                DashboardForm.Instance.pnlContain.Controls.Add(uc_schedule);
                DashboardForm.Instance.pnlContain.Controls["UC_Schedule"]?.BringToFront();
            }
        }
    }
}
