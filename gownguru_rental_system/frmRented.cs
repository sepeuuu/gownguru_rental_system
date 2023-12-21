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
    public partial class frmRented : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QS67U0AV\SQLEXPRESS;Initial Catalog=DB_GRS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmRented()
        {
            InitializeComponent();
            LoadRented();
        }

        public void LoadRented()
        {
            int i = 0;
            dgvRented.Rows.Clear();
            cm = new SqlCommand("SELECT rentid, rentdate, returndate, R.gid, G.gname, R.cid, C.cname, qty, price, total, status " +
                                "FROM tblRent AS R " +
                                "JOIN tblCustomer AS C ON R.cid = C.cid " +
                                "JOIN tblGown AS G ON R.gid = G.gid ", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvRented.Rows.Add(i, dr[0].ToString(), Convert.ToDateTime(dr[1].ToString()).ToString("dd/MM/yyyy"), Convert.ToDateTime(dr[2].ToString()).ToString("dd/MM/yyyy"), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRented();
        }
    }
}
