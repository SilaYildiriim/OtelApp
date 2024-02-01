namespace OtelUygulamasıUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEmployee = new Button();
            btnCustomer = new Button();
            btnRoom = new Button();
            btnBooking = new Button();
            SuspendLayout();
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new Point(136, 219);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(141, 76);
            btnEmployee.TabIndex = 0;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(136, 86);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(141, 66);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnRoom
            // 
            btnRoom.Location = new Point(500, 219);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(146, 76);
            btnRoom.TabIndex = 2;
            btnRoom.Text = "Room";
            btnRoom.UseVisualStyleBackColor = true;
            // 
            // btnBooking
            // 
            btnBooking.Location = new Point(500, 86);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(146, 66);
            btnBooking.TabIndex = 3;
            btnBooking.Text = "Booking";
            btnBooking.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBooking);
            Controls.Add(btnRoom);
            Controls.Add(btnCustomer);
            Controls.Add(btnEmployee);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmployee;
        private Button btnCustomer;
        private Button btnRoom;
        private Button btnBooking;
    }
}
