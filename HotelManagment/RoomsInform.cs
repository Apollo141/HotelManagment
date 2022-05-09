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
    public partial class RoomsInform : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelDB.mdf;Integrated Security=True;Connect Timeout=30");
        public void populicate()
        {
            connection.Open();
            string myquery = "select * from Rooms_tbl";
            SqlDataAdapter daps = new SqlDataAdapter(myquery, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(daps);
            var dbs = new DataSet();
            daps.Fill(dbs);
            roomsDataGridshow.DataSource = dbs.Tables[0];
            connection.Close();
        }
        public RoomsInform()
        {
            InitializeComponent();
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            //label2date3.Text = DateTime.Now.ToLongTimeString();
        }

        private void RoomsInform_Load(object sender, EventArgs e)
        {
            label2date3.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
            timer13.Start();
            populicate();

        }
        private string provider(string providersnm)
        {

            if (yesradio.Checked == true)
            {
                providersnm = "غير متوفرة";
            }
            else
            {
                providersnm = "متوفرة";
            }
            return providersnm;
        }
        private void romaddbtn_Click(object sender, EventArgs e)
        {
            string prover="";
            connection.Open();

            SqlCommand sqlcmd = new SqlCommand("insert into Rooms_tbl values(" + roomidtxt.Text + ",'" + roomphonetxt.Text + "','" + provider(prover) + "')", connection);
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("!تمت عملية الأضافة بنجاح");

            connection.Close();
          populicate();
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void roomsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
   
        }

        private void romdeltbtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            string quee = "delete from Rooms_tbl where RoomId=" + roomidtxt.Text + "";
            SqlCommand sqlCom = new SqlCommand(quee, connection);
            sqlCom.ExecuteNonQuery();
            MessageBox.Show("!تمت عمليةالحذف بنجاح");
            connection.Close();
            populicate();
        }

        private void romeditbtn_Click(object sender, EventArgs e)
        {
            string prover = "";
            connection.Open();
            string myquerre = "UPDATE Rooms_tbl set RoomPhone='" + roomphonetxt.Text + "',RoomIsFree='" + provider(prover) + "' where RoomId= " + roomidtxt.Text + ";";
            SqlCommand sqlCmd = new SqlCommand(myquerre, connection);
            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("!تمت عملية التعديل بنجاح");
            connection.Close();
            populicate();
        }

      

        private void roomidtxt_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void label2date3_Click(object sender, EventArgs e)
        {

        }

        private void searchbartxt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomsDataGridshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            roomidtxt.Text = roomsDataGridshow.SelectedRows[0].Cells[0].Value.ToString();
            roomphonetxt.Text = roomsDataGridshow.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            string myquery = "select * from Rooms_tbl where RoomId='" + searchbartxt33.Text + "'";
            SqlDataAdapter daps = new SqlDataAdapter(myquery, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(daps);
            var dbs = new DataSet();
            daps.Fill(dbs);
            roomsDataGridshow.DataSource = dbs.Tables[0];
            connection.Close();
        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {
            populicate();

            searchbartxt33.ResetText();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yesradio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
