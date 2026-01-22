using Krasotka.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krasotka.Controls;
using Krasotka.Models;

namespace Krasotka.Forms
{
    /// <summary>
    /// Форма отображения продуктов
    /// </summary>
    public partial class ProductForm : ParentForm
    {
        private List<Product> products;
        public ProductForm()
        {
            InitializeComponent();
            Session.ProductForm = this; 
            SetTitles("Продукты");
            SetLabels();
            RefreshProducts();
            SettingsAllowedElements();
        }

        /// <summary>
        /// Обновление списка продуктов
        /// </summary>
        public void RefreshProducts()
        {
            ClearProducts();
            SelectProducts();
            ShowProducts();
            SetAmounOnPage();
        }

        private void SetAmounOnPage()
        {
            labelWhichProducts.Text = $"{flowLayoutPanel1.Controls.Count} из {Program.ctx.Product.Count()}";
        }

        private void ClearProducts()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void SelectProducts()
        {
            IQueryable<Product> filterProducts = Program.ctx.Product;
            string search = TextBoxSearch.Text;

            if (!String.IsNullOrEmpty(search))
            {
                filterProducts = filterProducts.Where(p =>
                    p.ProductName.Name.Contains(search)
                );
            }

            filterProducts = RadioButtonFew.Checked
                ? filterProducts.OrderBy(p => p.Price - (p.Price * p.DiscountProbably / 100m))
                : filterProducts.OrderByDescending(p => p.Price - (p.Price * p.DiscountProbably / 100m));

            if (ComboBoxDiscount.SelectedIndex != -1)
            {
                switch (ComboBoxDiscount.SelectedIndex)
                {
                    case 1:
                        filterProducts = filterProducts.Where(p => p.DiscountProbably >= 0 && p.DiscountProbably < 10);
                        break;
                    case 2:
                        filterProducts = filterProducts.Where(p => p.DiscountProbably >= 10 && p.DiscountProbably < 15);
                        break;
                    case 3:
                        filterProducts = filterProducts.Where(p => p.DiscountProbably >= 15);
                        break;
                }
            }

            products = filterProducts.ToList();
        }

        private void ShowProducts()
        {
            foreach (var product in products)
            {
                flowLayoutPanel1.Controls.Add(new ProductUserControl(product));
            }
        }

        private void SettingsAllowedElements()
        {
            if (Session.User.Role.Id != 1)
            {
                ButtonAddProduct.Visible = false;
            }

            if (Session.User.Role.Id == 3 || Session.User.Role.Id == 4)
            {
                panel1.Visible = false;
            }
        }

        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RadioButtonMore_CheckedChanged(object sender, EventArgs e)
        {
            RefreshProducts();
        }

        private void RadioButtonFew_CheckedChanged(object sender, EventArgs e)
        {
            RefreshProducts();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshProducts();
        }

        private void ComboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshProducts();
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            EditProductForm epf = new EditProductForm(new Product());
            if (epf.ShowDialog() == DialogResult.Yes)
            {
                RefreshProducts();
            }
        }
    }
}