using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniProject_Vaccine
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            frmAppointment dlg = new frmAppointment();
            dlg.ShowDialog();
        }
    }
}
