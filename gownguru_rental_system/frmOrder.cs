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
    public partial class frmOrder : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QS67U0AV\SQLEXPRESS;Initial Catalog=DB_GRS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        private PictureBox pic;

        public frmOrder()
        {
            InitializeComponent();
        }

        private void getData()
        {
            con.Open();
            cm = new SqlCommand("SELECT gpic, gprice FROM tblGown", con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[len + 1];
                dr.GetBytes(0, 0, array, 0, 0);
                pic = new PictureBox();
                pic.Width = 100;
                pic.Height = 100;
                pic.BackgroundImageLayout = ImageLayout.Stretch;

                flowLayoutPanel2.Controls.Add(pic);

            }
            dr.Close();
            con.Close();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
