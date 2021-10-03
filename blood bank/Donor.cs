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
    public partial class Donor : Form
    {
        DataConnection db = new DataConnection();
        public Donor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr;
            if (!(String.IsNullOrEmpty(txtamtblo.Text) && String.IsNullOrEmpty(txtname.Text) && String.IsNullOrEmpty(txtage.Text) && String.IsNullOrEmpty(txtphone.Text) && String.IsNullOrEmpty(txtaddre.Text)) && comgender.Text!="" && comblogrp.Text!="")
            {
                db.openconnection();

                String sql = "INSERT INTO doner(name,age,gender,phone,bloodGroup,adddress,qty) VALUES('" + txtname.Text + "','" + txtage.Text + "','" + comgender.Text + "','" + txtphone.Text + "','" + comblogrp.Text + "','"+txtaddre.Text+"','"+txtamtblo.Text+"')";
                MessageBox.Show(sql);
                dr = db.executeReader(sql);

                dr.Close();
                bam();
                int amount = 0;
                amount = bam();
                 amount += Convert.ToInt32(txtamtblo.Text);
                dr = db.executeReader("update bloodstock set qty='" + Convert.ToString(amount) + "' where blood_Type ='" + comblogrp.Text + "'");
                dr.Close();

                dr.Dispose();
                db.closeconnection();
            }
            else
            {
                MessageBox.Show("plz fill all the field", "");
            }
        }

        private int bam()
        {
            int i=0;
            MessageBox.Show(comblogrp.Text);
            string sql = "select * from bloodstock where blood_Type='" + comblogrp.Text + "'";

            db.openconnection();
            MySqlDataReader dr = db.executeReader(sql);

            if (dr.HasRows)
            {
                while(dr.Read())
                { 
                String dat = dr["qty"].ToString();
                i = Convert.ToInt32(dat);
                 MessageBox.Show(dat,""+i);
                }
                dr.Close();
                return i;
            }
            else
            {
                
                dr.Close();
                return 0;
            }
            db.closeconnection();
        }

        private void Donor_Load(object sender, EventArgs e)
        {

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

        private void label18_Click(object sender, EventArgs e)
        {
            Viewdonor vp = new Viewdonor();
            vp.Show();
            this.Hide();
        }
    }
}
