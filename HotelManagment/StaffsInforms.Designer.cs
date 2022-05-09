
namespace HotelManagment
{
    partial class StaffsInforms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffsInforms));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2date22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientcombomeal2 = new System.Windows.Forms.ComboBox();
            this.editbtn = new System.Windows.Forms.Button();
            this.deltbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.timer12 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.staffsDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.StaffsPasss = new Guna.UI2.WinForms.Guna2TextBox();
            this.staffphone = new Guna.UI2.WinForms.Guna2TextBox();
            this.staffnametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.staffidtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchbartxt2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label2date22);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 107);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2date22
            // 
            this.label2date22.AutoSize = true;
            this.label2date22.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2date22.Location = new System.Drawing.Point(953, 47);
            this.label2date22.Name = "label2date22";
            this.label2date22.Size = new System.Drawing.Size(82, 34);
            this.label2date22.TabIndex = 1;
            this.label2date22.Text = "ألتاريخ";
            this.label2date22.Click += new System.EventHandler(this.label2date22_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "معلومات ألموظف ";
            // 
            // clientcombomeal2
            // 
            this.clientcombomeal2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientcombomeal2.ForeColor = System.Drawing.Color.Crimson;
            this.clientcombomeal2.FormattingEnabled = true;
            this.clientcombomeal2.Items.AddRange(new object[] {
            "ذكر",
            "أنثى"});
            this.clientcombomeal2.Location = new System.Drawing.Point(846, 487);
            this.clientcombomeal2.Name = "clientcombomeal2";
            this.clientcombomeal2.Size = new System.Drawing.Size(273, 36);
            this.clientcombomeal2.TabIndex = 7;
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.Salmon;
            this.editbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editbtn.FlatAppearance.BorderSize = 0;
            this.editbtn.Font = new System.Drawing.Font("Algerian", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.Black;
            this.editbtn.Location = new System.Drawing.Point(1130, 549);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(108, 72);
            this.editbtn.TabIndex = 18;
            this.editbtn.Text = "تعديل";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // deltbtn
            // 
            this.deltbtn.BackColor = System.Drawing.Color.Salmon;
            this.deltbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deltbtn.FlatAppearance.BorderSize = 0;
            this.deltbtn.Font = new System.Drawing.Font("Algerian", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deltbtn.ForeColor = System.Drawing.Color.Black;
            this.deltbtn.Location = new System.Drawing.Point(981, 549);
            this.deltbtn.Name = "deltbtn";
            this.deltbtn.Size = new System.Drawing.Size(108, 72);
            this.deltbtn.TabIndex = 17;
            this.deltbtn.Text = "حذف";
            this.deltbtn.UseVisualStyleBackColor = false;
            this.deltbtn.Click += new System.EventHandler(this.deltbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Salmon;
            this.addbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.Font = new System.Drawing.Font("Algerian", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.Black;
            this.addbtn.Location = new System.Drawing.Point(842, 549);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(108, 72);
            this.addbtn.TabIndex = 16;
            this.addbtn.Text = "أضافة";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // timer12
            // 
            this.timer12.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Algerian", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(981, 649);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 72);
            this.button1.TabIndex = 20;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(1128, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 36;
            this.label2.Text = "رقم ألموظف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(1124, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 37;
            this.label3.Text = "أسم ألموظف";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(1128, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 38;
            this.label4.Text = "رقم ألهاتف";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(1128, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 29);
            this.label6.TabIndex = 39;
            this.label6.Text = "ألرقم ألسري ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(45, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 29);
            this.label5.TabIndex = 44;
            this.label5.Text = "أبحث عن ألموظفين";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(716, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Salmon;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(589, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 57);
            this.button4.TabIndex = 42;
            this.button4.Text = "بحث";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // staffsDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.staffsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.staffsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.staffsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.staffsDataGrid.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.staffsDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.staffsDataGrid.EnableHeadersVisualStyles = false;
            this.staffsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.staffsDataGrid.Location = new System.Drawing.Point(8, 206);
            this.staffsDataGrid.Name = "staffsDataGrid";
            this.staffsDataGrid.RowHeadersVisible = false;
            this.staffsDataGrid.RowHeadersWidth = 51;
            this.staffsDataGrid.RowTemplate.Height = 24;
            this.staffsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffsDataGrid.Size = new System.Drawing.Size(819, 515);
            this.staffsDataGrid.TabIndex = 40;
            this.staffsDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.staffsDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.staffsDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.staffsDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.staffsDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.staffsDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.staffsDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.staffsDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Salmon;
            this.staffsDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.staffsDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffsDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.staffsDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.staffsDataGrid.ThemeStyle.HeaderStyle.Height = 29;
            this.staffsDataGrid.ThemeStyle.ReadOnly = false;
            this.staffsDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.staffsDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.staffsDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffsDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.staffsDataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.staffsDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.staffsDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.staffsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffsDataGrid_CellContentClick_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(1151, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 29);
            this.label7.TabIndex = 45;
            this.label7.Text = "ألجنس";
            // 
            // StaffsPasss
            // 
            this.StaffsPasss.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StaffsPasss.DefaultText = "";
            this.StaffsPasss.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StaffsPasss.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StaffsPasss.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StaffsPasss.DisabledState.Parent = this.StaffsPasss;
            this.StaffsPasss.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StaffsPasss.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StaffsPasss.FocusedState.Parent = this.StaffsPasss;
            this.StaffsPasss.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StaffsPasss.ForeColor = System.Drawing.Color.Black;
            this.StaffsPasss.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StaffsPasss.HoverState.Parent = this.StaffsPasss;
            this.StaffsPasss.Location = new System.Drawing.Point(842, 425);
            this.StaffsPasss.Name = "StaffsPasss";
            this.StaffsPasss.PasswordChar = '\0';
            this.StaffsPasss.PlaceholderText = "";
            this.StaffsPasss.SelectedText = "";
            this.StaffsPasss.ShadowDecoration.Parent = this.StaffsPasss;
            this.StaffsPasss.Size = new System.Drawing.Size(277, 36);
            this.StaffsPasss.TabIndex = 53;
            this.StaffsPasss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // staffphone
            // 
            this.staffphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staffphone.DefaultText = "";
            this.staffphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.staffphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.staffphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffphone.DisabledState.Parent = this.staffphone;
            this.staffphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffphone.FocusedState.Parent = this.staffphone;
            this.staffphone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.staffphone.ForeColor = System.Drawing.Color.Black;
            this.staffphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffphone.HoverState.Parent = this.staffphone;
            this.staffphone.Location = new System.Drawing.Point(842, 352);
            this.staffphone.Name = "staffphone";
            this.staffphone.PasswordChar = '\0';
            this.staffphone.PlaceholderText = "";
            this.staffphone.SelectedText = "";
            this.staffphone.ShadowDecoration.Parent = this.staffphone;
            this.staffphone.Size = new System.Drawing.Size(277, 36);
            this.staffphone.TabIndex = 54;
            this.staffphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // staffnametxt
            // 
            this.staffnametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staffnametxt.DefaultText = "";
            this.staffnametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.staffnametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.staffnametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffnametxt.DisabledState.Parent = this.staffnametxt;
            this.staffnametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffnametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffnametxt.FocusedState.Parent = this.staffnametxt;
            this.staffnametxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.staffnametxt.ForeColor = System.Drawing.Color.Black;
            this.staffnametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffnametxt.HoverState.Parent = this.staffnametxt;
            this.staffnametxt.Location = new System.Drawing.Point(842, 280);
            this.staffnametxt.Name = "staffnametxt";
            this.staffnametxt.PasswordChar = '\0';
            this.staffnametxt.PlaceholderText = "";
            this.staffnametxt.SelectedText = "";
            this.staffnametxt.ShadowDecoration.Parent = this.staffnametxt;
            this.staffnametxt.Size = new System.Drawing.Size(280, 36);
            this.staffnametxt.TabIndex = 55;
            this.staffnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // staffidtxt
            // 
            this.staffidtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staffidtxt.DefaultText = "";
            this.staffidtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.staffidtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.staffidtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffidtxt.DisabledState.Parent = this.staffidtxt;
            this.staffidtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffidtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffidtxt.FocusedState.Parent = this.staffidtxt;
            this.staffidtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.staffidtxt.ForeColor = System.Drawing.Color.Black;
            this.staffidtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffidtxt.HoverState.Parent = this.staffidtxt;
            this.staffidtxt.Location = new System.Drawing.Point(842, 195);
            this.staffidtxt.Name = "staffidtxt";
            this.staffidtxt.PasswordChar = '\0';
            this.staffidtxt.PlaceholderText = "";
            this.staffidtxt.SelectedText = "";
            this.staffidtxt.ShadowDecoration.Parent = this.staffidtxt;
            this.staffidtxt.Size = new System.Drawing.Size(280, 36);
            this.staffidtxt.TabIndex = 56;
            this.staffidtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // searchbartxt2
            // 
            this.searchbartxt2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbartxt2.DefaultText = "";
            this.searchbartxt2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchbartxt2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchbartxt2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchbartxt2.DisabledState.Parent = this.searchbartxt2;
            this.searchbartxt2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchbartxt2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchbartxt2.FocusedState.Parent = this.searchbartxt2;
            this.searchbartxt2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchbartxt2.ForeColor = System.Drawing.Color.Black;
            this.searchbartxt2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchbartxt2.HoverState.Parent = this.searchbartxt2;
            this.searchbartxt2.Location = new System.Drawing.Point(229, 161);
            this.searchbartxt2.Name = "searchbartxt2";
            this.searchbartxt2.PasswordChar = '\0';
            this.searchbartxt2.PlaceholderText = "";
            this.searchbartxt2.SelectedText = "";
            this.searchbartxt2.ShadowDecoration.Parent = this.searchbartxt2;
            this.searchbartxt2.Size = new System.Drawing.Size(354, 36);
            this.searchbartxt2.TabIndex = 57;
            this.searchbartxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchbartxt2.TextChanged += new System.EventHandler(this.searchbartxt2_TextChanged);
            // 
            // StaffsInforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 733);
            this.Controls.Add(this.searchbartxt2);
            this.Controls.Add(this.staffidtxt);
            this.Controls.Add(this.staffnametxt);
            this.Controls.Add(this.staffphone);
            this.Controls.Add(this.StaffsPasss);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.staffsDataGrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.deltbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.clientcombomeal2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffsInforms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffsForm";
            this.Load += new System.EventHandler(this.StaffsInforms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2date22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox clientcombomeal2;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button deltbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Timer timer12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private Guna.UI2.WinForms.Guna2DataGridView staffsDataGrid;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox StaffsPasss;
        private Guna.UI2.WinForms.Guna2TextBox staffphone;
        private Guna.UI2.WinForms.Guna2TextBox staffnametxt;
        private Guna.UI2.WinForms.Guna2TextBox staffidtxt;
        private Guna.UI2.WinForms.Guna2TextBox searchbartxt2;
    }
}