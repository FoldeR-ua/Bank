using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace Bank
{
    class DataBase
    {
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=bank");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                }
                catch
                {
                    MessageBox.Show("Something wrong with connection . . .");
                }
            }

        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection getConnection() => connection;


    }


    class WorkWithDB
    {
        public void CheckAccount(ref DataTable table, string login, string password)
        {
            DataBase db = new DataBase();
            db.openConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand($"SELECT * FROM `accounts` WHERE `login` = @UL AND `password`= @UP", db.getConnection());
            command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@UP", MySqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;

            try
            {
                adapter.Fill(table);
            }
            catch
            {
                Application.Exit();
            }
            db.closeConnection();
        }

        public void ExtractData(ref MainForm mainForm, string login)
        {
            DataBase mySqlConnection = new DataBase();
            try
            {
                MySqlCommand commandRead = new MySqlCommand($"SELECT `name`, `surname`, `pasport`, `id`, `balance_n`, `balance_alf` FROM `accounts` WHERE `login` = '{login}'", mySqlConnection.getConnection());
                mySqlConnection.openConnection();

                MySqlDataReader reader = commandRead.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        mainForm.GetName = reader.GetString(0);
                        mainForm.GetSurname = reader.GetString(1);
                        mainForm.GetPasport = reader.GetString(2);
                        mainForm.GetID = reader.GetString(3);
                        mainForm.GetBalanceN = reader.GetString(4);
                        mainForm.GetBalanceAlf = reader.GetString(5);
                    }
                }
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Something wrong with server connnection . . .");
            }
            mySqlConnection.closeConnection();
        }

        public void InsertData(string id, string name, string surname, string login, string password, string pasport)
        {
            DataBase signConnection = new DataBase();

            try
            {
                signConnection.openConnection();
            }
            catch
            {
                MessageBox.Show(" Something wrong with connection . . . ");
            }

            MySqlCommand commandInsert = new MySqlCommand($"INSERT INTO `accounts`(`id`, `login`, `password`, `name`, `surname`, `pasport`, `balance_n`, `balance_alf`) VALUES ( @id, @login , @password , @name , @surname , @pasport , '0' , 'grn' )", signConnection.getConnection());
            commandInsert.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            commandInsert.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            commandInsert.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
            commandInsert.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            commandInsert.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname;
            commandInsert.Parameters.Add("@pasport", MySqlDbType.VarChar).Value = pasport;
            try
            {
                commandInsert.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Can not to execute this SQL command . . . Please, wait . . .");
            }
            signConnection.closeConnection();
        }
    }
}
