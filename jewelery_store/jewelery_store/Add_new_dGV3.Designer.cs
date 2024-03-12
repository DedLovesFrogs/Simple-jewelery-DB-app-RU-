namespace jewelery_store
{
    partial class Add_new_dGV3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox3_seller = new System.Windows.Forms.TextBox();
            this.textBox3_quantity = new System.Windows.Forms.TextBox();
            this.textBox3_total = new System.Windows.Forms.TextBox();
            this.textBox3_price = new System.Windows.Forms.TextBox();
            this.textBox3_product = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox3_seller
            // 
            this.textBox3_seller.Location = new System.Drawing.Point(12, 213);
            this.textBox3_seller.Name = "textBox3_seller";
            this.textBox3_seller.Size = new System.Drawing.Size(316, 20);
            this.textBox3_seller.TabIndex = 15;
            // 
            // textBox3_quantity
            // 
            this.textBox3_quantity.Location = new System.Drawing.Point(12, 132);
            this.textBox3_quantity.Name = "textBox3_quantity";
            this.textBox3_quantity.Size = new System.Drawing.Size(316, 20);
            this.textBox3_quantity.TabIndex = 14;
            this.textBox3_quantity.TextChanged += new System.EventHandler(this.textBox3_quantity_TextChanged);
            // 
            // textBox3_total
            // 
            this.textBox3_total.Location = new System.Drawing.Point(12, 173);
            this.textBox3_total.Name = "textBox3_total";
            this.textBox3_total.ReadOnly = true;
            this.textBox3_total.Size = new System.Drawing.Size(316, 20);
            this.textBox3_total.TabIndex = 13;
            // 
            // textBox3_price
            // 
            this.textBox3_price.Location = new System.Drawing.Point(12, 92);
            this.textBox3_price.Name = "textBox3_price";
            this.textBox3_price.Size = new System.Drawing.Size(316, 20);
            this.textBox3_price.TabIndex = 12;
            // 
            // textBox3_product
            // 
            this.textBox3_product.Location = new System.Drawing.Point(12, 53);
            this.textBox3_product.Name = "textBox3_product";
            this.textBox3_product.Size = new System.Drawing.Size(316, 20);
            this.textBox3_product.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Добавление новой записи, \"Поставки\"";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Location = new System.Drawing.Point(12, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Добавить запись в таблицу \"Заказы\"";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Продавец";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Всего";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Материал";
            // 
            // Add_new_dGV3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3_seller);
            this.Controls.Add(this.textBox3_quantity);
            this.Controls.Add(this.textBox3_total);
            this.Controls.Add(this.textBox3_price);
            this.Controls.Add(this.textBox3_product);
            this.Controls.Add(this.label1);
            this.Name = "Add_new_dGV3";
            this.Text = "Добавление новой записи в \"Поставки\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3_seller;
        private System.Windows.Forms.TextBox textBox3_quantity;
        private System.Windows.Forms.TextBox textBox3_total;
        private System.Windows.Forms.TextBox textBox3_price;
        private System.Windows.Forms.TextBox textBox3_product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}