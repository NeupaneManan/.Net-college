﻿namespace DesktopAppWithCrud
{
    partial class NewStudentsForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of Birth";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(526, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(111, 86);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(526, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(111, 134);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(242, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // dtpDoB
            // 
            this.dtpDoB.Location = new System.Drawing.Point(111, 177);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(366, 20);
            this.dtpDoB.TabIndex = 8;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(42, 240);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(153, 45);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // NewStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 350);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dtpDoB);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewStudentsForm";
            this.Text = "NewStudentsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button button2;
    }
}