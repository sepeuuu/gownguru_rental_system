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
    public partial class frmReturnAdd : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QS67U0AV\SQLEXPRESS;Initial Catalog=DB_GRS;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public frmReturnAdd()
        {
            InitializeComponent();
            LoadRented();
        }

        public void LoadRented()
        {
            int i = 0;
            dgvGownOnRent.Rows.Clear();
            cm = new SqlCommand("SELECT rentid, rentdate, returndate, R.gid, G.gname, R.cid, C.cname, qty, price, total " +
                                "FROM tblRent AS R JOIN tblCustomer AS C ON R.cid = C.cid " +
                                "JOIN tblGown AS G ON R.gid = G.gid " +
                                "WHERE CONCAT(rentid, rentdate, returndate, R.gid, G.gname, R.cid, C.cname, qty, price, total) LIKE '%" + txtSearchRented.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvGownOnRent.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmReturnAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateFine();
        }

        private void CalculateFine()
        {
            DateTime d1 = dtReturndate.Value.Date;
            DateTime d2 = DateTime.Now;
            TimeSpan t = d2 - d1;
            int NrOfDays = Convert.ToInt32(t.TotalDays);

            if (NrOfDays <= 0)
            {
                txtDelay.Text = "0";
                txtFine.Text = "0"; // Set fine to 0 if there's no delay
            }
            else
            {
                txtDelay.Text = NrOfDays.ToString();
                int fineForDelay = NrOfDays * 250; // Fine for delay

                // Perform a null check before accessing SelectedItem
                if (cbStatus.SelectedItem != null)
                {
                    string selectedStatus = cbStatus.SelectedItem.ToString();

                    if (selectedStatus.Equals("Lost", StringComparison.OrdinalIgnoreCase))
                    {
                        txtFine.Text = (fineForDelay + 500).ToString(); // Fine for lost item along with delay
                    }
                    else if (selectedStatus.Equals("Damaged", StringComparison.OrdinalIgnoreCase))
                    {
                        txtFine.Text = (fineForDelay + 300).ToString(); // Fine for damaged item along with delay
                    }
                    else
                    {
                        txtFine.Text = fineForDelay.ToString(); // Only fine for delay
                    }
                }
                else
                {
                    txtFine.Text = fineForDelay.ToString(); // Only fine for delay if status is not selected
                }
            }
            CalculateOverallTotal();
        }

        private void CalculateOverallTotal()
        {
            if (double.TryParse(txtTotal.Text, out double total) && double.TryParse(txtFine.Text, out double fine))
            {
                if (txtDelay.Text == "0")
                {
                    if (cbStatus.SelectedItem != null)
                    {
                        string selectedStatus = cbStatus.SelectedItem.ToString();

                        if (selectedStatus.Equals("Lost", StringComparison.OrdinalIgnoreCase))
                        {
                            fine = 500; // Set fine to 500 for Lost item without delay
                            txtFine.Text = fine.ToString();
                        }
                        else if (selectedStatus.Equals("Damaged", StringComparison.OrdinalIgnoreCase))
                        {
                            fine = 300; // Set fine to 300 for Damaged item without delay
                            txtFine.Text = fine.ToString();
                        }
                    }
                }
                double overallTotal = total + fine;
                // Display the overall total in a TextBox or wherever you wish to show it
                txtOverallTotal.Text = overallTotal.ToString();
            }
            else
            {
                // Handle parsing errors or indicate the issue
                txtOverallTotal.Text = "Error calculating overall total";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtRentId.Clear();
            txtGownId.Clear();
            txtCId.Clear();
            txtCustname.Clear();
            dtReturndate.Value = DateTime.Now;
            dtRentdate.Value = DateTime.Now;
            txtDelay.Clear();
            txtFine.Clear();
            txtTotal.Clear();
            txtOverallTotal.Clear();
            cbConditionAft.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
        }

        private void dgvGownOnRent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRentId.Text = dgvGownOnRent.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtGownId.Text = dgvGownOnRent.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCId.Text = dgvGownOnRent.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCustname.Text = dgvGownOnRent.Rows[e.RowIndex].Cells[7].Value.ToString();
            dtReturndate.Text = dgvGownOnRent.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtRentdate.Text = dgvGownOnRent.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTotal.Text = dgvGownOnRent.Rows[e.RowIndex].Cells[10].Value.ToString();
            CalculateFine();
            CalculateOverallTotal();
        }

        private void txtSearchRented_TextChanged(object sender, EventArgs e)
        {
            LoadRented();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRentId.Text == "")
                {
                    MessageBox.Show("Please select rented gown!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate condition after return
                if (string.IsNullOrWhiteSpace(cbConditionAft.Text))
                {
                    MessageBox.Show("Please select the condition after renting!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate status
                if (string.IsNullOrWhiteSpace(cbStatus.Text))
                {
                    MessageBox.Show("Please select the status!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to return this gown?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tblReturn(rentid,gid,cid,rentdate,returndate,conditionafter,delay,status,fine,total)VALUES(@rentid,@gid,@cid,@rentdate,@returndate,@conditionafter,@delay,@status,@fine,@total)", con);
                    cm.Parameters.AddWithValue("@rentid", Convert.ToInt16(txtRentId.Text));
                    cm.Parameters.AddWithValue("@gid", Convert.ToInt16(txtGownId.Text));
                    cm.Parameters.AddWithValue("@cid", Convert.ToInt16(txtCId.Text));
                    cm.Parameters.AddWithValue("@rentdate", dtRentdate.Value);
                    cm.Parameters.AddWithValue("@returndate", dtReturndate.Value);
                    cm.Parameters.AddWithValue("@conditionafter", cbConditionAft.Text);
                    cm.Parameters.AddWithValue("@delay", Convert.ToInt16(txtDelay.Text));
                    cm.Parameters.AddWithValue("@status", cbStatus.Text);
                    cm.Parameters.AddWithValue("@fine", Convert.ToDouble(txtFine.Text));
                    cm.Parameters.AddWithValue("@total", Convert.ToDouble(txtOverallTotal.Text));
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Gown has been successfully returned!");

                    cm = new SqlCommand("UPDATE tblGown SET gstatus = @gstatus WHERE gid LIKE '" + txtGownId.Text + "' ", con);
                    cm.Parameters.AddWithValue("@gstatus", cbStatus.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    
                    // here yyung dinagdag koooo
                    cm = new SqlCommand("UPDATE tblGown SET gcondition = @gcondition WHERE gid LIKE '" + txtGownId.Text + "' ", con);
                    cm.Parameters.AddWithValue("@gcondition", cbConditionAft.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();

                    cm = new SqlCommand("DELETE FROM tblRent WHERE rentid = @rentid", con);
                    cm.Parameters.AddWithValue("@rentid", txtRentId.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    Clear();
                    LoadRented();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
