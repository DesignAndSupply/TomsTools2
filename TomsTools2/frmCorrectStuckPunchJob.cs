using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomsTools2.ClassLibs;

namespace TomsTools2
{
    public partial class frmCorrectStuckPunchJob : Form
    {
        public frmCorrectStuckPunchJob()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Door d = new Door(int.Parse(txtDoorID.Text));
            d.updatePunch();

        }
    }
}
