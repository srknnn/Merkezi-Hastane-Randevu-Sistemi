namespace LoginForm
{
    partial class AppointmentSave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentSave));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstVAppointmentList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cBxSelectDoctor = new System.Windows.Forms.ComboBox();
            this.cBxSelectHospital = new System.Windows.Forms.ComboBox();
            this.cBxSelectClinic = new System.Windows.Forms.ComboBox();
            this.cBxSelectTown = new System.Windows.Forms.ComboBox();
            this.cBxSelectCity = new System.Windows.Forms.ComboBox();
            this.dTPAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearchAppointment = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupAppointment = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLastAppointment = new System.Windows.Forms.Button();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 388);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lstVAppointmentList
            // 
            this.lstVAppointmentList.BackColor = System.Drawing.Color.PowderBlue;
            this.lstVAppointmentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstVAppointmentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstVAppointmentList.FullRowSelect = true;
            this.lstVAppointmentList.Location = new System.Drawing.Point(67, 332);
            this.lstVAppointmentList.Margin = new System.Windows.Forms.Padding(2);
            this.lstVAppointmentList.Name = "lstVAppointmentList";
            this.lstVAppointmentList.Size = new System.Drawing.Size(652, 145);
            this.lstVAppointmentList.TabIndex = 2;
            this.lstVAppointmentList.UseCompatibleStateImageBehavior = false;
            this.lstVAppointmentList.View = System.Windows.Forms.View.Details;
            this.lstVAppointmentList.Visible = false;
            this.lstVAppointmentList.DoubleClick += new System.EventHandler(this.lstVAppointmentList_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hekim";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "En Erken Tarih";
            this.columnHeader2.Width = 190;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kurum Adı ";
            this.columnHeader3.Width = 147;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Klinik Adı ";
            this.columnHeader4.Width = 181;
            // 
            // cBxSelectDoctor
            // 
            this.cBxSelectDoctor.DisplayMember = "FullName";
            this.cBxSelectDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxSelectDoctor.FormattingEnabled = true;
            this.cBxSelectDoctor.Location = new System.Drawing.Point(16, 233);
            this.cBxSelectDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.cBxSelectDoctor.Name = "cBxSelectDoctor";
            this.cBxSelectDoctor.Size = new System.Drawing.Size(195, 21);
            this.cBxSelectDoctor.TabIndex = 5;
            this.cBxSelectDoctor.ValueMember = "Id";
            // 
            // cBxSelectHospital
            // 
            this.cBxSelectHospital.DisplayMember = "HospitalName";
            this.cBxSelectHospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxSelectHospital.FormattingEnabled = true;
            this.cBxSelectHospital.Location = new System.Drawing.Point(16, 147);
            this.cBxSelectHospital.Margin = new System.Windows.Forms.Padding(2);
            this.cBxSelectHospital.Name = "cBxSelectHospital";
            this.cBxSelectHospital.Size = new System.Drawing.Size(195, 21);
            this.cBxSelectHospital.TabIndex = 3;
            this.cBxSelectHospital.ValueMember = "Id";
            this.cBxSelectHospital.SelectedIndexChanged += new System.EventHandler(this.cBxSelectHospital_SelectedIndexChanged);
            // 
            // cBxSelectClinic
            // 
            this.cBxSelectClinic.DisplayMember = "ClinicBranch";
            this.cBxSelectClinic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxSelectClinic.FormattingEnabled = true;
            this.cBxSelectClinic.Location = new System.Drawing.Point(16, 190);
            this.cBxSelectClinic.Margin = new System.Windows.Forms.Padding(2);
            this.cBxSelectClinic.Name = "cBxSelectClinic";
            this.cBxSelectClinic.Size = new System.Drawing.Size(195, 21);
            this.cBxSelectClinic.TabIndex = 4;
            this.cBxSelectClinic.ValueMember = "Id";
            this.cBxSelectClinic.SelectedIndexChanged += new System.EventHandler(this.cBxSelectClinic_SelectedIndexChanged);
            // 
            // cBxSelectTown
            // 
            this.cBxSelectTown.DisplayMember = "TownName";
            this.cBxSelectTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxSelectTown.FormattingEnabled = true;
            this.cBxSelectTown.Location = new System.Drawing.Point(16, 104);
            this.cBxSelectTown.Margin = new System.Windows.Forms.Padding(2);
            this.cBxSelectTown.Name = "cBxSelectTown";
            this.cBxSelectTown.Size = new System.Drawing.Size(195, 21);
            this.cBxSelectTown.TabIndex = 2;
            this.cBxSelectTown.ValueMember = "Id";
            this.cBxSelectTown.SelectedIndexChanged += new System.EventHandler(this.cBxSelectTown_SelectedIndexChanged);
            // 
            // cBxSelectCity
            // 
            this.cBxSelectCity.DisplayMember = "CityName";
            this.cBxSelectCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxSelectCity.FormattingEnabled = true;
            this.cBxSelectCity.Location = new System.Drawing.Point(16, 61);
            this.cBxSelectCity.Margin = new System.Windows.Forms.Padding(2);
            this.cBxSelectCity.Name = "cBxSelectCity";
            this.cBxSelectCity.Size = new System.Drawing.Size(195, 21);
            this.cBxSelectCity.TabIndex = 1;
            this.cBxSelectCity.SelectedIndexChanged += new System.EventHandler(this.cBxSelectCity_SelectedIndexChanged);
            // 
            // dTPAppointmentDate
            // 
            this.dTPAppointmentDate.Location = new System.Drawing.Point(16, 19);
            this.dTPAppointmentDate.Margin = new System.Windows.Forms.Padding(2);
            this.dTPAppointmentDate.Name = "dTPAppointmentDate";
            this.dTPAppointmentDate.Size = new System.Drawing.Size(195, 20);
            this.dTPAppointmentDate.TabIndex = 0;
            // 
            // btnSearchAppointment
            // 
            this.btnSearchAppointment.Location = new System.Drawing.Point(126, 279);
            this.btnSearchAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchAppointment.Name = "btnSearchAppointment";
            this.btnSearchAppointment.Size = new System.Drawing.Size(84, 28);
            this.btnSearchAppointment.TabIndex = 6;
            this.btnSearchAppointment.Text = "Randevu Ara";
            this.btnSearchAppointment.UseVisualStyleBackColor = true;
            this.btnSearchAppointment.Click += new System.EventHandler(this.btnSearchAppointment_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(16, 279);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 28);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupAppointment
            // 
            this.groupAppointment.BackColor = System.Drawing.Color.White;
            this.groupAppointment.Location = new System.Drawing.Point(283, 19);
            this.groupAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.groupAppointment.Name = "groupAppointment";
            this.groupAppointment.Padding = new System.Windows.Forms.Padding(2);
            this.groupAppointment.Size = new System.Drawing.Size(427, 288);
            this.groupAppointment.TabIndex = 19;
            this.groupAppointment.TabStop = false;
            this.groupAppointment.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox2.Location = new System.Drawing.Point(229, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(490, 296);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(226, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "15:00";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(226, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "14:00";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(226, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "13:00";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(226, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "11:00";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(226, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "10:00";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(227, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "09:00";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(227, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "08:00";
            this.label1.Visible = false;
            // 
            // btnLastAppointment
            // 
            this.btnLastAppointment.Location = new System.Drawing.Point(725, 42);
            this.btnLastAppointment.Name = "btnLastAppointment";
            this.btnLastAppointment.Size = new System.Drawing.Size(143, 41);
            this.btnLastAppointment.TabIndex = 8;
            this.btnLastAppointment.Text = "Randevu Geçmişi ";
            this.btnLastAppointment.UseVisualStyleBackColor = true;
            this.btnLastAppointment.Click += new System.EventHandler(this.btnLastAppointment_Click);
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Location = new System.Drawing.Point(748, 25);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(0, 13);
            this.lblDoctorName.TabIndex = 21;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(732, 105);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 36);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(226, 227);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "16:00";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(227, 251);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "17:00";
            this.label9.Visible = false;
            // 
            // AppointmentSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(877, 497);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLastAppointment);
            this.Controls.Add(this.groupAppointment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBxSelectDoctor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBxSelectHospital);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBxSelectClinic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBxSelectTown);
            this.Controls.Add(this.lstVAppointmentList);
            this.Controls.Add(this.cBxSelectCity);
            this.Controls.Add(this.dTPAppointmentDate);
            this.Controls.Add(this.btnSearchAppointment);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AppointmentSave";
            this.Load += new System.EventHandler(this.AppointmentSave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lstVAppointmentList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cBxSelectDoctor;
        private System.Windows.Forms.ComboBox cBxSelectHospital;
        private System.Windows.Forms.ComboBox cBxSelectClinic;
        private System.Windows.Forms.ComboBox cBxSelectTown;
        private System.Windows.Forms.ComboBox cBxSelectCity;
        private System.Windows.Forms.DateTimePicker dTPAppointmentDate;
        private System.Windows.Forms.Button btnSearchAppointment;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupAppointment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLastAppointment;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}