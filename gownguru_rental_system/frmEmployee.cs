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
    public partial class frmEmployee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QS67U0AV\SQLEXPRESS;Initial Catalog=DB_GRS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmEmployee()
        {
            InitializeComponent();
            LoadEmployee();
        }

        public void LoadEmployee()
        {
            int i = 0;
            dgvEmployee.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tblEmployee", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvEmployee.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEmployeeAdd userModule = new frmEmployeeAdd();
            userModule.btnSave.Enabled = true;
            userModule.btnUpdate.Enabled = false;
            userModule.ShowDialog();
            LoadEmployee();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvEmployee.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmEmployeeAdd userModule = new frmEmployeeAdd();
                userModule.txtUsername.Text = dgvEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.txtFullName.Text = dgvEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.txtPass.Text = dgvEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.txtPhone.Text = dgvEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
                userModule.txtAddress.Text = dgvEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();
                userModule.txtAccount.Text = dgvEmployee.Rows[e.RowIndex].Cells[6].Value.ToString();

                userModule.btnSave.Enabled = false;
                userModule.btnUpdate.Enabled = true;
                userModule.txtUsername.Enabled = false;
                userModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this user?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tblEmployee WHERE username LIKE '" + dgvEmployee.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }
            LoadEmployee();
        }
    }
}
