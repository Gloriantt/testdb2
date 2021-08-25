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
    public partial class Insert : Form
    {
        
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        private NpgsqlConnection conn = new NpgsqlConnection("Server=rogue.db.elephantsql.com;Port=5432;User Id=xxjquuqc;Password=9muAsldlU2ACYsrE95cEnJHrCduz6dBG;Database=xxjquuqc;");
        public Insert()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            int a1 = 0, a2 = 0;

            try
            {
                if ((textBox2.Text != "") && (textBox3.Text != ""))
                {
                    try
                    {

                        conn.Open();
                        string sql = $"select id_parent from Parents where names_parents='{comboBox3.SelectedItem}';";
                        NpgsqlCommand s = new NpgsqlCommand(sql, conn);
                        NpgsqlDataReader dr = s.ExecuteReader();
                        while(dr.Read())
                        {
                            
                            a1 = Convert.ToInt32(dr[0].ToString());
                            
                        }
                        MessageBox.Show( a1.ToString());
                        
                        conn.Close();

                        conn.Open();
                        string sql1 = $"select id_class from classes where name_class='{comboBox2.SelectedItem}' and class_number='{comboBox1.SelectedItem}';";
                        NpgsqlCommand s1 = new NpgsqlCommand(sql1, conn);
                        
                        NpgsqlDataReader dr1 = s1.ExecuteReader();
                        while (dr1.Read())
                        {
                                a2 = Convert.ToInt32(dr1[0].ToString());
                        }
                         MessageBox.Show(a2.ToString());
                        conn.Close();
                    }
                    catch { MessageBox.Show("ой не получилось"); }
                    string name = textBox2.Text;
                    string phone = textBox3.Text;
                    int id_class = Convert.ToInt32(comboBox1.SelectedItem);
                    try
                    {
                        conn.Open();
                        NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO Students (Name_Student,Phone,Id_Class,id_parents) VALUES ( '{name}','{phone}',{a2},{a1})", conn);
                        command.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch { MessageBox.Show("Что-то пошло не так"); }
                }
                else { MessageBox.Show("Пустые поля"); }
            }
            catch { MessageBox.Show("Не получилось добавить"); }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if ((textBox4.Text != "")&&(textBox1.Text!="")&&(textBox5.Text!=""))
            {
                string name = textBox4.Text;
                string phone = textBox1.Text;
                int stage = Convert.ToInt32(textBox5.Text);
                try
                {
                    conn.Open();
                    NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO Teachers (name_Teacher,Phone_Teacher,stage) VALUES ( '{ name}','{phone}',{stage})", conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                }
                catch { MessageBox.Show("Что-то пошло не так"); }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {

                int a = 0, b = 0; ;
                string sql = " select names_parents from Parents;";
                string sql1 = "select count(names_parents) from Parents;";
                NpgsqlCommand s = new NpgsqlCommand(sql, conn);
                NpgsqlCommand s1 = new NpgsqlCommand(sql1, conn);
                conn.Open();

                NpgsqlDataReader d1 = s1.ExecuteReader();

                while (d1.Read())
                {
                    a = Convert.ToInt32(d1[0].ToString());
                }
                conn.Close();
                conn.Open();
                string[] mas = new string[a];
                NpgsqlDataReader d = s.ExecuteReader();
                while (d.Read())
                {

                    mas[b] = d[0].ToString();
                    b++;


                }

                conn.Close();
                for (int i = 0; i < mas.Length; i++)
                {
                    comboBox3.Items.Add(mas[i]);
                }
            }
            catch { MessageBox.Show("Что-то пошло не так"); }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if ((textBox6.Text != "") && (textBox7.Text != ""))
            {
                string name = textBox6.Text;
                string phone = textBox7.Text;
                string adress_work = textBox8.Text;
                string name_work = textBox9.Text;
                string phone_work = textBox10.Text;
                try
                {
                    conn.Open();
                    NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO Parents (names_parents,phone_parents,adress_work,name_work,phone_work) VALUES ( '{ name}','{phone}','{adress_work}','{name_work}','{phone_work}')", conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                }
                catch { MessageBox.Show("Что-то пошло не так"); }
            }
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            Main f = new Main();
            f.button2.Enabled = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            Insert.ActiveForm.Visible = false;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main f = new Main();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            Insert.ActiveForm.Visible = false;
        }
    }
}
