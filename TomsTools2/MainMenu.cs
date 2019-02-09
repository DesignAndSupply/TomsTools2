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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnStockPriceIncrease_Click(object sender, EventArgs e)
        {
            frmStockPriceUpdate frmSPU = new frmStockPriceUpdate();
            frmSPU.Show();
        }

        private void btnCompletePunch_Click(object sender, EventArgs e)
        {
            frmCorrectStuckPunchJob frmCSPJ = new frmCorrectStuckPunchJob();
            frmCSPJ.Show();

        }
    }
}
