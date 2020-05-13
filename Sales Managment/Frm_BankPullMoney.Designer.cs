﻿namespace Sales_Managment
{
    partial class Frm_BankPullMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BankPullMoney));
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtreason = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NudPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnAdd.Location = new System.Drawing.Point(161, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(195, 53);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "اضافة ";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(63, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 28);
            this.label7.TabIndex = 45;
            this.label7.Text = "سبب السحب:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(61, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 28);
            this.label6.TabIndex = 44;
            this.label6.Text = "اسم الساحب:";
            // 
            // txtreason
            // 
            this.txtreason.Location = new System.Drawing.Point(161, 216);
            this.txtreason.Multiline = true;
            this.txtreason.Name = "txtreason";
            this.txtreason.Size = new System.Drawing.Size(195, 73);
            this.txtreason.TabIndex = 43;
            this.txtreason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(161, 171);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 36);
            this.txtName.TabIndex = 42;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(61, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 28);
            this.label4.TabIndex = 41;
            this.label4.Text = "تاريخ السحب:";
            // 
            // DtpDate
            // 
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDate.Location = new System.Drawing.Point(161, 119);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(195, 36);
            this.DtpDate.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 28);
            this.label2.TabIndex = 39;
            this.label2.Text = "المبلغ المراد سحبه:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.ForeColor = System.Drawing.Color.Red;
            this.lblMoney.Location = new System.Drawing.Point(228, 15);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(27, 28);
            this.lblMoney.TabIndex = 38;
            this.lblMoney.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 36);
            this.label3.TabIndex = 37;
            this.label3.Text = "رصيد البنك الحالى هو:";
            // 
            // NudPrice
            // 
            this.NudPrice.DecimalPlaces = 2;
            this.NudPrice.Location = new System.Drawing.Point(161, 64);
            this.NudPrice.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.NudPrice.Name = "NudPrice";
            this.NudPrice.Size = new System.Drawing.Size(195, 36);
            this.NudPrice.TabIndex = 36;
            this.NudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Frm_BankPullMoney
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(358, 363);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtreason);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NudPrice);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frm_BankPullMoney";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سحب رصيد من البنك";
            this.Load += new System.EventHandler(this.Frm_BankPullMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtreason;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NudPrice;
    }
}