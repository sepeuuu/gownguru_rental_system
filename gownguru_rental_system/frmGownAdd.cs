using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
//using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gownguru_rental_system
{
    public partial class frmGownAdd : Form
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
            openFileDialog1.Filter = "Image files (*.png) |*.png|(*.jpg)|*.jpg|(*.gif)|*.gif";
            openFileDialog1.ShowDialog();
            txtPic.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this gown??", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tblGown(gname,gdescription,gsize,gcolor,gcondition,gprice,gdateadded,gcategory,gstatus,gpic)VALUES(@gname,@gdescription,@gsize,@gcolor,@gcondition,@gprice,@gdateadded,@gcategory,@gstatus,@gpic)", con);
                    cm.Parameters.AddWithValue("@gname", txtName.Text);
                    cm.Parameters.AddWithValue("@gdescription", txtDesc.Text);
                    cm.Parameters.AddWithValue("@gsize", cbSize.Text);
                    cm.Parameters.AddWithValue("@gcolor", txtColor.Text);
                    cm.Parameters.AddWithValue("@gcondition", cbCondition.Text);
                    cm.Parameters.AddWithValue("@gprice", double.Parse(txtRprice.Text));
                    cm.Parameters.AddWithValue("@gdateAdded", dtDateAdded.Value.ToString("yyyy-MM-dd"));
                    cm.Parameters.AddWithValue("@gcategory", cbCategory.Text);
                    cm.Parameters.AddWithValue("@gstatus", cbStatus.Text);

                    MemoryStream ms = new MemoryStream();
                    txtPic.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] arrImage = ms.GetBuffer();
                    cm.Parameters.AddWithValue("@gpic", arrImage);

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
            txtDesc.Clear();
            txtColor.Clear();
            cbStatus.Text = "";
            cbSize.Text = "";
            txtRprice.Clear();
            dtDateAdded.Text = "";
            cbCondition.Text = "";
            txtDesc.Clear();
            cbCategory.Text = "";
            txtPic.Text = "";
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this gown?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MemoryStream ms = new MemoryStream();
                    txtPic.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] arrImage = ms.GetBuffer();

                    cm = new SqlCommand("UPDATE tblGown SET gname = @gname, gdescription = @gdescription, gsize = @gsize, gcolor = @gcolor, gcondition = @gcondition, gprice = @gprice, gdateadded = @gdateadded, gcategory = @gcategory, gstatus = @gstatus, gpic = @gpic WHERE gid LIKE '" + lblGid.Text + "' ", con);
                    cm.Parameters.AddWithValue("@gname", txtName.Text);
                    cm.Parameters.AddWithValue("@gdescription", txtDesc.Text);
                    cm.Parameters.AddWithValue("@gsize", cbSize.Text);
                    cm.Parameters.AddWithValue("@gcolor", txtColor.Text);
                    cm.Parameters.AddWithValue("@gcondition", cbCondition.Text);
                    cm.Parameters.AddWithValue("@gprice", double.Parse(txtRprice.Text));
                    cm.Parameters.AddWithValue("@gdateAdded", dtDateAdded.Value.ToString("yyyy-MM-dd"));
                    cm.Parameters.AddWithValue("@gcategory", cbCategory.Text);
                    cm.Parameters.AddWithValue("@gstatus", cbStatus.Text);
                    cm.Parameters.AddWithValue("@gpic", arrImage);

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
        
    

        private void LoadGownDetails(string gownID)
        {
            try
            {
                con.Open();

                // Prepare SQL command to select gown details
                cm = new SqlCommand("SELECT * FROM tblGown WHERE gid = @gid", con);
                cm.Parameters.AddWithValue("@gid", gownID);

                SqlDataReader dr = cm.ExecuteReader();

                if (dr.Read())
                {
                    // Update UI fields with gown details from the database
                    txtName.Text = dr["gname"].ToString();
                    txtDesc.Text = dr["gdescription"].ToString();
                    cbSize.Text = dr["gsize"].ToString();
                    txtColor.Text = dr["gcolor"].ToString();
                    cbCondition.Text = dr["gcondition"].ToString();
                    txtRprice.Text = dr["gprice"].ToString();
                    dtDateAdded.Value = Convert.ToDateTime(dr["gdateadded"]);
                    cbCategory.Text = dr["gcategory"].ToString();
                    cbStatus.Text = dr["gstatus"].ToString();

                    // Update the picture box with the gown image
                    if (!(dr["gpic"] is DBNull))
                    {
                        byte[] imageData = (byte[])dr["gpic"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            txtPic.BackgroundImage = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        // If no image is present, you may set a default image or leave it blank
                        txtPic.BackgroundImage = null;
                    }
                }

                dr.Close();
                con.Close();
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

        private bool isImageChanged = false;

        private void txtPic_Click(object sender, EventArgs e)
        {
            isImageChanged = true;
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
