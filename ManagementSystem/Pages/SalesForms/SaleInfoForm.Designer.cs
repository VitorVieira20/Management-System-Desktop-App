namespace ManagementSystem.Pages.SalesForms
{
    partial class SaleInfoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.ListView lvSaleItems;
        private System.Windows.Forms.Label lblClientNameValue;
        private System.Windows.Forms.Label lblSaleDateValue;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Button btnExportToExcel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lvSaleItems = new System.Windows.Forms.ListView();
            this.lblClientNameValue = new System.Windows.Forms.Label();
            this.lblSaleDateValue = new System.Windows.Forms.Label();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();

            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::ManagementSystem.Properties.Resources.open_book;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sale Details";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(765, 8);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(30, 120);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(85, 17);
            this.lblClientName.TabIndex = 3;
            this.lblClientName.Text = "Client Name:";
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.Location = new System.Drawing.Point(30, 160);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(71, 17);
            this.lblSaleDate.TabIndex = 4;
            this.lblSaleDate.Text = "Sale Date:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(30, 200);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(91, 17);
            this.lblTotalAmount.TabIndex = 5;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // lvSaleItems
            // 
            this.lvSaleItems.HideSelection = false;
            this.lvSaleItems.Location = new System.Drawing.Point(30, 240);
            this.lvSaleItems.Name = "lvSaleItems";
            this.lvSaleItems.Size = new System.Drawing.Size(740, 300);
            this.lvSaleItems.TabIndex = 6;
            this.lvSaleItems.UseCompatibleStateImageBehavior = false;
            this.lvSaleItems.View = System.Windows.Forms.View.Details;
            this.lvSaleItems.Columns.Add("Book Id", 50);
            this.lvSaleItems.Columns.Add("Title", 200);
            this.lvSaleItems.Columns.Add("Quantity", 50);
            this.lvSaleItems.Columns.Add("Unit Price", 100);
            this.lvSaleItems.Columns.Add("Total Price", 100);
            // 
            // lblClientNameValue
            // 
            this.lblClientNameValue.AutoSize = true;
            this.lblClientNameValue.Location = new System.Drawing.Point(150, 120);
            this.lblClientNameValue.Name = "lblClientNameValue";
            this.lblClientNameValue.Size = new System.Drawing.Size(0, 17);
            this.lblClientNameValue.TabIndex = 7;
            // 
            // lblSaleDateValue
            // 
            this.lblSaleDateValue.AutoSize = true;
            this.lblSaleDateValue.Location = new System.Drawing.Point(150, 160);
            this.lblSaleDateValue.Name = "lblSaleDateValue";
            this.lblSaleDateValue.Size = new System.Drawing.Size(0, 17);
            this.lblSaleDateValue.TabIndex = 8;
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.Location = new System.Drawing.Point(150, 200);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(0, 17);
            this.lblTotalAmountValue.TabIndex = 9;
            // 
            // btnExportToExcel
            //
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnExportToExcel.Location = new System.Drawing.Point(30, 560);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(150, 30);
            this.btnExportToExcel.TabIndex = 10;
            this.btnExportToExcel.Text = "Export to Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // SaleInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblTotalAmountValue);
            this.Controls.Add(this.lblSaleDateValue);
            this.Controls.Add(this.lblClientNameValue);
            this.Controls.Add(this.lvSaleItems);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblSaleDate);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExportToExcel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleInfoForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Load += new System.EventHandler(this.SaleInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void exit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
