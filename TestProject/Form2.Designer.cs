namespace TestProject
{
    partial class Form2
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
            this.lb_db = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_db = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_db
            // 
            this.lb_db.AutoSize = true;
            this.lb_db.Location = new System.Drawing.Point(17, 11);
            this.lb_db.Name = "lb_db";
            this.lb_db.Size = new System.Drawing.Size(55, 15);
            this.lb_db.TabIndex = 0;
            this.lb_db.Text = "DataBase";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(17, 44);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(60, 15);
            this.lb_username.TabIndex = 1;
            this.lb_username.Text = "Username";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(17, 80);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(57, 15);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Password";
            // 
            // tb_db
            // 
            this.tb_db.Location = new System.Drawing.Point(97, 8);
            this.tb_db.Name = "tb_db";
            this.tb_db.Size = new System.Drawing.Size(100, 23);
            this.tb_db.TabIndex = 3;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(97, 41);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(100, 23);
            this.tb_user.TabIndex = 4;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(97, 77);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(100, 23);
            this.tb_pass.TabIndex = 5;
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(97, 117);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(100, 23);
            this.btn_enter.TabIndex = 6;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 167);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.tb_db);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_db);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_db;
        private Label lb_username;
        private Label lb_password;
        private TextBox tb_db;
        private TextBox tb_user;
        private TextBox tb_pass;
        private Button btn_enter;
    }
}