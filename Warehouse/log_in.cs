using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Warehouse
{
    public partial class log_in : Form
    {
        DataBase Warehouse = new DataBase();

        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_up frm_sign = new sign_up();
            frm_sign.Show();
            this.Hide();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, Warehouse.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Ви успішно ввійшли","Успіх!", MessageBoxButtons.OK , MessageBoxIcon.Information );
                Form1 frm1 = new Form1();
                this.Hide();    
                frm1.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Ви не ввійшли", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
