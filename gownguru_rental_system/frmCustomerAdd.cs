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

namespace gownguru_rental_system
{
    public partial class frmCustomerAdd : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QS67U0AV\SQLEXPRESS;Initial Catalog=DB_GRS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        public frmCustomerAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this customer?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tblCustomer(cname,cgender,cemail,cphone,caddress)VALUES(@cname,@cgender,@cemail,@cphone,@caddress)", con);
                    cm.Parameters.AddWithValue("@cname", txtCustName.Text);
                    cm.Parameters.AddWithValue("@cgender", cbGender.Text);
                    cm.Parameters.AddWithValue("@cemail", txtEmail.Text);
                    cm.Parameters.AddWithValue("@cphone", txtPhone.Text);
                    cm.Parameters.AddWithValue("@caddress", txtAddress.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer has been successfully saved!");
                    Clear();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            txtCustName.Clear();
            cbGender.Text = "";
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this customer?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tblCustomer SET cname = @cname, cgender = @cgender, cemail = @cemail, cphone = @cphone, caddress = @cphone WHERE cid LIKE '" + lblCustId.Text + "' ", con);
                    cm.Parameters.AddWithValue("@cname", txtCustName.Text);
                    cm.Parameters.AddWithValue("@cgender", cbGender.Text);
                    cm.Parameters.AddWithValue("@cemail", txtEmail.Text);
                    cm.Parameters.AddWithValue("@cphone", txtPhone.Text);
                    cm.Parameters.AddWithValue("@caddress", txtAddress.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer has been successfully updated!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
    }
}
