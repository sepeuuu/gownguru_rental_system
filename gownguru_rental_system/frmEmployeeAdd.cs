﻿using System;
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
using System.Xml.Linq;

namespace gownguru_rental_system
{
    public partial class frmEmployeeAdd : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QS67U0AV\SQLEXPRESS;Initial Catalog=DB_GRS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        public frmEmployeeAdd()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text != txtRePass.Text)
                {
                    MessageBox.Show("Password did not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validating username (alphanumeric characters)
                if (!Regex.IsMatch(txtUsername.Text, @"^[a-zA-Z0-9]+$"))
                {
                    MessageBox.Show("Please enter a valid username (only alphanumeric characters)!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate if the text fields are not empty
                if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show("Please enter full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validating password (minimum 6 characters, at least one letter and one number)
                if (!Regex.IsMatch(txtPass.Text, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$"))
                {
                    MessageBox.Show("Please enter a valid password (minimum 6 characters, at least one letter and one number)!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validating phone number (digits only)
                if (!Regex.IsMatch(txtPhone.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("Please enter a valid phone number (only numbers)!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate if the text fields are not empty
                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show("Please enter address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validating account/role
                if (string.IsNullOrWhiteSpace(txtAccount.Text))
                {
                    MessageBox.Show("Please enter a valid account!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tblEmployee(username,fullname,password,phone,address,account)VALUES(@username,@fullname,@password,@phone,@address,@account)", con);
                    cm.Parameters.AddWithValue("@username", txtUsername.Text);
                    cm.Parameters.AddWithValue("@fullname", txtFullName.Text);
                    cm.Parameters.AddWithValue("@password", txtPass.Text);
                    cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@account", txtAccount.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been successfully saved!");
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
            txtUsername.Clear();
            txtFullName.Clear();
            txtPass.Clear();
            txtRePass.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtAccount.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text != txtRePass.Text)
                {
                    MessageBox.Show("Password did not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validating username (alphanumeric characters)
                if (!Regex.IsMatch(txtUsername.Text, @"^[a-zA-Z0-9]+$"))
                {
                    MessageBox.Show("Please enter a valid username (only alphanumeric characters)!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate if the text fields are not empty
                if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show("Please enter full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validating password (minimum 6 characters, at least one letter and one number)
                if (!Regex.IsMatch(txtPass.Text, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$"))
                {
                    MessageBox.Show("Please enter a valid password (minimum 6 characters, at least one letter and one number)!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validating phone number (digits only)
                if (!Regex.IsMatch(txtPhone.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("Please enter a valid phone number (only numbers)!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate if the text fields are not empty
                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show("Please enter address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validating account/role
                if (string.IsNullOrWhiteSpace(txtAccount.Text))
                {
                    MessageBox.Show("Please enter a valid account!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to update this user?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tblEmployee SET fullname = @fullname, password = @password, phone = @phone, address = @address, account = @account WHERE username LIKE '" + txtUsername.Text + "' ", con);
                    cm.Parameters.AddWithValue("@username", txtUsername.Text);
                    cm.Parameters.AddWithValue("@fullname", txtFullName.Text);
                    cm.Parameters.AddWithValue("@password", txtPass.Text);
                    cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@account", txtAccount.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been successfully updated!");
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
