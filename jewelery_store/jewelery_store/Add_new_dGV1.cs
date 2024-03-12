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
    public partial class Add_new_dGV1 : Form
    {
        Jewelery_DB dataBase = new Jewelery_DB();

        public Add_new_dGV1()
        {
            InitializeComponent();
        }

        private void Add_new_dGV1_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table_clients = new DataTable();

            string querystring = $"select * from Clients";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table_clients);

            for (var i=0; i < table_clients.Rows.Count; i++)
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

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var client_name = comboBox1_client_name.SelectedValue;
            var task = textBox1_task.Text;
            int price;
            var worker_name = comboBox1_worker_name.SelectedValue;

            if (int.TryParse(textBox1_price.Text, out price))
                
            {
                var addQuery = $"insert into Zakazy (client_name, task, price, worker_name) values ('{client_name}', '{task}', '{price}', '{worker_name}')";

                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                
            }
            else
            {
                MessageBox.Show("Проверьте тип данных в поле цены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataBase.closeConnection();

        }
    }
}
