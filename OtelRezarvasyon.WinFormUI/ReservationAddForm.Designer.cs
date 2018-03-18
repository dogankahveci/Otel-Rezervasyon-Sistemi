namespace OtelRezarvasyon.WinFormUI
{
    partial class ReservationAddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEntiringDate = new System.Windows.Forms.DateTimePicker();
            this.dtpLeavingDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonCount = new System.Windows.Forms.TextBox();
            this.btnRoomSelect = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomerIdentity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giriş-cıkış Tarihleri";
            // 
            // dtpEntiringDate
            // 
            this.dtpEntiringDate.Location = new System.Drawing.Point(139, 46);
            this.dtpEntiringDate.Name = "dtpEntiringDate";
            this.dtpEntiringDate.Size = new System.Drawing.Size(194, 20);
            this.dtpEntiringDate.TabIndex = 1;
            // 
            // dtpLeavingDate
            // 
            this.dtpLeavingDate.Location = new System.Drawing.Point(373, 46);
            this.dtpLeavingDate.Name = "dtpLeavingDate";
            this.dtpLeavingDate.Size = new System.Drawing.Size(194, 20);
            this.dtpLeavingDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Konaklayacak-KişiSayısı";
            // 
            // txtPersonCount
            // 
            this.txtPersonCount.Location = new System.Drawing.Point(213, 84);
            this.txtPersonCount.MaxLength = 2;
            this.txtPersonCount.Name = "txtPersonCount";
            this.txtPersonCount.Size = new System.Drawing.Size(116, 20);
            this.txtPersonCount.TabIndex = 4;
            this.txtPersonCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonCount_KeyPress);
            // 
            // btnRoomSelect
            // 
            this.btnRoomSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRoomSelect.Location = new System.Drawing.Point(397, 81);
            this.btnRoomSelect.Name = "btnRoomSelect";
            this.btnRoomSelect.Size = new System.Drawing.Size(66, 39);
            this.btnRoomSelect.TabIndex = 6;
            this.btnRoomSelect.Text = "Oda Seç";
            this.btnRoomSelect.UseVisualStyleBackColor = true;
            this.btnRoomSelect.Click += new System.EventHandler(this.btnRoomSelect_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.Location = new System.Drawing.Point(230, 291);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(87, 53);
            this.addCustomer.TabIndex = 8;
            this.addCustomer.Text = "Konaklayan  Ekle";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(213, 123);
            this.txtTotalPrice.MaxLength = 4;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(116, 20);
            this.txtTotalPrice.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ToplamFiyat";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(42, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 46);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(413, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 46);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(213, 164);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(116, 20);
            this.txtCustomerName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Adı";
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(213, 206);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(116, 20);
            this.txtCustomerLastName.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(14, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Soyadı";
            // 
            // txtCustomerIdentity
            // 
            this.txtCustomerIdentity.Location = new System.Drawing.Point(213, 253);
            this.txtCustomerIdentity.Name = "txtCustomerIdentity";
            this.txtCustomerIdentity.Size = new System.Drawing.Size(116, 20);
            this.txtCustomerIdentity.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(14, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "TcKimlikNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(122, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "REZERVASYON EKLEME İŞLEMLERİ";
            // 
            // ReservationAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 424);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerIdentity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCustomerLastName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.btnRoomSelect);
            this.Controls.Add(this.txtPersonCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpLeavingDate);
            this.Controls.Add(this.dtpEntiringDate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "ReservationAddForm";
            this.Text = "ReservationAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEntiringDate;
        private System.Windows.Forms.DateTimePicker dtpLeavingDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonCount;
        private System.Windows.Forms.Button btnRoomSelect;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustomerIdentity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
    }
}