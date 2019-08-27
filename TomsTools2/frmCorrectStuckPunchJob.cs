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
           


            int doorID;

            if (int.TryParse(txtDoorID.Text,out doorID))
            {
                Door d = new Door(doorID);
                if (d.isValid())
                {
                    try
                    {
                        if (d.isPunched() == true)
                        {
                            MessageBox.Show("This door has already been punched so cannot be updated again.", "Already punched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            d.updatePunch();
                            MessageBox.Show("Door Number Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter a valid door number.", "Invalid door number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Please enter a numerical value!", "Non Numerical Value Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           

        }
    }
}
