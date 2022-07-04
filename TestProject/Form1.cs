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
                        MessageBox.Show("Timed In");
                        tb_input1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error In Time in");
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
                            MessageBox.Show("Timed Out");
                            tb_input1.Clear();

                        }
                        else
                        {
                            MessageBox.Show("Error In Time out");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Employee Already Timed-out");
                    }

                }
                else
                {
                    MessageBox.Show("Must Time-in First");
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

        Image? img;
        string? fileName;
        private void btn_image_Click(object sender, EventArgs e)
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory + "/images/";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            ofd.InitialDirectory = @"C:\";
            ofd.Title = "Save Image";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap b = new Bitmap(ofd.FileName);
                img = resizeImage(b, new Size(192, 192));
                pictureBox1.Image = img;
                fileName = ofd.SafeFileName;


                string pathFile = directory + fileName;
                img.Save(pathFile);
            }            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory + "/images/";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            sf.InitialDirectory = Path.GetFullPath(directory);
            //sf.RestoreDirectory = true;
            sf.FileName = fileName;
            sf.AutoUpgradeEnabled = true;

            if (sf.ShowDialog() == DialogResult.OK)
            {

                string pathFile = directory + fileName;
                if (img != null)
                {
                    img.Save(pathFile);
                }
                else { }
            }
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn3 = GetConnection();
            try
            {
                int id = 16;
                string date = "01/07/2022";

                conn3.Open();
                string sql_check = "SELECT (time_in, time_out) FROM timeinout WHERE employee_id = @employee_id AND date = @date";
                using var cmd_check = new NpgsqlCommand(sql_check, conn3);

                cmd_check.Parameters.AddWithValue("employee_id", id);
                cmd_check.Parameters.AddWithValue("date", date);
                cmd_check.Prepare();

                var reader = cmd_check.ExecuteReader();
                object obj;


                if (reader.Read() == true)
                {
                    obj = reader.GetValue(0);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine(reader.Read().ToString());
                    System.Diagnostics.Debug.WriteLine("false");
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            finally
            {
                conn3.Close();
            }
        }

       
    }
}