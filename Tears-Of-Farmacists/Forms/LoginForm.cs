using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenter.Views;

namespace Tears_Of_Farmacists.Forms
{
    public partial class LoginForm : Form, ILoginForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public event Func<string, string, bool> Login;

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_Login_Click(object sender, EventArgs e)
        {
            if (TB_Login.Text != string.Empty && TB_Login.Text != ""&& Login(TB_Login.Text, TB_Pass.Text))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TB_Pass.Text = String.Empty;
                TB_Login.Text = String.Empty;
            }
        }


        private void TB_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                B_Login_Click(sender, e);
            }
        }
    }
}
