using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using twentyone;

namespace twentyone
{
    public partial class Form1 : Form
    {

        PlayerContext context = new PlayerContext();

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            Player newPlayer = new Player();
            newPlayer.Username = tbUsername.Text;
            newPlayer.Password = tbPassword.Text;
            //New player starts with $100 
            newPlayer.Funds = 100;

            context.Players.Add(newPlayer);
            context.SaveChanges();

            MessageBox.Show("Player created!");            
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
            Player player = context.Players.Where(p => p.Username.Equals(tbUsername.Text) && p.Password.Equals(tbPassword.Text)).FirstOrDefault();
            if (player != null)
            {
                //sign the player in
                MessageBox.Show("Player found!");    
            }
        }

        private void btnExistingUser_Click(object sender, EventArgs e)
        {
            panelUserLogin.Visible = true;
            btnLogin.Visible = true;
            btnCreateUser.Visible = false;
            btnExistingUser.Visible = false;
            btnCreateUser.Visible = false;
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
