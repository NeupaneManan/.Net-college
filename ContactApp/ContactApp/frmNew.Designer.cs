namespace ContactApp
{
    partial class frmNew
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.Label();
            this.cmbAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 59);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(299, 178);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(362, 22);
            this.textBox3.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(165, 68);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(48, 16);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "Name";
            // 
            // cmbAddress
            // 
            this.cmbAddress.AutoSize = true;
            this.cmbAddress.Location = new System.Drawing.Point(165, 126);
            this.cmbAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Size = new System.Drawing.Size(65, 16);
            this.cmbAddress.TabIndex = 5;
            this.cmbAddress.Text = "Address";
            this.cmbAddress.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.AutoSize = true;
            this.txtPhone.Location = new System.Drawing.Point(165, 182);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(113, 16);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.Text = "Phone Number:";
            this.txtPhone.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(299, 126);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(362, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(299, 238);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 39);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(467, 238);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 39);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.cmbAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1216, 593);
            this.Name = "frmNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Contact";
            this.Load += new System.EventHandler(this.frmNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label cmbAddress;
        private System.Windows.Forms.Label txtPhone;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
    }
}