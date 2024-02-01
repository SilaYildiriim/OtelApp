namespace OtelUygulamasıUI.CustomerForms
{
    partial class CustomerCreate
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
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtEMail = new TextBox();
            txtPhone = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblFirstName = new Label();
            btnCreate = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(175, 144);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 15;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(175, 72);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 14;
            // 
            // txtEMail
            // 
            txtEMail.Location = new Point(175, 228);
            txtEMail.Name = "txtEMail";
            txtEMail.Size = new Size(150, 31);
            txtEMail.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(175, 311);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 314);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 11;
            label4.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 234);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 10;
            label3.Text = "EMail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 144);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 9;
            label2.Text = "LastName :";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(46, 71);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(96, 25);
            lblFirstName.TabIndex = 8;
            lblFirstName.Text = "FirstName:";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(408, 144);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(185, 120);
            btnCreate.TabIndex = 16;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 417);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(796, 272);
            dataGridView1.TabIndex = 17;
            // 
            // CustomerCreate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 689);
            Controls.Add(dataGridView1);
            Controls.Add(btnCreate);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtEMail);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblFirstName);
            Name = "CustomerCreate";
            Text = "CustomerCreate";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtEMail;
        private TextBox txtPhone;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblFirstName;
        private Button btnCreate;
        private DataGridView dataGridView1;
    }
}