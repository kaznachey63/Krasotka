using Krasotka.Forms;
using Krasotka.Models;
using Krasotka.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krasotka.Controls
{
    public partial class ProductUserControl : UserControl
    {
        private Product product;
        public ProductUserControl(Product Product)
        {
            InitializeComponent();
            product = Product;
            FillUserControl();
            HighliteDiscount();
            InvisibleButtonRemove();
        }

        private void InvisibleButtonRemove()
        {
            if (Session.User.RoleId != 1) ButtonRemove.Visible = false;
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Точно желаете удалить данный продукт?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Program.ctx.Product.Remove(product);
                    Program.ctx.SaveChanges();
                }
                catch 
                {
                    MessageBox.Show("Не удалось удалить товар, он заказан", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Session.ProductForm.RefreshProducts();
            }   
        }

        private void FillUserControl()
        {
            if (product.Id == 0) return;
            labelName.Text = product.ProductName.Name;
            labelDescription.Text = product.Description;
            labelManufacturer.Text = product.Manufacturer.Name;
            labelPercent.Text = product.DiscountActual.ToString();
            labelPrice.Text = (product.Price - (product.Price / 100) * product.DiscountProbably).ToString();
            labelOldPrice.Text = product.Price.ToString();
            PictureBoxPhoto.Image = GetImage();
        }

        private Image GetImage()
        {
            try
            {
                return Image.FromFile(
                    Path.Combine(Application.StartupPath, "img", product?.Photo ?? "picture.png")
                );
            }
            catch
            {
                return Image.FromFile(
                    Path.Combine(Application.StartupPath, "img", "picture.png")
                );
            }
        }

        private void HighliteDiscount()
        {
            if (product.DiscountProbably > 15)
            {
                BackColor = Color.Chartreuse;
            }
        }
            
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (Session.User.RoleId == 3 ||  Session.User.RoleId == 4) { return; }

            EditProductForm epf = new EditProductForm(product);
            if (epf.ShowDialog() == DialogResult.Yes)
            {
                Session.ProductForm.RefreshProducts();
            }
        }
    }
}
