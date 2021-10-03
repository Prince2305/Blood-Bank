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
    public partial class BloodTransfer : Form
    {
        DataConnection db = new DataConnection();
        int amount = 0;
        public BloodTransfer()
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

        private void label22_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtname.Text)) && comgen.Text != "" && comblogrp.Text != "")
            {
                string sql = "select * from bloodstock where blood_Type='" + comblogrp.Text + "' ";

                db.openconnection();
                MySqlDataReader dr = db.executeReader(sql);

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        amount = Convert.ToInt32(dr["qty"].ToString());
                    }
                    if (amount >= Convert.ToInt32(txtamt.Text))
                    {
                        label6.Text = "Stock Available";
                        button2.Enabled = true;
                    }
                    else
                    {
                        label6.Text = "Stock Not Available";
                    }

                }
                dr.Close();
            }
        }
                 

        private void button2_Click(object sender, EventArgs e)
        {
            db.openconnection();
            MySqlDataReader dr;
            String sql = "INSERT INTO bloodtransfer(pName,pGender,pbloodGroup,pqty) VALUES('" + txtname.Text + "','" + comgen.Text + "','" + comblogrp.Text + "'," + Convert.ToInt32(txtamt.Text) + ")";

            dr = db.executeReader(sql);


            dr.Close();
            amount = amount - Convert.ToInt32(txtamt.Text);
            dr = db.executeReader("update bloodstock set qty='" + Convert.ToString(amount) + "' where blood_Type='" + comblogrp.Text + "'");
            dr.Close();
            dr.Dispose();
            db.closeconnection();


            txtamt.Text = "";
            txtname.Text = "";
            comgen.Text = "";
            comblogrp.Text = "";
            button2.Enabled = false;
        
         }

   

      
   
    }
}
