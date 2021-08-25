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
    public partial class Change : Form
    {
        private NpgsqlConnection conn = new NpgsqlConnection("Server=rogue.db.elephantsql.com;Port=5432;User Id=xxjquuqc;Password=9muAsldlU2ACYsrE95cEnJHrCduz6dBG;Database=xxjquuqc;");
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        public Change()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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
                    comboBox1.Items.Add(mas[i]);
                }
            }
            catch { MessageBox.Show("Что-то пошло не так"); }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = "";
            string phone = "";
            if (textBox1.Text !="")
            {

               try
                { 
                conn.Open();
                string sql = ($"SELECT Students.Name_Student FROM Students  where Students.id_student={textBox1.Text}");
                    NpgsqlCommand s = new NpgsqlCommand(sql, conn);
                    NpgsqlDataReader dr = s.ExecuteReader();
                while (dr.Read())
                {

                    name = (dr[0].ToString());

                }
                textBox2.Text = name;
                conn.Close();
                }
                catch
                {
                    MessageBox.Show("Возникла ошибка");
                }

                try
                {
                    conn.Open();
                    string sql = ($"SELECT Students.phone FROM Students  where Students.id_student={textBox1.Text}");
                    NpgsqlCommand s = new NpgsqlCommand(sql, conn);
                    NpgsqlDataReader dr = s.ExecuteReader();
                    while (dr.Read())
                    {

                        phone = (dr[0].ToString());

                    }
                    textBox3.Text = phone;
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Возникла ошибка");
                }

                panel1.Visible = true;
            }
           
            
            else
            {
                MessageBox.Show("пустое поле");
            }
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int a1 = 0;
            int a2 = 0;
            try
            {
                
                conn.Open();
                string sql = $"select id_parent from Parents where names_parents='{comboBox1.SelectedItem}';";
                NpgsqlCommand s = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader dr = s.ExecuteReader();
                while (dr.Read())
                {

                    a1 = Convert.ToInt32(dr[0].ToString());

                }
                

                conn.Close();
            }
            catch { MessageBox.Show("проверьте введенные данные"); }

            try
            {
                conn.Open();
                string sql1 = $"select id_class from classes where name_class='{comboBox2.SelectedItem}' and class_number='{comboBox3.SelectedItem}';";
                NpgsqlCommand s1 = new NpgsqlCommand(sql1, conn);

                NpgsqlDataReader dr1 = s1.ExecuteReader();
                while (dr1.Read())
                {
                    a2 = Convert.ToInt32(dr1[0].ToString());
                }
                MessageBox.Show(a2.ToString());
                conn.Close();
            }
            catch { MessageBox.Show("возникла ошибка"); }
            try
            {
                conn.Open();
                string sql2 = ($"update Students set id_parents={a1}, name_student='{textBox2.Text}',phone='{textBox3.Text}',id_class={a2} where id_student={textBox1.Text}");
                NpgsqlCommand s2 = new NpgsqlCommand(sql2, conn);
                s2.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка");
            }
            try
            {
                conn.Open();
                string sql = ("SELECT * FROM Students;");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();
               
            }
            catch { MessageBox.Show("Возникла ошибка!"); }

            panel1.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = $"select names_parents from Parents where id_parent={textBox4.Text};";
                NpgsqlCommand s = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader dr = s.ExecuteReader();
                while (dr.Read())
                {
                   textBox5.Text  =dr[0].ToString();

                }


                conn.Close();
            }
            catch { MessageBox.Show("проверьте введенные данные"); }

            try
            {
                conn.Open();
                string sql = $"select phone_parents from Parents where id_parent={textBox4.Text};";
                NpgsqlCommand s = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader dr = s.ExecuteReader();
                while (dr.Read())
                {
                    textBox6.Text = dr[0].ToString();

                }


                conn.Close();
            }
            catch { MessageBox.Show("проверьте введенные данные"); }
            try
            {
                conn.Open();
                string sql = $"select adress_work from Parents where id_parent={textBox4.Text};";
                NpgsqlCommand s = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader dr = s.ExecuteReader();
                while (dr.Read())
                {
                    textBox7.Text = dr[0].ToString();

                }


                conn.Close();
            }
            catch { MessageBox.Show("проверьте введенные данные"); }
            try
            {
                conn.Open();
                string sql = $"select name_work from Parents where id_parent={textBox4.Text};";
                NpgsqlCommand s = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader dr = s.ExecuteReader();
                while (dr.Read())
                {
                    textBox8.Text = dr[0].ToString();

                }


                conn.Close();
            }
            catch { MessageBox.Show("проверьте введенные данные"); }
            try
            {
                conn.Open();
                string sql = $"select phone_work from Parents where id_parent={textBox4.Text};";
                NpgsqlCommand s = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader dr = s.ExecuteReader();
                while (dr.Read())
                {
                    textBox9.Text = dr[0].ToString();

                }


                conn.Close();
            }
            catch { MessageBox.Show("проверьте введенные данные"); }
            panel4.Visible = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            Insert.ActiveForm.Visible = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql2 = ($"update parents set names_parents='{textBox5.Text}', phone_parents='{textBox6.Text}',adress_work='{textBox7.Text}',name_work='{textBox8.Text}',phone_work='{textBox9.Text}' where id_parent={textBox4.Text}");
                NpgsqlCommand s2 = new NpgsqlCommand(sql2, conn);
                s2.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка");
            }
            try
            {
                conn.Open();
                string sql = ("SELECT * FROM parents;");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                conn.Close();

            }
            catch { MessageBox.Show("Возникла ошибка!"); }

            panel4.Visible = false;
        }
    }
}
