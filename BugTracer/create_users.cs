using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracer
{
    public partial class create_users : Form
    {
        public create_users()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString;
            connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true";

            MySqlConnection myOleDbConn = new MySqlConnection(connectionString);
            myOleDbConn.Open();

            String fullname = textBox1.Text;
            String email = textBox2.Text;
            String username = textBox3.Text;
            String password = textBox4.Text;
            String userstatus = comboBox1.Text;

            // Format and execute SQL statement.[3
            String sql = String.Format("Insert Into createusers (fullname, email,username,password, userstatus) Values('{0}', '{1}', '{2}','{3}','{4}')",fullname, email, username, password, userstatus);
            MySqlCommand cmd = new MySqlCommand(sql, myOleDbConn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Bad input! Canceling request");
                return;
            }
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {


            String connectionString;
            connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true";

            MySqlConnection myOleDbConn = new MySqlConnection(connectionString);
            myOleDbConn.Open();

            String SQL = "Select * from createusers";
            MySqlCommand mySqlDbCmd = new MySqlCommand(SQL, myOleDbConn);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = mySqlDbCmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                AllDataGridView.DataSource = bSource;
                sda.Update(dbdataset);

            }

            catch (Exception ex)
            {
                MessageBox.Show("error");
            }





        }
    }
}
