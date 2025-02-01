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

    enum RoWState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }



    public partial class Form1 : Form
    {
        DataBase database = new DataBase();

        int selectedRow;



        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Id", "id");
            dataGridView1.Columns.Add("SubstanceName", "Назва");
            dataGridView1.Columns.Add("QuantityKg", "Вага");
            dataGridView1.Columns.Add("DateAdded", "Дата додавання");
            dataGridView1.Columns.Add("Posta", "Постачальник");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }


        private void ClearFields()
        {
            textBox_id.Text = "";
            textBox_Name.Text = "";
            textBox_Quantity.Text = "";
            textBox_Date.Text = "";
            textBox_Posta.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetFloat(2), record.GetDateTime(3), record.GetString(4), RoWState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Warehouse";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {

                ReadSingleRow(dgw, reader);

            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_Name.Text = row.Cells[1].Value.ToString();
                textBox_Quantity.Text = row.Cells[2].Value.ToString();
                textBox_Date.Text = row.Cells[3].Value.ToString();
                textBox_Posta.Text = row.Cells[4].Value.ToString();
            }
        }


        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Warehouse where concat (Id, SubstanceName, QuantityKg, DateAdded, Posta) like '%" + textBox_search.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());

            database.openConnection();


            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {

                ReadSingleRow(dgw, read);
            }



            read.Close();
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;


            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RoWState.Deleted;
            }
        }


        private void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RoWState)dataGridView1.Rows[index].Cells[5].Value;

                if (rowState == RoWState.Existed)
                {

                    continue;
                }

                if (rowState == RoWState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Warehouse where Id = {id}";

                    var command = new SqlCommand(deleteQuery, database.getConnection());

                    command.ExecuteNonQuery();

                }
                if (rowState == RoWState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var quantity = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var date = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var posta = dataGridView1.Rows[index].Cells[4].Value.ToString();


                    var changeQuery = $"update Warehouse set SubstanceName = '{name}', QuantityKg = '{quantity}', DateAdded = '{date}', Posta = '{posta}' where id = '{id}'";

                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

            }
            database.CloseConnection();
        }


        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }




        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Posta_Click(object sender, EventArgs e)
        {

        }

        private void DateAdded_Click(object sender, EventArgs e)
        {

        }

        private void QuantityKg_Click(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void btn_search2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Add_Form addfrm = new Add_Form();
            addfrm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }


        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;


            var id = textBox_id.Text;
            var name = textBox_Name.Text;
            var quantity = textBox_Quantity.Text;
            var date = DateTime.Now.Date;
            var posta = textBox_Posta.Text;


            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(id, name, quantity, date, posta);
                dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RoWState.Modified;
            }

            else
            {
                MessageBox.Show("Щось пішло не так!");
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Update();
            ClearFields();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}