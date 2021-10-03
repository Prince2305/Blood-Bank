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
    public partial class patient : Form
    {
        DataConnection db = new DataConnection();
        public patient()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Viewdonor vd = new Viewdonor();
            vd.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Donor d = new Donor();
            d.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr;
            if (!(String.IsNullOrEmpty(txtname.Text) && String.IsNullOrEmpty(txtaddre.Text) && String.IsNullOrEmpty(txtage.Text) && String.IsNullOrEmpty(txtphone.Text)) && comgen.Text != "" && comblogrp.Text != "")
            {
                db.openconnection();

                String sql = "INSERT INTO patient(name,age,gender,phone,bloodGroup,address) VALUES('" + txtname.Text + "','" + txtage.Text + "','" + comgen.Text + "','" +txtphone.Text + "','" + comblogrp.Text + "','"+txtaddre.Text+"')";

                dr = db.executeReader(sql);

                
                dr.Close();

                dr.Dispose();
                db.closeconnection();
            }
            else
            {
                MessageBox.Show("plz fill all the field", "");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtaddre.Text ="";
            txtage.Text = "";
            txtname.Text = "";
            txtphone.Text = "";

            comblogrp.Text = "";
            comgen.Text = "";
        }
    }
}
