namespace TestProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_input = new System.Windows.Forms.Label();
            this.tb_input1 = new System.Windows.Forms.TextBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.rbtn_timein = new System.Windows.Forms.RadioButton();
            this.rbtn_timeout = new System.Windows.Forms.RadioButton();
            this.lb_test = new System.Windows.Forms.Label();
            this.btn_log = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_image = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_test = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_input
            // 
            this.lb_input.AutoSize = true;
            this.lb_input.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_input.Location = new System.Drawing.Point(103, 240);
            this.lb_input.Name = "lb_input";
            this.lb_input.Size = new System.Drawing.Size(24, 18);
            this.lb_input.TabIndex = 0;
            this.lb_input.Text = "ID";
            // 
            // tb_input1
            // 
            this.tb_input1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_input1.Location = new System.Drawing.Point(133, 240);
            this.tb_input1.MaximumSize = new System.Drawing.Size(398, 23);
            this.tb_input1.MinimumSize = new System.Drawing.Size(187, 23);
            this.tb_input1.Name = "tb_input1";
            this.tb_input1.Size = new System.Drawing.Size(187, 23);
            this.tb_input1.TabIndex = 1;
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(133, 303);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(83, 23);
            this.btn_input.TabIndex = 4;
            this.btn_input.Text = "Input";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(236, 303);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(84, 23);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(22, 12);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 6;
            this.btn_connect.Text = "Register";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // rbtn_timein
            // 
            this.rbtn_timein.AutoSize = true;
            this.rbtn_timein.Checked = true;
            this.rbtn_timein.Location = new System.Drawing.Point(154, 278);
            this.rbtn_timein.Name = "rbtn_timein";
            this.rbtn_timein.Size = new System.Drawing.Size(66, 19);
            this.rbtn_timein.TabIndex = 7;
            this.rbtn_timein.TabStop = true;
            this.rbtn_timein.Text = "Time-in";
            this.rbtn_timein.UseVisualStyleBackColor = true;
            this.rbtn_timein.CheckedChanged += new System.EventHandler(this.rbtn_timein_CheckedChanged);
            // 
            // rbtn_timeout
            // 
            this.rbtn_timeout.AutoSize = true;
            this.rbtn_timeout.Location = new System.Drawing.Point(231, 278);
            this.rbtn_timeout.Name = "rbtn_timeout";
            this.rbtn_timeout.Size = new System.Drawing.Size(74, 19);
            this.rbtn_timeout.TabIndex = 8;
            this.rbtn_timeout.Text = "Time-out";
            this.rbtn_timeout.UseVisualStyleBackColor = true;
            this.rbtn_timeout.CheckedChanged += new System.EventHandler(this.rbtn_timeout_CheckedChanged);
            // 
            // lb_test
            // 
            this.lb_test.AutoSize = true;
            this.lb_test.Location = new System.Drawing.Point(154, 16);
            this.lb_test.Name = "lb_test";
            this.lb_test.Size = new System.Drawing.Size(0, 15);
            this.lb_test.TabIndex = 9;
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(22, 408);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(75, 23);
            this.btn_log.TabIndex = 10;
            this.btn_log.Text = "Log";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(133, 12);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(192, 192);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(192, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 192);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_image
            // 
            this.btn_image.Location = new System.Drawing.Point(331, 12);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(75, 23);
            this.btn_image.TabIndex = 12;
            this.btn_image.Text = "Upload";
            this.btn_image.UseVisualStyleBackColor = true;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 23);
            this.textBox1.TabIndex = 13;
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(103, 408);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 14;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(331, 51);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 443);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.lb_test);
            this.Controls.Add(this.rbtn_timeout);
            this.Controls.Add(this.rbtn_timein);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.tb_input1);
            this.Controls.Add(this.lb_input);
            this.MinimumSize = new System.Drawing.Size(520, 280);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_input;
        private TextBox tb_input1;
        private Button btn_input;
        private Button btn_clear;
        private Button btn_connect;
        private RadioButton rbtn_timein;
        private RadioButton rbtn_timeout;
        private Label lb_test;
        private Button btn_log;
        private PictureBox pictureBox1;
        private Button btn_image;
        private TextBox textBox1;
        private Button btn_test;
        private Button btn_save;
    }
}