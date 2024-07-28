namespace ManagementSystem
{
    partial class AddSalesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.ListView lvBooks;
        private System.Windows.Forms.ListView lvCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnFinalizePurchase;
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblCart;

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
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.lvBooks = new System.Windows.Forms.ListView();
            this.lvCart = new System.Windows.Forms.ListView();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnFinalizePurchase = new System.Windows.Forms.Button();
            this.lblClients = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.lblBookInfo = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(854, 100);
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
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Sales";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(811, 8);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // cmbClients
            // 
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(110, 120);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(200, 25);
            this.cmbClients.TabIndex = 3;
            // 
            // lvBooks
            // 
            this.lvBooks.HideSelection = false;
            this.lvBooks.Location = new System.Drawing.Point(110, 200);
            this.lvBooks.Name = "lvBooks";
            this.lvBooks.Size = new System.Drawing.Size(600, 150);
            this.lvBooks.TabIndex = 4;
            this.lvBooks.UseCompatibleStateImageBehavior = false;
            this.lvBooks.View = System.Windows.Forms.View.Details;
            this.lvBooks.Columns.Add("Id", 50);
            this.lvBooks.Columns.Add("Title", 200);
            this.lvBooks.Columns.Add("Author", 150);
            this.lvBooks.Columns.Add("Publish Date", 100);
            this.lvBooks.Columns.Add("Price", 100);
            // 
            // lvCart
            // 
            this.lvCart.HideSelection = false;
            this.lvCart.Location = new System.Drawing.Point(110, 420);
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(600, 150);
            this.lvCart.TabIndex = 5;
            this.lvCart.UseCompatibleStateImageBehavior = false;
            this.lvCart.View = System.Windows.Forms.View.Details;
            this.lvCart.Columns.Add("Book Id", 50);
            this.lvCart.Columns.Add("Title", 200);
            this.lvCart.Columns.Add("Quantity", 100);
            this.lvCart.Columns.Add("Unit Price", 100);
            this.lvCart.Columns.Add("Total Price", 100);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(720, 319);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(100, 30);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnFinalizePurchase
            // 
            this.btnFinalizePurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnFinalizePurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizePurchase.FlatAppearance.BorderSize = 0;
            this.btnFinalizePurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizePurchase.ForeColor = System.Drawing.Color.White;
            this.btnFinalizePurchase.Location = new System.Drawing.Point(720, 420);
            this.btnFinalizePurchase.Name = "btnFinalizePurchase";
            this.btnFinalizePurchase.Size = new System.Drawing.Size(100, 30);
            this.btnFinalizePurchase.TabIndex = 7;
            this.btnFinalizePurchase.Text = "Finalize";
            this.btnFinalizePurchase.UseVisualStyleBackColor = false;
            this.btnFinalizePurchase.Click += new System.EventHandler(this.btnFinalizePurchase_Click);
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Location = new System.Drawing.Point(30, 120);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(47, 17);
            this.lblClients.TabIndex = 8;
            this.lblClients.Text = "Clients";
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Location = new System.Drawing.Point(30, 200);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(45, 17);
            this.lblBooks.TabIndex = 9;
            this.lblBooks.Text = "Books";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Location = new System.Drawing.Point(30, 420);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(34, 17);
            this.lblCart.TabIndex = 10;
            this.lblCart.Text = "Cart";
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnSearchBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchBook.FlatAppearance.BorderSize = 0;
            this.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBook.ForeColor = System.Drawing.Color.White;
            this.btnSearchBook.Location = new System.Drawing.Point(720, 267);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(100, 30);
            this.btnSearchBook.TabIndex = 11;
            this.btnSearchBook.Text = "Search Book";
            this.btnSearchBook.UseVisualStyleBackColor = false;
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Location = new System.Drawing.Point(720, 220);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(100, 24);
            this.txtSearchBook.TabIndex = 12;
            // 
            // lblBookInfo
            // 
            this.lblBookInfo.AutoSize = true;
            this.lblBookInfo.Location = new System.Drawing.Point(717, 200);
            this.lblBookInfo.Name = "lblBookInfo";
            this.lblBookInfo.Size = new System.Drawing.Size(67, 17);
            this.lblBookInfo.TabIndex = 13;
            this.lblBookInfo.Text = "Book Info";
            // 
            // AddSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 600);
            this.Controls.Add(this.lblBookInfo);
            this.Controls.Add(this.txtSearchBook);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.lblClients);
            this.Controls.Add(this.btnFinalizePurchase);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lvCart);
            this.Controls.Add(this.lvBooks);
            this.Controls.Add(this.cmbClients);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.Label lblBookInfo;
    }
}
