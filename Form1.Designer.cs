namespace testdb2
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
            this.npgsqlConnection1 = new Npgsql.NpgsqlConnection();
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.классыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.учителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.родителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // npgsqlCommand1
            // 
            this.npgsqlCommand1.AllResultTypesAreUnknown = false;
            this.npgsqlCommand1.CommandText = "select * from Players";
            this.npgsqlCommand1.Connection = this.npgsqlConnection1;
            this.npgsqlCommand1.Transaction = null;
            this.npgsqlCommand1.UnknownResultTypeList = null;
            // 
            // npgsqlConnection1
            // 
            this.npgsqlConnection1.ConnectionString = "Server=rogue.db.elephantsql.com;Port=5432;User Id=xxjquuqc;Password=9muAsldlU2ACY" +
    "srE95cEnJHrCduz6dBG;Database=xxjquuqc";
            this.npgsqlConnection1.ProvideClientCertificatesCallback = null;
            this.npgsqlConnection1.ProvidePasswordCallback = null;
            this.npgsqlConnection1.UserCertificateValidationCallback = null;
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = this.npgsqlCommand1;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(835, 478);
            this.dataGridView1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(879, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Добавить значение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1133, 31);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.классыToolStripMenuItem,
            this.студентыToolStripMenuItem,
            this.учителяToolStripMenuItem,
            this.родителиToolStripMenuItem});
            this.таблицыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(91, 27);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // классыToolStripMenuItem
            // 
            this.классыToolStripMenuItem.Name = "классыToolStripMenuItem";
            this.классыToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.классыToolStripMenuItem.Text = "Классы";
            this.классыToolStripMenuItem.Click += new System.EventHandler(this.КлассыToolStripMenuItem_Click);
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.студентыToolStripMenuItem.Text = "Ученики";
            this.студентыToolStripMenuItem.Click += new System.EventHandler(this.СтудентыToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(104, 28);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(97, 28);
            this.aToolStripMenuItem.Text = "A";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.AToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(97, 28);
            this.bToolStripMenuItem.Text = "B";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.BToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem1,
            this.bToolStripMenuItem1});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(104, 28);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
            // 
            // aToolStripMenuItem1
            // 
            this.aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            this.aToolStripMenuItem1.Size = new System.Drawing.Size(97, 28);
            this.aToolStripMenuItem1.Text = "A";
            this.aToolStripMenuItem1.Click += new System.EventHandler(this.AToolStripMenuItem1_Click);
            // 
            // bToolStripMenuItem1
            // 
            this.bToolStripMenuItem1.Name = "bToolStripMenuItem1";
            this.bToolStripMenuItem1.Size = new System.Drawing.Size(97, 28);
            this.bToolStripMenuItem1.Text = "B";
            this.bToolStripMenuItem1.Click += new System.EventHandler(this.BToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem2,
            this.bToolStripMenuItem2});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(104, 28);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem4_Click);
            // 
            // aToolStripMenuItem2
            // 
            this.aToolStripMenuItem2.Name = "aToolStripMenuItem2";
            this.aToolStripMenuItem2.Size = new System.Drawing.Size(97, 28);
            this.aToolStripMenuItem2.Text = "A";
            this.aToolStripMenuItem2.Click += new System.EventHandler(this.AToolStripMenuItem2_Click);
            // 
            // bToolStripMenuItem2
            // 
            this.bToolStripMenuItem2.Name = "bToolStripMenuItem2";
            this.bToolStripMenuItem2.Size = new System.Drawing.Size(97, 28);
            this.bToolStripMenuItem2.Text = "B";
            this.bToolStripMenuItem2.Click += new System.EventHandler(this.BToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem3,
            this.bToolStripMenuItem3});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(104, 28);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.ToolStripMenuItem5_Click);
            // 
            // aToolStripMenuItem3
            // 
            this.aToolStripMenuItem3.Name = "aToolStripMenuItem3";
            this.aToolStripMenuItem3.Size = new System.Drawing.Size(97, 28);
            this.aToolStripMenuItem3.Text = "A";
            this.aToolStripMenuItem3.Click += new System.EventHandler(this.AToolStripMenuItem3_Click);
            // 
            // bToolStripMenuItem3
            // 
            this.bToolStripMenuItem3.Name = "bToolStripMenuItem3";
            this.bToolStripMenuItem3.Size = new System.Drawing.Size(97, 28);
            this.bToolStripMenuItem3.Text = "B";
            this.bToolStripMenuItem3.Click += new System.EventHandler(this.BToolStripMenuItem3_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem4,
            this.bToolStripMenuItem4});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(104, 28);
            this.toolStripMenuItem6.Text = "5";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.ToolStripMenuItem6_Click);
            // 
            // aToolStripMenuItem4
            // 
            this.aToolStripMenuItem4.Name = "aToolStripMenuItem4";
            this.aToolStripMenuItem4.Size = new System.Drawing.Size(97, 28);
            this.aToolStripMenuItem4.Text = "A";
            this.aToolStripMenuItem4.Click += new System.EventHandler(this.AToolStripMenuItem4_Click);
            // 
            // bToolStripMenuItem4
            // 
            this.bToolStripMenuItem4.Name = "bToolStripMenuItem4";
            this.bToolStripMenuItem4.Size = new System.Drawing.Size(97, 28);
            this.bToolStripMenuItem4.Text = "B";
            this.bToolStripMenuItem4.Click += new System.EventHandler(this.BToolStripMenuItem4_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem5,
            this.bToolStripMenuItem5});
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(104, 28);
            this.toolStripMenuItem7.Text = "6";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.ToolStripMenuItem7_Click);
            // 
            // aToolStripMenuItem5
            // 
            this.aToolStripMenuItem5.Name = "aToolStripMenuItem5";
            this.aToolStripMenuItem5.Size = new System.Drawing.Size(97, 28);
            this.aToolStripMenuItem5.Text = "A";
            this.aToolStripMenuItem5.Click += new System.EventHandler(this.AToolStripMenuItem5_Click);
            // 
            // bToolStripMenuItem5
            // 
            this.bToolStripMenuItem5.Name = "bToolStripMenuItem5";
            this.bToolStripMenuItem5.Size = new System.Drawing.Size(97, 28);
            this.bToolStripMenuItem5.Text = "B";
            this.bToolStripMenuItem5.Click += new System.EventHandler(this.BToolStripMenuItem5_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem6,
            this.bToolStripMenuItem6});
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(104, 28);
            this.toolStripMenuItem8.Text = "7";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.ToolStripMenuItem8_Click);
            // 
            // aToolStripMenuItem6
            // 
            this.aToolStripMenuItem6.Name = "aToolStripMenuItem6";
            this.aToolStripMenuItem6.Size = new System.Drawing.Size(97, 28);
            this.aToolStripMenuItem6.Text = "A";
            this.aToolStripMenuItem6.Click += new System.EventHandler(this.AToolStripMenuItem6_Click);
            // 
            // bToolStripMenuItem6
            // 
            this.bToolStripMenuItem6.Name = "bToolStripMenuItem6";
            this.bToolStripMenuItem6.Size = new System.Drawing.Size(97, 28);
            this.bToolStripMenuItem6.Text = "B";
            this.bToolStripMenuItem6.Click += new System.EventHandler(this.BToolStripMenuItem6_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem7,
            this.bToolStripMenuItem7});
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(104, 28);
            this.toolStripMenuItem9.Text = "8";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.ToolStripMenuItem9_Click);
            // 
            // aToolStripMenuItem7
            // 
            this.aToolStripMenuItem7.Name = "aToolStripMenuItem7";
            this.aToolStripMenuItem7.Size = new System.Drawing.Size(97, 28);
            this.aToolStripMenuItem7.Text = "A";
            this.aToolStripMenuItem7.Click += new System.EventHandler(this.AToolStripMenuItem7_Click);
            // 
            // bToolStripMenuItem7
            // 
            this.bToolStripMenuItem7.Name = "bToolStripMenuItem7";
            this.bToolStripMenuItem7.Size = new System.Drawing.Size(97, 28);
            this.bToolStripMenuItem7.Text = "B";
            this.bToolStripMenuItem7.Click += new System.EventHandler(this.BToolStripMenuItem7_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem8,
            this.bToolStripMenuItem8});
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(104, 28);
            this.toolStripMenuItem10.Text = "9";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.ToolStripMenuItem10_Click);
            // 
            // aToolStripMenuItem8
            // 
            this.aToolStripMenuItem8.Name = "aToolStripMenuItem8";
            this.aToolStripMenuItem8.Size = new System.Drawing.Size(97, 28);
            this.aToolStripMenuItem8.Text = "A";
            this.aToolStripMenuItem8.Click += new System.EventHandler(this.AToolStripMenuItem8_Click);
            // 
            // bToolStripMenuItem8
            // 
            this.bToolStripMenuItem8.Name = "bToolStripMenuItem8";
            this.bToolStripMenuItem8.Size = new System.Drawing.Size(97, 28);
            this.bToolStripMenuItem8.Text = "B";
            this.bToolStripMenuItem8.Click += new System.EventHandler(this.BToolStripMenuItem8_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem9,
            this.bToolStripMenuItem9});
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(104, 28);
            this.toolStripMenuItem11.Text = "10";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.ToolStripMenuItem11_Click);
            // 
            // aToolStripMenuItem9
            // 
            this.aToolStripMenuItem9.Name = "aToolStripMenuItem9";
            this.aToolStripMenuItem9.Size = new System.Drawing.Size(97, 28);
            this.aToolStripMenuItem9.Text = "A";
            this.aToolStripMenuItem9.Click += new System.EventHandler(this.AToolStripMenuItem9_Click);
            // 
            // bToolStripMenuItem9
            // 
            this.bToolStripMenuItem9.Name = "bToolStripMenuItem9";
            this.bToolStripMenuItem9.Size = new System.Drawing.Size(97, 28);
            this.bToolStripMenuItem9.Text = "B";
            this.bToolStripMenuItem9.Click += new System.EventHandler(this.BToolStripMenuItem9_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem10,
            this.bToolStripMenuItem10});
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(104, 28);
            this.toolStripMenuItem12.Text = "11";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.ToolStripMenuItem12_Click);
            // 
            // aToolStripMenuItem10
            // 
            this.aToolStripMenuItem10.Name = "aToolStripMenuItem10";
            this.aToolStripMenuItem10.Size = new System.Drawing.Size(97, 28);
            this.aToolStripMenuItem10.Text = "A";
            this.aToolStripMenuItem10.Click += new System.EventHandler(this.AToolStripMenuItem10_Click);
            // 
            // bToolStripMenuItem10
            // 
            this.bToolStripMenuItem10.Name = "bToolStripMenuItem10";
            this.bToolStripMenuItem10.Size = new System.Drawing.Size(97, 28);
            this.bToolStripMenuItem10.Text = "B";
            this.bToolStripMenuItem10.Click += new System.EventHandler(this.BToolStripMenuItem10_Click);
            // 
            // учителяToolStripMenuItem
            // 
            this.учителяToolStripMenuItem.Name = "учителяToolStripMenuItem";
            this.учителяToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.учителяToolStripMenuItem.Text = "Учителя";
            this.учителяToolStripMenuItem.Click += new System.EventHandler(this.УчителяToolStripMenuItem_Click);
            // 
            // родителиToolStripMenuItem
            // 
            this.родителиToolStripMenuItem.Name = "родителиToolStripMenuItem";
            this.родителиToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.родителиToolStripMenuItem.Text = "Родители";
            this.родителиToolStripMenuItem.Click += new System.EventHandler(this.РодителиToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(879, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Поиск ученика";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(841, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 30);
            this.textBox1.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(879, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 44);
            this.button3.TabIndex = 16;
            this.button3.Text = "Удаление";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(193, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 151);
            this.panel1.TabIndex = 17;
            this.panel1.Visible = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(223, 88);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 45);
            this.button7.TabIndex = 3;
            this.button7.Text = "На главную";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(422, 25);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 43);
            this.button6.TabIndex = 2;
            this.button6.Text = "Удаление Родителей";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(237, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 44);
            this.button5.TabIndex = 1;
            this.button5.Text = "Удаление Класса";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(49, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 43);
            this.button4.TabIndex = 0;
            this.button4.Text = "Удаление ученика";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(879, 306);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(219, 45);
            this.button8.TabIndex = 18;
            this.button8.Text = "Редактировать";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Location = new System.Drawing.Point(196, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 101);
            this.panel2.TabIndex = 19;
            this.panel2.Visible = false;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(422, 19);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(165, 42);
            this.button11.TabIndex = 2;
            this.button11.Text = "Главная";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(227, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(140, 42);
            this.button10.TabIndex = 1;
            this.button10.Text = "редактирование родителей";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(49, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(147, 42);
            this.button9.TabIndex = 0;
            this.button9.Text = "Редактирование ученика";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1133, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Teachers_Magazine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Npgsql.NpgsqlCommand npgsqlCommand1;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        public Npgsql.NpgsqlConnection npgsqlConnection1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem классыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учителяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem родителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
    }
}

