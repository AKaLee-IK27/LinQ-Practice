using System.Drawing;
using System.Windows.Forms;

namespace LinQ_Practice
{
    partial class homeScreen
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
            this.enterProductInfoBox = new System.Windows.Forms.GroupBox();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.removeProductBtn = new System.Windows.Forms.Button();
            this.expireDatePicker = new System.Windows.Forms.DateTimePicker();
            this.productFromTxt = new System.Windows.Forms.Label();
            this.productExpireDateTxt = new System.Windows.Forms.Label();
            this.productNameTxt = new System.Windows.Forms.Label();
            this.productIdTxt = new System.Windows.Forms.Label();
            this.productPriceTxt = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.productQuantityTxt = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.GroupBox();
            this.dgvFilter = new System.Windows.Forms.DataGridView();
            this.priceRangeBTextBox = new System.Windows.Forms.TextBox();
            this.priceRangeATextBox = new System.Windows.Forms.TextBox();
            this.findProductsByPriceRange = new System.Windows.Forms.Button();
            this.allExpiredProductBtn = new System.Windows.Forms.Button();
            this.findProductFromVNBtn = new System.Windows.Forms.Button();
            this.highestPriceProductBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeAllExpiredProductsBtn = new System.Windows.Forms.Button();
            this.removeAllProductsBtn = new System.Windows.Forms.Button();
            this.checkForExpiredProductsBtn = new System.Windows.Forms.Button();
            this.productOriginsComboBox = new System.Windows.Forms.ComboBox();
            this.deleteProductByOriginBtn = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.enterProductInfoBox.SuspendLayout();
            this.searchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // enterProductInfoBox
            // 
            this.enterProductInfoBox.BackColor = System.Drawing.Color.LightBlue;
            this.enterProductInfoBox.Controls.Add(this.addProductBtn);
            this.enterProductInfoBox.Controls.Add(this.removeProductBtn);
            this.enterProductInfoBox.Controls.Add(this.expireDatePicker);
            this.enterProductInfoBox.Controls.Add(this.productFromTxt);
            this.enterProductInfoBox.Controls.Add(this.productExpireDateTxt);
            this.enterProductInfoBox.Controls.Add(this.productNameTxt);
            this.enterProductInfoBox.Controls.Add(this.productIdTxt);
            this.enterProductInfoBox.Controls.Add(this.productPriceTxt);
            this.enterProductInfoBox.Controls.Add(this.fromTextBox);
            this.enterProductInfoBox.Controls.Add(this.priceTextBox);
            this.enterProductInfoBox.Controls.Add(this.idTextBox);
            this.enterProductInfoBox.Controls.Add(this.nameTextBox);
            this.enterProductInfoBox.Controls.Add(this.productQuantityTxt);
            this.enterProductInfoBox.Controls.Add(this.quantityTextBox);
            this.enterProductInfoBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enterProductInfoBox.Location = new System.Drawing.Point(12, 12);
            this.enterProductInfoBox.Name = "enterProductInfoBox";
            this.enterProductInfoBox.Size = new System.Drawing.Size(251, 228);
            this.enterProductInfoBox.TabIndex = 0;
            this.enterProductInfoBox.TabStop = false;
            this.enterProductInfoBox.Text = "Nhập thông tin sản phẩm";
            // 
            // addProductBtn
            // 
            this.addProductBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addProductBtn.Location = new System.Drawing.Point(70, 185);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(75, 23);
            this.addProductBtn.TabIndex = 12;
            this.addProductBtn.Text = "Lưu SP";
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // removeProductBtn
            // 
            this.removeProductBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.removeProductBtn.Location = new System.Drawing.Point(151, 185);
            this.removeProductBtn.Name = "removeProductBtn";
            this.removeProductBtn.Size = new System.Drawing.Size(75, 23);
            this.removeProductBtn.TabIndex = 13;
            this.removeProductBtn.Text = "Xóa SP";
            this.removeProductBtn.UseVisualStyleBackColor = false;
            this.removeProductBtn.Click += new System.EventHandler(this.removeProductBtn_Click);
            // 
            // expireDatePicker
            // 
            this.expireDatePicker.Location = new System.Drawing.Point(70, 159);
            this.expireDatePicker.Name = "expireDatePicker";
            this.expireDatePicker.Size = new System.Drawing.Size(160, 20);
            this.expireDatePicker.TabIndex = 11;
            this.expireDatePicker.Value = new System.DateTime(2024, 10, 1, 1, 33, 41, 0);
            // 
            // productFromTxt
            // 
            this.productFromTxt.AutoSize = true;
            this.productFromTxt.Location = new System.Drawing.Point(3, 130);
            this.productFromTxt.Name = "productFromTxt";
            this.productFromTxt.Size = new System.Drawing.Size(46, 13);
            this.productFromTxt.TabIndex = 9;
            this.productFromTxt.Text = "Xuất xứ:";
            // 
            // productExpireDateTxt
            // 
            this.productExpireDateTxt.AutoSize = true;
            this.productExpireDateTxt.Location = new System.Drawing.Point(3, 153);
            this.productExpireDateTxt.Name = "productExpireDateTxt";
            this.productExpireDateTxt.Size = new System.Drawing.Size(46, 26);
            this.productExpireDateTxt.TabIndex = 10;
            this.productExpireDateTxt.Text = "Ngày\r\nhết hạn:";
            // 
            // productNameTxt
            // 
            this.productNameTxt.AutoSize = true;
            this.productNameTxt.Location = new System.Drawing.Point(3, 52);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.Size = new System.Drawing.Size(46, 13);
            this.productNameTxt.TabIndex = 2;
            this.productNameTxt.Text = "Tên SP:";
            // 
            // productIdTxt
            // 
            this.productIdTxt.AutoSize = true;
            this.productIdTxt.Location = new System.Drawing.Point(6, 29);
            this.productIdTxt.Name = "productIdTxt";
            this.productIdTxt.Size = new System.Drawing.Size(42, 13);
            this.productIdTxt.TabIndex = 1;
            this.productIdTxt.Text = "Mã SP:";
            // 
            // productPriceTxt
            // 
            this.productPriceTxt.AutoSize = true;
            this.productPriceTxt.Location = new System.Drawing.Point(3, 104);
            this.productPriceTxt.Name = "productPriceTxt";
            this.productPriceTxt.Size = new System.Drawing.Size(47, 13);
            this.productPriceTxt.TabIndex = 8;
            this.productPriceTxt.Text = "Đơn giá:";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(70, 127);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(160, 20);
            this.fromTextBox.TabIndex = 7;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(70, 101);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(160, 20);
            this.priceTextBox.TabIndex = 6;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(70, 22);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(160, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(70, 49);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(160, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // productQuantityTxt
            // 
            this.productQuantityTxt.AutoSize = true;
            this.productQuantityTxt.Location = new System.Drawing.Point(3, 78);
            this.productQuantityTxt.Name = "productQuantityTxt";
            this.productQuantityTxt.Size = new System.Drawing.Size(52, 13);
            this.productQuantityTxt.TabIndex = 4;
            this.productQuantityTxt.Text = "Số lượng:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(70, 75);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(160, 20);
            this.quantityTextBox.TabIndex = 5;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.LightBlue;
            this.searchBox.Controls.Add(this.dgvFilter);
            this.searchBox.Controls.Add(this.priceRangeBTextBox);
            this.searchBox.Controls.Add(this.priceRangeATextBox);
            this.searchBox.Controls.Add(this.findProductsByPriceRange);
            this.searchBox.Controls.Add(this.allExpiredProductBtn);
            this.searchBox.Controls.Add(this.findProductFromVNBtn);
            this.searchBox.Controls.Add(this.highestPriceProductBtn);
            this.searchBox.Location = new System.Drawing.Point(269, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(530, 228);
            this.searchBox.TabIndex = 1;
            this.searchBox.TabStop = false;
            this.searchBox.Text = "Chọn chức năng tìm kiếm";
            // 
            // dgvFilter
            // 
            this.dgvFilter.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dgvFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilter.Location = new System.Drawing.Point(7, 75);
            this.dgvFilter.Name = "dgvFilter";
            this.dgvFilter.Size = new System.Drawing.Size(517, 147);
            this.dgvFilter.TabIndex = 6;
            // 
            // priceRangeBTextBox
            // 
            this.priceRangeBTextBox.Location = new System.Drawing.Point(467, 33);
            this.priceRangeBTextBox.Name = "priceRangeBTextBox";
            this.priceRangeBTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.priceRangeBTextBox.Size = new System.Drawing.Size(57, 20);
            this.priceRangeBTextBox.TabIndex = 5;
            // 
            // priceRangeATextBox
            // 
            this.priceRangeATextBox.Location = new System.Drawing.Point(404, 33);
            this.priceRangeATextBox.Name = "priceRangeATextBox";
            this.priceRangeATextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.priceRangeATextBox.Size = new System.Drawing.Size(57, 20);
            this.priceRangeATextBox.TabIndex = 4;
            // 
            // findProductsByPriceRange
            // 
            this.findProductsByPriceRange.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.findProductsByPriceRange.Location = new System.Drawing.Point(307, 19);
            this.findProductsByPriceRange.Name = "findProductsByPriceRange";
            this.findProductsByPriceRange.Size = new System.Drawing.Size(91, 45);
            this.findProductsByPriceRange.TabIndex = 3;
            this.findProductsByPriceRange.Text = "Xuất các SP\r\ncó ĐG [a..b]";
            this.findProductsByPriceRange.UseVisualStyleBackColor = false;
            this.findProductsByPriceRange.Click += new System.EventHandler(this.findProductsByPriceRange_Click);
            // 
            // allExpiredProductBtn
            // 
            this.allExpiredProductBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.allExpiredProductBtn.Location = new System.Drawing.Point(169, 19);
            this.allExpiredProductBtn.Name = "allExpiredProductBtn";
            this.allExpiredProductBtn.Size = new System.Drawing.Size(75, 45);
            this.allExpiredProductBtn.TabIndex = 2;
            this.allExpiredProductBtn.Text = "Tất cả SP\r\nhết hạn";
            this.allExpiredProductBtn.UseVisualStyleBackColor = false;
            this.allExpiredProductBtn.Click += new System.EventHandler(this.allExpiredProductBtn_Click);
            // 
            // findProductFromVNBtn
            // 
            this.findProductFromVNBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.findProductFromVNBtn.Location = new System.Drawing.Point(88, 19);
            this.findProductFromVNBtn.Name = "findProductFromVNBtn";
            this.findProductFromVNBtn.Size = new System.Drawing.Size(75, 45);
            this.findProductFromVNBtn.TabIndex = 1;
            this.findProductFromVNBtn.Text = "SP xuất xứ \r\nViệt Nam";
            this.findProductFromVNBtn.UseVisualStyleBackColor = false;
            this.findProductFromVNBtn.Click += new System.EventHandler(this.findProductFromVNBtn_Click);
            // 
            // highestPriceProductBtn
            // 
            this.highestPriceProductBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.highestPriceProductBtn.Location = new System.Drawing.Point(7, 20);
            this.highestPriceProductBtn.Name = "highestPriceProductBtn";
            this.highestPriceProductBtn.Size = new System.Drawing.Size(75, 45);
            this.highestPriceProductBtn.TabIndex = 0;
            this.highestPriceProductBtn.Text = "1 SP có ĐG\r\ncao nhất";
            this.highestPriceProductBtn.UseVisualStyleBackColor = false;
            this.highestPriceProductBtn.Click += new System.EventHandler(this.highestPriceProductBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvProducts);
            this.groupBox1.Location = new System.Drawing.Point(12, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm sau khi nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removeAllExpiredProductsBtn);
            this.groupBox2.Controls.Add(this.removeAllProductsBtn);
            this.groupBox2.Controls.Add(this.checkForExpiredProductsBtn);
            this.groupBox2.Controls.Add(this.productOriginsComboBox);
            this.groupBox2.Controls.Add(this.deleteProductByOriginBtn);
            this.groupBox2.Location = new System.Drawing.Point(523, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 167);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn thao tác";
            // 
            // removeAllExpiredProductsBtn
            // 
            this.removeAllExpiredProductsBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.removeAllExpiredProductsBtn.Location = new System.Drawing.Point(138, 116);
            this.removeAllExpiredProductsBtn.Name = "removeAllExpiredProductsBtn";
            this.removeAllExpiredProductsBtn.Size = new System.Drawing.Size(114, 45);
            this.removeAllExpiredProductsBtn.TabIndex = 11;
            this.removeAllExpiredProductsBtn.Text = "Xóa toàn bộ SP\r\nquá hạn";
            this.removeAllExpiredProductsBtn.UseVisualStyleBackColor = false;
            this.removeAllExpiredProductsBtn.Click += new System.EventHandler(this.removeAllExpiredProductsBtn_Click);
            // 
            // removeAllProductsBtn
            // 
            this.removeAllProductsBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.removeAllProductsBtn.Location = new System.Drawing.Point(6, 116);
            this.removeAllProductsBtn.Name = "removeAllProductsBtn";
            this.removeAllProductsBtn.Size = new System.Drawing.Size(126, 45);
            this.removeAllProductsBtn.TabIndex = 10;
            this.removeAllProductsBtn.Text = "Xóa toàn bộ SP \r\ntrong kho";
            this.removeAllProductsBtn.UseVisualStyleBackColor = false;
            this.removeAllProductsBtn.Click += new System.EventHandler(this.removeAllProductsBtn_Click);
            // 
            // checkForExpiredProductsBtn
            // 
            this.checkForExpiredProductsBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.checkForExpiredProductsBtn.Location = new System.Drawing.Point(6, 70);
            this.checkForExpiredProductsBtn.Name = "checkForExpiredProductsBtn";
            this.checkForExpiredProductsBtn.Size = new System.Drawing.Size(246, 45);
            this.checkForExpiredProductsBtn.TabIndex = 9;
            this.checkForExpiredProductsBtn.Text = "Kiểm tra kho có SP quá hạn hay không?\r\n";
            this.checkForExpiredProductsBtn.UseVisualStyleBackColor = false;
            this.checkForExpiredProductsBtn.Click += new System.EventHandler(this.checkForExpiredProductsBtn_Click);
            // 
            // productOriginsComboBox
            // 
            this.productOriginsComboBox.FormattingEnabled = true;
            this.productOriginsComboBox.Location = new System.Drawing.Point(103, 32);
            this.productOriginsComboBox.Name = "productOriginsComboBox";
            this.productOriginsComboBox.Size = new System.Drawing.Size(149, 21);
            this.productOriginsComboBox.TabIndex = 8;
            // 
            // deleteProductByOriginBtn
            // 
            this.deleteProductByOriginBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteProductByOriginBtn.Location = new System.Drawing.Point(6, 19);
            this.deleteProductByOriginBtn.Name = "deleteProductByOriginBtn";
            this.deleteProductByOriginBtn.Size = new System.Drawing.Size(91, 45);
            this.deleteProductByOriginBtn.TabIndex = 7;
            this.deleteProductByOriginBtn.Text = "Xóa SP theo\r\nxuất xứ bất kỳ";
            this.deleteProductByOriginBtn.UseVisualStyleBackColor = false;
            this.deleteProductByOriginBtn.Click += new System.EventHandler(this.deleteProductByOriginBtn_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(6, 19);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(511, 167);
            this.dgvProducts.TabIndex = 7;
            // 
            // homeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.enterProductInfoBox);
            this.Name = "homeScreen";
            this.Text = "LINQ to OBJECT - Quản lý sản phẩm";
            this.enterProductInfoBox.ResumeLayout(false);
            this.enterProductInfoBox.PerformLayout();
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox enterProductInfoBox;
        private Label productIdTxt;
        private TextBox idTextBox;
        private Label productNameTxt;
        private TextBox nameTextBox;
        private Label productQuantityTxt;
        private TextBox quantityTextBox;
        private Label productPriceTxt;
        private TextBox priceTextBox;
        private Label productFromTxt;
        private TextBox fromTextBox;
        private Label productExpireDateTxt;
        private DateTimePicker expireDatePicker;
        private Button addProductBtn;
        private Button removeProductBtn;
        private GroupBox searchBox;
        private Button highestPriceProductBtn;
        private Button findProductsByPriceRange;
        private Button allExpiredProductBtn;
        private Button findProductFromVNBtn;
        private TextBox priceRangeATextBox;
        private TextBox priceRangeBTextBox;
        private DataGridView dgvFilter;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button removeAllExpiredProductsBtn;
        private Button removeAllProductsBtn;
        private Button checkForExpiredProductsBtn;
        private ComboBox productOriginsComboBox;
        private Button deleteProductByOriginBtn;
        private DataGridView dgvProducts;
    }
}

