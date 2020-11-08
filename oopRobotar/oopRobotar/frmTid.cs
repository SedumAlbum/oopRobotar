using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopRobotar
{
    public partial class frmTid : Form
    {
        MaskinPark m;
        int passerat = 0;
        public frmTid()
        {
            InitializeComponent();            
            m = new MaskinPark();
            m.add(new Robot());
        }

        private void btnTid_Click(object sender, EventArgs e)
        {
            if(!Globals.klar)
            {
                passerat++;
                m.tick();
                lblTid.Text += "\nMånad " + passerat + " " + m.dennaManad();
            }
            else
                lblTid.Text += "\nDet tog alltså " + passerat + " månader.";
        }
    }
}
