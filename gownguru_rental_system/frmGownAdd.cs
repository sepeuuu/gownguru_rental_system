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
    public partial class frmGownAdd : Sample
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QS67U0AV\SQLEXPRESS;Initial Catalog=DB_GRS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmGownAdd()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            cbCategory.Items.Clear();
            cm = new SqlCommand("SELECT catname FROM tblCategory", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cbCategory.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                txtPic.Image = new Bitmap(filePath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this gown??", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tblGown(gname,gstatus,gsize,gprice,gconditionbefore,gdescription,gcategory)VALUES(@gname,@gstatus,@gsize,@gprice,@gconditionbefore,@gdescription,@gcategory)", con);
                    cm.Parameters.AddWithValue("@gname", txtName.Text);
                    cm.Parameters.AddWithValue("@gstatus", cbStatus.Text);
                    cm.Parameters.AddWithValue("@gsize", cbSize.Text);
                    cm.Parameters.AddWithValue("@gprice", Convert.ToInt16(txtRprice.Text));
                    cm.Parameters.AddWithValue("@gconditionbefore", cbConditionBef.Text);
                    cm.Parameters.AddWithValue("@gdescription", txtDesc.Text);
                    cm.Parameters.AddWithValue("@gcategory", cbCategory.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Gown has been successfully saved!");
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
            txtName.Clear();
            cbStatus.Text = "";
            cbSize.Text = "";
            txtRprice.Clear();
            cbConditionBef.Text = "";
            txtDesc.Clear();
            cbCategory.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this gown?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tblGown SET gname = @gname, gstatus = @gstatus, gsize = @gsize, gprice = @gprice, gconditionbefore = @gconditionbefore, gdescription = @gdescription, gcategory = @gcategory WHERE gid LIKE '" + lblGid.Text + "' ", con);
                    cm.Parameters.AddWithValue("@gname", txtName.Text);
                    cm.Parameters.AddWithValue("@gstatus", cbStatus.Text);
                    cm.Parameters.AddWithValue("@gsize", cbSize.Text);
                    cm.Parameters.AddWithValue("@gprice", Convert.ToInt16(txtRprice.Text));
                    cm.Parameters.AddWithValue("@gconditionbefore", cbConditionBef.Text);
                    cm.Parameters.AddWithValue("@gdescription", txtDesc.Text);
                    cm.Parameters.AddWithValue("@gcategory", cbCategory.Text);
                    
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Gown has been successfully updated!");
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

        private void frmGownAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
