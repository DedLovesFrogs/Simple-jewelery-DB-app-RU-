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
    public partial class Add_new_dGV4 : Form
    {
        Jewelery_DB dataBase = new Jewelery_DB();

        public Add_new_dGV4()
        {
            InitializeComponent();
        }

        private void Add_new_dGV4_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table_pos = new DataTable();

            string querystring = $"select * from position";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table_pos);

            for (var i = 0; i < table_pos.Rows.Count; i++)
            {
                table_pos.Rows[i][1] = (string)table_pos.Rows[i][1];
            }

            comboBox1_position.DataSource = table_pos;
            comboBox1_position.ValueMember = "id";
            comboBox1_position.DisplayMember = "position";

            dataBase.closeConnection();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var worker_name = textBox4_worker_name.Text;
            var worker_login = textBox4_worker_login.Text;
            var worker_password = textBox4_worker_password.Text;
            var worker_pos0 = comboBox1_position.SelectedValue;

            if (textBox4_worker_login.Text == "" & textBox4_worker_password.Text == "")

            {
                MessageBox.Show("Проверьте заполенение пароля и логина", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int worker_pos1 = Convert.ToInt32(worker_pos0);

                var addQuery = $"insert into Workers (worker_name, worker_login, worker_password, worker_position) values ('{worker_name}', '{worker_login}', '{worker_password}', '{worker_pos1}')";

                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }

            dataBase.closeConnection();
        }
    }
}
