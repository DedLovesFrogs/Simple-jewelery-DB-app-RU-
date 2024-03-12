namespace jewelery_store
{
    partial class Add_new_dGV2
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2_client_task_req = new System.Windows.Forms.TextBox();
            this.textBox2_task = new System.Windows.Forms.TextBox();
            this.textBox2_price = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2_workers = new System.Windows.Forms.ComboBox();
            this.comboBox1_client_name = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jewelery_storeDataSet1 = new jewelery_store.jewelery_storeDataSet1();
            this.clientsTableAdapter = new jewelery_store.jewelery_storeDataSet1TableAdapters.ClientsTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewelery_storeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Запрос клиента";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Задание";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Цена";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Имя работника";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(216, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(372, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Добавление записи из \"Запросы клиентов\" в \"Заказы\"";
            // 
            // textBox2_client_task_req
            // 
            this.textBox2_client_task_req.Location = new System.Drawing.Point(19, 107);
            this.textBox2_client_task_req.Multiline = true;
            this.textBox2_client_task_req.Name = "textBox2_client_task_req";
            this.textBox2_client_task_req.ReadOnly = true;
            this.textBox2_client_task_req.Size = new System.Drawing.Size(360, 331);
            this.textBox2_client_task_req.TabIndex = 11;
            // 
            // textBox2_task
            // 
            this.textBox2_task.Location = new System.Drawing.Point(420, 67);
            this.textBox2_task.Multiline = true;
            this.textBox2_task.Name = "textBox2_task";
            this.textBox2_task.Size = new System.Drawing.Size(368, 174);
            this.textBox2_task.TabIndex = 13;
            // 
            // textBox2_price
            // 
            this.textBox2_price.Location = new System.Drawing.Point(420, 260);
            this.textBox2_price.Name = "textBox2_price";
            this.textBox2_price.Size = new System.Drawing.Size(368, 20);
            this.textBox2_price.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Location = new System.Drawing.Point(515, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Добавить запись в таблицу \"Заказы\"";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox2_workers
            // 
            this.comboBox2_workers.FormattingEnabled = true;
            this.comboBox2_workers.Location = new System.Drawing.Point(420, 304);
            this.comboBox2_workers.Name = "comboBox2_workers";
            this.comboBox2_workers.Size = new System.Drawing.Size(368, 21);
            this.comboBox2_workers.TabIndex = 17;
            // 
            // comboBox1_client_name
            // 
            this.comboBox1_client_name.DataSource = this.clientsBindingSource;
            this.comboBox1_client_name.DisplayMember = "client_name";
            this.comboBox1_client_name.Enabled = false;
            this.comboBox1_client_name.FormattingEnabled = true;
            this.comboBox1_client_name.Location = new System.Drawing.Point(19, 67);
            this.comboBox1_client_name.Name = "comboBox1_client_name";
            this.comboBox1_client_name.Size = new System.Drawing.Size(360, 21);
            this.comboBox1_client_name.TabIndex = 18;
            this.comboBox1_client_name.ValueMember = "client_id";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.jewelery_storeDataSet1;
            // 
            // jewelery_storeDataSet1
            // 
            this.jewelery_storeDataSet1.DataSetName = "jewelery_storeDataSet1";
            this.jewelery_storeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Имя клиента";
            // 
            // Add_new_dGV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1_client_name);
            this.Controls.Add(this.comboBox2_workers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2_price);
            this.Controls.Add(this.textBox2_task);
            this.Controls.Add(this.textBox2_client_task_req);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Add_new_dGV2";
            this.Text = "Добавление записи из \"Запросы клиентов\" в \"Заказы\"";
            this.Load += new System.EventHandler(this.Add_new_dGV2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewelery_storeDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox textBox2_client_task_req;
        private System.Windows.Forms.TextBox textBox2_task;
        private System.Windows.Forms.TextBox textBox2_price;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2_workers;
        public System.Windows.Forms.ComboBox comboBox1_client_name;
        private jewelery_storeDataSet1 jewelery_storeDataSet1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private jewelery_storeDataSet1TableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Label label4;
    }
}