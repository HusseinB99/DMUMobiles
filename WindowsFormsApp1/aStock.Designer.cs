using System;

namespace WindowsFormsApp1
{
    partial class aStock
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtbStockID = new System.Windows.Forms.TextBox();
            this.txtbDateAdd = new System.Windows.Forms.TextBox();
            this.txtbStockType = new System.Windows.Forms.TextBox();
            this.txtbStockNumber = new System.Windows.Forms.TextBox();
            this.txtbDesc = new System.Windows.Forms.TextBox();
            this.lblStockNumber = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblStockStatus = new System.Windows.Forms.Label();
            this.lblDateAdd = new System.Windows.Forms.Label();
            this.lblStockType = new System.Windows.Forms.Label();
            this.lblStockID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtbStockID);
            this.groupBox1.Controls.Add(this.txtbDateAdd);
            this.groupBox1.Controls.Add(this.txtbStockType);
            this.groupBox1.Controls.Add(this.txtbStockNumber);
            this.groupBox1.Controls.Add(this.txtbDesc);
            this.groupBox1.Controls.Add(this.lblStockNumber);
            this.groupBox1.Controls.Add(this.lblDesc);
            this.groupBox1.Controls.Add(this.lblStockStatus);
            this.groupBox1.Controls.Add(this.lblDateAdd);
            this.groupBox1.Controls.Add(this.lblStockType);
            this.groupBox1.Controls.Add(this.lblStockID);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.comboBox1.Location = new System.Drawing.Point(122, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(9, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(619, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Stock ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Stock Description";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Stock Number";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Stock Type";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date Added";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Stock Status";
            this.Column6.Name = "Column6";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(277, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(277, 83);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(277, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtbStockID
            // 
            this.txtbStockID.Location = new System.Drawing.Point(122, 28);
            this.txtbStockID.Name = "txtbStockID";
            this.txtbStockID.Size = new System.Drawing.Size(100, 20);
            this.txtbStockID.TabIndex = 2;
            // 
            // txtbDateAdd
            // 
            this.txtbDateAdd.Location = new System.Drawing.Point(122, 132);
            this.txtbDateAdd.Name = "txtbDateAdd";
            this.txtbDateAdd.Size = new System.Drawing.Size(100, 20);
            this.txtbDateAdd.TabIndex = 2;
            this.txtbDateAdd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbStockType
            // 
            this.txtbStockType.Location = new System.Drawing.Point(122, 106);
            this.txtbStockType.Name = "txtbStockType";
            this.txtbStockType.Size = new System.Drawing.Size(100, 20);
            this.txtbStockType.TabIndex = 2;
            this.txtbStockType.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbStockNumber
            // 
            this.txtbStockNumber.Location = new System.Drawing.Point(122, 80);
            this.txtbStockNumber.Name = "txtbStockNumber";
            this.txtbStockNumber.Size = new System.Drawing.Size(100, 20);
            this.txtbStockNumber.TabIndex = 2;
            this.txtbStockNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbDesc
            // 
            this.txtbDesc.Location = new System.Drawing.Point(122, 54);
            this.txtbDesc.Name = "txtbDesc";
            this.txtbDesc.Size = new System.Drawing.Size(100, 20);
            this.txtbDesc.TabIndex = 2;
            this.txtbDesc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblStockNumber
            // 
            this.lblStockNumber.AutoSize = true;
            this.lblStockNumber.Location = new System.Drawing.Point(6, 83);
            this.lblStockNumber.Name = "lblStockNumber";
            this.lblStockNumber.Size = new System.Drawing.Size(75, 13);
            this.lblStockNumber.TabIndex = 0;
            this.lblStockNumber.Text = "Stock Number";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(6, 57);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Description";
            // 
            // lblStockStatus
            // 
            this.lblStockStatus.AutoSize = true;
            this.lblStockStatus.Location = new System.Drawing.Point(6, 161);
            this.lblStockStatus.Name = "lblStockStatus";
            this.lblStockStatus.Size = new System.Drawing.Size(68, 13);
            this.lblStockStatus.TabIndex = 0;
            this.lblStockStatus.Text = "Stock Status";
            // 
            // lblDateAdd
            // 
            this.lblDateAdd.AutoSize = true;
            this.lblDateAdd.Location = new System.Drawing.Point(6, 135);
            this.lblDateAdd.Name = "lblDateAdd";
            this.lblDateAdd.Size = new System.Drawing.Size(64, 13);
            this.lblDateAdd.TabIndex = 0;
            this.lblDateAdd.Text = "Date Added";
            // 
            // lblStockType
            // 
            this.lblStockType.AutoSize = true;
            this.lblStockType.Location = new System.Drawing.Point(6, 109);
            this.lblStockType.Name = "lblStockType";
            this.lblStockType.Size = new System.Drawing.Size(62, 13);
            this.lblStockType.TabIndex = 0;
            this.lblStockType.Text = "Stock Type";
            // 
            // lblStockID
            // 
            this.lblStockID.AutoSize = true;
            this.lblStockID.Location = new System.Drawing.Point(6, 31);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Size = new System.Drawing.Size(49, 13);
            this.lblStockID.TabIndex = 0;
            this.lblStockID.Text = "Stock ID";
            // 
            // aStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 390);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "aStock";
            this.Text = "Stock Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStockNumber;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.Label lblDateAdd;
        private System.Windows.Forms.Label lblStockType;
        private System.Windows.Forms.Label lblStockID;
        private System.Windows.Forms.TextBox txtbDateAdd;
        private System.Windows.Forms.TextBox txtbStockType;
        private System.Windows.Forms.TextBox txtbStockNumber;
        private System.Windows.Forms.TextBox txtbDesc;
        private System.Windows.Forms.TextBox txtbStockID;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

