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
    public partial class SignUpForm : Form
    {
        string name;
        string surname;
        string login;
        string password;
        string id;
        string pasport;
        List<string> emails = new List<string>() { "@gmail.com", "@ukr.net", "@i.ua" };
        MainForm main = new MainForm();

        public string GetName
        {
            get => this.name;
        }
        public string GetSurname
        {
            get => this.surname;
        }
        public string GetLogin
        {
            get => this.login;
        }
        public string GetPassword
        {
            get => this.password;
        }
        public string GetID
        {
            get => this.id;
        }
        public string GetPasport
        {
            get => this.pasport;
        }
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backArrow_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            StartForm start = new StartForm();
            start.Show();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            
        }


        private void registerButt_Click(object sender, EventArgs e)
        {
            name = nameBox.Text;
            surname = snameBox.Text;
            login = loginBox.Text;
            password = passwordMainBox.Text;
            pasport = pasportBox.Text;

            CheckName(name);   //name
            CheckSurname(surname); //surname
            CheckLogin(login); //login
            CheckPassword(password, confBox.Text, ref password); //password
            CheckPasport(pasport);
            
            Random idMaker = new Random();
            for (int i = 0; i < 16; i++)
                id += (idMaker.Next(0, 10));//id

            if(FindSimilar(loginBox.Text, pasportBox.Text) == true)
            {
                ActiveForm.Close();
                StartForm startForm = new StartForm();
                startForm.Show();
                MessageBox.Show("You are already registred. Please log in your account :)");
            } 
            else 
            if ((nameError.Visible == false) && (snameError.Visible == false) && (loginError.Visible == false) && (passwordError.Visible == false) && (confError.Visible == false) && (pasportError.Visible == false))
            {
                WorkWithDB withDB = new WorkWithDB();
                withDB.InsertData(id,name,surname,login,password,pasport);
               
                ActiveForm.Close();
                main.GetName = GetName;
                main.GetSurname = GetSurname;
                main.GetLogin = GetLogin;
                main.GetPassword = GetPassword;
                main.GetID = GetID;
                main.GetPasport = GetPasport;
                main.Show();

            }
            else MessageBox.Show("Write all data correctly!");

        }





        //CHECKING METHODS
        private void CheckName(string name)
        {

            if (name == string.Empty)
                nameError.Visible = true;                          //NAME CHECKING
            else
                nameError.Visible = false;
        }


        private void CheckSurname(string surname)
        {                                                                            //SURNAME CHECKING
            if (surname == string.Empty)
                snameError.Visible = true;
            else
                snameError.Visible = false;
        }


        private void CheckLogin(string login)
        {
            bool buff = false;
            if (login == string.Empty)
                loginError.Visible = true;
            else
                loginError.Visible = false;                        //LOGIN CHECKING
            //LOGIN CHECKING
            foreach (string end in emails)
            {
                if (login.EndsWith(end)) { loginError.Visible = false; buff = true; }
            }
            if (!buff)
            {
                loginError.Visible = true;
                login = string.Empty;
            }
        }

        public void CheckPassword(string password, string reppassword, ref string passMain)
        {
            if (password == string.Empty) passwordError.Visible = true;
            if (password.Length < 8)
            {
                passwordMainBox.Text = string.Empty;
                passwordError.Visible = true;                               //PASSWORD CHECKING
            }
            if (reppassword == string.Empty) confError.Visible = true;
            else if (reppassword == password)
            {
                passMain = password;
                passwordError.Visible = false;
                confError.Visible = false;
            }
            else confError.Visible = true;
        }

        private void CheckPasport(string pasport)
        {
            char[] numbers = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            if ((pasport.Length > 9) || (pasport.Length < 9)) pasportError.Visible = true; else pasportError.Visible = false;

            foreach(char num in pasport)
            {
                if (numbers.Contains(num))                                   // PASPORT CHECKING
                {
                    pasportError.Visible = false;
                }
                else pasportError.Visible = true;
            }

        }

        private bool FindSimilar(string login, string pasport)
        {
            DataBase dbr = new DataBase();
            dbr.openConnection();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand commandSimilar = new MySqlCommand("SELECT * FROM `accounts` WHERE `login` = @CL OR `pasport`= @CP", dbr.getConnection());
            commandSimilar.Parameters.Add("@CL", MySqlDbType.VarChar).Value = login;
            commandSimilar.Parameters.Add("@CP", MySqlDbType.VarChar).Value = pasport;
            adapter.SelectCommand = commandSimilar;
            adapter.Fill(dataTable);
            dbr.closeConnection();

            if (dataTable.Rows.Count > 0) return true; else return false;
        }
    }
}
