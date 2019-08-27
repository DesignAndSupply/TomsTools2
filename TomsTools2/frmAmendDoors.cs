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
        public frmAmendDoors()
        {
            InitializeComponent();
        }

        private void Rd_buff_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void Rd_weld_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void Rd_pack_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            //set sql here 
            string sql = "Select door_id, department,staff_id from dbo.door_allocation";
            if (rd_weld.Checked == true)
                MessageBox.Show("weld"); //change these to add sql code relevant to their operation
            if (rd_pack.Checked == true)
                MessageBox.Show("pack");//where operation = 'Packing'
            if (rd_buff.Checked == true)
                MessageBox.Show("buff");//will need to add a wipe later on
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
    }
}
