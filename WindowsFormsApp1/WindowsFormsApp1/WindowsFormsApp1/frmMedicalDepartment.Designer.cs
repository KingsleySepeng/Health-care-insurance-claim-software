namespace WindowsFormsApp1
{
    partial class frmMedicalDepartment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTreatments = new System.Windows.Forms.GroupBox();
            this.cmbDescription = new System.Windows.Forms.ComboBox();
            this.txtPolicyID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTreatmentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddConditionTreatment = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.grpMedicalConditions = new System.Windows.Forms.GroupBox();
            this.txtMedicalCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtConditionName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumDays = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpTreatments.SuspendLayout();
            this.grpMedicalConditions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(772, 212);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(694, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "View Treatments";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button3.Location = new System.Drawing.Point(850, 541);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 40);
            this.button3.TabIndex = 21;
            this.button3.Text = "Log Out";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 45);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ukupholisa Medical Department";
            // 
            // grpTreatments
            // 
            this.grpTreatments.Controls.Add(this.txtNumDays);
            this.grpTreatments.Controls.Add(this.label4);
            this.grpTreatments.Controls.Add(this.cmbDescription);
            this.grpTreatments.Controls.Add(this.txtPolicyID);
            this.grpTreatments.Controls.Add(this.label10);
            this.grpTreatments.Controls.Add(this.txtCost);
            this.grpTreatments.Controls.Add(this.label6);
            this.grpTreatments.Controls.Add(this.label3);
            this.grpTreatments.Controls.Add(this.txtTreatmentName);
            this.grpTreatments.Controls.Add(this.label5);
            this.grpTreatments.Location = new System.Drawing.Point(79, 373);
            this.grpTreatments.Margin = new System.Windows.Forms.Padding(2);
            this.grpTreatments.Name = "grpTreatments";
            this.grpTreatments.Padding = new System.Windows.Forms.Padding(2);
            this.grpTreatments.Size = new System.Drawing.Size(744, 197);
            this.grpTreatments.TabIndex = 23;
            this.grpTreatments.TabStop = false;
            this.grpTreatments.Text = "Treatment Details";
            this.grpTreatments.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbDescription
            // 
            this.cmbDescription.FormattingEnabled = true;
            this.cmbDescription.Items.AddRange(new object[] {
            "Surical",
            "Medicinal"});
            this.cmbDescription.Location = new System.Drawing.Point(147, 20);
            this.cmbDescription.Name = "cmbDescription";
            this.cmbDescription.Size = new System.Drawing.Size(192, 21);
            this.cmbDescription.TabIndex = 29;
            // 
            // txtPolicyID
            // 
            this.txtPolicyID.Location = new System.Drawing.Point(147, 125);
            this.txtPolicyID.Name = "txtPolicyID";
            this.txtPolicyID.Size = new System.Drawing.Size(192, 20);
            this.txtPolicyID.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(41, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Policy ID";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(147, 87);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(192, 20);
            this.txtCost.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(39, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Treatment Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(20, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Treatment Description";
            // 
            // txtTreatmentName
            // 
            this.txtTreatmentName.Location = new System.Drawing.Point(147, 52);
            this.txtTreatmentName.Name = "txtTreatmentName";
            this.txtTreatmentName.Size = new System.Drawing.Size(192, 20);
            this.txtTreatmentName.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(41, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Treatment Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnAddConditionTreatment
            // 
            this.btnAddConditionTreatment.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddConditionTreatment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddConditionTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddConditionTreatment.ForeColor = System.Drawing.Color.White;
            this.btnAddConditionTreatment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddConditionTreatment.Location = new System.Drawing.Point(79, 313);
            this.btnAddConditionTreatment.Name = "btnAddConditionTreatment";
            this.btnAddConditionTreatment.Size = new System.Drawing.Size(157, 44);
            this.btnAddConditionTreatment.TabIndex = 31;
            this.btnAddConditionTreatment.Text = "Add Medical Conditions";
            this.btnAddConditionTreatment.UseVisualStyleBackColor = false;
            this.btnAddConditionTreatment.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(562, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "View Medical Conditions";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // grpMedicalConditions
            // 
            this.grpMedicalConditions.Controls.Add(this.txtMedicalCode);
            this.grpMedicalConditions.Controls.Add(this.label8);
            this.grpMedicalConditions.Controls.Add(this.txtDescription);
            this.grpMedicalConditions.Controls.Add(this.txtConditionName);
            this.grpMedicalConditions.Controls.Add(this.label2);
            this.grpMedicalConditions.Controls.Add(this.label7);
            this.grpMedicalConditions.Location = new System.Drawing.Point(79, 373);
            this.grpMedicalConditions.Margin = new System.Windows.Forms.Padding(2);
            this.grpMedicalConditions.Name = "grpMedicalConditions";
            this.grpMedicalConditions.Padding = new System.Windows.Forms.Padding(2);
            this.grpMedicalConditions.Size = new System.Drawing.Size(418, 197);
            this.grpMedicalConditions.TabIndex = 27;
            this.grpMedicalConditions.TabStop = false;
            this.grpMedicalConditions.Text = "Medical Condition Details";
            this.grpMedicalConditions.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtMedicalCode
            // 
            this.txtMedicalCode.Location = new System.Drawing.Point(146, 113);
            this.txtMedicalCode.Name = "txtMedicalCode";
            this.txtMedicalCode.Size = new System.Drawing.Size(192, 20);
            this.txtMedicalCode.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(38, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Medical Code";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(146, 71);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(192, 20);
            this.txtDescription.TabIndex = 26;
            // 
            // txtConditionName
            // 
            this.txtConditionName.Location = new System.Drawing.Point(146, 30);
            this.txtConditionName.Name = "txtConditionName";
            this.txtConditionName.Size = new System.Drawing.Size(192, 20);
            this.txtConditionName.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(38, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Medical Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(16, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Medical Condition Name";
            // 
            // txtNumDays
            // 
            this.txtNumDays.Location = new System.Drawing.Point(522, 21);
            this.txtNumDays.Name = "txtNumDays";
            this.txtNumDays.Size = new System.Drawing.Size(192, 20);
            this.txtNumDays.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(392, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Treatment Length(days)";
            // 
            // frmMedicalDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 592);
            this.Controls.Add(this.grpMedicalConditions);
            this.Controls.Add(this.btnAddConditionTreatment);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.grpTreatments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "frmMedicalDepartment";
            this.Text = "frmMedicalDepartment";
            this.Load += new System.EventHandler(this.frmMedicalDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpTreatments.ResumeLayout(false);
            this.grpTreatments.PerformLayout();
            this.grpMedicalConditions.ResumeLayout(false);
            this.grpMedicalConditions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTreatments;
        private System.Windows.Forms.Button btnAddConditionTreatment;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTreatmentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox grpMedicalConditions;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtConditionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPolicyID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMedicalCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDescription;
        private System.Windows.Forms.TextBox txtNumDays;
        private System.Windows.Forms.Label label4;
    }
}