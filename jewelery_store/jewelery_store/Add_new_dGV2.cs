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
    public partial class Add_new_dGV2 : Form
    {
        Jewelery_DB dataBase = new Jewelery_DB();

        public Add_new_dGV2()
        {
            InitializeComponent();
        }

        private void Add_new_dGV2_Load(object sender, EventArgs e)
        {

            this.clientsTableAdapter.Fill(this.jewelery_storeDataSet1.Clients);
            dataBase.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table_workers = new DataTable();

            string querystring = $"select * from Workers";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table_workers);

            for (var i = 0; i < table_workers.Rows.Count; i++)
            {
                table_workers.Rows[i][1] = (string)table_workers.Rows[i][1];
            }

            comboBox2_workers.DataSource = table_workers;
            comboBox2_workers.ValueMember = "worker_id";
            comboBox2_workers.DisplayMember = "worker_name";

            dataBase.closeConnection();

            comboBox1_client_name.SelectedValue = internal_vars.clnt_id_dyn;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var client_name = comboBox1_client_name.SelectedValue;
            var task = textBox2_task.Text;
            int price;
            var worker_name = comboBox2_workers.SelectedValue;

            if (int.TryParse(textBox2_price.Text, out price))

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
