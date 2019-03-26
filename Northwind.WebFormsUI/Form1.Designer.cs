namespace Northwind.WebFormsUI
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxQuantityPer = new System.Windows.Forms.TextBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxProduct = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUpdateStockAmount = new System.Windows.Forms.TextBox();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.cbxUpdateCategory = new System.Windows.Forms.ComboBox();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(3, 199);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(1087, 179);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lbl_Category);
            this.gbxCategory.Location = new System.Drawing.Point(3, 2);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(1093, 100);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Ara";
            this.gbxCategory.Enter += new System.EventHandler(this.gbxCategory_Enter);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(108, 44);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(255, 24);
            this.cbxCategory.TabIndex = 4;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(9, 47);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(61, 17);
            this.lbl_Category.TabIndex = 3;
            this.lbl_Category.Text = "Kategori";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lbl_ProductName);
            this.gbxProductName.Location = new System.Drawing.Point(3, 108);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(1093, 100);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Ürün Adıne Göre Ara";
            this.gbxProductName.Enter += new System.EventHandler(this.gbxProductName_Enter);
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(101, 51);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(262, 22);
            this.tbxProductName.TabIndex = 1;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(9, 54);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(63, 17);
            this.lbl_ProductName.TabIndex = 0;
            this.lbl_ProductName.Text = "Ürün Adı";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnRemove);
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPer);
            this.gbxProductAdd.Controls.Add(this.tbxStock);
            this.gbxProductAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxProductAdd.Controls.Add(this.cbxCategoryId);
            this.gbxProductAdd.Controls.Add(this.tbxProduct);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblStockAmount);
            this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
            this.gbxProductAdd.Controls.Add(this.label2);
            this.gbxProductAdd.Controls.Add(this.lblProductName);
            this.gbxProductAdd.Location = new System.Drawing.Point(3, 384);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(1073, 182);
            this.gbxProductAdd.TabIndex = 2;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Ürün Ekle";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(851, 32);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(123, 46);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(439, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 47);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxQuantityPer
            // 
            this.tbxQuantityPer.Location = new System.Drawing.Point(439, 65);
            this.tbxQuantityPer.Name = "tbxQuantityPer";
            this.tbxQuantityPer.Size = new System.Drawing.Size(152, 22);
            this.tbxQuantityPer.TabIndex = 12;
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(439, 24);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(152, 22);
            this.tbxStock.TabIndex = 11;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(106, 109);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(165, 22);
            this.tbxUnitPrice.TabIndex = 10;
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(106, 70);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(165, 24);
            this.cbxCategoryId.TabIndex = 9;
            // 
            // tbxProduct
            // 
            this.tbxProduct.Location = new System.Drawing.Point(106, 32);
            this.tbxProduct.Name = "tbxProduct";
            this.tbxProduct.Size = new System.Drawing.Size(165, 22);
            this.tbxProduct.TabIndex = 8;
            this.tbxProduct.TextChanged += new System.EventHandler(this.tbxProduct_TextChanged);
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(327, 70);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(79, 17);
            this.lblQuantityPerUnit.TabIndex = 7;
            this.lblQuantityPerUnit.Text = "Birim Adedi";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(327, 27);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(76, 17);
            this.lblStockAmount.TabIndex = 6;
            this.lblStockAmount.Text = "Stok Adedi";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(12, 109);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(38, 17);
            this.lblUnitPrice.TabIndex = 5;
            this.lblUnitPrice.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategori";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(12, 32);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(63, 17);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.tbxUpdateQuantityPerUnit);
            this.groupBox1.Controls.Add(this.tbxUpdateStockAmount);
            this.groupBox1.Controls.Add(this.tbxUpdateUnitPrice);
            this.groupBox1.Controls.Add(this.cbxUpdateCategory);
            this.groupBox1.Controls.Add(this.tbxUpdateProductName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(6, 572);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 175);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Ürün Ekle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(439, 120);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 47);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdateQuantityPerUnit
            // 
            this.tbxUpdateQuantityPerUnit.Location = new System.Drawing.Point(439, 65);
            this.tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
            this.tbxUpdateQuantityPerUnit.Size = new System.Drawing.Size(152, 22);
            this.tbxUpdateQuantityPerUnit.TabIndex = 12;
            // 
            // tbxUpdateStockAmount
            // 
            this.tbxUpdateStockAmount.Location = new System.Drawing.Point(439, 24);
            this.tbxUpdateStockAmount.Name = "tbxUpdateStockAmount";
            this.tbxUpdateStockAmount.Size = new System.Drawing.Size(152, 22);
            this.tbxUpdateStockAmount.TabIndex = 11;
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(106, 109);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(165, 22);
            this.tbxUpdateUnitPrice.TabIndex = 10;
            // 
            // cbxUpdateCategory
            // 
            this.cbxUpdateCategory.FormattingEnabled = true;
            this.cbxUpdateCategory.Location = new System.Drawing.Point(106, 70);
            this.cbxUpdateCategory.Name = "cbxUpdateCategory";
            this.cbxUpdateCategory.Size = new System.Drawing.Size(165, 24);
            this.cbxUpdateCategory.TabIndex = 9;
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(106, 32);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(165, 22);
            this.tbxUpdateProductName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Birim Adedi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stok Adedi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kategori";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ürün Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxQuantityPer;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.TextBox tbxProduct;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdateQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUpdateStockAmount;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.ComboBox cbxUpdateCategory;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemove;
    }
}

