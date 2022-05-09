using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagment
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            LogInPage loginpage = new LogInPage();
            loginpage.Show();
            this.Hide();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            StaffsInforms staffs = new StaffsInforms();
            staffs.Show();
            this.Hide();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            ClientInfos client = new ClientInfos();
            client.Show();
            this.Hide();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            Reservationinfo reservationinfo = new Reservationinfo();
            reservationinfo.Show();
            this.Hide();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            RoomsInform rooms = new RoomsInform();
            rooms.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
