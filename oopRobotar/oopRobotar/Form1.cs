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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Robot.antalRobotar = 0;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Globals.samlar = int.Parse(numS.Text);
            Globals.bygger = int.Parse(numB.Text);
            Globals.klarAntal = int.Parse(numKA.Text);
            Globals.klar = false;
            frmTid ft = new frmTid();
            ft.Visible = true;
        }
    }
}