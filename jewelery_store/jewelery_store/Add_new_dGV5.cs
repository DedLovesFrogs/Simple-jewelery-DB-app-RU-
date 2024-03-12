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
    public partial class Add_new_dGV5 : Form
    {
        Jewelery_DB dataBase = new Jewelery_DB();

        public Add_new_dGV5()
        {
            InitializeComponent();
        }

        private void Add_new_dGV5_Load(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var client_name = textBox5_client_name.Text;
            var task = comboBox1_task.SelectedItem;
            var debt_amount = comboBox1_debt_amount.SelectedItem;
            var client_login = textBox5_client_login.Text;
            var client_password = textBox5_client_pass.Text;


            var addQuery = $"insert into Clients (client_name, task, debt_amount, client_login, client_password) values ('{client_name}', '{task}', '{debt_amount}', '{client_login}', '{client_password}')";

            var command = new SqlCommand(addQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись успешно добавлена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

            dataBase.closeConnection();

        }
    }
}
