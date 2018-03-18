namespace OtelRezarvasyon.WinFormUI
{
    partial class CustomerAddForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.txtCustomerIdentity = new System.Windows.Forms.TextBox();
            this.btnCustomerSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.btnAddAdress = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstViewCustContact = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.rdMan = new System.Windows.Forms.RadioButton();
            this.rdWoman = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(104, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(104, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(104, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "TCKimlikNo:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(262, 66);
            this.txtCustomerName.MaxLength = 10;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(262, 94);
            this.txtCustomerLastName.MaxLength = 10;
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerLastName.TabIndex = 1;
            this.txtCustomerLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerLastName_KeyPress);
            // 
            // txtCustomerIdentity
            // 
            this.txtCustomerIdentity.Location = new System.Drawing.Point(262, 122);
            this.txtCustomerIdentity.MaxLength = 11;
            this.txtCustomerIdentity.Name = "txtCustomerIdentity";
            this.txtCustomerIdentity.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerIdentity.TabIndex = 2;
            this.txtCustomerIdentity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerIdentity_KeyPress);
            // 
            // btnCustomerSave
            // 
            this.btnCustomerSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerSave.Location = new System.Drawing.Point(107, 314);
            this.btnCustomerSave.Name = "btnCustomerSave";
            this.btnCustomerSave.Size = new System.Drawing.Size(75, 41);
            this.btnCustomerSave.TabIndex = 4;
            this.btnCustomerSave.Text = "Kaydet";
            this.btnCustomerSave.UseVisualStyleBackColor = true;
            this.btnCustomerSave.Click += new System.EventHandler(this.btnCustomerSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCancel.Location = new System.Drawing.Point(289, 314);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 41);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "İptal";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnAddAdress
            // 
            this.btnAddAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddAdress.Location = new System.Drawing.Point(418, 171);
            this.btnAddAdress.Name = "btnAddAdress";
            this.btnAddAdress.Size = new System.Drawing.Size(75, 44);
            this.btnAddAdress.TabIndex = 3;
            this.btnAddAdress.Text = "Adres Ekle";
            this.btnAddAdress.UseVisualStyleBackColor = true;
            this.btnAddAdress.Click += new System.EventHandler(this.btnAdress_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(135, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "MÜŞTERİ KAYIT İŞLEMLERİ";
            // 
            // lstViewCustContact
            // 
            this.lstViewCustContact.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstViewCustContact.FullRowSelect = true;
            this.lstViewCustContact.Location = new System.Drawing.Point(108, 195);
            this.lstViewCustContact.Name = "lstViewCustContact";
            this.lstViewCustContact.Size = new System.Drawing.Size(256, 97);
            this.lstViewCustContact.TabIndex = 6;
            this.lstViewCustContact.UseCompatibleStateImageBehavior = false;
            this.lstViewCustContact.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adres";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tel";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(105, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cinsiyet";
            // 
            // rdMan
            // 
            this.rdMan.AutoSize = true;
            this.rdMan.Location = new System.Drawing.Point(255, 162);
            this.rdMan.Name = "rdMan";
            this.rdMan.Size = new System.Drawing.Size(53, 17);
            this.rdMan.TabIndex = 8;
            this.rdMan.TabStop = true;
            this.rdMan.Text = "Erkek";
            this.rdMan.UseVisualStyleBackColor = true;
            // 
            // rdWoman
            // 
            this.rdWoman.AutoSize = true;
            this.rdWoman.Location = new System.Drawing.Point(315, 162);
            this.rdWoman.Name = "rdWoman";
            this.rdWoman.Size = new System.Drawing.Size(55, 17);
            this.rdWoman.TabIndex = 9;
            this.rdWoman.TabStop = true;
            this.rdWoman.Text = "Bayan";
            this.rdWoman.UseVisualStyleBackColor = true;
            // 
            // CustomerAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 424);
            this.ControlBox = false;
            this.Controls.Add(this.rdWoman);
            this.Controls.Add(this.rdMan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstViewCustContact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddAdress);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.btnCustomerSave);
            this.Controls.Add(this.txtCustomerIdentity);
            this.Controls.Add(this.txtCustomerLastName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerAddForm";
            this.Text = "MÜŞTERİ KAYIT İŞLEMLERİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.TextBox txtCustomerIdentity;
        private System.Windows.Forms.Button btnCustomerSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button btnAddAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstViewCustContact;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdMan;
        private System.Windows.Forms.RadioButton rdWoman;
    }
}