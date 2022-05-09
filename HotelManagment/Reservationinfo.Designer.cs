
namespace HotelManagment
{
    partial class Reservationinfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservationinfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2date332 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer13 = new System.Windows.Forms.Timer(this.components);
            this.datein = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateout = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.reservditbtn = new System.Windows.Forms.Button();
            this.reservdeltbtn = new System.Windows.Forms.Button();
            this.reservaddbtn = new System.Windows.Forms.Button();
            this.comboroomid = new System.Windows.Forms.ComboBox();
            this.comboclientname = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clientcombomeal31 = new System.Windows.Forms.ComboBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.reservationsDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.reservsearchtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.resrevidtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.label2date332);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 107);
            this.panel1.TabIndex = 2;
            // 
            // label2date332
            // 
            this.label2date332.AutoSize = true;
            this.label2date332.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2date332.Location = new System.Drawing.Point(953, 47);
            this.label2date332.Name = "label2date332";
            this.label2date332.Size = new System.Drawing.Size(82, 34);
            this.label2date332.TabIndex = 1;
            this.label2date332.Text = "ألتاريخ";
            this.label2date332.Click += new System.EventHandler(this.label2date3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "معلومات ألحجز ";
            // 
            // timer13
            // 
            this.timer13.Tick += new System.EventHandler(this.timer13_Tick);
            // 
            // datein
            // 
            this.datein.Checked = true;
            this.datein.CheckedState.Parent = this.datein;
            this.datein.FillColor = System.Drawing.Color.Gold;
            this.datein.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datein.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datein.HoverState.Parent = this.datein;
            this.datein.Location = new System.Drawing.Point(853, 366);
            this.datein.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datein.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datein.Name = "datein";
            this.datein.ShadowDecoration.Parent = this.datein;
            this.datein.Size = new System.Drawing.Size(249, 54);
            this.datein.TabIndex = 11;
            this.datein.Value = new System.DateTime(2021, 12, 6, 23, 12, 45, 359);
            this.datein.ValueChanged += new System.EventHandler(this.datein_ValueChanged);
            // 
            // dateout
            // 
            this.dateout.Checked = true;
            this.dateout.CheckedState.Parent = this.dateout;
            this.dateout.FillColor = System.Drawing.Color.Gold;
            this.dateout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateout.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateout.HoverState.Parent = this.dateout;
            this.dateout.Location = new System.Drawing.Point(855, 444);
            this.dateout.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateout.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateout.Name = "dateout";
            this.dateout.ShadowDecoration.Parent = this.dateout;
            this.dateout.Size = new System.Drawing.Size(249, 54);
            this.dateout.TabIndex = 13;
            this.dateout.Value = new System.DateTime(2021, 12, 6, 23, 12, 45, 359);
            this.dateout.ValueChanged += new System.EventHandler(this.dateout_ValueChanged);
            // 
            // reservditbtn
            // 
            this.reservditbtn.BackColor = System.Drawing.Color.Gold;
            this.reservditbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.reservditbtn.FlatAppearance.BorderSize = 0;
            this.reservditbtn.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservditbtn.ForeColor = System.Drawing.Color.Black;
            this.reservditbtn.Location = new System.Drawing.Point(1121, 540);
            this.reservditbtn.Name = "reservditbtn";
            this.reservditbtn.Size = new System.Drawing.Size(108, 72);
            this.reservditbtn.TabIndex = 33;
            this.reservditbtn.Text = "تعديل";
            this.reservditbtn.UseVisualStyleBackColor = false;
            this.reservditbtn.Click += new System.EventHandler(this.reservditbtn_Click);
            // 
            // reservdeltbtn
            // 
            this.reservdeltbtn.BackColor = System.Drawing.Color.Gold;
            this.reservdeltbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.reservdeltbtn.FlatAppearance.BorderSize = 0;
            this.reservdeltbtn.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservdeltbtn.ForeColor = System.Drawing.Color.Black;
            this.reservdeltbtn.Location = new System.Drawing.Point(972, 540);
            this.reservdeltbtn.Name = "reservdeltbtn";
            this.reservdeltbtn.Size = new System.Drawing.Size(108, 72);
            this.reservdeltbtn.TabIndex = 32;
            this.reservdeltbtn.Text = "حذف";
            this.reservdeltbtn.UseVisualStyleBackColor = false;
            this.reservdeltbtn.Click += new System.EventHandler(this.reservdeltbtn_Click);
            // 
            // reservaddbtn
            // 
            this.reservaddbtn.BackColor = System.Drawing.Color.Gold;
            this.reservaddbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.reservaddbtn.FlatAppearance.BorderSize = 0;
            this.reservaddbtn.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservaddbtn.ForeColor = System.Drawing.Color.Black;
            this.reservaddbtn.Location = new System.Drawing.Point(833, 540);
            this.reservaddbtn.Name = "reservaddbtn";
            this.reservaddbtn.Size = new System.Drawing.Size(108, 72);
            this.reservaddbtn.TabIndex = 31;
            this.reservaddbtn.Text = "أضافة";
            this.reservaddbtn.UseVisualStyleBackColor = false;
            this.reservaddbtn.Click += new System.EventHandler(this.reservaddbtn_Click);
            // 
            // comboroomid
            // 
            this.comboroomid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboroomid.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.comboroomid.FormattingEnabled = true;
            this.comboroomid.Location = new System.Drawing.Point(839, 298);
            this.comboroomid.Name = "comboroomid";
            this.comboroomid.Size = new System.Drawing.Size(263, 37);
            this.comboroomid.TabIndex = 34;
            // 
            // comboclientname
            // 
            this.comboclientname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboclientname.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.comboclientname.FormattingEnabled = true;
            this.comboclientname.Location = new System.Drawing.Point(839, 240);
            this.comboclientname.Name = "comboclientname";
            this.comboclientname.Size = new System.Drawing.Size(263, 37);
            this.comboclientname.TabIndex = 35;
            this.comboclientname.SelectedIndexChanged += new System.EventHandler(this.comboclientname_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(1116, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 27);
            this.label5.TabIndex = 37;
            this.label5.Text = "أسم ألعميل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(1118, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 27);
            this.label4.TabIndex = 38;
            this.label4.Text = "رقم ألغرفة";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(972, 646);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 72);
            this.button1.TabIndex = 39;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(1126, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 29);
            this.label6.TabIndex = 40;
            this.label6.Text = "رقم ألحجز";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(1108, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 27);
            this.label3.TabIndex = 43;
            this.label3.Text = "تاريخ الخروج";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(1108, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 42;
            this.label2.Text = "تاريخ ألدخول";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(457, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 29);
            this.label7.TabIndex = 49;
            this.label7.Text = "أبحث عن ألحجوزات";
            // 
            // clientcombomeal31
            // 
            this.clientcombomeal31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientcombomeal31.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.clientcombomeal31.FormattingEnabled = true;
            this.clientcombomeal31.Items.AddRange(new object[] {
            "محجوز",
            "غير محجوز"});
            this.clientcombomeal31.Location = new System.Drawing.Point(592, 132);
            this.clientcombomeal31.Name = "clientcombomeal31";
            this.clientcombomeal31.Size = new System.Drawing.Size(167, 36);
            this.clientcombomeal31.TabIndex = 48;
            this.clientcombomeal31.Text = "حالة الغرف";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(89, 200);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(41, 51);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 47;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Click += new System.EventHandler(this.pictureBox14_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(655, 185);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 72);
            this.button4.TabIndex = 46;
            this.button4.Text = "بحث";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // reservationsDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.reservationsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.reservationsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservationsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.reservationsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservationsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reservationsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.reservationsDataGrid.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reservationsDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.reservationsDataGrid.EnableHeadersVisualStyles = false;
            this.reservationsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.reservationsDataGrid.Location = new System.Drawing.Point(8, 266);
            this.reservationsDataGrid.Name = "reservationsDataGrid";
            this.reservationsDataGrid.RowHeadersVisible = false;
            this.reservationsDataGrid.RowHeadersWidth = 51;
            this.reservationsDataGrid.RowTemplate.Height = 24;
            this.reservationsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservationsDataGrid.Size = new System.Drawing.Size(819, 452);
            this.reservationsDataGrid.TabIndex = 44;
            this.reservationsDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.reservationsDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.reservationsDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.reservationsDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.reservationsDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.reservationsDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.reservationsDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.reservationsDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Salmon;
            this.reservationsDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.reservationsDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.reservationsDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.reservationsDataGrid.ThemeStyle.HeaderStyle.Height = 29;
            this.reservationsDataGrid.ThemeStyle.ReadOnly = false;
            this.reservationsDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.reservationsDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.reservationsDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.reservationsDataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.reservationsDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.reservationsDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.reservationsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservationsDataGrid_CellContentClick_1);
            // 
            // reservsearchtxt
            // 
            this.reservsearchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reservsearchtxt.DefaultText = "";
            this.reservsearchtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.reservsearchtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.reservsearchtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reservsearchtxt.DisabledState.Parent = this.reservsearchtxt;
            this.reservsearchtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reservsearchtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reservsearchtxt.FocusedState.Parent = this.reservsearchtxt;
            this.reservsearchtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reservsearchtxt.ForeColor = System.Drawing.Color.Black;
            this.reservsearchtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reservsearchtxt.HoverState.Parent = this.reservsearchtxt;
            this.reservsearchtxt.Location = new System.Drawing.Point(147, 207);
            this.reservsearchtxt.Name = "reservsearchtxt";
            this.reservsearchtxt.PasswordChar = '\0';
            this.reservsearchtxt.PlaceholderText = "";
            this.reservsearchtxt.SelectedText = "";
            this.reservsearchtxt.ShadowDecoration.Parent = this.reservsearchtxt;
            this.reservsearchtxt.Size = new System.Drawing.Size(304, 36);
            this.reservsearchtxt.TabIndex = 57;
            this.reservsearchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resrevidtxt
            // 
            this.resrevidtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resrevidtxt.DefaultText = "";
            this.resrevidtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.resrevidtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.resrevidtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.resrevidtxt.DisabledState.Parent = this.resrevidtxt;
            this.resrevidtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.resrevidtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resrevidtxt.FocusedState.Parent = this.resrevidtxt;
            this.resrevidtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resrevidtxt.ForeColor = System.Drawing.Color.Black;
            this.resrevidtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resrevidtxt.HoverState.Parent = this.resrevidtxt;
            this.resrevidtxt.Location = new System.Drawing.Point(833, 179);
            this.resrevidtxt.Name = "resrevidtxt";
            this.resrevidtxt.PasswordChar = '\0';
            this.resrevidtxt.PlaceholderText = "";
            this.resrevidtxt.SelectedText = "";
            this.resrevidtxt.ShadowDecoration.Parent = this.resrevidtxt;
            this.resrevidtxt.Size = new System.Drawing.Size(271, 36);
            this.resrevidtxt.TabIndex = 58;
            this.resrevidtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Reservationinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 735);
            this.Controls.Add(this.resrevidtxt);
            this.Controls.Add(this.reservsearchtxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clientcombomeal31);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.reservationsDataGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboclientname);
            this.Controls.Add(this.comboroomid);
            this.Controls.Add(this.reservditbtn);
            this.Controls.Add(this.reservdeltbtn);
            this.Controls.Add(this.reservaddbtn);
            this.Controls.Add(this.dateout);
            this.Controls.Add(this.datein);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservationinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservationinfo";
            this.Load += new System.EventHandler(this.Reservationinfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2date332;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer13;
        private Guna.UI2.WinForms.Guna2DateTimePicker datein;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateout;
        private System.Windows.Forms.Button reservditbtn;
        private System.Windows.Forms.Button reservdeltbtn;
        private System.Windows.Forms.Button reservaddbtn;
        private System.Windows.Forms.ComboBox comboroomid;
        private System.Windows.Forms.ComboBox comboclientname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox clientcombomeal31;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Button button4;
        private Guna.UI2.WinForms.Guna2DataGridView reservationsDataGrid;
        private Guna.UI2.WinForms.Guna2TextBox reservsearchtxt;
        private Guna.UI2.WinForms.Guna2TextBox resrevidtxt;
    }
}