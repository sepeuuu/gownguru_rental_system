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
using System.IO;

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
            cm = new SqlCommand("SELECT * FROM tblGown WHERE CONCAT(gid,gname,gdescription,gsize,gcolor,gcondition,gprice,gdateadded,gcategory,gstatus) LIKE '%" + txtSearch.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvGown.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
                
            }
            dr.Close();
            con.Close();
        }
        private void frmGown_Load(object sender, EventArgs e)
        {
            LoadGown();
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
                frmGownAdd gownAdd = new frmGownAdd();
                gownAdd.lblGid.Text = dgvGown.Rows[e.RowIndex].Cells[1].Value.ToString();
                gownAdd.txtName.Text = dgvGown.Rows[e.RowIndex].Cells[2].Value.ToString();
                gownAdd.txtDesc.Text = dgvGown.Rows[e.RowIndex].Cells[3].Value.ToString();
                gownAdd.cbSize.Text = dgvGown.Rows[e.RowIndex].Cells[4].Value.ToString();
                gownAdd.txtColor.Text = dgvGown.Rows[e.RowIndex].Cells[5].Value.ToString();
                gownAdd.cbCondition.Text = dgvGown.Rows[e.RowIndex].Cells[6].Value.ToString();
                gownAdd.txtRprice.Text = dgvGown.Rows[e.RowIndex].Cells[7].Value.ToString();
                gownAdd.dtDateAdded.Text = dgvGown.Rows[e.RowIndex].Cells[8].Value.ToString();
                gownAdd.cbCategory.Text = dgvGown.Rows[e.RowIndex].Cells[9].Value.ToString();
                gownAdd.cbStatus.Text = dgvGown.Rows[e.RowIndex].Cells[10].Value.ToString();
                gownAdd.txtPic.Text = dgvGown.Rows[e.RowIndex].Cells[11].Value.ToString();
                gownAdd.btnSave.Enabled = false;
                gownAdd.btnUpdate.Enabled = true;
                gownAdd.ShowDialog();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
