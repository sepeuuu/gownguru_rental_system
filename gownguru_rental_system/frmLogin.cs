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
using System.Data.SqlClient;

namespace gownguru_rental_system
{
    public partial class frmLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QS67U0AV\SQLEXPRESS;Initial Catalog=DB_GRS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmLogin()
        {
            InitializeComponent();
        }   

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM tblEmployee WHERE username= '" + txtUsername.Text + "' and password= '" + txtPass.Text + "'", con);
                con.Open();
                dr = cm.ExecuteReader();

                if (dr.Read() == true)
                {
                    new frmMain().Show();
                    this.Hide();
                }
                else
                {
                MessageBox.Show("Invalid username or password, Please Try Again", "LoginFailed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPass.Text = "";
                txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }


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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
