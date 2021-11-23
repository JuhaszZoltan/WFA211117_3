using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA211117_3
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            int x = (int)nudSzelesseg.Value;
            int y = (int)nudMagassag.Value;
            int scale = (int)nudScale.Value;
            int noAkna = (int)nudDbAkna.Value;

            this.Hide();
            new FrmMain(x, y, scale, noAkna).ShowDialog();
            this.Show();
        }
    }
}
