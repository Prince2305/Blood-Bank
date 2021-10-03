using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blood_bank
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            Donor d = new Donor();
            d.Show();
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Viewdonor vd = new Viewdonor();
            vd.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            patient p = new patient();
            p.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            ViewPatient vp = new ViewPatient();
            vp.Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            BloodStock bs = new BloodStock();
            bs.Show();
            this.Hide();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            BloodTransfer bt = new BloodTransfer();
            bt.Show();
            this.Hide();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
