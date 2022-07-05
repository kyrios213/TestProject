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
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Reflection;
using System.Configuration;

namespace TestProject
{
    public partial class RegisteForm : Form
    {
        public RegisteForm()
        {
            InitializeComponent();
        }

        private static NpgsqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
            return new NpgsqlConnection(connectionString);
        }

        readonly NpgsqlConnection conn = new("Port=5433;Host=127.0.0.1;Database=test_cs;Username=postgres;Password=shadow213;Persist Security Info=True");
        readonly NpgsqlConnection conn2 = new("Port=5433;Host=127.0.0.1;Database=test_cs;Username=postgres;Password=shadow213;Persist Security Info=True");

        private void btn_register_Click(object sender, EventArgs e)
        {
            string employee_id = tb_employeeId.Text;
            string first_name = tb_firstName.Text;
            string last_name = tb_lastName.Text;

            string directory = AppDomain.CurrentDomain.BaseDirectory + "/images/";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            NpgsqlConnection conn = GetConnection();
            string sql = "INSERT INTO employee(employee_number, first_name, last_name, image) VALUES(@employee_number, @first_name, @last_name, @image)";
            if (fileName == null)
            {
                fileName = "null";
            }
            string pathFile = directory + fileName;
            

            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("employee_number", employee_id);
                cmd.Parameters.AddWithValue("first_name", first_name);
                cmd.Parameters.AddWithValue("last_name", last_name);
                cmd.Parameters.AddWithValue("image", pathFile);
                cmd.Prepare();

                cmd.ExecuteNonQuery();
                img.Save(pathFile);

                MessageBox.Show("Employee Registered");

                this.Close();
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

        Image? img;
        string? fileName;

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            ofd.InitialDirectory = @"C:\";
            ofd.Title = "Save Image";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap b = new Bitmap(ofd.FileName);
                img = resizeImage(b, new Size(192, 192));
                pb_profilepic.Image = img;
                fileName = ofd.SafeFileName;
            }
        }

        // IMG resize
        private static System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, Size size)
        {
            //Get the image current width  
            int sourceWidth = imgToResize.Width;
            //Get the image current height  
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }
    }
}
