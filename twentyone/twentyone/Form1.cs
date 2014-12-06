using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;
 

namespace twentyone
{
    public partial class Form1 : Form
    {
        string objConn = @"Data Source=(LocalDB)\v11.0;AttachDbFilename="+Application.StartupPath+"\\BlackJackDB.mdf;Integrated Security=True";
        //SqlConnection objConn = new SqlConnection(@"Data Source=CSCPROJECTS.lsus.local;Initial Catalog=BlackJack;Integrated Security=True");

        

        public Form1()
        {
            InitializeComponent();

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(objConn))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO BlackJackPlayerTB (Username, Password, Funds) VALUES (@Username, @Password, 1000)";
                
                    cmd.Parameters.AddWithValue("@Username", tbUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", tbPassword.Text);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Clone();
                        cmd.Parameters.Clear();

                        MessageBox.Show("Player created!");
                        Form1.ActiveForm.Hide();

                        Player player1 = new Player(tbUsername.Text, tbPassword.Text, 1000);

                        Blackjack blackjack = new Blackjack(player1);
                        blackjack.Activate();

                        blackjack.Show();
                    }
                    catch (SqlException s)
                    {
                        MessageBox.Show(s.Message.ToString(), "Did not create user");
                    }

                
                }
            }
           
                                 
           
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(objConn))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT PlayerID, Username, Password, Funds FROM BlackJackPlayerTB WHERE Username = @Username AND Password = @Password";
                    cmd.Parameters.AddWithValue("@Username", tbUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", tbPassword.Text);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException s)
                    {
                        MessageBox.Show(s.Message.ToString(), "Error Message");
                    }


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                //sign the player in
                                MessageBox.Show("Player found!");
                                Form1.ActiveForm.Hide();
                                string username = reader["Username"].ToString();
                                string password = reader["Password"].ToString();
                                string fundStr = reader["Funds"].ToString();
                                float funds = float.Parse(fundStr);

                                Player player1 = new Player(username, password, funds);
                                player1.playerID = int.Parse(reader["PlayerID"].ToString());
                               

                                Blackjack blackjack = new Blackjack(player1);
                                blackjack.Activate();

                                blackjack.Show();
                            }
                            else
                            {
                                MessageBox.Show("User does not exist!");
                            }

                            cmd.Clone();
                            cmd.Parameters.Clear();                       
                    }                   
                }
            }

        }

        private void btnExistingUser_Click(object sender, EventArgs e)
        {
            panelUserLogin.Visible = true;
            btnLogin.Visible = true;
            btnCreateUser.Visible = false;
            btnExistingUser.Visible = false;
            btnCreateUser.Visible = false;

            //Clear text boxes
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        private void panelUserLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            panelUserLogin.Visible = true;
            btnLogin.Visible = false;
            btnCreateUser.Visible = true;
            btnExistingUser.Visible = false;
            btnCreateUser.Visible = true;

            //Clear text boxes
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelUserLogin.Visible = false;
            btnCreateUser.Visible = true;
            btnExistingUser.Visible = true;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
