namespace Rental_Car_System
{
    partial class CarForm
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
            this.gbContainer = new System.Windows.Forms.GroupBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.cbElectric = new System.Windows.Forms.CheckBox();
            this.cbDiesel = new System.Windows.Forms.CheckBox();
            this.cbGasoline = new System.Windows.Forms.CheckBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbNotice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbHiring = new System.Windows.Forms.CheckBox();
            this.gbContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbContainer
            // 
            this.gbContainer.Controls.Add(this.cbHiring);
            this.gbContainer.Controls.Add(this.label7);
            this.gbContainer.Controls.Add(this.tbPrice);
            this.gbContainer.Controls.Add(this.label4);
            this.gbContainer.Controls.Add(this.tbModel);
            this.gbContainer.Controls.Add(this.label1);
            this.gbContainer.Controls.Add(this.btnBrowser);
            this.gbContainer.Controls.Add(this.cbElectric);
            this.gbContainer.Controls.Add(this.cbDiesel);
            this.gbContainer.Controls.Add(this.cbGasoline);
            this.gbContainer.Controls.Add(this.cbType);
            this.gbContainer.Controls.Add(this.cbBrand);
            this.gbContainer.Controls.Add(this.tbName);
            this.gbContainer.Controls.Add(this.label6);
            this.gbContainer.Controls.Add(this.label5);
            this.gbContainer.Controls.Add(this.label3);
            this.gbContainer.Controls.Add(this.label2);
            this.gbContainer.Controls.Add(this.pbImage);
            this.gbContainer.Location = new System.Drawing.Point(12, 27);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Size = new System.Drawing.Size(882, 391);
            this.gbContainer.TabIndex = 2;
            this.gbContainer.TabStop = false;
            this.gbContainer.Text = "Car information";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(677, 132);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(174, 26);
            this.tbPrice.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(673, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Price:";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(483, 199);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(166, 26);
            this.tbModel.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Model:";
            // 
            // btnBrowser
            // 
            this.btnBrowser.BackgroundImage = global::Rental_Car_System.Properties.Resources.icon_camera;
            this.btnBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBrowser.Location = new System.Drawing.Point(428, 331);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(30, 30);
            this.btnBrowser.TabIndex = 15;
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // cbElectric
            // 
            this.cbElectric.AutoSize = true;
            this.cbElectric.Location = new System.Drawing.Point(591, 337);
            this.cbElectric.Name = "cbElectric";
            this.cbElectric.Size = new System.Drawing.Size(87, 24);
            this.cbElectric.TabIndex = 13;
            this.cbElectric.Text = "Electric";
            this.cbElectric.UseVisualStyleBackColor = true;
            this.cbElectric.CheckedChanged += new System.EventHandler(this.cbDien_CheckedChanged);
            // 
            // cbDiesel
            // 
            this.cbDiesel.AutoSize = true;
            this.cbDiesel.Location = new System.Drawing.Point(701, 337);
            this.cbDiesel.Name = "cbDiesel";
            this.cbDiesel.Size = new System.Drawing.Size(101, 24);
            this.cbDiesel.TabIndex = 12;
            this.cbDiesel.Text = "Diesel Oil";
            this.cbDiesel.UseVisualStyleBackColor = true;
            this.cbDiesel.CheckedChanged += new System.EventHandler(this.cbDiesel_CheckedChanged);
            // 
            // cbGasoline
            // 
            this.cbGasoline.AutoSize = true;
            this.cbGasoline.Location = new System.Drawing.Point(483, 337);
            this.cbGasoline.Name = "cbGasoline";
            this.cbGasoline.Size = new System.Drawing.Size(98, 24);
            this.cbGasoline.TabIndex = 11;
            this.cbGasoline.Text = "Gasoline";
            this.cbGasoline.UseVisualStyleBackColor = true;
            this.cbGasoline.CheckedChanged += new System.EventHandler(this.cbXang_CheckedChanged);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(483, 264);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(368, 28);
            this.cbType.TabIndex = 10;
            // 
            // cbBrand
            // 
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(483, 130);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(166, 28);
            this.cbBrand.TabIndex = 9;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(483, 60);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(368, 26);
            this.tbName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fuel: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Brand: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbImage.Image = global::Rental_Car_System.Properties.Resources.car_default;
            this.pbImage.Location = new System.Drawing.Point(17, 37);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(441, 324);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(791, 424);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 40);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbNotice
            // 
            this.lbNotice.AutoSize = true;
            this.lbNotice.ForeColor = System.Drawing.Color.Red;
            this.lbNotice.Location = new System.Drawing.Point(18, 424);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(0, 20);
            this.lbNotice.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(673, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Status:";
            // 
            // cbHiring
            // 
            this.cbHiring.AutoSize = true;
            this.cbHiring.Location = new System.Drawing.Point(677, 201);
            this.cbHiring.Name = "cbHiring";
            this.cbHiring.Size = new System.Drawing.Size(93, 24);
            this.cbHiring.TabIndex = 21;
            this.cbHiring.Text = "Is Hiring";
            this.cbHiring.UseVisualStyleBackColor = true;
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 487);
            this.Controls.Add(this.lbNotice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbContainer);
            this.Name = "CarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarForm";
            this.Load += new System.EventHandler(this.CarForm_Load);
            this.gbContainer.ResumeLayout(false);
            this.gbContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContainer;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.CheckBox cbElectric;
        private System.Windows.Forms.CheckBox cbDiesel;
        private System.Windows.Forms.CheckBox cbGasoline;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Label lbNotice;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbHiring;
        private System.Windows.Forms.Label label7;
    }
}