namespace jewelery_store
{
    partial class Auth
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
            this.LogIn_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_LogIn = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_Visible = new System.Windows.Forms.CheckBox();
            this.Clear_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogIn_but
            // 
            this.LogIn_but.BackColor = System.Drawing.Color.MintCream;
            this.LogIn_but.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogIn_but.Location = new System.Drawing.Point(127, 157);
            this.LogIn_but.Name = "LogIn_but";
            this.LogIn_but.Size = new System.Drawing.Size(160, 45);
            this.LogIn_but.TabIndex = 0;
            this.LogIn_but.Text = "Войти";
            this.LogIn_but.UseVisualStyleBackColor = false;
            this.LogIn_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль";
            // 
            // textBox_LogIn
            // 
            this.textBox_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_LogIn.Location = new System.Drawing.Point(127, 51);
            this.textBox_LogIn.Name = "textBox_LogIn";
            this.textBox_LogIn.Size = new System.Drawing.Size(160, 26);
            this.textBox_LogIn.TabIndex = 4;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_pass.Location = new System.Drawing.Point(127, 100);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(160, 26);
            this.textBox_pass.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Видимый:";
            // 
            // checkBox_Visible
            // 
            this.checkBox_Visible.AutoSize = true;
            this.checkBox_Visible.Location = new System.Drawing.Point(325, 112);
            this.checkBox_Visible.Name = "checkBox_Visible";
            this.checkBox_Visible.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Visible.TabIndex = 7;
            this.checkBox_Visible.UseVisualStyleBackColor = true;
            this.checkBox_Visible.CheckedChanged += new System.EventHandler(this.checkBox_Visible_CheckedChanged);
            // 
            // Clear_but
            // 
            this.Clear_but.BackColor = System.Drawing.Color.MintCream;
            this.Clear_but.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_but.Location = new System.Drawing.Point(308, 9);
            this.Clear_but.Name = "Clear_but";
            this.Clear_but.Size = new System.Drawing.Size(69, 45);
            this.Clear_but.TabIndex = 8;
            this.Clear_but.Text = "Очистка полей";
            this.Clear_but.UseVisualStyleBackColor = false;
            this.Clear_but.Click += new System.EventHandler(this.button2_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(389, 214);
            this.Controls.Add(this.Clear_but);
            this.Controls.Add(this.checkBox_Visible);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_LogIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogIn_but);
            this.Name = "Auth";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button LogIn_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_LogIn;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_Visible;
        private System.Windows.Forms.Button Clear_but;
    }
}