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
        //SqlDataReader dr;
        public frmAdminDashboard()
        {
            InitializeComponent();
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

                // Get count of returned gowns
                cm = new SqlCommand("SELECT COUNT(*) FROM tblGown WHERE gstatus = 'returned'", con);
                int returnedcount = (int)cm.ExecuteScalar();
                lblReturned.Text = returnedcount.ToString();

                // Get count of damaged or lost gowns
                cm = new SqlCommand("SELECT COUNT(*) FROM tblGown WHERE gstatus IN ('damaged', 'lost')", con);
                int damlostcount = (int)cm.ExecuteScalar();
                lblDamLost.Text = damlostcount.ToString();

                // Get count of gowns in possession
                cm = new SqlCommand("SELECT COUNT(*) FROM tblGown WHERE gstatus = 'in-possession'", con);
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
    }
}
