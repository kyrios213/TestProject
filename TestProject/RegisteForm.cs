using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TestProject
{
    public partial class RegisteForm : Form
    {
        public RegisteForm()
        {
            InitializeComponent();
        }

        readonly NpgsqlConnection conn = new("Port=5433;Host=127.0.0.1;Database=test_cs;Username=postgres;Password=shadow213;Persist Security Info=True");
        readonly NpgsqlConnection conn2 = new("Port=5433;Host=127.0.0.1;Database=test_cs;Username=postgres;Password=shadow213;Persist Security Info=True");

        private void btn_register_Click(object sender, EventArgs e)
        {
            string employee_id = tb_employeeId.Text;
            string first_name = tb_firstName.Text;
            string last_name = tb_lastName.Text;

            try
            {
                if (Check_employee(employee_id))
                {
                    conn.Open();
                    var sql = "INSERT INTO employee(employee_number, first_name, last_name) VALUES(@employee_number, @first_name, @last_name)";
                    using var cmd = new NpgsqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("employee_number", employee_id);
                    cmd.Parameters.AddWithValue("first_name", first_name);
                    cmd.Parameters.AddWithValue("last_name", last_name);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Employee Registered");

                    this.Close();
                }  
                else
                {
                    tb_employeeId.Clear();
                    tb_firstName.Clear();
                    tb_lastName.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
                      
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_employeeId.Clear();
            tb_firstName.Clear();
            tb_lastName.Clear();
        }

        private bool Check_employee(string employee_id)
        {
            try
            {
                conn2.Open();
                string sql_check = "SELECT * FROM employee WHERE employee_number = @employee_number";
                using var cmd_check = new NpgsqlCommand(sql_check, conn2);

                cmd_check.Parameters.AddWithValue("employee_number", employee_id);
                var reader = cmd_check.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Employee Already Registered");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Employee Already Registered");
                return false;
            }
            finally
            {
                conn2.Close();
            }
        }

    }
}
