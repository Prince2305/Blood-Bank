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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {
            
            
        }
        Timer t;
        private void splash_Shown(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 2000;
            t.Start();
            t.Tick += t_Tick;
        }

        private void t_Tick(object sender, EventArgs e)
        {
            t.Stop();

            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
