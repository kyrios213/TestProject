using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System;
using System.IO;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Reflection;



namespace TestProject
{
    internal class QueryTools
    {
        // SQL Connection
        private static NpgsqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
            return new NpgsqlConnection(connectionString);
        }

        // Check Functions
        public bool Check_Timein(int id, string date)
        {
            NpgsqlConnection conn = GetConnection();
            try
            {
                conn.Open();
                string sql_check = "SELECT (time_in) FROM timeinout WHERE employee_id = @employee_id AND date = @date";
                using var cmd_check = new NpgsqlCommand(sql_check, conn);

                cmd_check.Parameters.AddWithValue("employee_id", id);
                cmd_check.Parameters.AddWithValue("date", date);
                cmd_check.Prepare();

                var reader = cmd_check.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Check_Timeout(int id, string date)
        {
            NpgsqlConnection conn = GetConnection();
            try
            {
                conn.Open();
                string sql_check = "SELECT (time_out) FROM timeinout WHERE employee_id = @employee_id AND date = @date";
                using var cmd_check = new NpgsqlCommand(sql_check, conn);

                cmd_check.Parameters.AddWithValue("employee_id", id);
                cmd_check.Parameters.AddWithValue("date", date);
                cmd_check.Prepare();

                var reader = cmd_check.ExecuteReader();
              
                while (reader.Read())
                {
                    if (reader.GetString(0) == null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;

            }
            catch
            {
                return true;
            }
            finally
            {
                conn.Close();
            }
        }
        // End of Check Functions

        // Get Functions

        // Get List Functions
        public List<string> Get_List_Timein(string date)
        {
            List<string> timeins = new();
            NpgsqlConnection conn = GetConnection();
            try
            {
                conn.Open();
                string sql_list = "SELECT (time_in) FROM timeinout WHERE date = @date";
                using var cmd_list = new NpgsqlCommand(sql_list, conn);

                cmd_list.Parameters.AddWithValue("date", date);

                var reader = cmd_list.ExecuteReader();

                while (reader.Read())
                {
                    timeins.Add(reader.GetString(0));
                }
                return timeins;
            }
            catch
            {
                return timeins;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<string> Get_List_Timeout(string date)
        {
            List<string> timeouts = new();
            NpgsqlConnection conn = GetConnection();
            try
            {
                conn.Open();
                string sql_list = "SELECT (time_out) FROM timeinout WHERE date = @date";
                using var cmd_list = new NpgsqlCommand(sql_list, conn);

                cmd_list.Parameters.AddWithValue("date", date);

                var reader = cmd_list.ExecuteReader();

                while (reader.Read())
                {
                    timeouts.Add(reader.GetString(0));
                }
                return timeouts;
            }
            catch
            {
                return timeouts;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<int> Get_List_Employeeid(string date)
        {
            List<int> employeeIds = new();
            NpgsqlConnection conn = GetConnection();

            conn.Open();
            string sql_list = "SELECT (employee_id) FROM timeinout WHERE date = @date";
            using var cmd_list = new NpgsqlCommand(sql_list, conn);

            cmd_list.Parameters.AddWithValue("date", date);

            var reader = cmd_list.ExecuteReader();

            while (reader.Read())
            {
                employeeIds.Add(reader.GetInt32(0));
            }
            conn.Close();
            return employeeIds;
        }
        // End Of Get List Functions

        // Get Employee Data Fucntions
        public string Get_Employee_Number(int id)
        {
            NpgsqlConnection conn = GetConnection();
            try
            {
                conn.Open();
                string sql_get = "SELECT (employee_number) FROM employee WHERE id = @id";
                using var cmd_get = new NpgsqlCommand(sql_get, conn);

                cmd_get.Parameters.AddWithValue("id", id);

                var reader = cmd_get.ExecuteReader();

                if (reader.Read())
                {
                    return reader.GetString(0);
                }
                else
                {
                    return "Empty";
                }
            }
            catch
            {
                MessageBox.Show("Error in finding employee");
                return "Empty";
            }
            finally
            {
                conn.Close();
            }
        }

        public string Get_Employee_First_Name(int id)
        {
            NpgsqlConnection conn = GetConnection();
            try
            {
                conn.Open();
                string sql_get = "SELECT (first_name) FROM employee WHERE id = @id";
                using var cmd_get = new NpgsqlCommand(sql_get, conn);

                cmd_get.Parameters.AddWithValue("id", id);
                cmd_get.Prepare();

                var reader = cmd_get.ExecuteReader();

                if (reader.Read())
                {
                    return reader.GetString(0);
                }
                else
                {
                    return "Empty";
                }
            }
            catch
            {
                MessageBox.Show("Error in finding employee");
                return "Empty";
            }
            finally
            {
                conn.Close();
            }
        }

        public string Get_Employee_Last_Name(int id)
        {
            NpgsqlConnection conn = GetConnection();
            try
            {
                conn.Open();
                string sql_get = "SELECT (last_name) FROM employee WHERE id = @id";
                using var cmd_get = new NpgsqlCommand(sql_get, conn);

                cmd_get.Parameters.AddWithValue("id", id);
                cmd_get.Prepare();

                var reader = cmd_get.ExecuteReader();

                if (reader.Read())
                {
                    return reader.GetString(0);
                }
                else
                {
                    return "Empty";
                }
            }
            catch
            {
                MessageBox.Show("Error in finding employee");
                return "Empty";
            }
            finally
            {
                conn.Close();
            }
        }

        public dynamic? Get_Employee_Id(string employee_number)
        {
            NpgsqlConnection conn = GetConnection();
            string sql = "SELECT (id) FROM employee WHERE employee_number = @employee_number";
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("employee_number", employee_number);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32(0);
                        }
                        else { return null; }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return null;
                }
            }
        }
        // End Of Get Employee Data Functions

        // End of Get Functions

        // Insert/Update Functions

        public bool Add_Timein(int id, string date, string time)
        {
            NpgsqlConnection conn = GetConnection();
            string sql = "INSERT INTO timeinout(employee_id, date, time_in) VALUES (@employee_id, @date, @time_in)";
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                try
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("employee_id", id);
                    cmd.Parameters.AddWithValue("date", date);
                    cmd.Parameters.AddWithValue("time_in", time);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
                
            }
        }

        public bool Add_Timeout(int id, string date, string time)
        {
            NpgsqlConnection conn = GetConnection();
            string sql = "UPDATE timeinout SET time_out = @time_out WHERE employee_id = @employee_id AND date = @date";
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                try
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("employee_id", id);
                    cmd.Parameters.AddWithValue("date", date);
                    cmd.Parameters.AddWithValue("time_out", time);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }

            }
        }


    }
}
