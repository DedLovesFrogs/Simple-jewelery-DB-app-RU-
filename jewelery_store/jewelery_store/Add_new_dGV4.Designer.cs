namespace jewelery_store
{
    partial class Add_new_dGV4
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4_worker_password = new System.Windows.Forms.TextBox();
            this.textBox4_worker_login = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4_worker_name = new System.Windows.Forms.TextBox();
            this.comboBox1_position = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Добавление новой записи, \"Работники\"";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Location = new System.Drawing.Point(28, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Добавить запись в таблицу \"Заказы\"";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "ФИО работника";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Пароль работника";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Логин работника";
            // 
            // textBox4_worker_password
            // 
            this.textBox4_worker_password.Location = new System.Drawing.Point(28, 137);
            this.textBox4_worker_password.Name = "textBox4_worker_password";
            this.textBox4_worker_password.Size = new System.Drawing.Size(316, 20);
            this.textBox4_worker_password.TabIndex = 27;
            // 
            // textBox4_worker_login
            // 
            this.textBox4_worker_login.Location = new System.Drawing.Point(28, 98);
            this.textBox4_worker_login.Name = "textBox4_worker_login";
            this.textBox4_worker_login.Size = new System.Drawing.Size(316, 20);
            this.textBox4_worker_login.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Должность";
            // 
            // textBox4_worker_name
            // 
            this.textBox4_worker_name.Location = new System.Drawing.Point(28, 52);
            this.textBox4_worker_name.Name = "textBox4_worker_name";
            this.textBox4_worker_name.Size = new System.Drawing.Size(316, 20);
            this.textBox4_worker_name.TabIndex = 11;
            // 
            // comboBox1_position
            // 
            this.comboBox1_position.FormattingEnabled = true;
            this.comboBox1_position.Location = new System.Drawing.Point(28, 181);
            this.comboBox1_position.Name = "comboBox1_position";
            this.comboBox1_position.Size = new System.Drawing.Size(316, 21);
            this.comboBox1_position.TabIndex = 32;
            // 
            // Add_new_dGV4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 256);
            this.Controls.Add(this.comboBox1_position);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4_worker_password);
            this.Controls.Add(this.textBox4_worker_login);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4_worker_name);
            this.Controls.Add(this.label1);
            this.Name = "Add_new_dGV4";
            this.Text = "Добавление новой записи в \"Работники\"";
            this.Load += new System.EventHandler(this.Add_new_dGV4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4_worker_password;
        private System.Windows.Forms.TextBox textBox4_worker_login;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4_worker_name;
        private System.Windows.Forms.ComboBox comboBox1_position;
    }
}