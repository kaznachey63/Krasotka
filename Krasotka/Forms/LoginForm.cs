using Krasotka.Models;
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

namespace Krasotka.Forms
{
    /// <summary>
    /// Форма авторизации
    /// </summary>
    public partial class LoginForm : ParentForm
    {
        public LoginForm()
        {
            InitializeComponent();
            InvisibleElements();
            SetTitles("Вход");
        }

        private bool ValidateLoginForm()
        {
            if (!String.IsNullOrEmpty(textBoxLogin.Text) && !String.IsNullOrEmpty(textBoxPassword.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateLoginForm())
            {
                MessageBox.Show("Заполнены не все поля!", "Заполнение данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else 
            { 
                Login(textBoxLogin.Text,textBoxPassword.Text);
            }
        }
        private void Login(string login, string password)
        {

            User user = Program.ctx.User.Where(u => login == u.Login && password == u.Password).FirstOrDefault();

            if (user != null)
            {
                Session.User = user;
                MessageBox.Show($"Добро пожаловать {user.Name}!");
                Hide();
                ProductForm pf = new ProductForm();
                pf.Show();
            }
            else
            {
                MessageBox.Show("Заполнены не все данные!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void ButtonGuest_Click(object sender, EventArgs e)
        {
            Login("g", "g");
            Hide();
            ProductForm pf = new ProductForm();
            pf.Show();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
