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
    public partial class frmAmendDoors : Form
    {
        public int firstTimeSearching { get; set; }
        public frmAmendDoors()
        {
            InitializeComponent();
        }

        private void Rd_buff_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
            txt_filter.Text = "";
        }

        private void Rd_weld_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
            txt_filter.Text = "";
        }

        private void Rd_pack_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
            txt_filter.Text = "";
        }

        private void loadData()
        {
            //set sql here 
            string sql = "SELECT a.door_id, department,staff_id, operation_date FROM dbo.door_allocation a " +
                "LEFT JOIN dbo.door b ON a.door_id = b.id ";
            if (rd_weld.Checked == true)
                sql = sql + "WHERE department = 'Welding' AND complete_weld = 0"; //change these to add sql code relevant to their operation
            if (rd_pack.Checked == true)
                sql = sql + "WHERE department = 'Packing' AND complete_pack = 0";//where operation = 'Packing'
            if (rd_buff.Checked == true)
                sql = sql + "WHERE department = 'Buffing' AND complete_buff = 0";//will need to add a wipe later on
            sql = sql + " ORDER BY a.door_id DESC";
            using (SqlConnection conn = new SqlConnection(ConnectionStrings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
        }

        private void filterDGV()
        {
            //prevents error when hiding rows out of view (apparently)
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridView1.DataSource];
            currencyManager.SuspendBinding();
            firstTimeSearching = 1;

            //start hiding the rows
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Visible = true;
            //if textbox is empty stop here
            if (txt_filter.TextLength == 0)
                return;
            //else hide rows based on what is entered
            else
            {
                string row_text = "";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    row_text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    if (row_text.Contains(txt_filter.Text))
                        dataGridView1.Rows[i].Visible = true;
                    else
                        dataGridView1.Rows[i].Visible = false;
                }
            }
            currencyManager.ResumeBinding();


        }

        private void Txt_filter_TextChanged(object sender, EventArgs e)
        {
            filterDGV();
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex);
            if (dataGridView1.Rows[row].DefaultCellStyle.BackColor == Color.CornflowerBlue)
                dataGridView1.Rows[row].DefaultCellStyle.BackColor = Color.Empty;
            else
                dataGridView1.Rows[row].DefaultCellStyle.BackColor = Color.CornflowerBlue;
        }

        private void Txt_filter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Btn_updateDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionStrings.ConnectionString))
            {
                conn.Open();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string sqlUPDATE = "UPDATE dbo.door "; //update door
                    string sqlDELETE = "DELETE FROM dbo.door_allocation "; //delete from allocation
                    if (dataGridView1.Rows[i].DefaultCellStyle.BackColor == Color.CornflowerBlue)
                    {
                        //if for each department
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "Welding")
                        {
                            sqlDELETE = sqlDELETE + "WHERE door_id = " + dataGridView1.Rows[i].Cells[0].Value.ToString() + " AND department = '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "'";
                            sqlUPDATE = sqlUPDATE + "SET weld_staff_allocation = NULL WHERE id = " + dataGridView1.Rows[i].Cells[0].Value.ToString();
                            using (SqlCommand cmd = new SqlCommand(sqlDELETE, conn))
                            {
                                //cmd.ExecuteNonQuery();
                            }
                            using (SqlCommand cmd = new SqlCommand(sqlUPDATE, conn))
                            {
                                //cmd.ExecuteNonQuery();
                            }
                        }
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "Buffing")
                        {
                            sqlDELETE = sqlDELETE + "WHERE door_id = " + dataGridView1.Rows[i].Cells[0].Value.ToString() + " AND department = '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "'";
                            sqlUPDATE = sqlUPDATE + "SET buff_staff_allocation = NULL WHERE id = " + dataGridView1.Rows[i].Cells[0].Value.ToString();
                            using (SqlCommand cmd = new SqlCommand(sqlDELETE, conn))
                            {
                                //cmd.ExecuteNonQuery();
                            }
                            using (SqlCommand cmd = new SqlCommand(sqlUPDATE, conn))
                            {
                                //cmd.ExecuteNonQuery();
                            }
                        }
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "Packing")
                        {
                            sqlDELETE = sqlDELETE + "WHERE door_id = " + dataGridView1.Rows[i].Cells[0].Value.ToString() + " AND department = '" + dataGridView1.Rows[i].Cells[1].Value.ToString() +"'";
                            sqlUPDATE = sqlUPDATE + "SET pack_staff_allocation = NULL WHERE id = " + dataGridView1.Rows[i].Cells[0].Value.ToString();
                            using (SqlCommand cmd = new SqlCommand(sqlDELETE, conn))
                            {
                                //cmd.ExecuteNonQuery();
                            }
                            using (SqlCommand cmd = new SqlCommand(sqlUPDATE, conn))
                            {
                                //cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    MessageBox.Show(sqlUPDATE + "---------" + sqlDELETE);
                }
                conn.Close();
            }
        }
    }
}
