using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagment
{
    public partial class StaffsInforms : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelDB.mdf;Integrated Security=True;Connect Timeout=30");
        public void populicate()
        {
            connection.Open();
            string myquery = "select * from Staffs_tbl";
            SqlDataAdapter daps = new SqlDataAdapter(myquery, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(daps);
            var dbs = new DataSet();
            daps.Fill(dbs);
            staffsDataGrid.DataSource = dbs.Tables[0];
            connection.Close();
        }
        public StaffsInforms()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand sqlcmd = new SqlCommand("insert into Staffs_tbl values(" + staffidtxt.Text + ",'" + staffnametxt.Text + "','" + staffphone.Text + "','" + clientcombomeal2.SelectedItem.ToString() + "','" +StaffsPasss.Text + "')", connection);
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("!تمت عملية الأضافة بنجاح");

            connection.Close();
          populicate();
        }

        private void staffsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void StaffsInforms_Load(object sender, EventArgs e)
        {
            label2date22.Text = DateTime.Now.ToLongTimeString();
            timer12.Start(); 
            populicate();

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            string myquerre = "UPDATE Staffs_tbl set StaffName='" + staffnametxt.Text + "',StaffPhone='" + staffphone.Text + "',Gender='" + clientcombomeal2.SelectedItem.ToString() + "',StaffPass='" + StaffsPasss.Text + "'where StaffId= " + staffidtxt.Text + ";";
            SqlCommand sqlCmd = new SqlCommand(myquerre, connection);
            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("!تمت عملية التعديل بنجاح");
            connection.Close();
            populicate();
        }

        private void deltbtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            string quee = "delete from Staffs_tbl where StaffId=" + staffidtxt.Text + "";
            SqlCommand sqlCom = new SqlCommand(quee, connection);
            sqlCom.ExecuteNonQuery();
            MessageBox.Show("!تمت عمليةالحذف بنجاح");
            connection.Close();
            populicate();
        }

    

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2date22.Text = DateTime.Now.ToLongTimeString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void label2date22_Click(object sender, EventArgs e)
        {

        }

        private void staffsDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            staffidtxt.Text = staffsDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            staffnametxt.Text = staffsDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            staffphone.Text = staffsDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            clientcombomeal2.SelectedItem = staffsDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            StaffsPasss.Text = staffsDataGrid.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            string myquery = "select * from Staffs_tbl where StaffName='" + searchbartxt2.Text + "'";
            SqlDataAdapter daps = new SqlDataAdapter(myquery, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(daps);
            var dbs = new DataSet();
            daps.Fill(dbs);
            staffsDataGrid.DataSource = dbs.Tables[0];
            connection.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            populicate();
            searchbartxt2.ResetText();
        }

        private void searchbartxt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
