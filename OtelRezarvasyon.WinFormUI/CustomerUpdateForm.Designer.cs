namespace OtelRezarvasyon.WinFormUI
{
    partial class CustomerUpdateForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstCustomerContactUpdate = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddAdress = new System.Windows.Forms.Button();
            this.btnDeleteAdress = new System.Windows.Forms.Button();
            this.txtCustomerIdentity = new System.Windows.Forms.TextBox();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUpdateAdress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(332, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 38);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(51, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstCustomerContactUpdate
            // 
            this.lstCustomerContactUpdate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstCustomerContactUpdate.FullRowSelect = true;
            this.lstCustomerContactUpdate.Location = new System.Drawing.Point(51, 177);
            this.lstCustomerContactUpdate.Name = "lstCustomerContactUpdate";
            this.lstCustomerContactUpdate.Size = new System.Drawing.Size(356, 127);
            this.lstCustomerContactUpdate.TabIndex = 17;
            this.lstCustomerContactUpdate.UseCompatibleStateImageBehavior = false;
            this.lstCustomerContactUpdate.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adres";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tel";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            // 
            // btnAddAdress
            // 
            this.btnAddAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddAdress.Location = new System.Drawing.Point(425, 175);
            this.btnAddAdress.Name = "btnAddAdress";
            this.btnAddAdress.Size = new System.Drawing.Size(83, 37);
            this.btnAddAdress.TabIndex = 15;
            this.btnAddAdress.Text = "Adres Ekle";
            this.btnAddAdress.UseVisualStyleBackColor = true;
            this.btnAddAdress.Click += new System.EventHandler(this.btnAddAdress_Click);
            // 
            // btnDeleteAdress
            // 
            this.btnDeleteAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteAdress.Location = new System.Drawing.Point(425, 220);
            this.btnDeleteAdress.Name = "btnDeleteAdress";
            this.btnDeleteAdress.Size = new System.Drawing.Size(83, 37);
            this.btnDeleteAdress.TabIndex = 15;
            this.btnDeleteAdress.Text = "Adres Sil";
            this.btnDeleteAdress.UseVisualStyleBackColor = true;
            this.btnDeleteAdress.Click += new System.EventHandler(this.btnDeleteAdress_Click);
            // 
            // txtCustomerIdentity
            // 
            this.txtCustomerIdentity.Location = new System.Drawing.Point(307, 146);
            this.txtCustomerIdentity.MaxLength = 11;
            this.txtCustomerIdentity.Name = "txtCustomerIdentity";
            this.txtCustomerIdentity.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerIdentity.TabIndex = 21;
            this.txtCustomerIdentity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerIdentity_KeyPress);
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(307, 108);
            this.txtCustomerLastName.MaxLength = 10;
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerLastName.TabIndex = 22;
            this.txtCustomerLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerLastName_KeyPress);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(307, 68);
            this.txtCustomerName.MaxLength = 10;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 23;
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(48, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "TCKimlikNo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(48, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Soyadı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(48, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(174, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "MÜŞTERİ GÜNCELLE";
            // 
            // BtnUpdateAdress
            // 
            this.BtnUpdateAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdateAdress.Location = new System.Drawing.Point(425, 265);
            this.BtnUpdateAdress.Name = "BtnUpdateAdress";
            this.BtnUpdateAdress.Size = new System.Drawing.Size(83, 39);
            this.BtnUpdateAdress.TabIndex = 25;
            this.BtnUpdateAdress.Text = "Adres Güncelle";
            this.BtnUpdateAdress.UseVisualStyleBackColor = true;
            this.BtnUpdateAdress.Click += new System.EventHandler(this.BtnUpdateAdress_Click);
            // 
            // CustomerUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 424);
            this.ControlBox = false;
            this.Controls.Add(this.BtnUpdateAdress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerIdentity);
            this.Controls.Add(this.txtCustomerLastName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstCustomerContactUpdate);
            this.Controls.Add(this.btnDeleteAdress);
            this.Controls.Add(this.btnAddAdress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "CustomerUpdateForm";
            this.Text = "MÜŞTERİ GÜNCELLEME İŞLEMLERİ";
            this.Load += new System.EventHandler(this.CustomerUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lstCustomerContactUpdate;
        private System.Windows.Forms.Button btnAddAdress;
        private System.Windows.Forms.Button btnDeleteAdress;
        private System.Windows.Forms.TextBox txtCustomerIdentity;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnUpdateAdress;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}