namespace OtelUygulamasıUI.BookingForms
{
    partial class BookingMainForm
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
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            cmbListPicker = new ComboBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label1 = new Label();
            label4 = new Label();
            btnList = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 342);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1107, 299);
            dataGridView1.TabIndex = 23;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(792, 41);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(166, 254);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "DELETE BOOKING";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // cmbListPicker
            // 
            cmbListPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListPicker.FormattingEnabled = true;
            cmbListPicker.Items.AddRange(new object[] { "New to Old", "Old to New", "Special", "Get All.." });
            cmbListPicker.Location = new Point(30, 32);
            cmbListPicker.Name = "cmbListPicker";
            cmbListPicker.Size = new Size(508, 33);
            cmbListPicker.TabIndex = 27;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Enabled = false;
            dtpStartDate.Location = new Point(238, 89);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(300, 31);
            dtpStartDate.TabIndex = 28;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Enabled = false;
            dtpEndDate.Location = new Point(238, 151);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(300, 31);
            dtpEndDate.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 89);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 30;
            label1.Text = "Start Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 151);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 31;
            label4.Text = "End Date:";
            // 
            // btnList
            // 
            btnList.Location = new Point(39, 238);
            btnList.Name = "btnList";
            btnList.Size = new Size(499, 48);
            btnList.TabIndex = 32;
            btnList.Text = "LIST ";
            btnList.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(569, 32);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(159, 102);
            btnUpdate.TabIndex = 33;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(569, 180);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(159, 106);
            btnCreate.TabIndex = 34;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // BookingMainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 634);
            Controls.Add(btnCreate);
            Controls.Add(btnUpdate);
            Controls.Add(btnList);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(cmbListPicker);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Name = "BookingMainForm";
            Text = "BookingMainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnDelete;
        private ComboBox cmbListPicker;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label1;
        private Label label4;
        private Button btnList;
        private Button btnUpdate;
        private Button btnCreate;
    }
}