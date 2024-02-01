namespace OtelUygulamasıUI.EmployeeForms
{
    partial class EmployeeUpdate
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
            btnUpdate = new Button();
            comboBox1 = new ComboBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(283, 193);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 41);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(256, 153);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 23);
            comboBox1.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(256, 114);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(142, 23);
            txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(256, 72);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(142, 23);
            txtFirstName.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(256, 33);
            txtId.Name = "txtId";
            txtId.Size = new Size(142, 23);
            txtId.TabIndex = 9;
            // 
            // EmployeeUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtId);
            Controls.Add(btnUpdate);
            Controls.Add(comboBox1);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "EmployeeUpdate";
            Text = "EmployeeUpdate";
            Load += EmployeeUpdate_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private ComboBox comboBox1;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtId;
    }
}