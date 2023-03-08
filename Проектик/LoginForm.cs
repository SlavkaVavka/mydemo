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

namespace Проектик
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.PassField.Size = this.LoginField.Size;
            //this.PassField.Size = new Size(this.PassField.Size.Height, 64);
            this.PassField.AutoSize = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vihod_Click(object sender, EventArgs e)
        {
           
           
        
           
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form regform = new regform();
            regform.Show();
            
        }

        private void LoginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void vxod_Click(object sender, EventArgs e)
        {
            string loginUser = LoginField.Text;
            string passUser = PassField.Text;

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM  'users' WHERE 'login' = @ul AND 'pass' = @up", db.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value= loginUser;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            

            if (table.Rows.Count > 0)
                MessageBox.Show("Yes");
            else MessageBox.Show("No");


        }
    }

       
    
}
