namespace BackOffice
{
    partial class frmCustomerMain
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
            this.txtboxFilter = new System.Windows.Forms.TextBox();
            this.lstCus = new System.Windows.Forms.ListBox();
            this.btnLastName = new System.Windows.Forms.Button();
            this.btnPostCode = new System.Windows.Forms.Button();
            this.lblCustomerDetail = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxFilter
            // 
            this.txtboxFilter.BackColor = System.Drawing.Color.PeachPuff;
            this.txtboxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFilter.Location = new System.Drawing.Point(30, 331);
            this.txtboxFilter.Name = "txtboxFilter";
            this.txtboxFilter.Size = new System.Drawing.Size(214, 30);
            this.txtboxFilter.TabIndex = 0;
            // 
            // lstCus
            // 
            this.lstCus.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lstCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCus.FormattingEnabled = true;
            this.lstCus.ItemHeight = 25;
            this.lstCus.Location = new System.Drawing.Point(30, 54);
            this.lstCus.Name = "lstCus";
            this.lstCus.Size = new System.Drawing.Size(585, 254);
            this.lstCus.TabIndex = 1;
            // 
            // btnLastName
            // 
            this.btnLastName.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastName.ForeColor = System.Drawing.Color.Black;
            this.btnLastName.Location = new System.Drawing.Point(30, 384);
            this.btnLastName.Name = "btnLastName";
            this.btnLastName.Size = new System.Drawing.Size(214, 39);
            this.btnLastName.TabIndex = 2;
            this.btnLastName.Text = "Filter by LastName";
            this.btnLastName.UseVisualStyleBackColor = false;
            // 
            // btnPostCode
            // 
            this.btnPostCode.BackColor = System.Drawing.Color.Tan;
            this.btnPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostCode.Location = new System.Drawing.Point(30, 442);
            this.btnPostCode.Name = "btnPostCode";
            this.btnPostCode.Size = new System.Drawing.Size(214, 39);
            this.btnPostCode.TabIndex = 3;
            this.btnPostCode.Text = "Filter by PostCode";
            this.btnPostCode.UseVisualStyleBackColor = false;
            // 
            // lblCustomerDetail
            // 
            this.lblCustomerDetail.AutoSize = true;
            this.lblCustomerDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerDetail.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCustomerDetail.Location = new System.Drawing.Point(200, 9);
            this.lblCustomerDetail.Name = "lblCustomerDetail";
            this.lblCustomerDetail.Size = new System.Drawing.Size(270, 29);
            this.lblCustomerDetail.TabIndex = 4;
            this.lblCustomerDetail.Text = "Display Customer Detail";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnAddCustomer.Location = new System.Drawing.Point(633, 54);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(214, 39);
            this.btnAddCustomer.TabIndex = 5;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnEditCustomer.Location = new System.Drawing.Point(633, 167);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(214, 39);
            this.btnEditCustomer.TabIndex = 6;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(633, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Delete Customer";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.BackColor = System.Drawing.Color.Orange;
            this.btnDisplayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAll.ForeColor = System.Drawing.Color.Black;
            this.btnDisplayAll.Location = new System.Drawing.Point(633, 442);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(214, 39);
            this.btnDisplayAll.TabIndex = 8;
            this.btnDisplayAll.Text = "Display All";
            this.btnDisplayAll.UseVisualStyleBackColor = false;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(443, 331);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(73, 25);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "lblError";
            // 
            // frmCustomerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(859, 526);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnDisplayAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblCustomerDetail);
            this.Controls.Add(this.btnPostCode);
            this.Controls.Add(this.btnLastName);
            this.Controls.Add(this.lstCus);
            this.Controls.Add(this.txtboxFilter);
            this.Name = "frmCustomerMain";
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.frmCustomerMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxFilter;
        private System.Windows.Forms.ListBox lstCus;
        private System.Windows.Forms.Button btnLastName;
        private System.Windows.Forms.Button btnPostCode;
        private System.Windows.Forms.Label lblCustomerDetail;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Label lblError;
    }
}