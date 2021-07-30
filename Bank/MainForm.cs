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
    public partial class MainForm : Form
    {
        string name;
        string surname;
        string login;
        string password;
        string id;
        string pasport;
        string balance_n;
        string balance_alf;


        public string GetName
        {
            get => this.name;
            set => name = value;
        }
        public string GetSurname
        {
            get => this.surname;
            set => surname = value;
        }
        public string GetLogin
        {
            get => this.login;
            set => login = value;
        }
        public string GetPassword
        {
            get => this.password;
            set => password = value;
        }
        public string GetID
        {
            get => this.id;
            set => id = value;
        }
        public string GetPasport
        {
            get => this.pasport;
            set => pasport = value;
        }
        public string GetBalanceN
        {
            get => balance_n;
            set => balance_n = value;
        }
        public string GetBalanceAlf
        {
            get => balance_alf;
            set => balance_alf = value;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            string idPrint = $"{id[0]}{id[1]}{id[2]}{id[3]}     {id[4]}{id[5]}{id[6]}{id[7]}     {id[8]}{id[9]}{id[10]}{id[11]}     {id[12]}{id[13]}{id[14]}{id[15]}";
            cardNumber.Text = idPrint;
            nameAccount.Text = surname + " " + name;
            balance.Text = balance_n + " " + balance_alf;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (menuPanel.Visible == false) menuPanel.Visible = true; else menuPanel.Visible = false; 
        }

        private void trasnClick(object sender, EventArgs e)
        {
            transPanel.Visible = true;
            cardOwn.Text = id;

        }
    }
}
