
namespace HotelManagment
{
    partial class RoomsInform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsInform));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2date3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer13 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.yesradio = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.noradio = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.romeditbtn = new System.Windows.Forms.Button();
            this.romdeltbtn = new System.Windows.Forms.Button();
            this.romaddbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.roomsDataGridshow = new Guna.UI2.WinForms.Guna2DataGridView();
            this.searchbartxt33 = new Guna.UI2.WinForms.Guna2TextBox();
            this.roomphonetxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.roomidtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridshow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.label2date3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 107);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2date3
            // 
            this.label2date3.AutoSize = true;
            this.label2date3.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2date3.Location = new System.Drawing.Point(953, 47);
            this.label2date3.Name = "label2date3";
            this.label2date3.Size = new System.Drawing.Size(82, 34);
            this.label2date3.TabIndex = 1;
            this.label2date3.Text = "ألتاريخ";
            this.label2date3.Click += new System.EventHandler(this.label2date3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "معلومات ألغرف ";
            // 
            // timer13
            // 
            this.timer13.Tick += new System.EventHandler(this.timer13_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(856, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "محجوزة";
            // 
            // yesradio
            // 
            this.yesradio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yesradio.CheckedState.BorderThickness = 0;
            this.yesradio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yesradio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.yesradio.CheckedState.Parent = this.yesradio;
            this.yesradio.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesradio.Location = new System.Drawing.Point(970, 367);
            this.yesradio.Name = "yesradio";
            this.yesradio.ShadowDecoration.Parent = this.yesradio;
            this.yesradio.Size = new System.Drawing.Size(35, 34);
            this.yesradio.TabIndex = 10;
            this.yesradio.Text = "guna2CustomRadioButton1";
            this.yesradio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.yesradio.UncheckedState.BorderThickness = 2;
            this.yesradio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.yesradio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.yesradio.UncheckedState.Parent = this.yesradio;
            this.yesradio.CheckedChanged += new System.EventHandler(this.yesradio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(1011, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "نعم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(1103, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "لا";
            // 
            // noradio
            // 
            this.noradio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.noradio.CheckedState.BorderThickness = 0;
            this.noradio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.noradio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.noradio.CheckedState.Parent = this.noradio;
            this.noradio.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noradio.Location = new System.Drawing.Point(1062, 367);
            this.noradio.Name = "noradio";
            this.noradio.ShadowDecoration.Parent = this.noradio;
            this.noradio.Size = new System.Drawing.Size(35, 34);
            this.noradio.TabIndex = 12;
            this.noradio.Text = "guna2CustomRadioButton2";
            this.noradio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.noradio.UncheckedState.BorderThickness = 2;
            this.noradio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.noradio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.noradio.UncheckedState.Parent = this.noradio;
            // 
            // romeditbtn
            // 
            this.romeditbtn.BackColor = System.Drawing.Color.MediumPurple;
            this.romeditbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.romeditbtn.FlatAppearance.BorderSize = 0;
            this.romeditbtn.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romeditbtn.ForeColor = System.Drawing.Color.Black;
            this.romeditbtn.Location = new System.Drawing.Point(1140, 483);
            this.romeditbtn.Name = "romeditbtn";
            this.romeditbtn.Size = new System.Drawing.Size(108, 72);
            this.romeditbtn.TabIndex = 21;
            this.romeditbtn.Text = "تعديل";
            this.romeditbtn.UseVisualStyleBackColor = false;
            this.romeditbtn.Click += new System.EventHandler(this.romeditbtn_Click);
            // 
            // romdeltbtn
            // 
            this.romdeltbtn.BackColor = System.Drawing.Color.MediumPurple;
            this.romdeltbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.romdeltbtn.FlatAppearance.BorderSize = 0;
            this.romdeltbtn.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romdeltbtn.ForeColor = System.Drawing.Color.Black;
            this.romdeltbtn.Location = new System.Drawing.Point(991, 483);
            this.romdeltbtn.Name = "romdeltbtn";
            this.romdeltbtn.Size = new System.Drawing.Size(108, 72);
            this.romdeltbtn.TabIndex = 20;
            this.romdeltbtn.Text = "حذف";
            this.romdeltbtn.UseVisualStyleBackColor = false;
            this.romdeltbtn.Click += new System.EventHandler(this.romdeltbtn_Click);
            // 
            // romaddbtn
            // 
            this.romaddbtn.BackColor = System.Drawing.Color.MediumPurple;
            this.romaddbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.romaddbtn.FlatAppearance.BorderSize = 0;
            this.romaddbtn.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romaddbtn.ForeColor = System.Drawing.Color.Black;
            this.romaddbtn.Location = new System.Drawing.Point(852, 483);
            this.romaddbtn.Name = "romaddbtn";
            this.romaddbtn.Size = new System.Drawing.Size(108, 72);
            this.romaddbtn.TabIndex = 19;
            this.romaddbtn.Text = "أضافة";
            this.romaddbtn.UseVisualStyleBackColor = false;
            this.romaddbtn.Click += new System.EventHandler(this.romaddbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(991, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 72);
            this.button1.TabIndex = 26;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(1135, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "رقم ألغرفة";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(1127, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "هاتف ألغرفة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(29, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "أبحث عن ألغرف";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(697, 150);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(41, 51);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 33;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumPurple;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(572, 148);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 57);
            this.button4.TabIndex = 32;
            this.button4.Text = "بحث";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // roomsDataGridshow
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.roomsDataGridshow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.roomsDataGridshow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomsDataGridshow.BackgroundColor = System.Drawing.Color.White;
            this.roomsDataGridshow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomsDataGridshow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomsDataGridshow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.roomsDataGridshow.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomsDataGridshow.DefaultCellStyle = dataGridViewCellStyle3;
            this.roomsDataGridshow.EnableHeadersVisualStyles = false;
            this.roomsDataGridshow.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomsDataGridshow.Location = new System.Drawing.Point(5, 207);
            this.roomsDataGridshow.Name = "roomsDataGridshow";
            this.roomsDataGridshow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.roomsDataGridshow.RowHeadersVisible = false;
            this.roomsDataGridshow.RowHeadersWidth = 51;
            this.roomsDataGridshow.RowTemplate.Height = 24;
            this.roomsDataGridshow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomsDataGridshow.Size = new System.Drawing.Size(819, 447);
            this.roomsDataGridshow.TabIndex = 30;
            this.roomsDataGridshow.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.roomsDataGridshow.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.roomsDataGridshow.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.roomsDataGridshow.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.roomsDataGridshow.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.roomsDataGridshow.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.roomsDataGridshow.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomsDataGridshow.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Salmon;
            this.roomsDataGridshow.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.roomsDataGridshow.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsDataGridshow.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.roomsDataGridshow.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.roomsDataGridshow.ThemeStyle.HeaderStyle.Height = 29;
            this.roomsDataGridshow.ThemeStyle.ReadOnly = false;
            this.roomsDataGridshow.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.roomsDataGridshow.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.roomsDataGridshow.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsDataGridshow.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.roomsDataGridshow.ThemeStyle.RowsStyle.Height = 24;
            this.roomsDataGridshow.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomsDataGridshow.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.roomsDataGridshow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomsDataGridshow_CellContentClick);
            // 
            // searchbartxt33
            // 
            this.searchbartxt33.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbartxt33.DefaultText = "";
            this.searchbartxt33.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchbartxt33.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchbartxt33.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchbartxt33.DisabledState.Parent = this.searchbartxt33;
            this.searchbartxt33.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchbartxt33.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchbartxt33.FocusedState.Parent = this.searchbartxt33;
            this.searchbartxt33.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchbartxt33.ForeColor = System.Drawing.Color.Black;
            this.searchbartxt33.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchbartxt33.HoverState.Parent = this.searchbartxt33;
            this.searchbartxt33.Location = new System.Drawing.Point(201, 162);
            this.searchbartxt33.Name = "searchbartxt33";
            this.searchbartxt33.PasswordChar = '\0';
            this.searchbartxt33.PlaceholderText = "";
            this.searchbartxt33.SelectedText = "";
            this.searchbartxt33.ShadowDecoration.Parent = this.searchbartxt33;
            this.searchbartxt33.Size = new System.Drawing.Size(354, 36);
            this.searchbartxt33.TabIndex = 35;
            this.searchbartxt33.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchbartxt33.TextChanged += new System.EventHandler(this.searchbartxt3_TextChanged);
            // 
            // roomphonetxt
            // 
            this.roomphonetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomphonetxt.DefaultText = "";
            this.roomphonetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.roomphonetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.roomphonetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomphonetxt.DisabledState.Parent = this.roomphonetxt;
            this.roomphonetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomphonetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomphonetxt.FocusedState.Parent = this.roomphonetxt;
            this.roomphonetxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.roomphonetxt.ForeColor = System.Drawing.Color.Black;
            this.roomphonetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomphonetxt.HoverState.Parent = this.roomphonetxt;
            this.roomphonetxt.Location = new System.Drawing.Point(838, 254);
            this.roomphonetxt.Name = "roomphonetxt";
            this.roomphonetxt.PasswordChar = '\0';
            this.roomphonetxt.PlaceholderText = "";
            this.roomphonetxt.SelectedText = "";
            this.roomphonetxt.ShadowDecoration.Parent = this.roomphonetxt;
            this.roomphonetxt.Size = new System.Drawing.Size(283, 36);
            this.roomphonetxt.TabIndex = 37;
            this.roomphonetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // roomidtxt
            // 
            this.roomidtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomidtxt.DefaultText = "";
            this.roomidtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.roomidtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.roomidtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomidtxt.DisabledState.Parent = this.roomidtxt;
            this.roomidtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomidtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomidtxt.FocusedState.Parent = this.roomidtxt;
            this.roomidtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.roomidtxt.ForeColor = System.Drawing.Color.Black;
            this.roomidtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomidtxt.HoverState.Parent = this.roomidtxt;
            this.roomidtxt.Location = new System.Drawing.Point(838, 169);
            this.roomidtxt.Name = "roomidtxt";
            this.roomidtxt.PasswordChar = '\0';
            this.roomidtxt.PlaceholderText = "";
            this.roomidtxt.SelectedText = "";
            this.roomidtxt.ShadowDecoration.Parent = this.roomidtxt;
            this.roomidtxt.Size = new System.Drawing.Size(291, 36);
            this.roomidtxt.TabIndex = 36;
            this.roomidtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RoomsInform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 712);
            this.Controls.Add(this.roomphonetxt);
            this.Controls.Add(this.roomidtxt);
            this.Controls.Add(this.searchbartxt33);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.roomsDataGridshow);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.romeditbtn);
            this.Controls.Add(this.romdeltbtn);
            this.Controls.Add(this.romaddbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.noradio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yesradio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomsInform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomsInform";
            this.Load += new System.EventHandler(this.RoomsInform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2date3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer13;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CustomRadioButton yesradio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CustomRadioButton noradio;
        private System.Windows.Forms.Button romeditbtn;
        private System.Windows.Forms.Button romdeltbtn;
        private System.Windows.Forms.Button romaddbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Button button4;
        private Guna.UI2.WinForms.Guna2DataGridView roomsDataGridshow;
        private Guna.UI2.WinForms.Guna2TextBox searchbartxt33;
        private Guna.UI2.WinForms.Guna2TextBox roomphonetxt;
        private Guna.UI2.WinForms.Guna2TextBox roomidtxt;
    }
}