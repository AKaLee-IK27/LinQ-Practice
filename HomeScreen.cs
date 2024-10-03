using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQ_Practice
{
    public partial class homeScreen : Form
    {
        List<Product> products = new List<Product>()
        {
            new Product("sp1", "Sữa chua Vinamilk", new DateTime(2024, 12, 31), 15000, 10, "Việt Nam"),
            new Product("sp2", "Bánh mì", new DateTime(2021, 12, 31), 5000, 100, "Việt Nam"),
            new Product("sp3", "Coca Cola", new DateTime(2024, 12, 31), 10000, 20, "Mỹ"),
            new Product("sp4", "Cá viên chiên", new DateTime(2021, 12, 31), 9000, 20, "Trung quốc")
        };
        public homeScreen()
        {
            InitializeComponent();

            dgvProducts.RowHeadersVisible = false;
            dgvFilter.RowHeadersVisible = false;

            loadDGVProducts();
            loadDVGFilter(products);

            List<string> origins = products.Select(p => p.from).Distinct().ToList();
            origins.ForEach(origin => productOriginsComboBox.Items.Add(origin));

        }

        void loadDGVProducts()
        { 
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;

            dgvProducts.Columns["id"].HeaderText = "Mã SP";
            dgvProducts.Columns["name"].HeaderText = "Tên SP";
            dgvProducts.Columns["quantity"].HeaderText = "Số lượng";
            dgvProducts.Columns["price"].HeaderText = "Đơn Giá";
            dgvProducts.Columns["from"].HeaderText = "Xuất xứ";
            dgvProducts.Columns["expireDate"].HeaderText = "Hạn sử dụng";
            dgvProducts.Columns["price"].DefaultCellStyle.Format = "C0";
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product()
            {
                id = idTextBox.Text,
                name = nameTextBox.Text,
                expireDate = expireDatePicker.Value.Date,
                price = double.Parse(priceTextBox.Text),
                quantity = double.Parse(quantityTextBox.Text),
                from = fromTextBox.Text
            };

            products.Add(newProduct);
            loadDGVProducts();
        }

        private void removeProductBtn_Click(object sender, EventArgs e)
        {
            Product removedProduct = new Product()
            {
                id = idTextBox.Text,
                name = nameTextBox.Text,
                expireDate = expireDatePicker.Value.Date,
                price = double.Parse(priceTextBox.Text),
                quantity = double.Parse(quantityTextBox.Text),
                from = fromTextBox.Text
            };

            products.Remove(removedProduct);
            loadDGVProducts();
        }

        private void loadDVGFilter(List<Product> products)
        {
            dgvFilter.DataSource = null;
            dgvFilter.DataSource = products;

            dgvFilter.Columns["id"].HeaderText = "Mã SP";
            dgvFilter.Columns["name"].HeaderText = "Tên SP";
            dgvFilter.Columns["quantity"].HeaderText = "Số lượng";
            dgvFilter.Columns["price"].HeaderText = "Đơn Giá";
            dgvFilter.Columns["from"].HeaderText = "Xuất xứ";
            dgvFilter.Columns["expireDate"].HeaderText = "Hạn sử dụng";
            dgvFilter.Columns["price"].DefaultCellStyle.Format = "C0";
        }

        private void highestPriceProductBtn_Click(object sender, EventArgs e)
        {
            // Find the product with the highest price
            Product highestPriceProduct = products.OrderByDescending(p => p.price).First();
            if (highestPriceProduct != null)
            {
                loadDVGFilter(new List<Product> { highestPriceProduct });
            }
        }

        private void findProductFromVNBtn_Click(object sender, EventArgs e)
        {
            List<Product> productsFromVN = products.Where(p => p.from == "Việt Nam").ToList();

            loadDVGFilter(productsFromVN);
        }

        private void allExpiredProductBtn_Click(object sender, EventArgs e)
        {
            List<Product> productsExpired = products.Where(p => p.expireDate < DateTime.Now).ToList();

            loadDVGFilter(productsExpired);
        }

        private void findProductsByPriceRange_Click(object sender, EventArgs e)
        {
            int a = int.Parse(priceRangeATextBox.Text), b = int.Parse(priceRangeBTextBox.Text);
            List<Product> productsInRange = products.Where(p => p.price >= a && p.price <= b).ToList();

            loadDVGFilter(productsInRange);
        }

        private void deleteProductByOriginBtn_Click(object sender, EventArgs e)
        {
            var selectedOrigin = productOriginsComboBox.SelectedItem;

            if (selectedOrigin != null)
            {
                List<Product> productsToRemove = products.Where(p => p.from == selectedOrigin.ToString()).ToList();
                productsToRemove.ForEach(p => products.Remove(p));
                loadDVGFilter(products);
                loadDGVProducts();
            }
        }

        private void checkForExpiredProductsBtn_Click(object sender, EventArgs e)
        {
            products.ForEach(p =>
            {
                if (p.expireDate < DateTime.Now)
                {
                    MessageBox.Show($"Sản phẩm {p.name} đã hết hạn sử dụng");

                }
            });
        }

        private void removeAllProductsBtn_Click(object sender, EventArgs e)
        {
            products = new List<Product>();

            loadDVGFilter(products);
            loadDGVProducts();
        }

        private void removeAllExpiredProductsBtn_Click(object sender, EventArgs e)
        {
            products.RemoveAll(p => p.expireDate < DateTime.Now);

            loadDVGFilter(products);
            loadDGVProducts();
        }
    }
}
