using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomsTools2.ClassLibs;

namespace TomsTools2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUserName.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user u = new user(txtUserName.Text);
            if (u._isValid == true)
            {
                MainMenu mm = new MainMenu(u._permissionLevel);
                this.Hide();
                mm.Show();
                
                
            }
            else
            {
                MessageBox.Show("Username not valid, please try again.", "Invalid user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
