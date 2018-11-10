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

namespace BugTracer
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {


            String connectionString;
            connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true";

            MySqlConnection myOleDbConn = new MySqlConnection(connectionString);
            myOleDbConn.Open();

            String SQL = "Select * from createusers where username = '" + txtuname.Text.Trim() + "' and password ='" + txtpassword.Text.Trim() + "'";

            MySqlDataAdapter sda = new MySqlDataAdapter(SQL, myOleDbConn);

            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (txtuname.Text != "" && txtpassword.Text != "")
            {
                
                if (dtbl.Rows.Count == 1)
                {
                    
                    create_users cuser = new create_users();
                    this.Hide();
                    cuser.Show();

                    
                }
                else
                {
                    MessageBox.Show("incorrect username or password");
                }
            }
            else {
                MessageBox.Show("Please fill all field! ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
