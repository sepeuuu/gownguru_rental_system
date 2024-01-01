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
    public partial class frmAdminDashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QS67U0AV\SQLEXPRESS;Initial Catalog=DB_GRS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmAdminDashboard()
        {
            InitializeComponent();
            LoadRented();
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                // Get count of customers
                cm = new SqlCommand("SELECT COUNT(*) FROM tblCustomer", con);
                int clientcount = (int)cm.ExecuteScalar();
                lblClients.Text = clientcount.ToString();

                // Get count of gowns
                cm = new SqlCommand("SELECT COUNT(*) FROM tblGown", con);
                int gowncount = (int)cm.ExecuteScalar();
                lblGown.Text = gowncount.ToString();

                // Get count of available gowns
                cm = new SqlCommand("SELECT COUNT(*) FROM tblGown WHERE gstatus = 'available'", con);
                int availableGownCount = (int)cm.ExecuteScalar();
                lblGAvailable.Text = availableGownCount.ToString();

                // Get count of rented gowns
                cm = new SqlCommand("SELECT COUNT(*) FROM tblRent", con);
                int rentedcount = (int)cm.ExecuteScalar();
                lblRented.Text = rentedcount.ToString();

                // Get count of returned gowns excluding 'lost' status
                cm = new SqlCommand("SELECT COUNT(*) FROM tblReturn WHERE status != 'lost'", con);
                int nonLostReturnedCount = (int)cm.ExecuteScalar();
                lblReturned.Text = nonLostReturnedCount.ToString();

                // Get count of returned gowns
                /*cm = new SqlCommand("SELECT COUNT(*) FROM tblGown WHERE gstatus = 'returned'", con);
                int returnedcount = (int)cm.ExecuteScalar();
                lblReturned.Text = returnedcount.ToString();*/

                // Get count of damaged or lost gowns
                cm = new SqlCommand("SELECT COUNT(*) FROM tblGown WHERE gstatus IN ('damaged', 'lost')", con);
                int damlostcount = (int)cm.ExecuteScalar();
                lblDamLost.Text = damlostcount.ToString();

                // Get count of gowns in possession
                cm = new SqlCommand("SELECT COUNT(*) FROM tblRent WHERE status = 'in-possession'", con);
                int inpossessioncount = (int)cm.ExecuteScalar();
                lblInPossession.Text = inpossessioncount.ToString();

                // Get total revenue from tblReturn
                cm = new SqlCommand("SELECT SUM(total) FROM tblReturn", con);
                object totalSum = cm.ExecuteScalar();

                if (totalSum != null && totalSum != DBNull.Value)
                {
                    decimal revenue = Convert.ToDecimal(totalSum);
                    lblRevenue.Text = revenue.ToString();
                }
                else
                {
                    lblRevenue.Text = "0"; // If there are no records or sum is null
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadRented()
        {
            int i = 0;
            dgvRented.Rows.Clear();
            DateTime today = DateTime.Today;

            cm = new SqlCommand("SELECT rentid, rentdate, returndate, R.gid, G.gname, R.cid, C.cname, qty, price, total, status " +
                                "FROM tblRent AS R " +
                                "JOIN tblCustomer AS C ON R.cid = C.cid " +
                                "JOIN tblGown AS G ON R.gid = G.gid " +
                                "WHERE CONVERT(date, rentdate) = '" + today.ToString("yyyy-MM-dd") + "' " +
                                "AND CONCAT(G.gname, R.cid, C.cname) LIKE '%" + txtSearch.Text + "%'", con);
            
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvRented.Rows.Add(i, dr[0].ToString(), Convert.ToDateTime(dr[1].ToString()).ToString("dd/MM/yyyy"), Convert.ToDateTime(dr[2].ToString()).ToString("dd/MM/yyyy"),
                    dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString());
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
