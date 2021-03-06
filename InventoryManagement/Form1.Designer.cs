﻿namespace InventoryManagement
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMake = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbPart = new System.Windows.Forms.ComboBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lstParts = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.lblOther = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSmallTest = new System.Windows.Forms.Button();
            this.btnLoadLargeTest = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDaysInStock = new System.Windows.Forms.TextBox();
            this.picPhone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Make: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Part: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Model: ";
            // 
            // cmbMake
            // 
            this.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMake.FormattingEnabled = true;
            this.cmbMake.Items.AddRange(new object[] {
            "Apple",
            "Nokia",
            "Samsung"});
            this.cmbMake.Location = new System.Drawing.Point(93, 13);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(112, 21);
            this.cmbMake.TabIndex = 0;
            this.cmbMake.SelectedIndexChanged += new System.EventHandler(this.ChangeModelCollection);
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(264, 13);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(96, 21);
            this.cmbModel.TabIndex = 1;
            // 
            // cmbPart
            // 
            this.cmbPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPart.FormattingEnabled = true;
            this.cmbPart.Items.AddRange(new object[] {
            "Battery",
            "Charging Port",
            "Display",
            "Home Button",
            "Other",
            "Power / Lock Button"});
            this.cmbPart.Location = new System.Drawing.Point(93, 40);
            this.cmbPart.Name = "cmbPart";
            this.cmbPart.Size = new System.Drawing.Size(112, 21);
            this.cmbPart.Sorted = true;
            this.cmbPart.TabIndex = 2;
            this.cmbPart.SelectedIndexChanged += new System.EventHandler(this.ChangeOtherVisible);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(93, 69);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(96, 20);
            this.txtColor.TabIndex = 4;
            this.txtColor.Text = "N/A";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(93, 97);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(26, 20);
            this.txtQuantity.TabIndex = 5;
            // 
            // lstParts
            // 
            this.lstParts.FormattingEnabled = true;
            this.lstParts.Location = new System.Drawing.Point(15, 188);
            this.lstParts.Name = "lstParts";
            this.lstParts.Size = new System.Drawing.Size(492, 186);
            this.lstParts.TabIndex = 10;
            this.lstParts.SelectedIndexChanged += new System.EventHandler(this.DisplayDaysInStock);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 147);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(130, 147);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(245, 147);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 9;
            this.btnSort.Text = "&Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(264, 40);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(100, 20);
            this.txtOther.TabIndex = 3;
            this.txtOther.Visible = false;
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(211, 43);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(39, 13);
            this.lblOther.TabIndex = 15;
            this.lblOther.Text = "Other: ";
            this.lblOther.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(432, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Search: ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(264, 97);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.SearchParts);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(242, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Searches are case sensitive!";
            // 
            // btnSmallTest
            // 
            this.btnSmallTest.Location = new System.Drawing.Point(15, 377);
            this.btnSmallTest.Name = "btnSmallTest";
            this.btnSmallTest.Size = new System.Drawing.Size(118, 23);
            this.btnSmallTest.TabIndex = 11;
            this.btnSmallTest.Text = "Load Small Test List";
            this.btnSmallTest.UseVisualStyleBackColor = true;
            this.btnSmallTest.Click += new System.EventHandler(this.btnSmallTest_Click);
            // 
            // btnLoadLargeTest
            // 
            this.btnLoadLargeTest.Location = new System.Drawing.Point(140, 377);
            this.btnLoadLargeTest.Name = "btnLoadLargeTest";
            this.btnLoadLargeTest.Size = new System.Drawing.Size(118, 23);
            this.btnLoadLargeTest.TabIndex = 12;
            this.btnLoadLargeTest.Text = "Load Large Test List";
            this.btnLoadLargeTest.UseVisualStyleBackColor = true;
            this.btnLoadLargeTest.Click += new System.EventHandler(this.btnLoadLargeTest_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Days In Stock: ";
            // 
            // txtDaysInStock
            // 
            this.txtDaysInStock.Location = new System.Drawing.Point(370, 379);
            this.txtDaysInStock.Name = "txtDaysInStock";
            this.txtDaysInStock.ReadOnly = true;
            this.txtDaysInStock.Size = new System.Drawing.Size(42, 20);
            this.txtDaysInStock.TabIndex = 22;
            this.txtDaysInStock.TabStop = false;
            // 
            // picPhone
            // 
            this.picPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPhone.Location = new System.Drawing.Point(383, 13);
            this.picPhone.Name = "picPhone";
            this.picPhone.Size = new System.Drawing.Size(124, 104);
            this.picPhone.TabIndex = 23;
            this.picPhone.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(519, 413);
            this.Controls.Add(this.picPhone);
            this.Controls.Add(this.txtDaysInStock);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLoadLargeTest);
            this.Controls.Add(this.btnSmallTest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstParts);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.cmbPart);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbMake);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Inventory Management";
            ((System.ComponentModel.ISupportInitialize)(this.picPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMake;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbPart;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ListBox lstParts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSmallTest;
        private System.Windows.Forms.Button btnLoadLargeTest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDaysInStock;
        private System.Windows.Forms.PictureBox picPhone;
    }
}

