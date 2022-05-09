
namespace HotelManagment
{
    partial class ClientInfos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientInfos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientcombomeal = new System.Windows.Forms.ComboBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.deltbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clientcombomeal31 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clientDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.searchbartxt11 = new Guna.UI2.WinForms.Guna2TextBox();
            this.clientnametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.clientidtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.clientphone = new Guna.UI2.WinForms.Guna2TextBox();
            this.clientidnum = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label2date);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 107);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2date
            // 
            this.label2date.AutoSize = true;
            this.label2date.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2date.Location = new System.Drawing.Point(953, 47);
            this.label2date.Name = "label2date";
            this.label2date.Size = new System.Drawing.Size(82, 34);
            this.label2date.TabIndex = 1;
            this.label2date.Text = "ألتاريخ";
            this.label2date.Click += new System.EventHandler(this.label2date_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "معلومات ألعميل ";
            // 
            // clientcombomeal
            // 
            this.clientcombomeal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientcombomeal.ForeColor = System.Drawing.Color.DarkCyan;
            this.clientcombomeal.FormattingEnabled = true;
            this.clientcombomeal.Items.AddRange(new object[] {
            "العراق ",
            "سوريا ",
            "الأردن",
            "عمان",
            "الأمارات",
            "السعودية",
            "ليبيا",
            "مصر",
            "فلسطين"});
            this.clientcombomeal.Location = new System.Drawing.Point(848, 463);
            this.clientcombomeal.Name = "clientcombomeal";
            this.clientcombomeal.Size = new System.Drawing.Size(273, 36);
            this.clientcombomeal.TabIndex = 4;
            this.clientcombomeal.Text = "البلد";
            this.clientcombomeal.SelectedIndexChanged += new System.EventHandler(this.clientcombomeal_SelectedIndexChanged);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.Font = new System.Drawing.Font("Algerian", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.addbtn.Location = new System.Drawing.Point(848, 539);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(108, 72);
            this.addbtn.TabIndex = 6;
            this.addbtn.Text = "أضافة";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // deltbtn
            // 
            this.deltbtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.deltbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deltbtn.FlatAppearance.BorderSize = 0;
            this.deltbtn.Font = new System.Drawing.Font("Algerian", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deltbtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.deltbtn.Location = new System.Drawing.Point(987, 539);
            this.deltbtn.Name = "deltbtn";
            this.deltbtn.Size = new System.Drawing.Size(108, 72);
            this.deltbtn.TabIndex = 7;
            this.deltbtn.Text = "حذف";
            this.deltbtn.UseVisualStyleBackColor = false;
            this.deltbtn.Click += new System.EventHandler(this.deltbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.editbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editbtn.FlatAppearance.BorderSize = 0;
            this.editbtn.Font = new System.Drawing.Font("Algerian", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.editbtn.Location = new System.Drawing.Point(1136, 539);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(108, 72);
            this.editbtn.TabIndex = 8;
            this.editbtn.Text = "تعديل";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Algerian", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(987, 641);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 72);
            this.button1.TabIndex = 32;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(1130, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "رقم ألعميل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(1130, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 44;
            this.label3.Text = "أسم ألعميل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(1130, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 45;
            this.label4.Text = "رقم ألهاتف";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(489, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 29);
            this.label7.TabIndex = 51;
            this.label7.Text = "أبحث عن ألاسماء";
            // 
            // clientcombomeal31
            // 
            this.clientcombomeal31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientcombomeal31.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.clientcombomeal31.FormattingEnabled = true;
            this.clientcombomeal31.Items.AddRange(new object[] {
            "محجوز",
            "غير محجوز"});
            this.clientcombomeal31.Location = new System.Drawing.Point(590, 124);
            this.clientcombomeal31.Name = "clientcombomeal31";
            this.clientcombomeal31.Size = new System.Drawing.Size(177, 36);
            this.clientcombomeal31.TabIndex = 50;
            this.clientcombomeal31.Text = "حالة الغرف";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // clientDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.clientDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.clientDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.clientDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.clientDataGrid.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.clientDataGrid.EnableHeadersVisualStyles = false;
            this.clientDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.clientDataGrid.Location = new System.Drawing.Point(5, 251);
            this.clientDataGrid.Name = "clientDataGrid";
            this.clientDataGrid.RowHeadersVisible = false;
            this.clientDataGrid.RowHeadersWidth = 51;
            this.clientDataGrid.RowTemplate.Height = 24;
            this.clientDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientDataGrid.Size = new System.Drawing.Size(819, 449);
            this.clientDataGrid.TabIndex = 48;
            this.clientDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.clientDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.clientDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.clientDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.clientDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.clientDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.clientDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.clientDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.clientDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.clientDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.clientDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.clientDataGrid.ThemeStyle.HeaderStyle.Height = 29;
            this.clientDataGrid.ThemeStyle.ReadOnly = false;
            this.clientDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.clientDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.clientDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.clientDataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.clientDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.clientDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.clientDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientDataGrid_CellContentClick_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(659, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 75);
            this.button4.TabIndex = 47;
            this.button4.Text = "بحث";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // searchbartxt11
            // 
            this.searchbartxt11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbartxt11.DefaultText = "";
            this.searchbartxt11.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchbartxt11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchbartxt11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchbartxt11.DisabledState.Parent = this.searchbartxt11;
            this.searchbartxt11.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchbartxt11.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchbartxt11.FocusedState.Parent = this.searchbartxt11;
            this.searchbartxt11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchbartxt11.ForeColor = System.Drawing.Color.Black;
            this.searchbartxt11.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchbartxt11.HoverState.Parent = this.searchbartxt11;
            this.searchbartxt11.Location = new System.Drawing.Point(129, 187);
            this.searchbartxt11.Name = "searchbartxt11";
            this.searchbartxt11.PasswordChar = '\0';
            this.searchbartxt11.PlaceholderText = "";
            this.searchbartxt11.SelectedText = "";
            this.searchbartxt11.ShadowDecoration.Parent = this.searchbartxt11;
            this.searchbartxt11.Size = new System.Drawing.Size(354, 36);
            this.searchbartxt11.TabIndex = 52;
            this.searchbartxt11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchbartxt11.TextChanged += new System.EventHandler(this.searchbartxt_TextChanged);
            // 
            // clientnametxt
            // 
            this.clientnametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientnametxt.DefaultText = "";
            this.clientnametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clientnametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clientnametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientnametxt.DisabledState.Parent = this.clientnametxt;
            this.clientnametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientnametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientnametxt.FocusedState.Parent = this.clientnametxt;
            this.clientnametxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clientnametxt.ForeColor = System.Drawing.Color.Black;
            this.clientnametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientnametxt.HoverState.Parent = this.clientnametxt;
            this.clientnametxt.Location = new System.Drawing.Point(842, 266);
            this.clientnametxt.Name = "clientnametxt";
            this.clientnametxt.PasswordChar = '\0';
            this.clientnametxt.PlaceholderText = "";
            this.clientnametxt.SelectedText = "";
            this.clientnametxt.ShadowDecoration.Parent = this.clientnametxt;
            this.clientnametxt.Size = new System.Drawing.Size(279, 36);
            this.clientnametxt.TabIndex = 53;
            this.clientnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clientidtxt
            // 
            this.clientidtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientidtxt.DefaultText = "";
            this.clientidtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clientidtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clientidtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientidtxt.DisabledState.Parent = this.clientidtxt;
            this.clientidtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientidtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientidtxt.FocusedState.Parent = this.clientidtxt;
            this.clientidtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clientidtxt.ForeColor = System.Drawing.Color.Black;
            this.clientidtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientidtxt.HoverState.Parent = this.clientidtxt;
            this.clientidtxt.Location = new System.Drawing.Point(842, 193);
            this.clientidtxt.Name = "clientidtxt";
            this.clientidtxt.PasswordChar = '\0';
            this.clientidtxt.PlaceholderText = "";
            this.clientidtxt.SelectedText = "";
            this.clientidtxt.ShadowDecoration.Parent = this.clientidtxt;
            this.clientidtxt.Size = new System.Drawing.Size(279, 36);
            this.clientidtxt.TabIndex = 54;
            this.clientidtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clientidtxt.TextChanged += new System.EventHandler(this.clientidtxt_TextChanged);
            // 
            // clientphone
            // 
            this.clientphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientphone.DefaultText = "";
            this.clientphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clientphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clientphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientphone.DisabledState.Parent = this.clientphone;
            this.clientphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientphone.FocusedState.Parent = this.clientphone;
            this.clientphone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clientphone.ForeColor = System.Drawing.Color.Black;
            this.clientphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientphone.HoverState.Parent = this.clientphone;
            this.clientphone.Location = new System.Drawing.Point(841, 334);
            this.clientphone.Name = "clientphone";
            this.clientphone.PasswordChar = '\0';
            this.clientphone.PlaceholderText = "";
            this.clientphone.SelectedText = "";
            this.clientphone.ShadowDecoration.Parent = this.clientphone;
            this.clientphone.Size = new System.Drawing.Size(283, 36);
            this.clientphone.TabIndex = 55;
            this.clientphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clientidnum
            // 
            this.clientidnum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientidnum.DefaultText = "";
            this.clientidnum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clientidnum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clientidnum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientidnum.DisabledState.Parent = this.clientidnum;
            this.clientidnum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientidnum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientidnum.FocusedState.Parent = this.clientidnum;
            this.clientidnum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clientidnum.ForeColor = System.Drawing.Color.Black;
            this.clientidnum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientidnum.HoverState.Parent = this.clientidnum;
            this.clientidnum.Location = new System.Drawing.Point(841, 399);
            this.clientidnum.Name = "clientidnum";
            this.clientidnum.PasswordChar = '\0';
            this.clientidnum.PlaceholderText = "";
            this.clientidnum.SelectedText = "";
            this.clientidnum.ShadowDecoration.Parent = this.clientidnum;
            this.clientidnum.Size = new System.Drawing.Size(280, 36);
            this.clientidnum.TabIndex = 57;
            this.clientidnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(1127, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 56;
            this.label5.Text = "رقم ألهوية";
            // 
            // ClientInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 712);
            this.Controls.Add(this.clientidnum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clientphone);
            this.Controls.Add(this.clientidtxt);
            this.Controls.Add(this.clientnametxt);
            this.Controls.Add(this.searchbartxt11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clientcombomeal31);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clientDataGrid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.deltbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.clientcombomeal);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientInfos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientInfos";
            this.Load += new System.EventHandler(this.ClientInfos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox clientcombomeal;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button deltbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Label label2date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox clientcombomeal31;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView clientDataGrid;
        private System.Windows.Forms.Button button4;
        private Guna.UI2.WinForms.Guna2TextBox searchbartxt11;
        private Guna.UI2.WinForms.Guna2TextBox clientnametxt;
        private Guna.UI2.WinForms.Guna2TextBox clientidtxt;
        private Guna.UI2.WinForms.Guna2TextBox clientphone;
        private Guna.UI2.WinForms.Guna2TextBox clientidnum;
        private System.Windows.Forms.Label label5;
    }
}