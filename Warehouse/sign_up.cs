using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Warehouse
{
    public partial class sign_up : Form
    {
        DataBase Warehouse = new DataBase();

        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void sign_up_Load(object sender, EventArgs e)
        {
            textBox_password2.PasswordChar = '*';
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();

            var login = textBox_login2.Text;
            var password = textBox_password2.Text;

            string querystring = $"insert into register(login_user, password_user) values ('{login}', '{password}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успішно створено!", "Успіх!");
                log_in frm_login = new log_in();
                this.Hide();
                frm_login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не створено!");
            }
            dataBase.CloseConnection();
        }

        private Boolean checkUser()
        {
            var loginUser = textBox_login2.Text;    
            var passUser = textBox_password2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queystring = $"select id_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}";

            SqlCommand command = new SqlCommand(queystring, Warehouse.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Користувач вже існує!");
                return true;
            }
            else 
            {
                return false;
            }
           


        }

        private void textBox_password2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_login1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
