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
    public partial class frmRemoveStuckBuffJob : Form
    {
        public frmRemoveStuckBuffJob()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            int doorID;

            if (int.TryParse(txtDoorID.Text, out doorID))
            {
                Door d = new Door(doorID);
                if (d.isValid() == true)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(ConnectionStrings.ConnectionString);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("usp_remove_stuck_buff_job", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@doorID", doorID);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Job removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception error)
                    {
                        MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    MessageBox.Show("This is not a valid door number", "Invalid Door Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a numerical Value", "Non numerical value used", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void frmRemoveStuckBuffJob_Load(object sender, EventArgs e)
        {

        }
    }
}
