namespace jewelery_store
{
    partial class User_form
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
            this.label_username_user = new System.Windows.Forms.Label();
            this.dGV1_Requests = new System.Windows.Forms.DataGridView();
            this.dGV2_Orders = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label2_req_desc = new System.Windows.Forms.Label();
            this.label2_client_name = new System.Windows.Forms.Label();
            this.button1_save_changes = new System.Windows.Forms.Button();
            this.label2_id = new System.Windows.Forms.Label();
            this.textBox1_client_req = new System.Windows.Forms.TextBox();
            this.textBox1_id = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox1_Client_name_req = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.button1_delete_record = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1_add_record = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label_worker_name_order = new System.Windows.Forms.Label();
            this.label_price_order = new System.Windows.Forms.Label();
            this.label_task_order = new System.Windows.Forms.Label();
            this.label_client_name_order = new System.Windows.Forms.Label();
            this.label1_worker_name = new System.Windows.Forms.Label();
            this.label1_price = new System.Windows.Forms.Label();
            this.label1_task = new System.Windows.Forms.Label();
            this.label1_client_name = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1_Requests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV2_Orders)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_username_user
            // 
            this.label_username_user.AutoSize = true;
            this.label_username_user.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_username_user.Location = new System.Drawing.Point(447, 9);
            this.label_username_user.Name = "label_username_user";
            this.label_username_user.Size = new System.Drawing.Size(16, 17);
            this.label_username_user.TabIndex = 0;
            this.label_username_user.Text = "1";
            // 
            // dGV1_Requests
            // 
            this.dGV1_Requests.AllowUserToAddRows = false;
            this.dGV1_Requests.AllowUserToDeleteRows = false;
            this.dGV1_Requests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1_Requests.Location = new System.Drawing.Point(12, 49);
            this.dGV1_Requests.Name = "dGV1_Requests";
            this.dGV1_Requests.ReadOnly = true;
            this.dGV1_Requests.Size = new System.Drawing.Size(256, 299);
            this.dGV1_Requests.TabIndex = 1;
            this.dGV1_Requests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_Requests_CellClick);
            // 
            // dGV2_Orders
            // 
            this.dGV2_Orders.AllowUserToAddRows = false;
            this.dGV2_Orders.AllowUserToDeleteRows = false;
            this.dGV2_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV2_Orders.Location = new System.Drawing.Point(274, 49);
            this.dGV2_Orders.Name = "dGV2_Orders";
            this.dGV2_Orders.ReadOnly = true;
            this.dGV2_Orders.Size = new System.Drawing.Size(514, 201);
            this.dGV2_Orders.TabIndex = 2;
            this.dGV2_Orders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV2_Orders_CellClick);
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.label2_req_desc);
            this.panel10.Controls.Add(this.label2_client_name);
            this.panel10.Controls.Add(this.button1_save_changes);
            this.panel10.Controls.Add(this.label2_id);
            this.panel10.Controls.Add(this.textBox1_client_req);
            this.panel10.Controls.Add(this.textBox1_id);
            this.panel10.Controls.Add(this.label17);
            this.panel10.Controls.Add(this.textBox1_Client_name_req);
            this.panel10.Location = new System.Drawing.Point(274, 256);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(514, 268);
            this.panel10.TabIndex = 20;
            // 
            // label2_req_desc
            // 
            this.label2_req_desc.AutoSize = true;
            this.label2_req_desc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_req_desc.Location = new System.Drawing.Point(3, 33);
            this.label2_req_desc.Name = "label2_req_desc";
            this.label2_req_desc.Size = new System.Drawing.Size(52, 15);
            this.label2_req_desc.TabIndex = 16;
            this.label2_req_desc.Text = "Задание";
            // 
            // label2_client_name
            // 
            this.label2_client_name.AutoSize = true;
            this.label2_client_name.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_client_name.Location = new System.Drawing.Point(172, 26);
            this.label2_client_name.Name = "label2_client_name";
            this.label2_client_name.Size = new System.Drawing.Size(77, 15);
            this.label2_client_name.TabIndex = 15;
            this.label2_client_name.Text = "Имя клиента";
            // 
            // button1_save_changes
            // 
            this.button1_save_changes.BackColor = System.Drawing.Color.MintCream;
            this.button1_save_changes.Location = new System.Drawing.Point(194, 240);
            this.button1_save_changes.Name = "button1_save_changes";
            this.button1_save_changes.Size = new System.Drawing.Size(136, 23);
            this.button1_save_changes.TabIndex = 20;
            this.button1_save_changes.Text = "Сохранить изменения";
            this.button1_save_changes.UseVisualStyleBackColor = false;
            this.button1_save_changes.Click += new System.EventHandler(this.button1_save_changes_Click);
            // 
            // label2_id
            // 
            this.label2_id.AutoSize = true;
            this.label2_id.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_id.Location = new System.Drawing.Point(65, 26);
            this.label2_id.Name = "label2_id";
            this.label2_id.Size = new System.Drawing.Size(20, 15);
            this.label2_id.TabIndex = 14;
            this.label2_id.Text = "ID";
            // 
            // textBox1_client_req
            // 
            this.textBox1_client_req.Location = new System.Drawing.Point(3, 51);
            this.textBox1_client_req.Multiline = true;
            this.textBox1_client_req.Name = "textBox1_client_req";
            this.textBox1_client_req.Size = new System.Drawing.Size(500, 185);
            this.textBox1_client_req.TabIndex = 13;
            // 
            // textBox1_id
            // 
            this.textBox1_id.Location = new System.Drawing.Point(91, 24);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.ReadOnly = true;
            this.textBox1_id.Size = new System.Drawing.Size(75, 20);
            this.textBox1_id.TabIndex = 8;
            this.textBox1_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(87, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(359, 19);
            this.label17.TabIndex = 7;
            this.label17.Text = "Поле оформления запроса/Редактирование запроса";
            // 
            // textBox1_Client_name_req
            // 
            this.textBox1_Client_name_req.Location = new System.Drawing.Point(255, 24);
            this.textBox1_Client_name_req.Name = "textBox1_Client_name_req";
            this.textBox1_Client_name_req.ReadOnly = true;
            this.textBox1_Client_name_req.Size = new System.Drawing.Size(248, 20);
            this.textBox1_Client_name_req.TabIndex = 9;
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.button1_delete_record);
            this.panel14.Location = new System.Drawing.Point(12, 444);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(256, 80);
            this.panel14.TabIndex = 19;
            // 
            // button1_delete_record
            // 
            this.button1_delete_record.BackColor = System.Drawing.Color.MintCream;
            this.button1_delete_record.Location = new System.Drawing.Point(3, 3);
            this.button1_delete_record.Name = "button1_delete_record";
            this.button1_delete_record.Size = new System.Drawing.Size(245, 72);
            this.button1_delete_record.TabIndex = 1;
            this.button1_delete_record.Text = "Удалить запрос";
            this.button1_delete_record.UseVisualStyleBackColor = false;
            this.button1_delete_record.Click += new System.EventHandler(this.button1_delete_record_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button1_add_record);
            this.panel4.Location = new System.Drawing.Point(12, 354);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 88);
            this.panel4.TabIndex = 18;
            // 
            // button1_add_record
            // 
            this.button1_add_record.BackColor = System.Drawing.Color.MintCream;
            this.button1_add_record.Location = new System.Drawing.Point(3, 3);
            this.button1_add_record.Name = "button1_add_record";
            this.button1_add_record.Size = new System.Drawing.Size(245, 80);
            this.button1_add_record.TabIndex = 0;
            this.button1_add_record.Text = "Отправить запрос на заказ";
            this.button1_add_record.UseVisualStyleBackColor = false;
            this.button1_add_record.Click += new System.EventHandler(this.button1_add_record_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ваши запросы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ваши заказы (подтвеждённые запросы)";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.label_worker_name_order);
            this.panel11.Controls.Add(this.label_price_order);
            this.panel11.Controls.Add(this.label_task_order);
            this.panel11.Controls.Add(this.label_client_name_order);
            this.panel11.Controls.Add(this.label1_worker_name);
            this.panel11.Controls.Add(this.label1_price);
            this.panel11.Controls.Add(this.label1_task);
            this.panel11.Controls.Add(this.label1_client_name);
            this.panel11.Controls.Add(this.label11);
            this.panel11.Location = new System.Drawing.Point(797, 49);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(268, 475);
            this.panel11.TabIndex = 23;
            // 
            // label_worker_name_order
            // 
            this.label_worker_name_order.BackColor = System.Drawing.Color.MintCream;
            this.label_worker_name_order.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_worker_name_order.Location = new System.Drawing.Point(3, 413);
            this.label_worker_name_order.Name = "label_worker_name_order";
            this.label_worker_name_order.Size = new System.Drawing.Size(251, 57);
            this.label_worker_name_order.TabIndex = 22;
            this.label_worker_name_order.Text = "Выберите заказ.";
            // 
            // label_price_order
            // 
            this.label_price_order.BackColor = System.Drawing.Color.MintCream;
            this.label_price_order.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_price_order.Location = new System.Drawing.Point(3, 356);
            this.label_price_order.Name = "label_price_order";
            this.label_price_order.Size = new System.Drawing.Size(251, 42);
            this.label_price_order.TabIndex = 21;
            this.label_price_order.Text = "Выберите заказ.";
            // 
            // label_task_order
            // 
            this.label_task_order.BackColor = System.Drawing.Color.MintCream;
            this.label_task_order.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_task_order.Location = new System.Drawing.Point(3, 92);
            this.label_task_order.Name = "label_task_order";
            this.label_task_order.Size = new System.Drawing.Size(251, 249);
            this.label_task_order.TabIndex = 20;
            this.label_task_order.Text = "Выберите заказ.";
            // 
            // label_client_name_order
            // 
            this.label_client_name_order.BackColor = System.Drawing.Color.MintCream;
            this.label_client_name_order.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_client_name_order.Location = new System.Drawing.Point(3, 38);
            this.label_client_name_order.Name = "label_client_name_order";
            this.label_client_name_order.Size = new System.Drawing.Size(251, 36);
            this.label_client_name_order.TabIndex = 19;
            this.label_client_name_order.Text = "Выберите заказ.";
            // 
            // label1_worker_name
            // 
            this.label1_worker_name.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_worker_name.Location = new System.Drawing.Point(3, 398);
            this.label1_worker_name.Name = "label1_worker_name";
            this.label1_worker_name.Size = new System.Drawing.Size(137, 15);
            this.label1_worker_name.TabIndex = 18;
            this.label1_worker_name.Text = "Работающий над этим:";
            // 
            // label1_price
            // 
            this.label1_price.AutoSize = true;
            this.label1_price.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_price.Location = new System.Drawing.Point(3, 341);
            this.label1_price.Name = "label1_price";
            this.label1_price.Size = new System.Drawing.Size(38, 15);
            this.label1_price.TabIndex = 17;
            this.label1_price.Text = "Цена:";
            // 
            // label1_task
            // 
            this.label1_task.AutoSize = true;
            this.label1_task.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_task.Location = new System.Drawing.Point(3, 74);
            this.label1_task.Name = "label1_task";
            this.label1_task.Size = new System.Drawing.Size(55, 15);
            this.label1_task.TabIndex = 16;
            this.label1_task.Text = "Задание:";
            // 
            // label1_client_name
            // 
            this.label1_client_name.AutoSize = true;
            this.label1_client_name.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_client_name.Location = new System.Drawing.Point(3, 19);
            this.label1_client_name.Name = "label1_client_name";
            this.label1_client_name.Size = new System.Drawing.Size(80, 15);
            this.label1_client_name.TabIndex = 15;
            this.label1_client_name.Text = "Имя клиента:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(13, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 19);
            this.label11.TabIndex = 7;
            this.label11.Text = "Подробности о выбранном заказе";
            // 
            // User_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 533);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dGV2_Orders);
            this.Controls.Add(this.dGV1_Requests);
            this.Controls.Add(this.label_username_user);
            this.Name = "User_form";
            this.Text = "Добро пожаловать в окно заказов";
            this.Load += new System.EventHandler(this.User_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV1_Requests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV2_Orders)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_username_user;
        private System.Windows.Forms.DataGridView dGV1_Requests;
        private System.Windows.Forms.DataGridView dGV2_Orders;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label2_req_desc;
        private System.Windows.Forms.Label label2_client_name;
        private System.Windows.Forms.Label label2_id;
        private System.Windows.Forms.TextBox textBox1_client_req;
        private System.Windows.Forms.TextBox textBox1_id;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox1_Client_name_req;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button button1_delete_record;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1_add_record;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1_save_changes;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label_worker_name_order;
        private System.Windows.Forms.Label label_price_order;
        private System.Windows.Forms.Label label_task_order;
        private System.Windows.Forms.Label label_client_name_order;
        private System.Windows.Forms.Label label1_worker_name;
        private System.Windows.Forms.Label label1_price;
        private System.Windows.Forms.Label label1_task;
        private System.Windows.Forms.Label label1_client_name;
        private System.Windows.Forms.Label label11;
    }
}