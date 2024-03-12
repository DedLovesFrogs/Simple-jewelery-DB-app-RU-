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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Menu : Form
    {

        Jewelery_DB dataBase = new Jewelery_DB();

        int selectedRow;

        public string User_Welcome
        {
            get { return label_username.Text; }
            set { label_username.Text = value; }
        }

        public Menu()
        {
            InitializeComponent();

        }

        private void CreateColumns()
        {
            dGV1_Orders.Columns.Add("id", "id");
            dGV1_Orders.Columns.Add("client_name", "Имя клиента");
            dGV1_Orders.Columns.Add("task", "Задание");
            dGV1_Orders.Columns.Add("price", "Цена");
            dGV1_Orders.Columns.Add("worker_name", "Имя работника");
            dGV1_Orders.Columns.Add("IsNew", String.Empty);

            dGV2_Requests.Columns.Add("id", "id");
            dGV2_Requests.Columns.Add("client_name_req", "Имя заказчика");
            dGV2_Requests.Columns.Add("client_task_req", "Запрос заказчика");
            dGV2_Requests.Columns.Add("hidden_id", "hid_id");
            dGV2_Requests.Columns.Add("IsNew", String.Empty);

            dGV3_Supply.Columns.Add("id", "id");
            dGV3_Supply.Columns.Add("product", "Материал");
            dGV3_Supply.Columns.Add("price", "Цена");
            dGV3_Supply.Columns.Add("quantity", "Количество");
            dGV3_Supply.Columns.Add("total", "Итого");
            dGV3_Supply.Columns.Add("seller", "Продавец");
            dGV3_Supply.Columns.Add("IsNew", String.Empty);

            dGV4_Workers.Columns.Add("worker_id", "id");
            dGV4_Workers.Columns.Add("worker_name", "ФИО работника");
            dGV4_Workers.Columns.Add("worker_login", "Логин работника");
            dGV4_Workers.Columns.Add("worker_password", "Пароль работника");
            dGV4_Workers.Columns.Add("worker_pos", "Должность");
            dGV4_Workers.Columns.Add("IsNew", String.Empty);

            dGV5_Clients.Columns.Add("client_id", "id");
            dGV5_Clients.Columns.Add("client_name", "ФИО клиента");
            dGV5_Clients.Columns.Add("task", "Задание от клиента");
            dGV5_Clients.Columns.Add("debt_amount", "Задолженность");
            dGV5_Clients.Columns.Add("client_login", "Логин клиента");
            dGV5_Clients.Columns.Add("client_pass", "Пароль клиента");
            dGV5_Clients.Columns.Add("IsNew", String.Empty);

            dGV1_Orders.Columns["IsNew"].Visible = false;
            dGV2_Requests.Columns["IsNew"].Visible = false;
            dGV2_Requests.Columns["hidden_id"].Visible = false;
            dGV3_Supply.Columns["IsNew"].Visible = false;
            dGV4_Workers.Columns["IsNew"].Visible = false;
            dGV5_Clients.Columns["IsNew"].Visible = false;

        }

        private void ReadSingleRow0(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0),
                record.GetInt32(1),
                record.GetString(2),
                record.GetInt32(3),
                record.GetInt32(4),
                RowState.ModifiedNew);
        }

        private void RefreshDataGrid0(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querystring = $"select * from Zakazy";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow0(dgw, reader);
            }
            reader.Close();
        }

        private void ReadSingleRow1(DataGridView dgw1, IDataRecord record1)
        {
            dgw1.Rows.Add(record1.GetInt32(0),
                record1.GetString(1),
                record1.GetString(2),
                record1.GetInt32(3),
                RowState.ModifiedNew);
        }

        private void RefreshDataGrid1(DataGridView dgw1)
        {
            dgw1.Rows.Clear();

            string querystring1 = $"select * from Requests";

            SqlCommand command1 = new SqlCommand(querystring1, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader1 = command1.ExecuteReader();

            while (reader1.Read())
            {
                ReadSingleRow1(dgw1, reader1);
            }
            reader1.Close();
        }

        private void ReadSingleRow2(DataGridView dgw2, IDataRecord record2)
        {
            dgw2.Rows.Add(record2.GetInt32(0),
                record2.GetString(1),
                record2.GetInt32(2),
                record2.GetInt32(3),
                record2.GetInt64(4),
                record2.GetString(5),
                RowState.ModifiedNew);
        }

        private void RefreshDataGrid2(DataGridView dgw2)
        {
            dgw2.Rows.Clear();

            string querystring2 = $"select * from Postavki";

            SqlCommand command2 = new SqlCommand(querystring2, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                ReadSingleRow2(dgw2, reader2);
            }
            reader2.Close();
        }

        private void ReadSingleRow3(DataGridView dgw3, IDataRecord record3)
        {
            dgw3.Rows.Add(record3.GetInt32(0),
                record3.GetString(1),
                record3.GetString(2),
                record3.GetString(3),
                record3.GetInt32(4),
                RowState.ModifiedNew);
        }

        private void RefreshDataGrid3(DataGridView dgw3)
        {
            dgw3.Rows.Clear();

            string querystring3 = $"select * from Workers";

            SqlCommand command3 = new SqlCommand(querystring3, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader3 = command3.ExecuteReader();

            while (reader3.Read())
            {
                ReadSingleRow3(dgw3, reader3);
            }
            reader3.Close();
        }

        private void ReadSingleRow4(DataGridView dgw4, IDataRecord record4)
        {
            dgw4.Rows.Add(record4.GetInt32(0),
                record4.GetString(1),
                record4.GetString(2),
                record4.GetString(3),
                record4.GetString(4),
                record4.GetString(5),
                RowState.ModifiedNew);
        }

        private void RefreshDataGrid4(DataGridView dgw4)
        {
            dgw4.Rows.Clear();

            string querystring4 = $"select * from Clients";

            SqlCommand command4 = new SqlCommand(querystring4, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader4 = command4.ExecuteReader();

            while (reader4.Read())
            {
                ReadSingleRow4(dgw4, reader4);
            }
            reader4.Close();
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "jewelery_storeDataSet.position". При необходимости она может быть перемещена или удалена.
            this.positionTableAdapter.Fill(this.jewelery_storeDataSet.position);
            StartPosition = FormStartPosition.CenterScreen;
            CreateColumns();
            RefreshDataGrid0(dGV1_Orders);
            RefreshDataGrid1(dGV2_Requests);
            RefreshDataGrid2(dGV3_Supply);
            RefreshDataGrid3(dGV4_Workers);
            RefreshDataGrid4(dGV5_Clients);


            if (internal_vars.Usr_pos != 2)
            {
                tabControl1.TabPages.Remove(tabPage4_Workers);
                label7.Visible = false;
                label8.Visible = false;
                button5_add_record.Visible = false;
                button5_delete_record.Visible = false;
                textBox5_client_name.ReadOnly = true;
                textBox5_login.Visible = false;
                textBox5_pass.Visible = false;
                dGV5_Clients.Columns["client_login"].Visible = false;
                dGV5_Clients.Columns["client_pass"].Visible = false;
            }


            dataBase.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table_clients = new DataTable();

            string querystring = $"select * from Clients";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table_clients);

            for (var i = 0; i < table_clients.Rows.Count; i++)
            {
                table_clients.Rows[i][1] = (string)table_clients.Rows[i][1];
            }

            comboBox1_client_name.DataSource = table_clients;
            comboBox1_client_name.ValueMember = "client_id";
            comboBox1_client_name.DisplayMember = "client_name";



            SqlDataAdapter adapter2 = new SqlDataAdapter();
            DataTable table_workers = new DataTable();

            string querystring2 = $"select * from Workers";

            SqlCommand command2 = new SqlCommand(querystring2, dataBase.getConnection());

            adapter2.SelectCommand = command2;
            adapter2.Fill(table_workers);

            for (var i = 0; i < table_workers.Rows.Count; i++)
            {
                table_workers.Rows[i][1] = (string)table_workers.Rows[i][1];
            }

            comboBox1_worker_name.DataSource = table_workers;
            comboBox1_worker_name.ValueMember = "worker_id";
            comboBox1_worker_name.DisplayMember = "worker_name";

            dataBase.closeConnection();

        }

        private void dGV1_Orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGV1_Orders.Rows[selectedRow];

                textBox1_id.Text = row.Cells[0].Value.ToString();
                comboBox1_client_name.SelectedValue = row.Cells[1].Value.ToString();
                textBox1_task.Text = row.Cells[2].Value.ToString();
                textBox1_price.Text = row.Cells[3].Value.ToString();
                comboBox1_worker_name.SelectedValue = row.Cells[4].Value.ToString();

            }
        }

        private void dGV2_Requests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGV2_Requests.Rows[selectedRow];

                textBox2_id.Text = row.Cells[0].Value.ToString();
                textBox2_Client_name_req.Text = row.Cells[1].Value.ToString();
                textBox2_client_req.Text = row.Cells[2].Value.ToString();
                internal_vars.clnt_id_dyn = Convert.ToInt32(row.Cells[3].Value);

            }
        }

        private void dGV3_Supply_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGV3_Supply.Rows[selectedRow];

                textBox3_id.Text = row.Cells[0].Value.ToString();
                textBox3_product.Text = row.Cells[1].Value.ToString();
                textBox3_price.Text = row.Cells[2].Value.ToString();
                textBox3_quantity.Text = row.Cells[3].Value.ToString();
                textBox3_total.Text = row.Cells[4].Value.ToString();
                textBox3_seller.Text = row.Cells[5].Value.ToString();

            }
        }

        private void dGV4_Workers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGV4_Workers.Rows[selectedRow];

                textBox4_id.Text = row.Cells[0].Value.ToString();
                textBox4_worker_name.Text = row.Cells[1].Value.ToString();
                textBox4_login.Text = row.Cells[2].Value.ToString();
                textBox4_password.Text = row.Cells[3].Value.ToString();
                comboBox4_pos.SelectedValue = row.Cells[4].Value.ToString();

            }
        }

        private void dGV5_Clients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGV5_Clients.Rows[selectedRow];

                textBox5_id.Text = row.Cells[0].Value.ToString();
                textBox5_client_name.Text = row.Cells[1].Value.ToString();
                comboBox5_task.SelectedItem = row.Cells[2].Value.ToString();
                comboBox5_debt_amount.SelectedItem = row.Cells[3].Value.ToString();
                textBox5_login.Text = row.Cells[4].Value.ToString();
                textBox5_pass.Text = row.Cells[5].Value.ToString();

            }
        }

        private void deleteRow1()
        {
            int index = dGV1_Orders.CurrentCell.RowIndex;

            dGV1_Orders.Rows[index].Visible = false;

            if (dGV1_Orders.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dGV1_Orders.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }

            dGV1_Orders.Rows[index].Cells[5].Value = RowState.Deleted;

        }

        private void Update1()
        {
            dataBase.openConnection();

            for (int index = 0; index < dGV1_Orders.Rows.Count; index++)
            {
                var rowState = (RowState)dGV1_Orders.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dGV1_Orders.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Zakazy where id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }


                if (rowState == RowState.Modified)
                {
                    try
                    {
                        dGV1_Orders.Rows[index].Cells[0].Value.ToString();
                        dGV1_Orders.Rows[index].Cells[1].Value.ToString();
                        dGV1_Orders.Rows[index].Cells[2].Value.ToString();
                        dGV1_Orders.Rows[index].Cells[3].Value.ToString();
                        dGV1_Orders.Rows[index].Cells[4].Value.ToString();
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Проверьте:"
                      + "\n" +
                      "1) Выбран ли необходимый вам элемент в выпадающих меню Имя клиента и Имя работника. "
                      + "\n" +
                      "2) Введено ли числовое значение в строку цены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    var id = dGV1_Orders.Rows[index].Cells[0].Value.ToString();
                    var client_name = dGV1_Orders.Rows[index].Cells[1].Value.ToString();
                    var task = dGV1_Orders.Rows[index].Cells[2].Value.ToString();
                    var price = dGV1_Orders.Rows[index].Cells[3].Value.ToString();
                    var worker_name = dGV1_Orders.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"update Zakazy set client_name = '{client_name}', task = '{task}', price = '{price}', worker_name = '{worker_name}' where id = '{id}'";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            dataBase.closeConnection();

        }

        private void button1_delete_record_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                deleteRow1();
                Update1();
                textBox1_id.Clear();
                comboBox1_client_name.Text = "";
                textBox1_task.Clear();
                textBox1_price.Clear();
                comboBox1_worker_name.Text = "";
                MessageBox.Show("Запись удалена", "Готово");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Действие отменено");
            }
        }

        private void deleteRow2()
        {
            int index = dGV2_Requests.CurrentCell.RowIndex;

            dGV2_Requests.Rows[index].Visible = false;

            if (dGV2_Requests.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dGV2_Requests.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }

            dGV2_Requests.Rows[index].Cells[4].Value = RowState.Deleted;

        }

        private void Update2()
        {
            dataBase.openConnection();

            for (int index = 0; index < dGV2_Requests.Rows.Count; index++)
            {
                var rowState = (RowState)dGV2_Requests.Rows[index].Cells[4].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dGV2_Requests.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Requests where id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }

        private void button2_delete_record_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                deleteRow2();
                Update2();
                textBox2_id.Clear();
                textBox2_Client_name_req.Clear();
                textBox2_client_req.Clear();
                MessageBox.Show("Запись удалена", "Готово");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Действие отменено");
            }
        }

        private void deleteRow3()
        {
            int index = dGV3_Supply.CurrentCell.RowIndex;

            dGV3_Supply.Rows[index].Visible = false;

            if (dGV3_Supply.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dGV3_Supply.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }

            dGV3_Supply.Rows[index].Cells[6].Value = RowState.Deleted;

        }

        private void Update3()
        {
            dataBase.openConnection();

            for (int index = 0; index < dGV3_Supply.Rows.Count; index++)
            {
                var rowState = (RowState)dGV3_Supply.Rows[index].Cells[6].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dGV3_Supply.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Postavki where id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {

                    var id = dGV3_Supply.Rows[index].Cells[0].Value.ToString();
                    var product = dGV3_Supply.Rows[index].Cells[1].Value.ToString();
                    var price = dGV3_Supply.Rows[index].Cells[2].Value.ToString();
                    var quantity = dGV3_Supply.Rows[index].Cells[3].Value.ToString();
                    var total = dGV3_Supply.Rows[index].Cells[4].Value.ToString();
                    var seller = dGV3_Supply.Rows[index].Cells[5].Value.ToString();

                    var changeQuery = $"update Postavki set product = '{product}', price = '{price}', quantity = '{quantity}', total = '{total}', seller = '{seller}' where id = '{id}'";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }

        private void button3_delete_record_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                deleteRow3();
                Update3();
                textBox3_id.Clear();
                textBox3_price.Clear();
                textBox3_product.Clear();
                textBox3_quantity.Clear();
                textBox3_total.Clear();
                MessageBox.Show("Запись удалена", "Готово");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Действие отменено");
            }
        }

        private void deleteRow4()
        {
            int index = dGV4_Workers.CurrentCell.RowIndex;

            dGV4_Workers.Rows[index].Visible = false;

            if (dGV4_Workers.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dGV4_Workers.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }

            dGV4_Workers.Rows[index].Cells[5].Value = RowState.Deleted;

        }

        private void Update4()
        {
            dataBase.openConnection();

            for (int index = 0; index < dGV4_Workers.Rows.Count; index++)
            {
                var rowState = (RowState)dGV4_Workers.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dGV4_Workers.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Workers where worker_id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {

                    var worker_id = dGV4_Workers.Rows[index].Cells[0].Value.ToString();
                    var worker_name = dGV4_Workers.Rows[index].Cells[1].Value.ToString();
                    var worker_login = dGV4_Workers.Rows[index].Cells[2].Value.ToString();
                    var worker_password = dGV4_Workers.Rows[index].Cells[3].Value.ToString();
                    var worker_pos = dGV4_Workers.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"update Workers set worker_name = '{worker_name}', worker_login = '{worker_login}', worker_password = '{worker_password}', worker_position = '{worker_pos}'  where worker_id = '{worker_id}'";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

            }
            dataBase.closeConnection();
        }

        private void button4_delete_record_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                deleteRow4();
                Update4();
                textBox4_id.Clear();
                textBox4_worker_name.Clear();
                MessageBox.Show("Запись удалена", "Готово");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Действие отменено");
            }
        }

        private void deleteRow5()
        {
            int index = dGV5_Clients.CurrentCell.RowIndex;

            dGV5_Clients.Rows[index].Visible = false;

            if (dGV5_Clients.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dGV5_Clients.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }

            dGV5_Clients.Rows[index].Cells[6].Value = RowState.Deleted;

        }

        private void Update5()
        {
            dataBase.openConnection();

            for (int index = 0; index < dGV5_Clients.Rows.Count; index++)
            {
                var rowState = (RowState)dGV5_Clients.Rows[index].Cells[6].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dGV5_Clients.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Clients where client_id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {

                    var client_id = dGV5_Clients.Rows[index].Cells[0].Value.ToString();
                    var client_name = dGV5_Clients.Rows[index].Cells[1].Value.ToString();
                    var task = dGV5_Clients.Rows[index].Cells[2].Value.ToString();
                    var debt_amount = dGV5_Clients.Rows[index].Cells[3].Value.ToString();
                    var client_login = dGV5_Clients.Rows[index].Cells[4].Value.ToString();
                    var client_pass = dGV5_Clients.Rows[index].Cells[5].Value.ToString();

                    var changeQuery = $"update Clients set client_name = '{client_name}', task = '{task}', debt_amount = '{debt_amount}', client_login = '{client_login}', client_password = '{client_pass}' where client_id = '{client_id}'";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

            }
            dataBase.closeConnection();

        }

        private void button5_delete_record_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                deleteRow5();
                Update5();
                textBox5_id.Clear();
                textBox5_client_name.Clear();
                comboBox5_debt_amount.SelectedValue = -1;
                comboBox5_task.SelectedValue = -1;
                MessageBox.Show("Запись удалена", "Готово");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Действие отменено");
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid0(dGV1_Orders);
            RefreshDataGrid1(dGV2_Requests);
            RefreshDataGrid2(dGV3_Supply);
            RefreshDataGrid3(dGV4_Workers);
            RefreshDataGrid4(dGV5_Clients);
        }

        private void button1_add_record_Click_1(object sender, EventArgs e)
        {
            Add_new_dGV1 addfrm_1 = new Add_new_dGV1();
            addfrm_1.ShowDialog();
        }

        private void button2_add_record_Click(object sender, EventArgs e)
        {
            if (textBox2_client_req.Text == String.Empty)
            {
                MessageBox.Show("Не выбрана запись");
            }
            else
            {
                Add_new_dGV2 addfrm_2 = new Add_new_dGV2();
                addfrm_2.comboBox1_client_name.SelectedValue = internal_vars.clnt_id_dyn;
                addfrm_2.textBox2_client_task_req.Text = this.textBox2_client_req.Text;
                addfrm_2.ShowDialog();
            }
        }

        private void button3_add_record_Click(object sender, EventArgs e)
        {
            Add_new_dGV3 addfrm_3 = new Add_new_dGV3();
            addfrm_3.ShowDialog();
        }

        private void button4_add_record_Click(object sender, EventArgs e)
        {
            Add_new_dGV4 addfrm_4 = new Add_new_dGV4();
            addfrm_4.ShowDialog();
        }

        private void button5_add_record_Click(object sender, EventArgs e)
        {
            Add_new_dGV5 addfrm_5 = new Add_new_dGV5();
            addfrm_5.ShowDialog();
        }

        private void Change1()
        {
            var selectedRowIndex = dGV1_Orders.CurrentCell.RowIndex;

            var id = textBox1_id.Text;
            var client_name = comboBox1_client_name.SelectedValue;
            var task = textBox1_task.Text;
            int price;
            var worker_name = comboBox1_worker_name.SelectedValue;

            if (dGV1_Orders.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if ((int.TryParse(textBox1_price.Text, out price) &
                    (Convert.ToInt32(comboBox1_client_name.SelectedValue) >= 0) &
                    (Convert.ToInt32(comboBox1_worker_name.SelectedValue) >= 0)))
                {
                    dGV1_Orders.Rows[selectedRowIndex].SetValues(id, client_name, task, price, worker_name);
                    dGV1_Orders.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Проверьте:"
                       + "\n" +
                       "1. Выбран ли необходимый вам элемент в выпадающих меню Имя клиента и Имя работника. "
                       + "\n" +
                       " 2)Введено ли числовое значение в строку цены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Change3()
        {
            var selectedRowIndex = dGV3_Supply.CurrentCell.RowIndex;

            var id = textBox3_id.Text;
            var product = textBox3_product.Text;
            int price;
            int quantity;
            int total;
            var seller = textBox3_seller.Text;

            if (dGV3_Supply.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox3_price.Text, out price) &
                    int.TryParse(textBox3_quantity.Text, out quantity) &
                    int.TryParse(textBox3_total.Text, out total))
                {
                    dGV3_Supply.Rows[selectedRowIndex].SetValues(id, product, price, quantity, total, seller);
                    dGV3_Supply.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Проверьте, введены ли числовые значения в полях цены, количества и итого", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Change4()
        {
            var selectedRowIndex = dGV4_Workers.CurrentCell.RowIndex;

            var worker_id = textBox4_id.Text;
            var worker_name = textBox4_worker_name.Text;
            var worker_login = textBox4_login.Text;
            var worker_pass = textBox4_password.Text;
            var worker_pos = comboBox4_pos.SelectedValue;

            if (dGV4_Workers.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dGV4_Workers.Rows[selectedRowIndex].SetValues(worker_id, worker_name, worker_login, worker_pass, worker_pos);
                dGV4_Workers.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
            }
            else
            {
                MessageBox.Show("Проверьте заполненность строк", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Change5()
        {
            var selectedRowIndex = dGV5_Clients.CurrentCell.RowIndex;

            var client_id = textBox5_id.Text;
            var client_name = textBox5_client_name.Text;
            var task = comboBox5_task.SelectedItem;
            var debt_amount = comboBox5_debt_amount.SelectedItem;
            var client_login = textBox5_login.Text;
            var client_password = textBox5_pass.Text;

            if (dGV5_Clients.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {

                dGV5_Clients.Rows[selectedRowIndex].SetValues(client_id, client_name, task, debt_amount, client_login, client_password);
                dGV5_Clients.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;

            }
            else
            {
                MessageBox.Show("Проверьте строки на пустоту", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_save_changes_Click(object sender, EventArgs e)
        {
            Change1();
            Update1();
        }

        private void button3_save_changes_Click(object sender, EventArgs e)
        {
            Change3();
            Update3();
        }

        private void button4_save_changes_Click(object sender, EventArgs e)
        {
            Change4();
            Update4();
        }

        private void button5_save_changes_Click(object sender, EventArgs e)
        {
            Change5();
            Update5();
        }

        private void ifChanged_tB3()
        {
            if (textBox3_quantity.Text == "" || textBox3_price.Text == "")
            {
                textBox3_quantity.Text = "0";
            }
            try
            {
                Convert.ToInt32(textBox3_price.Text);
                Convert.ToInt32(textBox3_quantity.Text);
                var total_number_try = Convert.ToInt64(textBox3_price.Text) * Convert.ToInt64(textBox3_quantity.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не число!");
                textBox3_quantity.Text = "0";
                textBox3_price.Text = "0";
            }
            catch (OverflowException)
            {
                MessageBox.Show("Слишком большое число.");
                textBox3_quantity.Text = "0";
                textBox3_price.Text = "0";
            }
            var total_number = Convert.ToInt64(textBox3_price.Text) * Convert.ToInt64(textBox3_quantity.Text);
            textBox3_total.Text = Convert.ToString(total_number);
        }

        private void textBox3_quantity_TextChanged(object sender, EventArgs e)
        {
            ifChanged_tB3();
        }

        private void textBox3_price_TextChanged(object sender, EventArgs e)
        {
            ifChanged_tB3();
        }

        private void dGV1_Orders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                if (e.Value != String.Empty)
                {
                    e.Value = new string('•', e.Value.ToString().Length);
                }
                else e.Value = "";
            }
        }

        private void dGV2_Requests_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (e.Value != String.Empty)
                {
                    e.Value = new string('•', e.Value.ToString().Length);
                }
                else e.Value = "";
            }
        }

        private void dGV3_Supply_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                if (e.Value != String.Empty)
                {
                    e.Value = new string('•', e.Value.ToString().Length);
                }
                else e.Value = "";
            }
        }

        private void dGV4_Workers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if (e.Value != String.Empty)
                {
                    e.Value = new string('•', e.Value.ToString().Length);
                }
                else e.Value = "";
            }
        }
        private void dGV5_Clients_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                if (e.Value != String.Empty)
                {
                    e.Value = new string('•', e.Value.ToString().Length);
                }
                else e.Value = "";
            }
        }
    }
}