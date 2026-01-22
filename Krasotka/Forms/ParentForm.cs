using Krasotka.Utils;
using System;
using System.Windows.Forms;

namespace Krasotka.Forms
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Скрытие кнопки выхода
        /// </summary>
        public void InvisibleElements()
        {
            ButtonLogout.Visible = false;
            labelName.Visible = false;
            labelRole.Visible = false;
        }

        /// <summary>
        /// Заполнение заголовка и имени формы
        /// </summary>
        public void SetTitles(string title)
        {
            labelTitle.Text = title;
            Text = title;
        }

        /// <summary>
        /// Заполнение лейблов
        /// </summary>
        public void SetLabels()
        {
            labelRole.Text = Session.User.Role.Name;
            labelName.Text = Session.User.Name;
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
