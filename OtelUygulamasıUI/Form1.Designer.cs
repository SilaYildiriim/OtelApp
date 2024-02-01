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
            btnEmployee.Location = new Point(194, 365);
            btnEmployee.Margin = new Padding(4, 5, 4, 5);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(201, 127);
            btnEmployee.TabIndex = 0;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(194, 143);
            btnCustomer.Margin = new Padding(4, 5, 4, 5);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(201, 110);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnRoom
            // 
            btnRoom.Location = new Point(714, 365);
            btnRoom.Margin = new Padding(4, 5, 4, 5);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(209, 127);
            btnRoom.TabIndex = 2;
            btnRoom.Text = "Room";
            btnRoom.UseVisualStyleBackColor = true;
            // 
            // btnBooking
            // 
            btnBooking.Location = new Point(714, 143);
            btnBooking.Margin = new Padding(4, 5, 4, 5);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(209, 110);
            btnBooking.TabIndex = 3;
            btnBooking.Text = "Booking";
            btnBooking.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnBooking);
            Controls.Add(btnRoom);
            Controls.Add(btnCustomer);
            Controls.Add(btnEmployee);
            Margin = new Padding(4, 5, 4, 5);
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
