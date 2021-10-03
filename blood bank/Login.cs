using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace blood_bank
{
    public partial class Login : Form
    {
        DataConnection db = new DataConnection();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string sql = "select * from login where UserName='" + textBox1.Text + "' and pass='" + textBox2.Text + "'";
                
                db.openconnection();
                MySqlDataReader dr = db.executeReader(sql);

                if (dr.HasRows)
                {
                    Mainform mf = new Mainform();
                    mf.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("incorrect data", "");
                    dr.Close();
                }


            }
            else
            {
                MessageBox.Show("Fill the fields", "");
            }
        }
    }
}
