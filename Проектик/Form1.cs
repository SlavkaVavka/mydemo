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
    public partial class regform : Form
    {
        public regform()
        {
            InitializeComponent();

           
        }

        private void avtoriz_Click(object sender, EventArgs e)
        {
            
        }

        private void vxod_Click(object sender, EventArgs e)
        {
            DB db= new DB();
            MySqlCommand command= new MySqlCommand("INSERT INTO 'users'('id','login','pass','name','surname') VALUES (NULL, 'Алиса','123','Алиса','Иванова');");

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = PassssField.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = RegField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");
            db.closeConnection();
        }

        private void vihod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginField_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
