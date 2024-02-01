namespace OtelUygulamasıUI.BookingForms
{
    partial class CreateBooking
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
            btnCreate = new Button();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(202, 284);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(300, 34);
            btnCalculate.TabIndex = 33;
            btnCalculate.Text = "CALCULATE";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // dtpCheckInDate
            // 
            dtpCheckInDate.Location = new Point(202, 47);
            dtpCheckInDate.Name = "dtpCheckInDate";
            dtpCheckInDate.Size = new Size(300, 31);
            dtpCheckInDate.TabIndex = 32;
            // 
            // dtpCheckOutDate
            // 
            dtpCheckOutDate.Location = new Point(202, 127);
            dtpCheckOutDate.Name = "dtpCheckOutDate";
            dtpCheckOutDate.Size = new Size(300, 31);
            dtpCheckOutDate.TabIndex = 31;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(202, 209);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(300, 31);
            txtTotalPrice.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 215);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 29;
            label3.Text = "Total Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 125);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 28;
            label2.Text = "Check Out Date:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(35, 52);
            label.Name = "label";
            label.Size = new Size(125, 25);
            label.TabIndex = 27;
            label.Text = "Check In Date:";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(202, 372);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(300, 90);
            btnCreate.TabIndex = 34;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // CreateBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 633);
            Controls.Add(btnCreate);
            Controls.Add(btnCalculate);
            Controls.Add(dtpCheckInDate);
            Controls.Add(dtpCheckOutDate);
            Controls.Add(txtTotalPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label);
            Name = "CreateBooking";
            Text = "CreateBooking";
            Load += CreateBooking_Load;
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
        private Button btnCreate;
    }
}