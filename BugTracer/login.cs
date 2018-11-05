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
            if (txtuname.Text != "" && txtpassword.Text != "")
            {
                if (txtuname.Text == "admin" && txtpassword.Text == "admin")
                {
                    MessageBox.Show("hello " + txtuname.Text);
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
    }
}
