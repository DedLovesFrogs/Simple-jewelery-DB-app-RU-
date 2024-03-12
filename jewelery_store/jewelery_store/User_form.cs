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

namespace jewelery_store
{

    public partial class User_form : Form
    {
        public User_form()
        {
            InitializeComponent();
        }

        Jewelery_DB dataBase = new Jewelery_DB();

        int selectedRow;

        

        private void CreateColumns()
        {

            dGV1_Requests.Columns.Add("id", "id");
            dGV1_Requests.Columns.Add("client_task_req", "Запрос заказчика");
            dGV1_Requests.Columns.Add("IsNew", String.Empty);

            dGV2_Orders.Columns.Add("id", "id");
            dGV2_Orders.Columns.Add("client_name", "Имя клиента");
            dGV2_Orders.Columns.Add("task", "Задание");
            dGV2_Orders.Columns.Add("price", "Цена");
            dGV2_Orders.Columns.Add("worker_name", "Имя работника");
            dGV2_Orders.Columns.Add("IsNew", String.Empty);

            dGV1_Requests.Columns["IsNew"].Visible = false;
            dGV2_Orders.Columns["IsNew"].Visible = false;
        }

        private void ReadSingleRow1(DataGridView dgw, IDataRecord record1)
        {
            dgw.Rows.Add(record1.GetInt32(0),
                record1.GetString(1),
                RowState.ModifiedNew);
        }

        private void RefreshDataGrid1(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querystring = $"select id, client_tast_req from Requests where client_name_req = '{internal_vars.clnt_name}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow1(dgw, reader);
            }
            reader.Close();
        }

        private void ReadSingleRow2(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0),
                record.GetInt32(1),
                record.GetString(2),
                record.GetInt32(3),
                record.GetInt32(4),
                RowState.ModifiedNew);
        }

        private void RefreshDataGrid2(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querystring = $"select * from Zakazy where client_name = '{internal_vars.clnt_id}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow2(dgw, reader);
            }
            reader.Close();
        }

        private void User_form_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;

            CreateColumns();
            RefreshDataGrid1(dGV1_Requests);
            RefreshDataGrid2(dGV2_Orders);

            label_username_user.Text = "Добро пожаловать, " + internal_vars.clnt_name;
            textBox1_Client_name_req.Text = internal_vars.clnt_name;
        }

        private void dGV1_Requests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGV1_Requests.Rows[selectedRow];

                textBox1_id.Text = row.Cells[0].Value.ToString();
                textBox1_client_req.Text = row.Cells[1].Value.ToString();
                textBox1_Client_name_req.Text = internal_vars.clnt_name.ToString();

            }
        }

        private void dGV2_Orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGV2_Orders.Rows[selectedRow];

                label_client_name_order.Text = row.Cells[1].Value.ToString();
                label_task_order.Text = row.Cells[2].Value.ToString();
                label_price_order.Text = row.Cells[3].Value.ToString();
                label_worker_name_order.Text = row.Cells[4].Value.ToString();

            }
        }

        private void deleteRow()
        {
            int index = dGV1_Requests.CurrentCell.RowIndex;

            dGV1_Requests.Rows[index].Visible = false;

            if (dGV1_Requests.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dGV1_Requests.Rows[index].Cells[1].Value = RowState.Deleted;
                return;
            }

            dGV1_Requests.Rows[index].Cells[2].Value = RowState.Deleted;

        }

        private void Update()
        {
            dataBase.openConnection();

            for (int index = 0; index < dGV1_Requests.Rows.Count; index++)
            {
                var rowState = (RowState)dGV1_Requests.Rows[index].Cells[2].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dGV1_Requests.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Requests where id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {

                    var client_id = dGV1_Requests.Rows[index].Cells[0].Value.ToString();
                    var client_req = dGV1_Requests.Rows[index].Cells[1].Value.ToString();

                    var changeQuery = $"update Requests set client_tast_req = '{client_req}' where id = '{client_id}'";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
            RefreshDataGrid1(dGV1_Requests);
        }

        private void Change()
        {
            
            try
            {
                var selectedRowIndex0 = dGV1_Requests.CurrentCell.RowIndex;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Нажмите на кнопку Отправить запрос", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRowIndex = dGV1_Requests.CurrentCell.RowIndex;

            var client_id = textBox1_id.Text;
            var client_req = textBox1_client_req.Text;

            if (dGV1_Requests.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dGV1_Requests.Rows[selectedRowIndex].SetValues(client_id, client_req);
                dGV1_Requests.Rows[selectedRowIndex].Cells[2].Value = RowState.Modified;
            }
            else
            {
                MessageBox.Show("Проверьте заполненность строк", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button1_delete_record_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                deleteRow();
                Update();
                textBox1_id.Clear();
                textBox1_Client_name_req.Clear();
                textBox1_client_req.Clear();
                MessageBox.Show("Запись удалена", "Готово");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Действие отменено");
            }
        }

        private void button1_save_changes_Click(object sender, EventArgs e)
        {
            Change();
            Update();
        }

        private void button1_add_record_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var client_req = textBox1_client_req.Text;

            if (client_req != String.Empty)

            {
                var addQuery = $"insert into Requests (client_name_req, client_tast_req, id_hidden) values ('{internal_vars.clnt_name}', '{client_req}', '{internal_vars.clnt_id}')";

                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Проверьте поле запроса на заполненность", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataBase.closeConnection();
            RefreshDataGrid1(dGV1_Requests);
        }
    }
}

