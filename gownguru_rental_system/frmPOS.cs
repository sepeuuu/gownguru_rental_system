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
    public partial class frmPOS : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QS67U0AV\SQLEXPRESS;Initial Catalog=DB_GRS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        private Panel panel;
        private PictureBox pic;
        private Label price;
        private Label name;
        private Button button;
        double _tot;
        public frmPOS()
        {
            InitializeComponent();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            flowLayoutPanel1.Controls.Clear();
            con.Open();
            cm = new SqlCommand("select gpic, gname, gprice, gid from tblGown where gname like '%" + txtSearch.Text + "%' order by gname", con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));

                panel = new Panel();
                panel.Width = 150;
                panel.Height = 250;
                panel.BackColor = Color.White;

                pic = new PictureBox();
                pic.Width = 150;
                pic.Height = 150;
                pic.BackgroundImageLayout = ImageLayout.Stretch;
                pic.BorderStyle = BorderStyle.FixedSingle;
                pic.Tag = dr["gid"].ToString();

                //pic.Dock = DockStyle.Top;

                name = new Label();
                name.Text = dr["gname"].ToString();
                //name.BackColor = Color.FromArgb(46, 134, 222);
                name.ForeColor = Color.Black;
                name.Font = new Font(name.Font.FontFamily, 12, FontStyle.Regular);
                name.TextAlign = ContentAlignment.MiddleCenter;
                name.Dock = DockStyle.Bottom;


                price = new Label();
                price.Text = dr["gprice"].ToString();
                price.Width = 50;
                //price.BackColor = Color.FromArgb(255, 121, 121);
                price.Font = new Font(name.Font.FontFamily, 15, FontStyle.Bold);
                price.TextAlign = ContentAlignment.MiddleCenter;
                price.Dock = DockStyle.Bottom;

                button = new Button();
                button.Width = 30;
                button.Height = 30;
                button.Text = "Details";
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.FromArgb(41, 128, 185);
                button.ForeColor = Color.White;
                button.Dock = DockStyle.Bottom;
                //button.BackgroundImageLayout = ImageLayout.Stretch;


                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pic.BackgroundImage = bitmap;

                panel.Controls.Add(pic);
                panel.Controls.Add(name);
                panel.Controls.Add(price);
                panel.Controls.Add(button);
                flowLayoutPanel1.Controls.Add(panel);
                panel.Cursor = Cursors.Hand;

                //pagcclick na yung pic may magpapopup na message box, basta macclick na yung details dito
                button.Click += new EventHandler(OnClick);

            }
            dr.Close();
            con.Close();
        }
        public void OnClick(object sender, EventArgs e)
        {
            String tag = ((PictureBox)sender).Tag.ToString();
            con.Open();
            cm = new SqlCommand("select * from tblGown where gid like '" + tag + "'", con);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                _tot += double.Parse(dr["gprice"].ToString());                //di nakavisible sa pag add ng ID column ah
                dgvGown.Rows.Add(dgvGown.Rows.Count + 1, dr["gid"].ToString(), dr["gname"].ToString(), double.Parse(dr["gprice"].ToString()).ToString("#,##0.00"));
            }
            dr.Close();
            con.Close();
            lblTotal.Text = _tot.ToString("#,##0.00");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
