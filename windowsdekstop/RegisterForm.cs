using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsdekstop
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {

            InitializeComponent();
            UserName.Text = "Введите имя";
            UserSurname.Text = "фамилия";

        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastpoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
                Console.WriteLine(e);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserName_Enter(object sender, EventArgs e)
        {
            if (UserName.Text == "Введите имя") ;
            UserName.Text = "";
        }

        private void UserName_Leave(object sender, EventArgs e)
        {
            if (UserName.Text == "")
                UserName.Text = "Введите имя";

        }

        private void UserSurname_Enter(object sender, EventArgs e)
        {
            if (UserSurname.Text == "фамилия")
                UserSurname.Text = "";
        }

        private void UserSurname_Leave(object sender, EventArgs e)
        {
            if (UserSurname.Text == "")
                UserSurname.Text = "фамилия";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "Введите имя")
            {
                MessageBox.Show("Веддите имя");
                return;

            }
            if (UserSurname.Text == "фамилия")
            {
                MessageBox.Show("Введите фамилию");
                return;

            }
            if (Login.Text == "")
            {
                MessageBox.Show("Веддите логин");
                return;

            }
            if (Password.Text == "")
            {
                MessageBox.Show("Веддите пароль");
                return;

            }
            if (isUserExists())
                return;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`) VALUES (@login,@password,@name,@surname);", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Login.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = UserName.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = UserSurname.Text;
            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("аккаунт был создан");
            else MessageBox.Show("аккаунт не был создан");


            db.CloseConnection();
        }
        public Boolean isUserExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapeter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL ", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Login.Text;
            adapeter.SelectCommand = command;
            adapeter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Loginlabel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Registerlabel3_Click(object sender, EventArgs e)
        {

        }

        private void Registerlabel3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
          Form1 form = new Form1();
            form.Show();
        }
    }
}


