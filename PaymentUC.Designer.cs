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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.license_plateTextBox = new System.Windows.Forms.TextBox();
            this.vehicle_type_idTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            license_plateLabel = new System.Windows.Forms.Label();
            vehicle_type_idLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(vehicle_type_idLabel);
            this.panel1.Controls.Add(this.vehicle_type_idTextBox);
            this.panel1.Controls.Add(license_plateLabel);
            this.panel1.Controls.Add(this.license_plateTextBox);
            this.panel1.Location = new System.Drawing.Point(22, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 440);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(406, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 161);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(406, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 262);
            this.panel3.TabIndex = 2;
            // 
            // license_plateLabel
            // 
            license_plateLabel.AutoSize = true;
            license_plateLabel.Location = new System.Drawing.Point(48, 44);
            license_plateLabel.Name = "license_plateLabel";
            license_plateLabel.Size = new System.Drawing.Size(69, 13);
            license_plateLabel.TabIndex = 0;
            license_plateLabel.Text = "license plate:";
            // 
            // license_plateTextBox
            // 
            this.license_plateTextBox.Location = new System.Drawing.Point(123, 41);
            this.license_plateTextBox.Name = "license_plateTextBox";
            this.license_plateTextBox.Size = new System.Drawing.Size(100, 20);
            this.license_plateTextBox.TabIndex = 1;
            // 
            // vehicle_type_idLabel
            // 
            vehicle_type_idLabel.AutoSize = true;
            vehicle_type_idLabel.Location = new System.Drawing.Point(39, 70);
            vehicle_type_idLabel.Name = "vehicle_type_idLabel";
            vehicle_type_idLabel.Size = new System.Drawing.Size(78, 13);
            vehicle_type_idLabel.TabIndex = 2;
            vehicle_type_idLabel.Text = "vehicle type id:";
            // 
            // vehicle_type_idTextBox
            // 
            this.vehicle_type_idTextBox.Location = new System.Drawing.Point(123, 67);
            this.vehicle_type_idTextBox.Name = "vehicle_type_idTextBox";
            this.vehicle_type_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicle_type_idTextBox.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 152);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox license_plateTextBox;
        private System.Windows.Forms.TextBox vehicle_type_idTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}
