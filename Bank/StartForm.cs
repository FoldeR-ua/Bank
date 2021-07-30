using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signupB_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
        }
    }
}
