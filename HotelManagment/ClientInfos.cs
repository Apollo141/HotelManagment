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
    public partial class ClientInfos : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelDB.mdf;Integrated Security=True;Connect Timeout=30");
      
        public void populicate()
        {
            connection.Open();
            string myquery = "select * from Client_tbl";
            SqlDataAdapter daps = new SqlDataAdapter(myquery, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(daps);
            var dbs = new DataSet();
            daps.Fill(dbs);
            clientDataGrid.DataSource = dbs.Tables[0];
            connection.Close();
        }
        public ClientInfos()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2date.Text = DateTime.Now.ToLongTimeString();
        }

        private void ClientInfos_Load(object sender, EventArgs e)
        {
             label2date.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populicate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

           SqlCommand sqlcmd = new SqlCommand("insert into Client_tbl values("+clientidtxt.Text+",'"+clientnametxt.Text+"','"+clientphone.Text+ "','" + clientcombomeal.SelectedItem.ToString()+ "','" + clientidnum.Text + "' )", connection);
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("!تمت عملية الأضافة بنجاح");

            connection.Close();
            populicate();
        }

        private void deltbtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            string quee = "delete from Client_tbl where ClienntId=" + clientidtxt.Text + "";
            SqlCommand sqlCom = new SqlCommand(quee, connection);
            sqlCom.ExecuteNonQuery();
            MessageBox.Show("!تمت عمليةالحذف بنجاح");
            connection.Close();
            populicate();

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void clientDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            string myquerre = "UPDATE Client_tbl set ClientName='"+ clientnametxt.Text+"',ClientPhone='"+clientphone.Text+"',ClientCountry='"+clientcombomeal.SelectedItem.ToString()+ "',ClientIdNumber='" + clientidnum.Text + "'where ClienntId= " + clientidtxt.Text+";";
            SqlCommand sqlCmd = new SqlCommand(myquerre, connection);
            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("!تمت عملية التعديل بنجاح");
            connection.Close();
            populicate();

          
        }
 
     

        private void label2date_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clientDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            clientidtxt.Text = clientDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            clientnametxt.Text = clientDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            clientphone.Text = clientDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            clientcombomeal.SelectedItem = clientDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            clientidnum.Text= clientDataGrid.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            string myquery = "select * from Client_tbl where ClientName='" +searchbartxt11.Text+ "'";
            SqlDataAdapter daps = new SqlDataAdapter(myquery, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(daps);
            var dbs = new DataSet();
            daps.Fill(dbs);
            clientDataGrid.DataSource = dbs.Tables[0];
            connection.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            populicate();
            searchbartxt11.ResetText();
        }

        private void clientidtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientcombomeal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchbartxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
