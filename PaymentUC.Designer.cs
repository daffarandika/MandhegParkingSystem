namespace MandhegParkingSystem
{
    partial class PaymentUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label license_plateLabel;
            System.Windows.Forms.Label vehicle_type_idLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.vehicle_type_idTextBox = new System.Windows.Forms.TextBox();
            this.license_plateTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.inDatePicker = new System.Windows.Forms.DateTimePicker();
            this.inTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.outTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.outDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.memberTypeTextBox = new System.Windows.Forms.TextBox();
            this.hourlyRateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.parkingDurationTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.amountToPayTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            license_plateLabel = new System.Windows.Forms.Label();
            vehicle_type_idLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // license_plateLabel
            // 
            license_plateLabel.AutoSize = true;
            license_plateLabel.Location = new System.Drawing.Point(39, 44);
            license_plateLabel.Name = "license_plateLabel";
            license_plateLabel.Size = new System.Drawing.Size(71, 13);
            license_plateLabel.TabIndex = 0;
            license_plateLabel.Text = "License Plate";
            // 
            // vehicle_type_idLabel
            // 
            vehicle_type_idLabel.AutoSize = true;
            vehicle_type_idLabel.Location = new System.Drawing.Point(39, 70);
            vehicle_type_idLabel.Name = "vehicle_type_idLabel";
            vehicle_type_idLabel.Size = new System.Drawing.Size(69, 13);
            vehicle_type_idLabel.TabIndex = 2;
            vehicle_type_idLabel.Text = "Vehicle Type";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(vehicle_type_idLabel);
            this.panel1.Controls.Add(this.vehicle_type_idTextBox);
            this.panel1.Controls.Add(license_plateLabel);
            this.panel1.Controls.Add(this.license_plateTextBox);
            this.panel1.Location = new System.Drawing.Point(22, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 440);
            this.panel1.TabIndex = 0;
            // 
            // vehicle_type_idTextBox
            // 
            this.vehicle_type_idTextBox.Location = new System.Drawing.Point(123, 67);
            this.vehicle_type_idTextBox.Name = "vehicle_type_idTextBox";
            this.vehicle_type_idTextBox.Size = new System.Drawing.Size(228, 20);
            this.vehicle_type_idTextBox.TabIndex = 3;
            // 
            // license_plateTextBox
            // 
            this.license_plateTextBox.Location = new System.Drawing.Point(123, 41);
            this.license_plateTextBox.Name = "license_plateTextBox";
            this.license_plateTextBox.Size = new System.Drawing.Size(228, 20);
            this.license_plateTextBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.memberTypeTextBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.ownerTextBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(406, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 136);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSubmit);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.amountToPayTextBox);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.hourlyRateTextBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.parkingDurationTextBox);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(406, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 295);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.inTimePicker);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.inDatePicker);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(13, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(338, 119);
            this.panel4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date";
            // 
            // inDatePicker
            // 
            this.inDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inDatePicker.Location = new System.Drawing.Point(78, 25);
            this.inDatePicker.Name = "inDatePicker";
            this.inDatePicker.Size = new System.Drawing.Size(239, 20);
            this.inDatePicker.TabIndex = 1;
            // 
            // inTimePicker
            // 
            this.inTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.inTimePicker.Location = new System.Drawing.Point(78, 62);
            this.inTimePicker.Name = "inTimePicker";
            this.inTimePicker.ShowUpDown = true;
            this.inTimePicker.Size = new System.Drawing.Size(239, 20);
            this.inTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "In Time";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.outTimePicker);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.outDatePicker);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(13, 276);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(338, 119);
            this.panel5.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Out Time";
            // 
            // outTimePicker
            // 
            this.outTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.outTimePicker.Location = new System.Drawing.Point(78, 62);
            this.outTimePicker.Name = "outTimePicker";
            this.outTimePicker.ShowUpDown = true;
            this.outTimePicker.Size = new System.Drawing.Size(239, 20);
            this.outTimePicker.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Time";
            // 
            // outDatePicker
            // 
            this.outDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.outDatePicker.Location = new System.Drawing.Point(78, 25);
            this.outDatePicker.Name = "outDatePicker";
            this.outDatePicker.Size = new System.Drawing.Size(239, 20);
            this.outDatePicker.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Owner";
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.Location = new System.Drawing.Point(104, 37);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(225, 20);
            this.ownerTextBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Member Type";
            // 
            // memberTypeTextBox
            // 
            this.memberTypeTextBox.Location = new System.Drawing.Point(106, 80);
            this.memberTypeTextBox.Name = "memberTypeTextBox";
            this.memberTypeTextBox.Size = new System.Drawing.Size(221, 20);
            this.memberTypeTextBox.TabIndex = 3;
            // 
            // hourlyRateTextBox
            // 
            this.hourlyRateTextBox.Location = new System.Drawing.Point(104, 72);
            this.hourlyRateTextBox.Name = "hourlyRateTextBox";
            this.hourlyRateTextBox.Size = new System.Drawing.Size(221, 20);
            this.hourlyRateTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hourly Rate";
            // 
            // parkingDurationTextBox
            // 
            this.parkingDurationTextBox.Location = new System.Drawing.Point(104, 29);
            this.parkingDurationTextBox.Name = "parkingDurationTextBox";
            this.parkingDurationTextBox.Size = new System.Drawing.Size(221, 20);
            this.parkingDurationTextBox.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Parking Duration";
            // 
            // amountToPayTextBox
            // 
            this.amountToPayTextBox.Location = new System.Drawing.Point(104, 131);
            this.amountToPayTextBox.Name = "amountToPayTextBox";
            this.amountToPayTextBox.Size = new System.Drawing.Size(221, 20);
            this.amountToPayTextBox.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Amount to Pay";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(295, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "________________________________________________";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(317, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "X";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(254, 236);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // PaymentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PaymentUC";
            this.Size = new System.Drawing.Size(771, 485);
            this.Load += new System.EventHandler(this.PaymentUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox license_plateTextBox;
        private System.Windows.Forms.TextBox vehicle_type_idTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker inTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker inDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker outTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker outDatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox memberTypeTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox amountToPayTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox hourlyRateTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parkingDurationTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSubmit;
    }
}
