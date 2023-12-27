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
    public partial class frmReturned : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QS67U0AV\SQLEXPRESS;Initial Catalog=DB_GRS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmReturned()
        {
            InitializeComponent();
            LoadReturned();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmReturnAdd formModule = new frmReturnAdd();
            formModule.ShowDialog();
        }

        public void LoadReturned()
        {
            int i = 0;
            dgvReturned.Rows.Clear();
            cm = new SqlCommand("SELECT returnid, R.rentid, R.rentdate, R.returndate, R.gid, G.gname, R.cid, C.cname, conditionafter, delay, status, fine, total " +
                                "FROM tblReturn AS R " +
                                "JOIN tblCustomer AS C ON R.cid = C.cid " +
                                "JOIN tblGown AS G ON R.gid = G.gid", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvReturned.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), Convert.ToDateTime(dr[2].ToString()).ToString("dd/MM/yyyy"), Convert.ToDateTime(dr[3].ToString()).ToString("dd/MM/yyyy"), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString());
            }
            dr.Close();
            con.Close();
        }


    }
}
