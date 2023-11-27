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
    public partial class frmScheduler : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QS67U0AV\SQLEXPRESS;Initial Catalog=DB_GRS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        double _tot;
        private PictureBox pic;
        private Label prc;
        private Label description;
        private Button button;

        public frmScheduler()
        {
            InitializeComponent();
        }

        private void frmScheduler_Load(object sender, EventArgs e)
        {
           GetData();
            //hide id column
            //DataGridView.Columns[1].Visible = false;
        }

        private void GetData()
        {
            con.Open();
            cm = new SqlCommand("SELECT * FROM tblGown WHERE CONCAT(gpic, category, gdescription, gprice", con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                pic = new PictureBox();
                pic.Width = 150;
                pic.Height = 150;
                pic.BackgroundImageLayout = ImageLayout.Stretch;
                pic.BorderStyle = BorderStyle.FixedSingle;
                pic.Tag = dr["id"].ToString();

                prc = new Label();
                prc.Text = dr["gprice"].ToString();
                prc.Width = 50;
                prc.BackColor = Color.FromArgb(255, 121, 121);
                prc.TextAlign = ContentAlignment.MiddleCenter;

                description = new Label();
                description.Text = dr["gdescription"].ToString();
                description.BackColor = Color.FromArgb(46, 134, 222);
                description.TextAlign = ContentAlignment.MiddleCenter;
                description.Dock = DockStyle.Bottom;

                button = new Button();
                button.Width = 250;
                button.Height = 50;
                //butoo



                /*MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pic.BackgroundImage = bitmap;*/

                flowLayoutPanel1.Controls.Add(pic);
            }
            dr.Close();
            con.Close();
        }
    }
}
