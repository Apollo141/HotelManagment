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
    public partial class Reservationinfo : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelDB.mdf;Integrated Security=True;Connect Timeout=30");
        public void populicate()
        {
            connection.Open();
            string myquery = "select * from Reservations_tbl";
            SqlDataAdapter daps = new SqlDataAdapter(myquery, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(daps);
            var dbs = new DataSet();
            daps.Fill(dbs);
            reservationsDataGrid.DataSource = dbs.Tables[0];
            connection.Close();
        }

        public void fillroomscombo()
        {
            connection.Open();
            string freeroom = "متوفرة";
            SqlCommand cmdrs = new SqlCommand("select RoomId from Rooms_tbl where RoomIsFree ='"+freeroom+"'", connection);
            SqlDataReader sqldr;
            sqldr = cmdrs.ExecuteReader();
            DataTable dtb = new DataTable();
            dtb.Columns.Add("RoomId", typeof(int));
            dtb.Load(sqldr);
            comboroomid.ValueMember = "RoomId"; 
            comboroomid.DataSource = dtb;
            connection.Close();

        }
        public void fillclientcombo()
        {
            connection.Open();
            SqlCommand cmdrs = new SqlCommand("select ClientName from Client_tbl", connection);
            SqlDataReader sqldr;
            sqldr = cmdrs.ExecuteReader();
            DataTable dtb = new DataTable();
            dtb.Columns.Add("ClientName", typeof(string));
            dtb.Load(sqldr);
            comboclientname.ValueMember = "ClientName";
            comboclientname.DataSource = dtb;
            connection.Close();

        }
        public Reservationinfo()
        {
            InitializeComponent();
        }
        DateTime today;
        private void Reservationinfo_Load(object sender, EventArgs e)
        {
            today = datein.Value;
            populicate();
            fillroomscombo();
            fillclientcombo();
            label2date332.Text = DateTime.Today.Day.ToString()+"-"+DateTime.Today.Month.ToString()+"-"+DateTime.Today.Year.ToString();
        }

        private void datein_ValueChanged(object sender, EventArgs e)
        {
            int rese = DateTime.Compare(datein.Value, today);
            if (rese < 0)
            {
                MessageBox.Show("الوقت الذي تم ادخاله حطأ");
                datein.ResetText();
            }
        }

        private void dateout_ValueChanged(object sender, EventArgs e)
        {
            int rese = DateTime.Compare(dateout.Value,datein.Value);
            if (rese < 0)
            {
                MessageBox.Show("وقت تسجيل الخروج غير صحيح حاول مرة اخرى");
                dateout.ResetText();
            }
        }
        public void updateroomsstateinadd()
        {
            connection.Open();
            string anotherstate = "غير متوفرة";
            string myquerre = "UPDATE Rooms_tbl set RoomIsFree='" + anotherstate + "'where RoomId= " +Convert.ToInt32(comboroomid.SelectedValue.ToString()) + ";";
            SqlCommand sqlCmd = new SqlCommand(myquerre, connection);
            sqlCmd.ExecuteNonQuery();
            //MessageBox.Show("!تمت عملية التعديل بنجاح");
            connection.Close();
            fillroomscombo();
        }
        public void updateroomsstateindelete()
        {
            connection.Open();
            string anotherstate = "متوفرة";
            int roomidz = Convert.ToInt32(reservationsDataGrid.SelectedRows[0].Cells[2].Value.ToString());
            string myquerre = "UPDATE Rooms_tbl set RoomIsFree='" + anotherstate + "'where RoomId= " +roomidz+ ";";
            SqlCommand sqlCmd = new SqlCommand(myquerre, connection);
            sqlCmd.ExecuteNonQuery();
            //MessageBox.Show("!تمت عملية التعديل بنجاح");
            connection.Close();
            fillroomscombo();
        }
        private void reservaddbtn_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand sqlcmd = new SqlCommand("insert into Reservations_tbl values(" + resrevidtxt.Text + ",'" + comboclientname.SelectedValue.ToString() + "','" + comboroomid.SelectedValue.ToString() + "','" + datein.Value + "','" + dateout.Value + "')", connection);
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("!تمت عملية الأضافة بنجاح");

            connection.Close();
            updateroomsstateinadd();
            populicate();
           
        }

        private void comboclientname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reservationsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void reservdeltbtn_Click(object sender, EventArgs e)
        {
            if (resrevidtxt.Text == "") {
                MessageBox.Show("قم بأدخال رقم الحجز حتى يتم حذفه ");
            }
            else {

                connection.Open();
                string quee = "delete from Reservations_tbl where ReservId=" + resrevidtxt.Text + "";
                SqlCommand sqlCom = new SqlCommand(quee, connection);
                sqlCom.ExecuteNonQuery();
                MessageBox.Show("!تمت عمليةالحذف بنجاح");
                connection.Close();
                updateroomsstateindelete();
                populicate();
            }
           
        }

        private void reservditbtn_Click(object sender, EventArgs e)
        {
            if (resrevidtxt.Text == "")
            {
                MessageBox.Show("قم بأدخال رقم الحجز حتى يتم تعديله ");
            }
            else
            {
                connection.Open();
                string myquerre = "UPDATE Reservations_tbl set Client='" + comboclientname.SelectedValue.ToString() + "',Room='" + comboroomid.SelectedValue.ToString() + "',DateIn='" + datein.Value.ToString() + "',DateOut='" + dateout.Value.ToString() + "' where ReservId= " + resrevidtxt.Text + ";";
                SqlCommand sqlCmd = new SqlCommand(myquerre, connection);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("!تمت عملية التعديل بنجاح");
                connection.Close();
                populicate();
            }

         
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

        private void timer13_Tick(object sender, EventArgs e)
        {
             
        }

        private void reservationsDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            resrevidtxt.Text = reservationsDataGrid.SelectedRows[0].Cells[0].Value.ToString();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            string myquery = "select * from Reservations_tbl where ReservId='" + reservsearchtxt.Text + "'";
            SqlDataAdapter daps = new SqlDataAdapter(myquery, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(daps);
            var dbs = new DataSet();
            daps.Fill(dbs);
            reservationsDataGrid.DataSource = dbs.Tables[0];
            connection.Close();
        }

        private void pictureBox14_Click_1(object sender, EventArgs e)
        {
            populicate();
        }
    }
}
