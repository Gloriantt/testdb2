using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace testdb2
{
    public partial class Main : Form
    {
        public int Number_Tables = 0;
        private DataTable dt = new DataTable();   
        private DataSet ds = new DataSet();
        private NpgsqlConnection conn = new NpgsqlConnection("Server=rogue.db.elephantsql.com;Port=5432;User Id=xxjquuqc;Password=9muAsldlU2ACYsrE95cEnJHrCduz6dBG;Database=xxjquuqc;");
        public Main()
        {
            InitializeComponent();
        }
        private void Output_table_Classes()
        {
            try
            {

                conn.Open();
                string sql = ("SELECT classes.name_class,classes.class_number,teachers.name_teacher FROM Classes inner join teachers on classes.id_teacher=teachers.id_teacher;");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Button2_Click(object sender, EventArgs e)
        {
            Insert f = new Insert();
            f.Show();
            if (Number_Tables == 1)
            {
                f.panel1.Visible = true;
            } else if (Number_Tables == 2)
            {
                f.panel2.Visible = true;
            } else if (Number_Tables == 3)
            {
                f.panel3.Visible = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void КлассыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Output_table_Classes();
        }

        private void СтудентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            { 
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.class_number='1';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.class_number='2';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.class_number='3';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.class_number='4';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.class_number='5';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.class_number='6';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.class_number='7';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void ToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.class_number='8';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void ToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.class_number='9';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void ToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.class_number='10';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void ToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.class_number='11';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void УчителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Number_Tables = 2;
            try
            {
                conn.Open();
                string sql = ("SELECT Name_Teacher,Phone_Teacher,Stage FROM Teachers");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void РодителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Number_Tables = 3;
            try
            {
                conn.Open();
                string sql = ("select names_parents,phone_parents,adress_work,name_work,phone_work from parents;");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    conn.Open();
                    string sql = ($"SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_Number FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Students.Name_Student='{textBox1.Text}'");
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                    ds.Reset();
                    da.Fill(ds);
                    dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    conn.Close();
            }
                catch
            {
                MessageBox.Show("Возникла ошибка");
            }
        }
            else { MessageBox.Show("пустое поле"); }
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='A' and Classes.class_number='1';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void AToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='A' and Classes.class_number='2';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void AToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='A' and Classes.class_number='3';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void AToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='A' and Classes.class_number='4';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void AToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='A' and Classes.class_number='5';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void AToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='A' and Classes.class_number='6';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void AToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='A' and Classes.class_number='7';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void AToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='A' and Classes.class_number='8';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void AToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='A' and Classes.class_number='9';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void AToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='A' and Classes.class_number='10';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void AToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='A' and Classes.class_number='11';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='B' and Classes.class_number='1';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void BToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='B' and Classes.class_number='2';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void BToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='B' and Classes.class_number='3';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void BToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='B' and Classes.class_number='4';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void BToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='B' and Classes.class_number='5';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void BToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='B' and Classes.class_number='6';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void BToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='B' and Classes.class_number='7';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void BToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='B' and Classes.class_number='8';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void BToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='B' and Classes.class_number='9';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void BToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='B' and Classes.class_number='10';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void BToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Number_Tables = 1;
            try
            {
                conn.Open();
                string sql = ("SELECT Students.Name_Student,Students.Phone,Classes.Name_Class,Classes.Class_number,Parents.Names_Parents FROM Students inner join Classes on Students.Id_Class=Classes.Id_Class inner join Parents on Students.Id_Parents=Parents.Id_Parent where Classes.name_class='B' and Classes.class_number='11';");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка!");
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Main.ActiveForm.Enabled = true;
            panel1.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           
            Delete f = new Delete();
            try
            {
                conn.Open();
                string sql = ("SELECT * FROM Students;");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                f.dataGridView1.DataSource = dt;
                conn.Close();
                f.panel1.Visible = true;
                f.Show();
            }
            catch { MessageBox.Show("Возникла ошибка!"); }
            panel1.Visible = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            
            Delete f = new Delete();
            try
            {
                conn.Open();
                string sql = ("SELECT * FROM Classes;");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                f.dataGridView1.DataSource = dt;
                conn.Close();
                f.panel2.Visible = true;
                f.Show();
               
            }
            catch { MessageBox.Show("Возникла ошибка!"); }
            panel1.Visible = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Delete f = new Delete();
            try
            {
                conn.Open();
                string sql = ("SELECT * FROM parents;");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                f.dataGridView1.DataSource = dt;
                conn.Close();
                f.panel3.Visible = true;
                f.Show();
                
            }
            catch { MessageBox.Show("Возникла ошибка!"); }
            panel1.Visible = false;
        }

        private void Button9_Click(object sender, EventArgs e)
        {

            Change f = new Change();
            try
            {
                conn.Open();
                string sql = ("SELECT * FROM Students;");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                f.dataGridView1.DataSource = dt;
                conn.Close();
                f.panel2.Visible = true;
                f.Show();
            }
            catch { MessageBox.Show("Возникла ошибка!"); }
            panel2.Visible = false;
            f.panel2.Visible = true;
        }

        private void Button10_Click(object sender, EventArgs e)
        {

            Change f = new Change();
            try
            {
                conn.Open();
                string sql = ("SELECT * FROM parents;");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                f.dataGridView1.DataSource = dt;
                conn.Close();
                f.panel3.Visible = true;
                f.Show();
            }
            catch { MessageBox.Show("Возникла ошибка!"); }
            panel2.Visible = false;
            f.panel3.Visible = true;

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
   

