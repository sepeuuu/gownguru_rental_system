using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gownguru_rental_system
{
    public partial class frmGown : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QS67U0AV\SQLEXPRESS;Initial Catalog=DB_GRS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmGown()
        {
            InitializeComponent();
            LoadGown();
        }
        public void LoadGown()
        {
            int i = 0;
            dgvGown.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tblGown WHERE CONCAT(gid,gname,gstatus,gsize,gprice,gconditionbefore,gdescription,gcategory) LIKE '%" + txtSearch.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvGown.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void frmGown_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmGownAdd formModule = new frmGownAdd();
            formModule.btnSave.Enabled = true;
            formModule.btnUpdate.Enabled = false;
            formModule.ShowDialog();
            LoadGown();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadGown();
        }

        private void dgvGown_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvGown.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmGownAdd gownModule = new frmGownAdd();
                gownModule.lblGid.Text = dgvGown.Rows[e.RowIndex].Cells[1].Value.ToString();
                gownModule.txtName.Text = dgvGown.Rows[e.RowIndex].Cells[2].Value.ToString();
                gownModule.cbStatus.Text = dgvGown.Rows[e.RowIndex].Cells[3].Value.ToString();
                gownModule.cbSize.Text = dgvGown.Rows[e.RowIndex].Cells[4].Value.ToString();
                gownModule.txtRprice.Text = dgvGown.Rows[e.RowIndex].Cells[5].Value.ToString();
                gownModule.cbConditionBef.Text = dgvGown.Rows[e.RowIndex].Cells[6].Value.ToString();
                gownModule.txtDesc.Text = dgvGown.Rows[e.RowIndex].Cells[7].Value.ToString();
                gownModule.cbCategory.Text = dgvGown.Rows[e.RowIndex].Cells[8].Value.ToString();
                gownModule.txtPic.Text = dgvGown.Rows[e.RowIndex].Cells[9].Value.ToString();
                gownModule.btnSave.Enabled = false;
                gownModule.btnUpdate.Enabled = true;
                gownModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this gown?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tblGown WHERE gid LIKE '" + dgvGown.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }
            LoadGown();
        }
    }
}
