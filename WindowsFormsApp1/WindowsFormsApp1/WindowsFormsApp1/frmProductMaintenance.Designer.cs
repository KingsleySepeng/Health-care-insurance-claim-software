namespace WindowsFormsApp1
{
    partial class frmProductMaintenance
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtSubmit = new System.Windows.Forms.Button();
            this.lblDateHint = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCareLevel = new System.Windows.Forms.ComboBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPolicyType = new System.Windows.Forms.ComboBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPolicyName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button5.Location = new System.Drawing.Point(798, 540);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 40);
            this.button5.TabIndex = 46;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(624, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 45;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(127, 323);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(499, 20);
            this.txtSearch.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(282, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 45);
            this.label4.TabIndex = 44;
            this.label4.Text = "Product Maintenance";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(410, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 33);
            this.button3.TabIndex = 43;
            this.button3.Text = "Delete Policy";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(240, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 42;
            this.button1.Text = "Update Policy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.txtSubmit);
            this.grpDetails.Controls.Add(this.lblDateHint);
            this.grpDetails.Controls.Add(this.txtEndDate);
            this.grpDetails.Controls.Add(this.label1);
            this.grpDetails.Controls.Add(this.label7);
            this.grpDetails.Controls.Add(this.cmbCareLevel);
            this.grpDetails.Controls.Add(this.txtCost);
            this.grpDetails.Controls.Add(this.label2);
            this.grpDetails.Controls.Add(this.label5);
            this.grpDetails.Controls.Add(this.cmbPolicyType);
            this.grpDetails.Controls.Add(this.txtStartDate);
            this.grpDetails.Controls.Add(this.label3);
            this.grpDetails.Controls.Add(this.label6);
            this.grpDetails.Controls.Add(this.txtPolicyName);
            this.grpDetails.Location = new System.Drawing.Point(12, 408);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(781, 172);
            this.grpDetails.TabIndex = 41;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Policy Details";
            this.grpDetails.Visible = false;
            // 
            // txtSubmit
            // 
            this.txtSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.txtSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtSubmit.ForeColor = System.Drawing.Color.White;
            this.txtSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSubmit.Location = new System.Drawing.Point(688, 111);
            this.txtSubmit.Name = "txtSubmit";
            this.txtSubmit.Size = new System.Drawing.Size(77, 33);
            this.txtSubmit.TabIndex = 48;
            this.txtSubmit.Text = "Submit";
            this.txtSubmit.UseVisualStyleBackColor = false;
            this.txtSubmit.Click += new System.EventHandler(this.txtSubmit_Click);
            // 
            // lblDateHint
            // 
            this.lblDateHint.AutoSize = true;
            this.lblDateHint.BackColor = System.Drawing.Color.White;
            this.lblDateHint.ForeColor = System.Drawing.Color.Black;
            this.lblDateHint.Location = new System.Drawing.Point(59, 16);
            this.lblDateHint.Name = "lblDateHint";
            this.lblDateHint.Size = new System.Drawing.Size(152, 13);
            this.lblDateHint.TabIndex = 36;
            this.lblDateHint.Text = "*Date time format: yyyy/mm/dd";
            this.lblDateHint.Visible = false;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(112, 120);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(192, 20);
            this.txtEndDate.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(16, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "End Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(382, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Care level";
            // 
            // cmbCareLevel
            // 
            this.cmbCareLevel.Enabled = false;
            this.cmbCareLevel.FormattingEnabled = true;
            this.cmbCareLevel.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbCareLevel.Location = new System.Drawing.Point(478, 79);
            this.cmbCareLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCareLevel.Name = "cmbCareLevel";
            this.cmbCareLevel.Size = new System.Drawing.Size(156, 21);
            this.cmbCareLevel.TabIndex = 32;
            this.cmbCareLevel.SelectedIndexChanged += new System.EventHandler(this.cmbCareLevel_SelectedIndexChanged);
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(478, 117);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(192, 20);
            this.txtCost.TabIndex = 26;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(382, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Policy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(16, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Start Date";
            // 
            // cmbPolicyType
            // 
            this.cmbPolicyType.FormattingEnabled = true;
            this.cmbPolicyType.Items.AddRange(new object[] {
            "Premium",
            "Intermediate",
            "Basic"});
            this.cmbPolicyType.Location = new System.Drawing.Point(478, 40);
            this.cmbPolicyType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPolicyType.Name = "cmbPolicyType";
            this.cmbPolicyType.Size = new System.Drawing.Size(156, 21);
            this.cmbPolicyType.TabIndex = 30;
            this.cmbPolicyType.SelectedIndexChanged += new System.EventHandler(this.cmbPolicyType_SelectedIndexChanged);
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(112, 83);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(192, 20);
            this.txtStartDate.TabIndex = 24;
            this.txtStartDate.TextChanged += new System.EventHandler(this.txtStartDate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(16, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Policy Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(382, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Policy Cost";
            // 
            // txtPolicyName
            // 
            this.txtPolicyName.Location = new System.Drawing.Point(112, 44);
            this.txtPolicyName.Name = "txtPolicyName";
            this.txtPolicyName.Size = new System.Drawing.Size(192, 20);
            this.txtPolicyName.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(74, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 33);
            this.button2.TabIndex = 39;
            this.button2.Text = "Add Policy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(790, 226);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(789, 316);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(37, 33);
            this.btnReset.TabIndex = 47;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(92, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 180);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CalcProfit";
            this.groupBox1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Premium",
            "Intermediate",
            "Basic"});
            this.comboBox1.Location = new System.Drawing.Point(363, 28);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 43;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DodgerBlue;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(494, 136);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(116, 33);
            this.button8.TabIndex = 42;
            this.button8.Text = "Most Profitable Policy";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(320, 136);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 33);
            this.button7.TabIndex = 41;
            this.button7.Text = "Calculate Total Profit";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(155, 136);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 33);
            this.button6.TabIndex = 40;
            this.button6.Text = "Calculate Policy Profit";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(288, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Specify Policy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(288, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Specify Year";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(363, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(15, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Net Expenditure";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(116, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(34, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Net Income";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(116, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 24;
            // 
            // frmProductMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 587);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmProductMaintenance";
            this.Text = "frmProductMaintenance";
            this.Load += new System.EventHandler(this.frmProductMaintenance_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPolicyType;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPolicyName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCareLevel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDateHint;
        private System.Windows.Forms.Button txtSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
    }
}