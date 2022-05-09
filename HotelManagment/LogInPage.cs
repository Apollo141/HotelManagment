using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagment
{
    public partial class LogInPage : Form
    {
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelDB.mdf;Integrated Security=True;Connect Timeout=30");
      
        public LogInPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
      {
            Connect.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter( "select COUNT(*) from Staffs_tbl where StaffName='"+ UserName.Text+"' and StaffPass='"+ UserPass.Text+"' " ,Connect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if(dataTable.Rows[0][0].ToString()=="1")
            {
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }                                                                                                                                                                                                                                                                                                                                                                      
            else
            {
                MessageBox.Show("خطأ ! الرمز السري او الاسم غير صحيح");
            }
            Connect.Close();
            
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void LogInPage_Load(object sender, EventArgs e)
        {

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
