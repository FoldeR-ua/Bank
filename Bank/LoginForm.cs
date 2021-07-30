using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bank
{
    public partial class LoginForm : Form
    {

        string login;
        string password;

        MainForm mainForm = new MainForm();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {
            loginBox.ForeColor = Color.Black;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
          
        }

        private void ActivateLogin(object sender, EventArgs e)
        {
            loginBox.Text = string.Empty;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EnterButt_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            login = loginBox.Text;
            password = passBox.Text;
            
            WorkWithDB bdw = new WorkWithDB();
            
            bdw.CheckAccount(ref table, login, password);


            if (table.Rows.Count > 0)
            {
                bdw.ExtractData(ref mainForm, login);

                ActiveForm.Close();
                mainForm.Show();
            }
            else
            {
                errorLabel.Visible = true;
                loginBox.Text = string.Empty;
                passBox.Text = string.Empty;
            }
        }

        private void backArrow_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            StartForm startForm = new StartForm();
            startForm.Show();
        }
    }
}
