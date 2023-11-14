using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gownguru_rental_system
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        /*SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QS67U0AV\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True");
           SqlCommand cm = new SqlCommand();
           SqlDataReader dr;*/

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*con.Open();
            string login = "SELECT * FROM tblUser WHERE username= '" + txtUsername.Text + "' and password= '" + txtPass.Text + "'";
            cmd = new OleDBCOmmand(login, con);
            OleDBDataReader dr = cmd.ExecuteReader();*/

            /*if (dr.Read() == true)
            {
                new dashboard().Show();
                this.Hide();
            }
            else
            {*/
                MessageBox.Show("Invalid username or password, Please Try Again", "LoginFailed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPass.Text = "";
                txtUsername.Focus();
            //}
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPass.Text = "";
            txtUsername.Focus();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                txtPass.PasswordChar = '\0';      
            }
            else
            {
                txtPass.PasswordChar = '●';
            }
        }

        private void lblCreateAcc_Click(object sender, EventArgs e)
        {
            new frmSignUp().Show();
            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
