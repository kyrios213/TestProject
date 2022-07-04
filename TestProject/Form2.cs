using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            string database = tb_db.Text;
            string username = tb_user.Text;
            string password = tb_pass.Text;
            string user = nameof(user);

            Environment.SetEnvironmentVariable("database_name", database, EnvironmentVariableTarget.User);
            Environment.SetEnvironmentVariable("username", username, EnvironmentVariableTarget.User);
            Environment.SetEnvironmentVariable("password", password, EnvironmentVariableTarget.User);

            this.Close();
        }
    }
}
