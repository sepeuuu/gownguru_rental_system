using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                // Validate name
                if (!Regex.IsMatch(txtCustName.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Please enter a valid name (only letters and spaces)!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate gender selection
                if (cbGender.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a gender!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate email using regex pattern
                if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    MessageBox.Show("Please enter a valid email address!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate phone number using regex pattern
                if (!Regex.IsMatch(txtPhone.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("Please enter a valid phone number (only numbers)!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate address (alphanumeric characters)
                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show("Please enter an address!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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
                // Validate name
                if (!Regex.IsMatch(txtCustName.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Please enter a valid name (only letters and spaces)!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate gender selection
                if (string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    MessageBox.Show("Please select a gender!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate email using regex pattern
                if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    MessageBox.Show("Please enter a valid email address!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate phone number using regex pattern
                if (!Regex.IsMatch(txtPhone.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("Please enter a valid phone number (only numbers)!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate address (alphanumeric characters)
                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show("Please enter an address!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to update this customer?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tblCustomer SET cname = @cname, cgender = @cgender, cemail = @cemail, cphone = @cphone, caddress = @caddress WHERE cid LIKE '" + lblCustId.Text + "' ", con);
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
