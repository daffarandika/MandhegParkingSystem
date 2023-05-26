namespace MandhegParkingSystem
{
    partial class VehicleUC
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
            System.Windows.Forms.Label vehicle_type_idLabel;
            System.Windows.Forms.Label member_idLabel;
            System.Windows.Forms.Label license_plateLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label label1;
            this.vehicleDataGridView = new System.Windows.Forms.DataGridView();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.license_plateTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.vehicle_type_ComboBox = new System.Windows.Forms.ComboBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label_time = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            vehicle_type_idLabel = new System.Windows.Forms.Label();
            member_idLabel = new System.Windows.Forms.Label();
            license_plateLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicle_type_idLabel
            // 
            vehicle_type_idLabel.AutoSize = true;
            vehicle_type_idLabel.Location = new System.Drawing.Point(65, 311);
            vehicle_type_idLabel.Name = "vehicle_type_idLabel";
            vehicle_type_idLabel.Size = new System.Drawing.Size(69, 13);
            vehicle_type_idLabel.TabIndex = 4;
            vehicle_type_idLabel.Text = "Vehicle Type";
            // 
            // member_idLabel
            // 
            member_idLabel.AutoSize = true;
            member_idLabel.Location = new System.Drawing.Point(65, 337);
            member_idLabel.Name = "member_idLabel";
            member_idLabel.Size = new System.Drawing.Size(38, 13);
            member_idLabel.TabIndex = 6;
            member_idLabel.Text = "Owner";
            // 
            // license_plateLabel
            // 
            license_plateLabel.AutoSize = true;
            license_plateLabel.Location = new System.Drawing.Point(65, 265);
            license_plateLabel.Name = "license_plateLabel";
            license_plateLabel.Size = new System.Drawing.Size(70, 13);
            license_plateLabel.TabIndex = 8;
            license_plateLabel.Text = "License plate";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(65, 363);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(35, 13);
            notesLabel.TabIndex = 10;
            notesLabel.Text = "Notes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 13);
            label1.TabIndex = 13;
            label1.Text = "Search by";
            // 
            // vehicleDataGridView
            // 
            this.vehicleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleDataGridView.Location = new System.Drawing.Point(10, 56);
            this.vehicleDataGridView.Name = "vehicleDataGridView";
            this.vehicleDataGridView.Size = new System.Drawing.Size(748, 171);
            this.vehicleDataGridView.TabIndex = 1;
            this.vehicleDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehicleDataGridView_CellClick);
            this.vehicleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehicleDataGridView_CellContentClick);
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.Location = new System.Drawing.Point(151, 334);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(200, 20);
            this.ownerTextBox.TabIndex = 7;
            this.ownerTextBox.TextChanged += new System.EventHandler(this.ownerTextBox_TextChanged);
            // 
            // license_plateTextBox
            // 
            this.license_plateTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.license_plateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.license_plateTextBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.license_plateTextBox.Location = new System.Drawing.Point(151, 255);
            this.license_plateTextBox.Name = "license_plateTextBox";
            this.license_plateTextBox.Size = new System.Drawing.Size(200, 40);
            this.license_plateTextBox.TabIndex = 9;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(151, 360);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(200, 20);
            this.notesTextBox.TabIndex = 11;
            // 
            // vehicle_type_ComboBox
            // 
            this.vehicle_type_ComboBox.FormattingEnabled = true;
            this.vehicle_type_ComboBox.Location = new System.Drawing.Point(151, 308);
            this.vehicle_type_ComboBox.Name = "vehicle_type_ComboBox";
            this.vehicle_type_ComboBox.Size = new System.Drawing.Size(200, 21);
            this.vehicle_type_ComboBox.TabIndex = 12;
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "Owner Name",
            "License Plate"});
            this.searchComboBox.Location = new System.Drawing.Point(79, 7);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(104, 21);
            this.searchComboBox.TabIndex = 14;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(189, 8);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(237, 20);
            this.searchTextBox.TabIndex = 16;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label_time
            // 
            this.label_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point(407, 446);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(345, 16);
            this.label_time.TabIndex = 29;
            this.label_time.Text = " This record is last modified at YYYY-MM-DD, HH:mm:SS";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(604, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(604, 301);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 27;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(511, 368);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(511, 323);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.Location = new System.Drawing.Point(511, 279);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 24;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // VehicleUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.vehicle_type_ComboBox);
            this.Controls.Add(vehicle_type_idLabel);
            this.Controls.Add(member_idLabel);
            this.Controls.Add(this.ownerTextBox);
            this.Controls.Add(license_plateLabel);
            this.Controls.Add(this.license_plateTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.vehicleDataGridView);
            this.Name = "VehicleUC";
            this.Size = new System.Drawing.Size(771, 485);
            this.Load += new System.EventHandler(this.VehicleUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView vehicleDataGridView;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.TextBox license_plateTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.ComboBox vehicle_type_ComboBox;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
    }
}
