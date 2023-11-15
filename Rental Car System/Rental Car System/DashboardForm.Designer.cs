namespace Rental_Car_System
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flp_Navigation = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_icon = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.flp_Navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_Navigation
            // 
            this.flp_Navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(135)))));
            this.flp_Navigation.Controls.Add(this.pn_icon);
            this.flp_Navigation.Controls.Add(this.btnDashboard);
            this.flp_Navigation.Controls.Add(this.btnCustomer);
            this.flp_Navigation.Controls.Add(this.btnCar);
            this.flp_Navigation.Controls.Add(this.btnReservation);
            this.flp_Navigation.Controls.Add(this.btnSchedule);
            this.flp_Navigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp_Navigation.Location = new System.Drawing.Point(0, 0);
            this.flp_Navigation.Margin = new System.Windows.Forms.Padding(0);
            this.flp_Navigation.Name = "flp_Navigation";
            this.flp_Navigation.Size = new System.Drawing.Size(200, 1050);
            this.flp_Navigation.TabIndex = 0;
            // 
            // pn_icon
            // 
            this.pn_icon.Location = new System.Drawing.Point(0, 0);
            this.pn_icon.Margin = new System.Windows.Forms.Padding(0);
            this.pn_icon.Name = "pn_icon";
            this.pn_icon.Size = new System.Drawing.Size(200, 250);
            this.pn_icon.TabIndex = 0;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(200, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1724, 1050);
            this.pnlContainer.TabIndex = 1;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(135)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Rental_Car_System.Properties.Resources.icon_homescreen;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 253);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10);
            this.btnDashboard.Size = new System.Drawing.Size(197, 73);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "     &Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(135)))));
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = global::Rental_Car_System.Properties.Resources.icon_customer;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(3, 332);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(10);
            this.btnCustomer.Size = new System.Drawing.Size(197, 73);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "     &Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnCar
            // 
            this.btnCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(135)))));
            this.btnCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCar.FlatAppearance.BorderSize = 0;
            this.btnCar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCar.ForeColor = System.Drawing.Color.White;
            this.btnCar.Image = global::Rental_Car_System.Properties.Resources.icon_car;
            this.btnCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCar.Location = new System.Drawing.Point(3, 411);
            this.btnCar.Name = "btnCar";
            this.btnCar.Padding = new System.Windows.Forms.Padding(10);
            this.btnCar.Size = new System.Drawing.Size(197, 73);
            this.btnCar.TabIndex = 3;
            this.btnCar.Text = "  &Car";
            this.btnCar.UseVisualStyleBackColor = false;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(135)))));
            this.btnReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReservation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.Image = global::Rental_Car_System.Properties.Resources.icon_rental;
            this.btnReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservation.Location = new System.Drawing.Point(3, 490);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Padding = new System.Windows.Forms.Padding(10);
            this.btnReservation.Size = new System.Drawing.Size(197, 73);
            this.btnReservation.TabIndex = 4;
            this.btnReservation.Text = "     &Reservation";
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(135)))));
            this.btnSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSchedule.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Image = global::Rental_Car_System.Properties.Resources.icon_schedule;
            this.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.Location = new System.Drawing.Point(3, 569);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Padding = new System.Windows.Forms.Padding(10);
            this.btnSchedule.Size = new System.Drawing.Size(197, 73);
            this.btnSchedule.TabIndex = 5;
            this.btnSchedule.Text = "     &Schedule";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.flp_Navigation);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.flp_Navigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_Navigation;
        private System.Windows.Forms.Panel pn_icon;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Panel pnlContainer;
    }
}