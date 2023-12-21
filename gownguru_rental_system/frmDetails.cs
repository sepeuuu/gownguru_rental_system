using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gownguru_rental_system
{
    public partial class frmDetails : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QS67U0AV\SQLEXPRESS;Initial Catalog=DB_GRS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmDetails()
        {
            InitializeComponent();
        }

        public int id = 0;
        private void frmDetails_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                cm = new SqlCommand("SELECT * FROM tblGown WHERE gid = @ID", con);
                cm.Parameters.AddWithValue("@ID", id);

                con.Open();
                dr = cm.ExecuteReader();

                if (dr.Read())
                {
                    lblName.Text = dr["gname"].ToString();
                    lblPrice.Text = dr["gprice"].ToString();
                    lblDesc.Text = dr["gdescription"].ToString();
                    lblSize.Text = dr["gsize"].ToString();
                    lblColor.Text = dr["gcolor"].ToString();
                    lblCondition.Text = dr["gcondition"].ToString();
                    lblCategory.Text = dr["gcategory"].ToString();
                    lblStatus.Text = dr["gstatus"].ToString();

                    if (!dr.IsDBNull(dr.GetOrdinal("gpic")))
                    {
                        byte[] ImageArray = (byte[])dr["gpic"];
                        using (MemoryStream ms = new MemoryStream(ImageArray))
                        {
                            gpic.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        // Handle situation where the image field is NULL in the database
                        // For example, set a default image or display a placeholder
                        gpic.Image = null; // Set a default image or display a placeholder
                    }
                }
                dr.Close();
                con.Close();
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
