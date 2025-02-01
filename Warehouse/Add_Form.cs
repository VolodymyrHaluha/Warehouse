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
    public partial class Add_Form : Form
    {

        DataBase database = new DataBase();

        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var name = textBox_Name2.Text;
            var quantity = textBox_Quantity2.Text;
            var posta = textBox_Posta2.Text;
            var date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            if (string.IsNullOrWhiteSpace(quantity) || !decimal.TryParse(quantity, out decimal parsedQuantity) || parsedQuantity <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну кількість (позитивне число).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var addQuery = "INSERT INTO Warehouse (SubstanceName, QuantityKg, DateAdded, Posta) VALUES (@name, @quantity, @date, @posta)";

            var command = new SqlCommand(addQuery, database.getConnection());
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@posta", posta);

            command.ExecuteNonQuery();

            MessageBox.Show("Запис успішно створено!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            database.CloseConnection();
        }

        private void TextBox_Quantity2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Дозволяємо тільки цифри, крапку (для дробових чисел) та керуючі символи (наприклад, Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Забороняємо вводити недозволені символи
            }

            // Забороняємо введення більше однієї крапки
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }

            // Забороняємо вводити від'ємний знак
            if (e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
