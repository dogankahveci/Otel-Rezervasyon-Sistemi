namespace OtelRezarvasyon.WinFormUI
{
    partial class CustomerAddForReservationForm
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
            this.flpCustomers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpCustomers
            // 
            this.flpCustomers.AutoScroll = true;
            this.flpCustomers.Location = new System.Drawing.Point(0, 0);
            this.flpCustomers.Name = "flpCustomers";
            this.flpCustomers.Size = new System.Drawing.Size(599, 359);
            this.flpCustomers.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(485, 377);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Tamam";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // CustomerAddForReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 412);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.flpCustomers);
            this.Name = "CustomerAddForReservationForm";
            this.Text = "CustomerAddForReservationForm";
            this.Load += new System.EventHandler(this.CustomerAddForReservationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCustomers;
        private System.Windows.Forms.Button btnOk;
    }
}