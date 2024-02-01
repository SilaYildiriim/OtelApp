﻿namespace OtelUygulamasıUI.BookingForms
{
    partial class UpdateBooking
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
            btnCalculate = new Button();
            dtpCheckInDate = new DateTimePicker();
            dtpCheckOutDate = new DateTimePicker();
            txtTotalPrice = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label = new Label();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(334, 255);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(300, 34);
            btnCalculate.TabIndex = 41;
            btnCalculate.Text = "CALCULATE";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // dtpCheckInDate
            // 
            dtpCheckInDate.Location = new Point(334, 18);
            dtpCheckInDate.Name = "dtpCheckInDate";
            dtpCheckInDate.Size = new Size(300, 31);
            dtpCheckInDate.TabIndex = 40;
            // 
            // dtpCheckOutDate
            // 
            dtpCheckOutDate.Location = new Point(334, 98);
            dtpCheckOutDate.Name = "dtpCheckOutDate";
            dtpCheckOutDate.Size = new Size(300, 31);
            dtpCheckOutDate.TabIndex = 39;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(334, 180);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(300, 31);
            txtTotalPrice.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 186);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 37;
            label3.Text = "Total Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 96);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 36;
            label2.Text = "Check Out Date:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(167, 23);
            label.Name = "label";
            label.Size = new Size(125, 25);
            label.TabIndex = 35;
            label.Text = "Check In Date:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(334, 331);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(300, 90);
            btnUpdate.TabIndex = 42;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 441);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(789, 225);
            dataGridView1.TabIndex = 43;
            // 
            // UpdateBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 667);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnCalculate);
            Controls.Add(dtpCheckInDate);
            Controls.Add(dtpCheckOutDate);
            Controls.Add(txtTotalPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label);
            Name = "UpdateBooking";
            Text = "UpdateBooking";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCalculate;
        private DateTimePicker dtpCheckInDate;
        private DateTimePicker dtpCheckOutDate;
        private TextBox txtTotalPrice;
        private Label label3;
        private Label label2;
        private Label label;
        private Button btnUpdate;
        private DataGridView dataGridView1;
    }
}