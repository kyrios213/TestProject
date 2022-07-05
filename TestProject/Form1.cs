using Npgsql;
using System;
using System.IO;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Reflection;

namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn1 = GetConnection();
            NpgsqlConnection conn2 = GetConnection();
            string sql_employee = "CREATE TABLE IF NOT EXISTS employee (" +
                "id SERIAL PRIMARY KEY NOT NULL," +
                "employee_number VARCHAR(255)," +
                "first_name VARCHAR(255)," +
                "last_name VARCHAR(255)," +
                "image VARCHAR(255))";

            string sql_timeinout = "CREATE TABLE IF NOT EXISTS timeinout (" +
                "id SERIAL PRIMARY KEY NOT NULL," +
                "employee_id INT," +
                "date VARCHAR(255)," +
                "time_in VARCHAR(255)," +
                "time_out VARCHAR(255)," +
                "CONSTRAINT fk_employee FOREIGN KEY(employee_id) REFERENCES employee(id) ON DELETE CASCADE)";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql_employee, conn1))
            {
                conn1.Open();
                cmd.ExecuteNonQuery();
            }

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql_timeinout, conn2))
            {
                conn2.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private static NpgsqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
            return new NpgsqlConnection(connectionString);
        }
   
        //readonly NpgsqlConnection conn = new("Port=5433;Host=127.0.0.1;Database=test_cs;Username=postgres;Password=shadow213;Persist Security Info=True");

        // Buttons

        private void btn_connect_Click(object sender, EventArgs e)
        {
            RegisteForm form2 = new RegisteForm();
            form2.Show();

        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            string idInput = tb_input1.Text;
            NpgsqlConnection conn1 = GetConnection();
            QueryTools qt = new QueryTools();

            var employee_id = qt.Get_Employee_Id(idInput);
            if (employee_id == null)
            {
                MessageBox.Show("Invalid Employee ID");
                tb_input1.Clear();
                return;
            }
            var currentDate = DateOnly.FromDateTime(DateTime.Now);
            var currentTime = TimeOnly.FromDateTime(DateTime.Now);

            if (rbtn_timein.Checked == true)
            {
                if (qt.Check_Timein(employee_id, currentDate.ToString()))
                {
                    MessageBox.Show("Already Timed In Today");
                }
                else
                {
                    if (qt.Add_Timein(employee_id, currentDate.ToString(), currentTime.ToString()))
                    {
                        if (qt.Get_Image(idInput) != "null")
                        {
                            pb_profilepic.Image = Image.FromFile(qt.Get_Image(idInput));
                        }       
                        tb_idread.Text = idInput;
                        tb_nameread.Text = $"{qt.Get_Employee_First_Name(employee_id)} {qt.Get_Employee_Last_Name(employee_id)}";
                        tb_timeinread.Text = currentTime.ToString();
                        MessageBox.Show("Timed In");
                        tb_input1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error In Time in", "Time In Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            else if (rbtn_timeout.Checked == true)
            {
                if (qt.Check_Timein(employee_id, currentDate.ToString()))
                {
                    if (qt.Check_Timeout(employee_id, currentDate.ToString()))
                    {
                        if (qt.Add_Timeout(employee_id, currentDate.ToString(), currentTime.ToString()))
                        {
                            if (qt.Get_Image(idInput) != "null")
                            {
                                pb_profilepic.Image = Image.FromFile(qt.Get_Image(idInput));
                            }
                            tb_idread.Text = idInput;
                            tb_nameread.Text = $"{qt.Get_Employee_First_Name(employee_id)} {qt.Get_Employee_Last_Name(employee_id)}";
                            tb_timeinread.Text = qt.Get_Timein(employee_id, currentDate.ToString());
                            tb_timeoutread.Text = currentTime.ToString();
                            MessageBox.Show("Timed Out");
                            tb_input1.Clear();

                        }
                        else
                        {
                            MessageBox.Show("Error In Time out", "Time Out Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Employee Already Timed-out", "Time Out Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Must Time-in First", "Time Out Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }        
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_input1.Clear();
        }

        private void rbtn_timein_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_timein.Checked == true)
            {
                rbtn_timeout.Checked = false;
            }
        }

        private void rbtn_timeout_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_timeout.Checked == true)
            {
                rbtn_timein.Checked = false;
            }
        }
       
        private void btn_log_Click(object sender, EventArgs e)
        {
            List<string> time_inList = new();
            List<string> time_outList = new();
            List<int> employee_idList = new();
            var currentDate = DateOnly.FromDateTime(DateTime.Now);
            QueryTools qt = new QueryTools();

            try
            {
                time_inList = qt.Get_List_Timein(currentDate.ToString());
                time_outList = qt.Get_List_Timeout(currentDate.ToString());
                employee_idList = qt.Get_List_Employeeid(currentDate.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                string directory = AppDomain.CurrentDomain.BaseDirectory + "/log/";
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                string filePath = AppDomain.CurrentDomain.BaseDirectory + "/log/" + "log " + currentDate.ToString().Replace("/", "-") + ".txt";

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine("List of Names: ");
                    for (int i = 0; i < employee_idList.Count; i++)
                    {
                        string employee_number = qt.Get_Employee_Number(employee_idList[i]);
                        string employee_name = $"{qt.Get_Employee_First_Name(employee_idList[i])} {qt.Get_Employee_Last_Name(employee_idList[i])}";
                   
                        string names = $"Employee number: {employee_number} Employee Name: {employee_name}";
                        sw.WriteLine(names + " " + "Time-in: " + time_inList[i] + " " + "Time-out: " + time_outList[i]);
       
                    }
                    MessageBox.Show($"Log {currentDate.ToString()} Created at: {directory}", "Log Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }           
    }
}