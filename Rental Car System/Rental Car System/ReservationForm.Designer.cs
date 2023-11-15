namespace Rental_Car_System
{
    partial class ReservationForm1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbContainer = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.cbDiesel = new System.Windows.Forms.CheckBox();
            this.cbElectric = new System.Windows.Forms.CheckBox();
            this.cbGasoline = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFeatures = new System.Windows.Forms.GroupBox();
            this.cbCameraLui = new System.Windows.Forms.CheckBox();
            this.cbCanhBaoTocDo = new System.Windows.Forms.CheckBox();
            this.cbLopDuPhong = new System.Windows.Forms.CheckBox();
            this.cbCamera360 = new System.Windows.Forms.CheckBox();
            this.cbCamBienVaCham = new System.Windows.Forms.CheckBox();
            this.cbDinhViGPS = new System.Windows.Forms.CheckBox();
            this.cbKheCamUSB = new System.Windows.Forms.CheckBox();
            this.cbNapThungXe = new System.Windows.Forms.CheckBox();
            this.cbBlueTooth = new System.Windows.Forms.CheckBox();
            this.cbCameraHanhTrinh = new System.Windows.Forms.CheckBox();
            this.cbCamBienLop = new System.Windows.Forms.CheckBox();
            this.cbCuaSoTroi = new System.Windows.Forms.CheckBox();
            this.cbCameraCapLe = new System.Windows.Forms.CheckBox();
            this.cbBanDo = new System.Windows.Forms.CheckBox();
            this.lbNotice = new System.Windows.Forms.Label();
            this.dgv_Car = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbFeatures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Car)).BeginInit();
            this.SuspendLayout();
            // 
            // gbContainer
            // 
            this.gbContainer.Controls.Add(this.groupBox2);
            this.gbContainer.Controls.Add(this.cbDiesel);
            this.gbContainer.Controls.Add(this.cbElectric);
            this.gbContainer.Controls.Add(this.cbGasoline);
            this.gbContainer.Controls.Add(this.label3);
            this.gbContainer.Controls.Add(this.tbPhoneNumber);
            this.gbContainer.Controls.Add(this.cbType);
            this.gbContainer.Controls.Add(this.label2);
            this.gbContainer.Controls.Add(this.label1);
            this.gbContainer.Controls.Add(this.gbFeatures);
            this.gbContainer.Location = new System.Drawing.Point(23, 12);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Size = new System.Drawing.Size(878, 398);
            this.gbContainer.TabIndex = 0;
            this.gbContainer.TabStop = false;
            this.gbContainer.Text = "Reservation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTotalPrice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpHireDate);
            this.groupBox2.Controls.Add(this.dtpReturnDate);
            this.groupBox2.Location = new System.Drawing.Point(276, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 112);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hire Information && Price";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(462, 25);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(34, 25);
            this.lbTotalPrice.TabIndex = 22;
            this.lbTotalPrice.Text = "$0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Total Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Return Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Hire Date:";
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHireDate.Location = new System.Drawing.Point(130, 30);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(200, 26);
            this.dtpHireDate.TabIndex = 0;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturnDate.Location = new System.Drawing.Point(130, 80);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(200, 26);
            this.dtpReturnDate.TabIndex = 19;
            // 
            // cbDiesel
            // 
            this.cbDiesel.AutoSize = true;
            this.cbDiesel.Location = new System.Drawing.Point(17, 271);
            this.cbDiesel.Name = "cbDiesel";
            this.cbDiesel.Size = new System.Drawing.Size(101, 24);
            this.cbDiesel.TabIndex = 15;
            this.cbDiesel.Text = "Diesel Oil";
            this.cbDiesel.UseVisualStyleBackColor = true;
            this.cbDiesel.CheckedChanged += new System.EventHandler(this.cbDiesel_CheckedChanged);
            // 
            // cbElectric
            // 
            this.cbElectric.AutoSize = true;
            this.cbElectric.Location = new System.Drawing.Point(146, 230);
            this.cbElectric.Name = "cbElectric";
            this.cbElectric.Size = new System.Drawing.Size(87, 24);
            this.cbElectric.TabIndex = 16;
            this.cbElectric.Text = "Electric";
            this.cbElectric.UseVisualStyleBackColor = true;
            this.cbElectric.CheckedChanged += new System.EventHandler(this.cbElectric_CheckedChanged);
            // 
            // cbGasoline
            // 
            this.cbGasoline.AutoSize = true;
            this.cbGasoline.Location = new System.Drawing.Point(17, 230);
            this.cbGasoline.Name = "cbGasoline";
            this.cbGasoline.Size = new System.Drawing.Size(98, 24);
            this.cbGasoline.TabIndex = 14;
            this.cbGasoline.Text = "Gasoline";
            this.cbGasoline.UseVisualStyleBackColor = true;
            this.cbGasoline.CheckedChanged += new System.EventHandler(this.cbGasonline_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fuel:";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(17, 141);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(245, 26);
            this.tbPhoneNumber.TabIndex = 0;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(17, 71);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(245, 28);
            this.cbType.TabIndex = 2;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of Car:";
            // 
            // gbFeatures
            // 
            this.gbFeatures.Controls.Add(this.cbCameraLui);
            this.gbFeatures.Controls.Add(this.cbCanhBaoTocDo);
            this.gbFeatures.Controls.Add(this.cbLopDuPhong);
            this.gbFeatures.Controls.Add(this.cbCamera360);
            this.gbFeatures.Controls.Add(this.cbCamBienVaCham);
            this.gbFeatures.Controls.Add(this.cbDinhViGPS);
            this.gbFeatures.Controls.Add(this.cbKheCamUSB);
            this.gbFeatures.Controls.Add(this.cbNapThungXe);
            this.gbFeatures.Controls.Add(this.cbBlueTooth);
            this.gbFeatures.Controls.Add(this.cbCameraHanhTrinh);
            this.gbFeatures.Controls.Add(this.cbCamBienLop);
            this.gbFeatures.Controls.Add(this.cbCuaSoTroi);
            this.gbFeatures.Controls.Add(this.cbCameraCapLe);
            this.gbFeatures.Controls.Add(this.cbBanDo);
            this.gbFeatures.Location = new System.Drawing.Point(276, 25);
            this.gbFeatures.Name = "gbFeatures";
            this.gbFeatures.Size = new System.Drawing.Size(588, 244);
            this.gbFeatures.TabIndex = 0;
            this.gbFeatures.TabStop = false;
            this.gbFeatures.Text = "Features";
            // 
            // cbCameraLui
            // 
            this.cbCameraLui.AutoSize = true;
            this.cbCameraLui.Location = new System.Drawing.Point(386, 116);
            this.cbCameraLui.Name = "cbCameraLui";
            this.cbCameraLui.Size = new System.Drawing.Size(110, 24);
            this.cbCameraLui.TabIndex = 13;
            this.cbCameraLui.Text = "Camera lùi";
            this.cbCameraLui.UseVisualStyleBackColor = true;
            this.cbCameraLui.CheckedChanged += new System.EventHandler(this.cbCameraLui_CheckedChanged);
            // 
            // cbCanhBaoTocDo
            // 
            this.cbCanhBaoTocDo.AutoSize = true;
            this.cbCanhBaoTocDo.Location = new System.Drawing.Point(386, 161);
            this.cbCanhBaoTocDo.Name = "cbCanhBaoTocDo";
            this.cbCanhBaoTocDo.Size = new System.Drawing.Size(152, 24);
            this.cbCanhBaoTocDo.TabIndex = 12;
            this.cbCanhBaoTocDo.Text = "Cảnh báo tốc độ";
            this.cbCanhBaoTocDo.UseVisualStyleBackColor = true;
            this.cbCanhBaoTocDo.CheckedChanged += new System.EventHandler(this.cbCanhBaoTocDo_CheckedChanged);
            // 
            // cbLopDuPhong
            // 
            this.cbLopDuPhong.AutoSize = true;
            this.cbLopDuPhong.Location = new System.Drawing.Point(386, 36);
            this.cbLopDuPhong.Name = "cbLopDuPhong";
            this.cbLopDuPhong.Size = new System.Drawing.Size(133, 24);
            this.cbLopDuPhong.TabIndex = 11;
            this.cbLopDuPhong.Text = "Lốp dự phòng";
            this.cbLopDuPhong.UseVisualStyleBackColor = true;
            this.cbLopDuPhong.CheckedChanged += new System.EventHandler(this.cbLopDuPhong_CheckedChanged);
            // 
            // cbCamera360
            // 
            this.cbCamera360.AutoSize = true;
            this.cbCamera360.Location = new System.Drawing.Point(386, 75);
            this.cbCamera360.Name = "cbCamera360";
            this.cbCamera360.Size = new System.Drawing.Size(122, 24);
            this.cbCamera360.TabIndex = 10;
            this.cbCamera360.Text = "Camera 360";
            this.cbCamera360.UseVisualStyleBackColor = true;
            this.cbCamera360.CheckedChanged += new System.EventHandler(this.cbCamera360_CheckedChanged);
            // 
            // cbCamBienVaCham
            // 
            this.cbCamBienVaCham.AutoSize = true;
            this.cbCamBienVaCham.Location = new System.Drawing.Point(190, 161);
            this.cbCamBienVaCham.Name = "cbCamBienVaCham";
            this.cbCamBienVaCham.Size = new System.Drawing.Size(165, 24);
            this.cbCamBienVaCham.TabIndex = 9;
            this.cbCamBienVaCham.Text = "Cảm biến va chạm";
            this.cbCamBienVaCham.UseVisualStyleBackColor = true;
            this.cbCamBienVaCham.CheckedChanged += new System.EventHandler(this.cbCamBienVaCham_CheckedChanged);
            // 
            // cbDinhViGPS
            // 
            this.cbDinhViGPS.AutoSize = true;
            this.cbDinhViGPS.Location = new System.Drawing.Point(190, 205);
            this.cbDinhViGPS.Name = "cbDinhViGPS";
            this.cbDinhViGPS.Size = new System.Drawing.Size(120, 24);
            this.cbDinhViGPS.TabIndex = 8;
            this.cbDinhViGPS.Text = "Định vị GPS";
            this.cbDinhViGPS.UseVisualStyleBackColor = true;
            this.cbDinhViGPS.CheckedChanged += new System.EventHandler(this.cbDinhViGPS_CheckedChanged);
            // 
            // cbKheCamUSB
            // 
            this.cbKheCamUSB.AutoSize = true;
            this.cbKheCamUSB.Location = new System.Drawing.Point(18, 205);
            this.cbKheCamUSB.Name = "cbKheCamUSB";
            this.cbKheCamUSB.Size = new System.Drawing.Size(135, 24);
            this.cbKheCamUSB.TabIndex = 7;
            this.cbKheCamUSB.Text = "Khe cắm USB";
            this.cbKheCamUSB.UseVisualStyleBackColor = true;
            this.cbKheCamUSB.CheckedChanged += new System.EventHandler(this.cbKheCamUSB_CheckedChanged);
            // 
            // cbNapThungXe
            // 
            this.cbNapThungXe.AutoSize = true;
            this.cbNapThungXe.Location = new System.Drawing.Point(189, 36);
            this.cbNapThungXe.Name = "cbNapThungXe";
            this.cbNapThungXe.Size = new System.Drawing.Size(181, 24);
            this.cbNapThungXe.TabIndex = 6;
            this.cbNapThungXe.Text = "Nắp thùng xe bán tải";
            this.cbNapThungXe.UseVisualStyleBackColor = true;
            this.cbNapThungXe.CheckedChanged += new System.EventHandler(this.cbNapThungXe_CheckedChanged);
            // 
            // cbBlueTooth
            // 
            this.cbBlueTooth.AutoSize = true;
            this.cbBlueTooth.Location = new System.Drawing.Point(190, 75);
            this.cbBlueTooth.Name = "cbBlueTooth";
            this.cbBlueTooth.Size = new System.Drawing.Size(104, 24);
            this.cbBlueTooth.TabIndex = 5;
            this.cbBlueTooth.Text = "Bluetooth";
            this.cbBlueTooth.UseVisualStyleBackColor = true;
            this.cbBlueTooth.CheckedChanged += new System.EventHandler(this.cbBlueTooth_CheckedChanged);
            // 
            // cbCameraHanhTrinh
            // 
            this.cbCameraHanhTrinh.AutoSize = true;
            this.cbCameraHanhTrinh.Location = new System.Drawing.Point(189, 116);
            this.cbCameraHanhTrinh.Name = "cbCameraHanhTrinh";
            this.cbCameraHanhTrinh.Size = new System.Drawing.Size(166, 24);
            this.cbCameraHanhTrinh.TabIndex = 4;
            this.cbCameraHanhTrinh.Text = "Camera hành trình";
            this.cbCameraHanhTrinh.UseVisualStyleBackColor = true;
            this.cbCameraHanhTrinh.CheckedChanged += new System.EventHandler(this.cbCameraHanhTrinh_CheckedChanged);
            // 
            // cbCamBienLop
            // 
            this.cbCamBienLop.AutoSize = true;
            this.cbCamBienLop.Location = new System.Drawing.Point(18, 116);
            this.cbCamBienLop.Name = "cbCamBienLop";
            this.cbCamBienLop.Size = new System.Drawing.Size(127, 24);
            this.cbCamBienLop.TabIndex = 3;
            this.cbCamBienLop.Text = "Cảm biến lốp";
            this.cbCamBienLop.UseVisualStyleBackColor = true;
            this.cbCamBienLop.CheckedChanged += new System.EventHandler(this.cbCamBienLop_CheckedChanged);
            // 
            // cbCuaSoTroi
            // 
            this.cbCuaSoTroi.AutoSize = true;
            this.cbCuaSoTroi.Location = new System.Drawing.Point(18, 161);
            this.cbCuaSoTroi.Name = "cbCuaSoTroi";
            this.cbCuaSoTroi.Size = new System.Drawing.Size(111, 24);
            this.cbCuaSoTroi.TabIndex = 2;
            this.cbCuaSoTroi.Text = "Cửa sổ trời";
            this.cbCuaSoTroi.UseVisualStyleBackColor = true;
            this.cbCuaSoTroi.CheckedChanged += new System.EventHandler(this.cbCuaSoTroi_CheckedChanged);
            // 
            // cbCameraCapLe
            // 
            this.cbCameraCapLe.AutoSize = true;
            this.cbCameraCapLe.Location = new System.Drawing.Point(18, 75);
            this.cbCameraCapLe.Name = "cbCameraCapLe";
            this.cbCameraCapLe.Size = new System.Drawing.Size(137, 24);
            this.cbCameraCapLe.TabIndex = 1;
            this.cbCameraCapLe.Text = "Camera cập lề";
            this.cbCameraCapLe.UseVisualStyleBackColor = true;
            this.cbCameraCapLe.CheckedChanged += new System.EventHandler(this.cbCameraCapLe_CheckedChanged);
            // 
            // cbBanDo
            // 
            this.cbBanDo.AutoSize = true;
            this.cbBanDo.Location = new System.Drawing.Point(18, 36);
            this.cbBanDo.Name = "cbBanDo";
            this.cbBanDo.Size = new System.Drawing.Size(86, 24);
            this.cbBanDo.TabIndex = 0;
            this.cbBanDo.Text = "Bản đồ";
            this.cbBanDo.UseVisualStyleBackColor = true;
            this.cbBanDo.CheckedChanged += new System.EventHandler(this.cbBanDo_CheckedChanged);
            // 
            // lbNotice
            // 
            this.lbNotice.AutoSize = true;
            this.lbNotice.ForeColor = System.Drawing.Color.Red;
            this.lbNotice.Location = new System.Drawing.Point(19, 615);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(35, 20);
            this.lbNotice.TabIndex = 23;
            this.lbNotice.Text = "abc";
            // 
            // dgv_Car
            // 
            this.dgv_Car.AllowUserToAddRows = false;
            this.dgv_Car.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Car.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Car.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Car.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Car.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.fName,
            this.Brand,
            this.Model,
            this.Reservation,
            this.Type,
            this.Fuel});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Car.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Car.Location = new System.Drawing.Point(23, 416);
            this.dgv_Car.Name = "dgv_Car";
            this.dgv_Car.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Car.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Car.RowHeadersWidth = 62;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Car.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Car.RowTemplate.Height = 28;
            this.dgv_Car.Size = new System.Drawing.Size(878, 196);
            this.dgv_Car.TabIndex = 25;
            this.dgv_Car.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Car_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle3;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // fName
            // 
            this.fName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fName.DataPropertyName = "Name";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fName.DefaultCellStyle = dataGridViewCellStyle4;
            this.fName.HeaderText = "Name";
            this.fName.MinimumWidth = 8;
            this.fName.Name = "fName";
            this.fName.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Brand.DataPropertyName = "Brand";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Brand.DefaultCellStyle = dataGridViewCellStyle5;
            this.Brand.HeaderText = "Brand";
            this.Brand.MinimumWidth = 8;
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Model.DataPropertyName = "Model";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Model.DefaultCellStyle = dataGridViewCellStyle6;
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 8;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Reservation
            // 
            this.Reservation.HeaderText = "Reservation";
            this.Reservation.MinimumWidth = 8;
            this.Reservation.Name = "Reservation";
            this.Reservation.ReadOnly = true;
            this.Reservation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Reservation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Reservation.Text = "Reservation";
            this.Reservation.UseColumnTextForButtonValue = true;
            this.Reservation.Width = 80;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Visible = false;
            this.Type.Width = 150;
            // 
            // Fuel
            // 
            this.Fuel.DataPropertyName = "Fuel";
            this.Fuel.HeaderText = "Fuel";
            this.Fuel.MinimumWidth = 8;
            this.Fuel.Name = "Fuel";
            this.Fuel.ReadOnly = true;
            this.Fuel.Visible = false;
            this.Fuel.Width = 150;
            // 
            // ReservationForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 656);
            this.Controls.Add(this.dgv_Car);
            this.Controls.Add(this.lbNotice);
            this.Controls.Add(this.gbContainer);
            this.Name = "ReservationForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.gbContainer.ResumeLayout(false);
            this.gbContainer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbFeatures.ResumeLayout(false);
            this.gbFeatures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFeatures;
        private System.Windows.Forms.CheckBox cbDiesel;
        private System.Windows.Forms.CheckBox cbElectric;
        private System.Windows.Forms.CheckBox cbGasoline;
        private System.Windows.Forms.CheckBox cbCameraLui;
        private System.Windows.Forms.CheckBox cbCanhBaoTocDo;
        private System.Windows.Forms.CheckBox cbLopDuPhong;
        private System.Windows.Forms.CheckBox cbCamera360;
        private System.Windows.Forms.CheckBox cbCamBienVaCham;
        private System.Windows.Forms.CheckBox cbDinhViGPS;
        private System.Windows.Forms.CheckBox cbKheCamUSB;
        private System.Windows.Forms.CheckBox cbNapThungXe;
        private System.Windows.Forms.CheckBox cbBlueTooth;
        private System.Windows.Forms.CheckBox cbCameraHanhTrinh;
        private System.Windows.Forms.CheckBox cbCamBienLop;
        private System.Windows.Forms.CheckBox cbCuaSoTroi;
        private System.Windows.Forms.CheckBox cbCameraCapLe;
        private System.Windows.Forms.CheckBox cbBanDo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lbNotice;
        private System.Windows.Forms.DataGridView dgv_Car;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewButtonColumn Reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fuel;
    }
}