using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter dataReadere;
            String sql;
            SqlConnection con;

            con = new SqlConnection("Data Source=sqlserver;Initial Catalog=Heritagetab;Integrated Security=True");

            try
            {
                con.Open();

                if (name.Text == "" || surname.Text == "" || email.Text == "" || password.Text== "" )
                {
                    MessageBox.Show("fill in all details");
                }
                else
                {



                    if (password.Text == confirmpassword.Text)
                    {
                        if (radioButton2.Checked == true)
                        {
                            if (pictureBox1.Image == null)
                            {
                                MessageBox.Show("upload a picture");
                            }
                            else
                            {
                                
                                sql = "insert into Participants values" + name.Text + "," + surname.Text + "," + email.Text + "," + pictureBox1.Image + "," + password.Text + ";";
                                command = new SqlCommand(sql, con);
                            }
                        }
                        else
                        {

                            sql = "insert into VoterTable values" + name.Text + "," + surname.Text + "," + email.Text + ", " + 3 + " ," + password.Text + ";";
                            command = new SqlCommand(sql, con);
                        }

                    }
                    else
                    {
                        MessageBox.Show("password does not match");
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("failed");
            }

            con.Close();
            this.Close();
            Form2 frm = new Form2();
            frm.Show();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                pictureBox1.Visible = true;
                button3.Visible = true;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pictureBox1.Visible = false;
                button3.Visible = false;
            }

        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;
            SqlConnection con;

            con = new SqlConnection("Data Source=sqlserver;Initial Catalog=Heritagetab;Integrated Security=True");

            try
            {
                con.Open();


                sql = "select email,password from Participants where email = " + email.Text + " and  password =" + password.Text + ";";

                command = new SqlCommand(sql, con);

                dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    Form2 frm = new Form2();
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Either password or email is incorrect");
                }


            }
            catch (Exception)
            {

                MessageBox.Show("failed");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
           
}

}
