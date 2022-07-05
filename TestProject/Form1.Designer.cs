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
            this.pb_profilepic = new System.Windows.Forms.PictureBox();
            this.lb_nameread = new System.Windows.Forms.Label();
            this.lb_timeinread = new System.Windows.Forms.Label();
            this.lb_timeoutread = new System.Windows.Forms.Label();
            this.tb_nameread = new System.Windows.Forms.TextBox();
            this.tb_timeinread = new System.Windows.Forms.TextBox();
            this.tb_timeoutread = new System.Windows.Forms.TextBox();
            this.tb_idread = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profilepic)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_input
            // 
            this.lb_input.AutoSize = true;
            this.lb_input.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_input.Location = new System.Drawing.Point(232, 136);
            this.lb_input.Name = "lb_input";
            this.lb_input.Size = new System.Drawing.Size(24, 18);
            this.lb_input.TabIndex = 0;
            this.lb_input.Text = "ID";
            // 
            // tb_input1
            // 
            this.tb_input1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_input1.Location = new System.Drawing.Point(262, 136);
            this.tb_input1.MaximumSize = new System.Drawing.Size(398, 23);
            this.tb_input1.MinimumSize = new System.Drawing.Size(187, 23);
            this.tb_input1.Name = "tb_input1";
            this.tb_input1.Size = new System.Drawing.Size(187, 23);
            this.tb_input1.TabIndex = 1;
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(262, 190);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(83, 23);
            this.btn_input.TabIndex = 4;
            this.btn_input.Text = "Input";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(365, 190);
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
            this.rbtn_timein.Location = new System.Drawing.Point(279, 165);
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
            this.rbtn_timeout.Location = new System.Drawing.Point(365, 165);
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
            this.btn_log.Location = new System.Drawing.Point(374, 393);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(75, 23);
            this.btn_log.TabIndex = 10;
            this.btn_log.Text = "Log";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // pb_profilepic
            // 
            this.pb_profilepic.Location = new System.Drawing.Point(22, 55);
            this.pb_profilepic.MaximumSize = new System.Drawing.Size(192, 192);
            this.pb_profilepic.MinimumSize = new System.Drawing.Size(192, 192);
            this.pb_profilepic.Name = "pb_profilepic";
            this.pb_profilepic.Size = new System.Drawing.Size(192, 192);
            this.pb_profilepic.TabIndex = 11;
            this.pb_profilepic.TabStop = false;
            // 
            // lb_nameread
            // 
            this.lb_nameread.AutoSize = true;
            this.lb_nameread.Location = new System.Drawing.Point(22, 301);
            this.lb_nameread.Name = "lb_nameread";
            this.lb_nameread.Size = new System.Drawing.Size(39, 15);
            this.lb_nameread.TabIndex = 15;
            this.lb_nameread.Text = "Name";
            // 
            // lb_timeinread
            // 
            this.lb_timeinread.AutoSize = true;
            this.lb_timeinread.Location = new System.Drawing.Point(22, 333);
            this.lb_timeinread.Name = "lb_timeinread";
            this.lb_timeinread.Size = new System.Drawing.Size(46, 15);
            this.lb_timeinread.TabIndex = 16;
            this.lb_timeinread.Text = "Time In";
            // 
            // lb_timeoutread
            // 
            this.lb_timeoutread.AutoSize = true;
            this.lb_timeoutread.Location = new System.Drawing.Point(22, 365);
            this.lb_timeoutread.Name = "lb_timeoutread";
            this.lb_timeoutread.Size = new System.Drawing.Size(56, 15);
            this.lb_timeoutread.TabIndex = 17;
            this.lb_timeoutread.Text = "Time Out";
            // 
            // tb_nameread
            // 
            this.tb_nameread.Location = new System.Drawing.Point(79, 298);
            this.tb_nameread.Name = "tb_nameread";
            this.tb_nameread.ReadOnly = true;
            this.tb_nameread.Size = new System.Drawing.Size(135, 23);
            this.tb_nameread.TabIndex = 19;
            this.tb_nameread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_timeinread
            // 
            this.tb_timeinread.Location = new System.Drawing.Point(79, 330);
            this.tb_timeinread.Name = "tb_timeinread";
            this.tb_timeinread.ReadOnly = true;
            this.tb_timeinread.Size = new System.Drawing.Size(135, 23);
            this.tb_timeinread.TabIndex = 20;
            this.tb_timeinread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_timeoutread
            // 
            this.tb_timeoutread.Location = new System.Drawing.Point(79, 362);
            this.tb_timeoutread.Name = "tb_timeoutread";
            this.tb_timeoutread.ReadOnly = true;
            this.tb_timeoutread.Size = new System.Drawing.Size(135, 23);
            this.tb_timeoutread.TabIndex = 21;
            this.tb_timeoutread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_idread
            // 
            this.tb_idread.Location = new System.Drawing.Point(63, 253);
            this.tb_idread.Name = "tb_idread";
            this.tb_idread.ReadOnly = true;
            this.tb_idread.Size = new System.Drawing.Size(100, 23);
            this.tb_idread.TabIndex = 22;
            this.tb_idread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 443);
            this.Controls.Add(this.tb_idread);
            this.Controls.Add(this.tb_timeoutread);
            this.Controls.Add(this.tb_timeinread);
            this.Controls.Add(this.tb_nameread);
            this.Controls.Add(this.lb_timeoutread);
            this.Controls.Add(this.lb_timeinread);
            this.Controls.Add(this.lb_nameread);
            this.Controls.Add(this.pb_profilepic);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.lb_test);
            this.Controls.Add(this.rbtn_timeout);
            this.Controls.Add(this.rbtn_timein);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.tb_input1);
            this.Controls.Add(this.lb_input);
            this.MaximumSize = new System.Drawing.Size(490, 482);
            this.MinimumSize = new System.Drawing.Size(490, 482);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_profilepic)).EndInit();
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
        private PictureBox pb_profilepic;
        private Label lb_nameread;
        private Label lb_timeinread;
        private Label lb_timeoutread;
        private TextBox tb_nameread;
        private TextBox tb_timeinread;
        private TextBox tb_timeoutread;
        private TextBox tb_idread;
    }
}