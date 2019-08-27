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
    public partial class frmSqlAnywhere : Form
    {
        public frmSqlAnywhere()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string statement = txtStatement.Text;
            string statementType;

            statementType = statement.Substring(0, statement.IndexOf(" ")).ToUpper();

            


            if (statementType == "SELECT")
            {
               fillGrid();
            }
            else
            {
                executeUpdateDelete();
            }
            
            


        }
        private void executeUpdateDelete()
        {
            //NEEDS TO BE VARIABLE AT LATER TIME
            SqlConnection conn = new SqlConnection(ConnectionStrings.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(txtStatement.Text, conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
          
            conn.Close();
        }
        private void fillGrid()
        {
            //NEEDS TO BE VARIABLE AT LATER TIME
            SqlConnection conn = new SqlConnection(ConnectionStrings.ConnectionString);
            SqlCommand cmd = new SqlCommand(txtStatement.Text, conn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);


            try
            {

                DataTable dt = new DataTable();
                adap.Fill(dt);
                dgOutput.DataSource = dt;




            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            conn.Close();
        }

        private void presetStatementsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void slimlineSRItemsBoxSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtStatement.Text = "SELECT dbo.addition.addition_description as 'Addition Type', Sum(dbo.door_addition.addition_quantity) AS Count " +
                                "FROM dbo.door LEFT JOIN(dbo.addition RIGHT JOIN dbo.door_addition ON dbo.addition.id = dbo.door_addition.addition_id) ON dbo.door.id = dbo.door_addition.door_id " +
                                "WHERE(((dbo.door.date_completion)Between '01/01/2019' And '01/31/2019') AND((dbo.door_addition.addition_id) = 29 Or(dbo.door_addition.addition_id) = 30 Or(dbo.door_addition.addition_id) = 35) AND((dbo.door.status_id) = 1 Or(dbo.door.status_id) = 2 Or(dbo.door.status_id) = 3)) " +
                                "GROUP BY dbo.addition.addition_description;";
        }
    }
}
