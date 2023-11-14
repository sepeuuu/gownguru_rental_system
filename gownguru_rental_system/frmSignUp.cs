using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gownguru_rental_system
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        /*SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QS67U0AV\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True");
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;*/

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtConfirmPass.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPass.Text == txtConfirmPass.Text)
            {
                /*con.Open();
                string register = "INSERT INTO tblUser VALUES ('" + txtUsername.Text + "','" + txtPassword.Text + "');
                cmd = new OlenDBCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();*/

                txtUsername.Text = "";
                txtPass.Text = "";
                txtConfirmPass.Text = "";

                MessageBox.Show("Your account has been successfully created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password doesnot match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Text = "";
                txtConfirmPass.Text = "";
                txtPass.Focus();
            }
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                txtPass.PasswordChar = '\0';
                txtConfirmPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '●';
                txtConfirmPass.PasswordChar = '●';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPass.Text = "";
            txtConfirmPass.Text = "";
            txtUsername.Focus();
        }

        private void lblBackLogin_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
