using MySql.Data.MySqlClient;
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
    public partial class Viewdonor : Form
    {
        DataConnection db = new DataConnection();
        public Viewdonor()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            Donor d = new Donor();
            d.Show();
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

        private void Viewdonor_Load(object sender, EventArgs e)
        {
            db.openconnection();

            DataSet dt = new DataSet();
            MySqlDataAdapter sd = db.sda("select * from doner");
            sd.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];

            sd.Dispose();
            db.closeconnection();
        }
    }
}
