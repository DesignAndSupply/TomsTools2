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



namespace TomsTools2
{
    public partial class MainMenu : Form
    {
        public int _permissionLevel { get; set; }


        public MainMenu(int pl)
        {
            InitializeComponent();
            _permissionLevel = pl;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnStockPriceIncrease_Click(object sender, EventArgs e)
        {
            if (_permissionLevel == 1 || _permissionLevel == 2)
            {
                frmStockPriceUpdate frmSPU = new frmStockPriceUpdate();
                frmSPU.Show();
            }
            else
            {
                MessageBox.Show("Insufficient permissions", "Nope!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCompletePunch_Click(object sender, EventArgs e)
        {

            if (_permissionLevel == 1 || _permissionLevel == 2 || _permissionLevel == 3 || _permissionLevel ==4)
            {
                frmCorrectStuckPunchJob frmCSPJ = new frmCorrectStuckPunchJob();
                frmCSPJ.Show();
            }
            else
            {
                MessageBox.Show("Insufficient permissions", "Nope!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_permissionLevel == 1 || _permissionLevel == 2 || _permissionLevel == 3 || _permissionLevel == 7)
            {
                frmRemoveStuckBuffJob frmRSBJ = new frmRemoveStuckBuffJob();
                frmRSBJ.Show();
            }
            else
            {
                MessageBox.Show("Insufficient permissions", "Nope!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCameraUpload_Click(object sender, EventArgs e)
        {
            if (_permissionLevel == 1 || _permissionLevel == 2 || _permissionLevel == 3 || _permissionLevel == 10)
            {
                frmCameraUpload frmCU = new frmCameraUpload();
                frmCU.Show();
            }
            else
            {
                MessageBox.Show("Insufficient permissions", "Nope!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnImportStockToDoor_Click(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_permissionLevel == 1)
            {
                frmSqlAnywhere frmsa = new frmSqlAnywhere();
                frmsa.Show();
            }
            else
            {
                MessageBox.Show("Insufficient permissions", "Nope!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_amend_list_Click(object sender, EventArgs e)
        {
            if (_permissionLevel == 1 || _permissionLevel == 2 || _permissionLevel == 3 || _permissionLevel == 4 || _permissionLevel == 7 || _permissionLevel == 10)
            {
                frmAmendDoors frmAD = new frmAmendDoors();
                frmAD.Show();
            }
            else
            {
                MessageBox.Show("Insufficient permissions", "Nope!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
