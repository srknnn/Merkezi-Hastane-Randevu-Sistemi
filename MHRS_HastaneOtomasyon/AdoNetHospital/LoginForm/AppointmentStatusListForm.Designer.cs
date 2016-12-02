namespace LoginForm
{
    partial class AppointmentStatusListForm
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
            this.btnAppointCancel = new System.Windows.Forms.Button();
            this.btnBackForm = new System.Windows.Forms.Button();
            this.dgvAppointmenList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmenList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAppointCancel
            // 
            this.btnAppointCancel.Location = new System.Drawing.Point(514, 265);
            this.btnAppointCancel.Name = "btnAppointCancel";
            this.btnAppointCancel.Size = new System.Drawing.Size(247, 34);
            this.btnAppointCancel.TabIndex = 5;
            this.btnAppointCancel.Text = "Randevu İptal Et";
            this.btnAppointCancel.UseVisualStyleBackColor = true;
            this.btnAppointCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBackForm
            // 
            this.btnBackForm.Location = new System.Drawing.Point(12, 265);
            this.btnBackForm.Name = "btnBackForm";
            this.btnBackForm.Size = new System.Drawing.Size(248, 34);
            this.btnBackForm.TabIndex = 6;
            this.btnBackForm.Text = "Randevu Ekranına Geri Dön";
            this.btnBackForm.UseVisualStyleBackColor = true;
            this.btnBackForm.Click += new System.EventHandler(this.btnBackForm_Click);
            // 
            // dgvAppointmenList
            // 
            this.dgvAppointmenList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmenList.Location = new System.Drawing.Point(12, 40);
            this.dgvAppointmenList.Name = "dgvAppointmenList";
            this.dgvAppointmenList.Size = new System.Drawing.Size(749, 219);
            this.dgvAppointmenList.TabIndex = 9;
            this.dgvAppointmenList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAppointmenList_CellMouseClick);
            this.dgvAppointmenList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAppointmenList_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Randevu Listeniz";
            // 
            // AppointmentStatusListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(792, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAppointmenList);
            this.Controls.Add(this.btnBackForm);
            this.Controls.Add(this.btnAppointCancel);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AppointmentStatusListForm";
            this.Text = "LastAppointmentList";
            this.Load += new System.EventHandler(this.AppointmentStatusListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmenList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAppointCancel;
        private System.Windows.Forms.Button btnBackForm;
        private System.Windows.Forms.DataGridView dgvAppointmenList;
        private System.Windows.Forms.Label label1;
    }
}