using Krasotka.Models;
using Krasotka.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krasotka.Forms
{
    /// <summary>
    /// Форма добавления / редактирования товара
    /// </summary>
    public partial class EditProductForm : ParentForm
    {
        private Product targetProduct;
        public EditProductForm(Product Product)
        {
            InitializeComponent();
            SetTitles("Параметры продукта");
            SetLabels();
            targetProduct = Product;
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "krasotka_dnDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.krasotka_dnDataSet.Category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "krasotka_dnDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.krasotka_dnDataSet.Supplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "krasotka_dnDataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.krasotka_dnDataSet.Manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "krasotka_dnDataSet.Unit". При необходимости она может быть перемещена или удалена.
            this.unitTableAdapter.Fill(this.krasotka_dnDataSet.Unit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "krasotka_dnDataSet.ProductName". При необходимости она может быть перемещена или удалена.
            this.productNameTableAdapter.Fill(this.krasotka_dnDataSet.ProductName);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "krasotka_dnDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.krasotka_dnDataSet.Product);
            FillElements();
        }

        private void FillModel()
        {
            targetProduct.Article = articleTextBox.Text;
            targetProduct.ProductNameId = (int)productNameComboBox.SelectedValue;
            targetProduct.UnitId = (int)unitComboBox.SelectedValue;
            targetProduct.SupplierId = (int)supplierComboBox.SelectedValue;
            targetProduct.ManufacturerId = (int)manufacturerComboBox.SelectedValue;
            targetProduct.Price = (int)priceNumericUpDown.Value;
            targetProduct.DiscountActual = (int)discountActualNumericUpDown.Value;
            targetProduct.DiscountProbably = (int)discountProbablyNumericUpDown.Value;
            targetProduct.Description = descriptionTextBox.Text;
            targetProduct.Photo = photoTextBox.Text;
            targetProduct.CategoryId = (int)categoryComboBox.SelectedValue;
            targetProduct.Amount = (int)amountNumericUpDown.Value;
        }

        private void FillElements()
        {
            if (targetProduct.Id != 0)
            {
                articleTextBox.Text = targetProduct.Article;
                productNameComboBox.SelectedValue = targetProduct.ProductNameId;
                unitComboBox.SelectedValue = targetProduct.UnitId;
                supplierComboBox.SelectedValue = targetProduct.SupplierId;
                manufacturerComboBox.SelectedValue = targetProduct.ManufacturerId;
                priceNumericUpDown.Value = (decimal)targetProduct.Price;
                discountActualNumericUpDown.Value = (decimal)targetProduct.DiscountActual;
                descriptionTextBox.Text = targetProduct.Description;
                photoTextBox.Text = targetProduct.Photo;
                categoryComboBox.SelectedValue = targetProduct.CategoryId;
                amountNumericUpDown.Value = (decimal)targetProduct.Amount;
            }
            else
            {
                articleTextBox.Text = string.Empty;
                productNameComboBox.SelectedValue = -1;
                unitComboBox.SelectedValue = -1;
                supplierComboBox.SelectedValue = -1;
                manufacturerComboBox.SelectedValue = -1;
                priceNumericUpDown.Value = 1;
                discountActualNumericUpDown.Value = 0;
                descriptionTextBox.Text = string.Empty;
                photoTextBox.Text = string.Empty;
                categoryComboBox.SelectedValue = -1;
                amountNumericUpDown.Value = 0;
            }
        }

        private bool ValidateForm()
        {
            if (
                articleTextBox.Text == string.Empty ||
                productNameComboBox.SelectedIndex == -1 ||
                unitComboBox.SelectedIndex == -1 ||
                supplierComboBox.SelectedIndex == -1 ||
                manufacturerComboBox.SelectedIndex == -1 ||
                priceNumericUpDown.Value <= 0 ||
                descriptionTextBox.Text == string.Empty ||
                photoTextBox.Text == string.Empty ||
                categoryComboBox.SelectedIndex == -1 ||
                amountNumericUpDown.Value <= 0
            )
            {
                return false;
            }
            return true;
        }

        private void ButtonAddPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Filter = "Изображения (*.jpg;*.png;*jpeg)|(*.jpg;*.png;*jpeg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                photoTextBox.Text = SaveFile(openFileDialog1.FileName);
                targetProduct.Photo = SaveFile(openFileDialog1.FileName);
            }
        }

        private string SaveFile(string source)
        {
            string fileName = Guid.NewGuid().ToString().Substring(0, 8) + Path.GetExtension(source);
            File.Copy(source, Path.Combine(Path.Combine(Application.StartupPath, "img"), fileName));
            return fileName;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Заполнены не все поля!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                FillModel();
                try
                {
                    if (targetProduct.Id == 0)
                    {
                        Program.ctx.Product.Add(targetProduct);
                    }
                    else
                    {
                        Program.ctx.Entry(targetProduct).State = System.Data.Entity.EntityState.Modified;
                    }

                    Program.ctx.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Session.ProductForm.RefreshProducts();
                MessageBox.Show("Данные сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
