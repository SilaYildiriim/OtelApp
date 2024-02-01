namespace OtelUygulamasıUI.CustomerForms
{
    partial class UpdateCustomer
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
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            btnGetInformation = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(171, 111);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 23;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(171, 39);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 22;
            // 
            // txtEMail
            // 
            txtEMail.Location = new Point(171, 195);
            txtEMail.Name = "txtEMail";
            txtEMail.Size = new Size(150, 31);
            txtEMail.TabIndex = 21;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(171, 278);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 281);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 19;
            label4.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 201);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 18;
            label3.Text = "EMail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 111);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 17;
            label2.Text = "LastName :";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(42, 38);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(96, 25);
            lblFirstName.TabIndex = 16;
            lblFirstName.Text = "FirstName:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(417, 195);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(145, 90);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 327);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(800, 225);
            dataGridView1.TabIndex = 25;
            // 
            // btnGetInformation
            // 
            btnGetInformation.Location = new Point(391, 46);
            btnGetInformation.Name = "btnGetInformation";
            btnGetInformation.Size = new Size(195, 90);
            btnGetInformation.TabIndex = 26;
            btnGetInformation.Text = "GET INFORMATION";
            btnGetInformation.UseVisualStyleBackColor = true;
            btnGetInformation.Click += btnGetInformation_Click;
            // 
            // UpdateCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 552);
            Controls.Add(btnGetInformation);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtEMail);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblFirstName);
            Name = "UpdateCustomer";
            Text = "UpdateCustomer";
            Load += UpdateCustomer_Load;
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
        private Button btnUpdate;
        private DataGridView dataGridView1;
        private Button btnGetInformation;
    }
}