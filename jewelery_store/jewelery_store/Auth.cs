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
    public partial class Auth : Form
    {
        Jewelery_DB database = new Jewelery_DB();
        public Auth()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            textBox_pass.UseSystemPasswordChar = true;
            textBox_LogIn.MaxLength = 50;
            textBox_pass.MaxLength = 50;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_LogIn.Text;
            var passUser = textBox_pass.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select * from Workers where worker_login = '{loginUser}' and worker_password = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли.", "Успешно.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu menu = new Menu();

                menu.User_Welcome = "Добро пожаловать, " + Convert.ToString(table.Rows[0][1]);
                internal_vars.Usr_pos = Convert.ToInt32(table.Rows[0][4]);

                textBox_LogIn.Clear();
                textBox_pass.Clear();

                this.Hide();
                menu.ShowDialog();
                this.Show();

            }
            else
            {
                DataTable table2 = new DataTable();

                string querystring2 = $"select client_id, client_name, client_login, client_password from Clients where client_login = '{loginUser}' and client_password = '{passUser}'";

                SqlCommand command2 = new SqlCommand(querystring2, database.getConnection());

                adapter.SelectCommand = command2;
                adapter.Fill(table2);

                if (table2.Rows.Count == 1)
                {
                    MessageBox.Show("Вы успешно вошли.", "Успешно.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    User_form usr_frm = new User_form();

                    internal_vars.clnt_name = Convert.ToString(table2.Rows[0][1]);
                    internal_vars.clnt_id = Convert.ToInt32(table2.Rows[0][0]);

                    textBox_LogIn.Clear();
                    textBox_pass.Clear();

                    this.Hide();
                    usr_frm.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Проверьте логин или пароль.", "Ошибка входа.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_LogIn.Text = "";
            textBox_pass.Text = "";
        }

        private void checkBox_Visible_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Visible.Checked)
            {
                textBox_pass.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_pass.UseSystemPasswordChar = true;
            }
        }

    }
}
