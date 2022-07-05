namespace TestProject
{
    partial class RegisteForm
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.lb_employeeId = new System.Windows.Forms.Label();
            this.lb_firstName = new System.Windows.Forms.Label();
            this.lb_lastName = new System.Windows.Forms.Label();
            this.tb_employeeId = new System.Windows.Forms.TextBox();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.pb_profilepic = new System.Windows.Forms.PictureBox();
            this.btn_upload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profilepic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(161, 169);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 23);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "button1";
            this.btn_1.UseVisualStyleBackColor = true;
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(0, 0);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(100, 23);
            this.tb_1.TabIndex = 0;
            // 
            // lb_employeeId
            // 
            this.lb_employeeId.AutoSize = true;
            this.lb_employeeId.Location = new System.Drawing.Point(63, 298);
            this.lb_employeeId.Name = "lb_employeeId";
            this.lb_employeeId.Size = new System.Drawing.Size(72, 15);
            this.lb_employeeId.TabIndex = 0;
            this.lb_employeeId.Text = "Employee Id";
            // 
            // lb_firstName
            // 
            this.lb_firstName.AutoSize = true;
            this.lb_firstName.Location = new System.Drawing.Point(62, 353);
            this.lb_firstName.Name = "lb_firstName";
            this.lb_firstName.Size = new System.Drawing.Size(64, 15);
            this.lb_firstName.TabIndex = 1;
            this.lb_firstName.Text = "First Name";
            // 
            // lb_lastName
            // 
            this.lb_lastName.AutoSize = true;
            this.lb_lastName.Location = new System.Drawing.Point(63, 408);
            this.lb_lastName.Name = "lb_lastName";
            this.lb_lastName.Size = new System.Drawing.Size(63, 15);
            this.lb_lastName.TabIndex = 2;
            this.lb_lastName.Text = "Last Name";
            // 
            // tb_employeeId
            // 
            this.tb_employeeId.Location = new System.Drawing.Point(140, 295);
            this.tb_employeeId.Name = "tb_employeeId";
            this.tb_employeeId.Size = new System.Drawing.Size(192, 23);
            this.tb_employeeId.TabIndex = 3;
            // 
            // tb_firstName
            // 
            this.tb_firstName.Location = new System.Drawing.Point(140, 350);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(192, 23);
            this.tb_firstName.TabIndex = 4;
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(140, 405);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(192, 23);
            this.tb_lastName.TabIndex = 5;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(140, 445);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(257, 445);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // pb_profilepic
            // 
            this.pb_profilepic.Location = new System.Drawing.Point(140, 12);
            this.pb_profilepic.MaximumSize = new System.Drawing.Size(192, 192);
            this.pb_profilepic.MinimumSize = new System.Drawing.Size(192, 192);
            this.pb_profilepic.Name = "pb_profilepic";
            this.pb_profilepic.Size = new System.Drawing.Size(192, 192);
            this.pb_profilepic.TabIndex = 8;
            this.pb_profilepic.TabStop = false;
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(191, 232);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 9;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // RegisteForm
            // 
            this.ClientSize = new System.Drawing.Size(478, 505);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.pb_profilepic);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.tb_firstName);
            this.Controls.Add(this.tb_employeeId);
            this.Controls.Add(this.lb_lastName);
            this.Controls.Add(this.lb_firstName);
            this.Controls.Add(this.lb_employeeId);
            this.MaximumSize = new System.Drawing.Size(494, 544);
            this.MinimumSize = new System.Drawing.Size(494, 544);
            this.Name = "RegisteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Register Form";
            ((System.ComponentModel.ISupportInitialize)(this.pb_profilepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_1;
        private TextBox tb_1;
        private Label lb_employeeId;
        private Label lb_firstName;
        private Label lb_lastName;
        private TextBox tb_employeeId;
        private TextBox tb_firstName;
        private TextBox tb_lastName;
        private Button btn_register;
        private Button btn_clear;
        private PictureBox pb_profilepic;
        private Button btn_upload;
    }
}