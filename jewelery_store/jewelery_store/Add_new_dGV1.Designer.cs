namespace jewelery_store
{
    partial class Add_new_dGV1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_task = new System.Windows.Forms.TextBox();
            this.textBox1_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1_client_name = new System.Windows.Forms.ComboBox();
            this.comboBox1_worker_name = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление новой записи, \"Заказы\"";
            // 
            // textBox1_task
            // 
            this.textBox1_task.Location = new System.Drawing.Point(12, 92);
            this.textBox1_task.Name = "textBox1_task";
            this.textBox1_task.Size = new System.Drawing.Size(316, 20);
            this.textBox1_task.TabIndex = 3;
            // 
            // textBox1_price
            // 
            this.textBox1_price.Location = new System.Drawing.Point(12, 132);
            this.textBox1_price.Name = "textBox1_price";
            this.textBox1_price.Size = new System.Drawing.Size(316, 20);
            this.textBox1_price.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ФИО клиента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Заказ от клиента";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Цена";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Имя работника";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Location = new System.Drawing.Point(12, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Добавить запись в таблицу \"Заказы\"";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1_client_name
            // 
            this.comboBox1_client_name.FormattingEnabled = true;
            this.comboBox1_client_name.Location = new System.Drawing.Point(12, 54);
            this.comboBox1_client_name.Name = "comboBox1_client_name";
            this.comboBox1_client_name.Size = new System.Drawing.Size(316, 21);
            this.comboBox1_client_name.TabIndex = 17;
            // 
            // comboBox1_worker_name
            // 
            this.comboBox1_worker_name.FormattingEnabled = true;
            this.comboBox1_worker_name.Location = new System.Drawing.Point(12, 177);
            this.comboBox1_worker_name.Name = "comboBox1_worker_name";
            this.comboBox1_worker_name.Size = new System.Drawing.Size(316, 21);
            this.comboBox1_worker_name.TabIndex = 18;
            // 
            // Add_new_dGV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 251);
            this.Controls.Add(this.comboBox1_worker_name);
            this.Controls.Add(this.comboBox1_client_name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1_price);
            this.Controls.Add(this.textBox1_task);
            this.Controls.Add(this.label1);
            this.Name = "Add_new_dGV1";
            this.Text = "Добавление новой записи в \"Заказы\"";
            this.Load += new System.EventHandler(this.Add_new_dGV1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_task;
        private System.Windows.Forms.TextBox textBox1_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1_client_name;
        private System.Windows.Forms.ComboBox comboBox1_worker_name;
    }
}