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
    public partial class Delete : Form
    {
        private NpgsqlConnection conn = new NpgsqlConnection("Server=rogue.db.elephantsql.com;Port=5432;User Id=xxjquuqc;Password=9muAsldlU2ACYsrE95cEnJHrCduz6dBG;Database=xxjquuqc;");
        public Delete()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand($"delete from Students where id_student={textBox1.Text}", conn);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("успешно");
            }
            catch { MessageBox.Show("Возникла ошибка!"); }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand($"delete from classes where id_class={textBox2.Text}", conn);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("успешно");
            }
            catch { MessageBox.Show("Возникла ошибка!"); }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand($"delete from parents where id_parent={textBox3.Text}", conn);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("успешно");
            }
            catch { MessageBox.Show("Возникла ошибка!"); }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            Delete.ActiveForm.Visible = false;


        }
    }
}
