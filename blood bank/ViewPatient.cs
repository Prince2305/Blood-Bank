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
    public partial class ViewPatient : Form
    {
        DataConnection db = new DataConnection();
       
        public ViewPatient()
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

        private void ViewPatient_Load(object sender, EventArgs e)
        {
            db.openconnection();

            DataSet dt = new DataSet();
            MySqlDataAdapter sd = db.sda("select * from patient");
            sd.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];

           

            db.closeconnection();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            txtname.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            txtage.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            comgen.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            txtcontct.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            comblogrp.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
            txtaddress.Text = dataGridView1.Rows[row].Cells[5].Value.ToString();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.openconnection();
            MySqlDataReader dr;
            dr = db.executeReader("update patient set name='" + txtname.Text + "',age='" + txtage.Text + "',gender='" + comgen.Text + "',phone='" + txtcontct.Text + "',bloodGroup='" + comblogrp.Text + "',address='" + txtaddress.Text + "' where name='" + txtname.Text + "'");
            MessageBox.Show("Data Updated!!!", "");
            // setDataGridView();
            dr.Close();
            MySqlDataAdapter sd = db.sda("select * from patient");
            DataSet d = new DataSet();
            sd.Fill(d);
            dataGridView1.DataSource = d.Tables[0];

            db.closeconnection();

        }

        private void setDataGridView()
        {
            db.openconnection();
            
           
            
            db.closeconnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.openconnection();
            MySqlDataReader dr;
            dr = db.executeReader("delete from patient where name='" + txtname.Text + "'");
            MessageBox.Show("Data Deleted!!!", "");
            dr.Close();

            MySqlDataAdapter sd = db.sda("select * from patient");
            DataSet d = new DataSet();
            sd.Fill(d);
            dataGridView1.DataSource = d.Tables[0];

            db.closeconnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtaddress.Text = "";
            txtage.Text = "";
            txtcontct.Text = "";
            txtname.Text = "";
            comblogrp.Text = "";
            comgen.Text = "";
            
        }
    }
}
