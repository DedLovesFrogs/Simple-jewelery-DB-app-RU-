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
    public partial class Add_new_dGV3 : Form
    {
        Jewelery_DB dataBase = new Jewelery_DB();

        public Add_new_dGV3()
        {
            InitializeComponent();
        }

        private void textBox3_quantity_TextChanged(object sender, EventArgs e)
        {
            if (textBox3_quantity.Text == "" || textBox3_price.Text == "") 
            { 
                textBox3_quantity.Text = "0"; 
            }
            try
            {
                Convert.ToInt32(textBox3_price.Text);
                Convert.ToInt32(textBox3_quantity.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не число!");
                textBox3_quantity.Text = "0";
                textBox3_price.Text = "0";

            }
            var total_number = Convert.ToInt32(textBox3_price.Text) * Convert.ToInt32(textBox3_quantity.Text);
            textBox3_total.Text = Convert.ToString(total_number);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var product = textBox3_product.Text;
            int price;
            int quantity;
            int total;
            var seller = textBox3_seller.Text;

            if (int.TryParse(textBox3_price.Text, out price) 
                & int.TryParse(textBox3_quantity.Text, out quantity) 
                & int.TryParse(textBox3_total.Text, out total))

            {
                var addQuery = $"insert into Postavki (product, price, quantity, total, seller) values ('{product}', '{price}', '{quantity}', '{total}', '{seller}')";

                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

            }
            else
            {
                MessageBox.Show("Проверьте тип данных в поле цены, количества или итого", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataBase.closeConnection();
        }

        
    }
}
