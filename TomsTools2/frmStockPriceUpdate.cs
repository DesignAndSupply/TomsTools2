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
using TomsTools2.ClassLibs;

namespace TomsTools2
{
    public partial class frmStockPriceUpdate : Form
    {
        public frmStockPriceUpdate()
        {
            InitializeComponent();
        }

        private void frmStockPriceUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'order_databaseDataSet.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.order_databaseDataSet.supplier);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtPercentage.Text) || string.IsNullOrWhiteSpace(cmbSupplier.Text))
            {
                MessageBox.Show("Percentage and Supplier are mandatory fields.", "Missing information",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                //try
                //{
                    SqlConnection conn = new SqlConnection(ConnectionStrings.ConnectionString);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_update_stock_by_percentage", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    int supplierID;
                    string keywords;
                    double percentage;
                    int mode;

                    supplierID = Convert.ToInt32(cmbSupplier.SelectedValue);
                    keywords = txtKeyword.Text;
                    percentage = Convert.ToDouble(txtPercentage.Text);
                    

                    if (rdoIncrease.Checked == true)
                    {
                        mode = 1;
                    }
                    else
                    {
                        mode = 2;
                    }

                    cmd.Parameters.AddWithValue("@supplierID", SqlDbType.Int).Value = supplierID;
                    cmd.Parameters.AddWithValue("@keyWords", SqlDbType.NVarChar).Value = keywords;
                    cmd.Parameters.AddWithValue("@percentageIncrease", SqlDbType.Float).Value = percentage;
                    cmd.Parameters.AddWithValue("@mode", SqlDbType.Int).Value = mode;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Update Completed Successfully", "Update complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //}
                //catch(Exception error)
                //{
                    //MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                

            }




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
