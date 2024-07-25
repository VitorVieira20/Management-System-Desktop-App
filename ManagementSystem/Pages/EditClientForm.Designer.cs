namespace ManagementSystem.Pages
{
    partial class EditClientForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddres;

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
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.lblNif = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(110, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(235, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(110, 150);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(30, 150);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 16);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone";
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(110, 110);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(200, 22);
            this.txtNif.TabIndex = 7;
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(30, 110);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(28, 16);
            this.lblNif.TabIndex = 6;
            this.lblNif.Text = "NIF";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(110, 190);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 22);
            this.txtAddress.TabIndex = 11;
            // 
            // lblAddres
            // 
            this.lblAddres.AutoSize = true;
            this.lblAddres.Location = new System.Drawing.Point(30, 190);
            this.lblAddres.Name = "lblAddres";
            this.lblAddres.Size = new System.Drawing.Size(58, 16);
            this.lblAddres.TabIndex = 10;
            this.lblAddres.Text = "Address";
            // 
            // EditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 270);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddres);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.lblNif);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "EditClientForm";
            this.Text = "Edit Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
