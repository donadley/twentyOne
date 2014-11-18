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
        SqlConnection objConn;
        SqlDataAdapter daPlayerAdapter;
        DataSet dsPlayerDataSet;

        public Form1()
        {
            InitializeComponent();

            string sConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mercury\Documents\GitHub\twentyOne\twentyone\twentyone\BlackJackDB.mdf;Integrated Security=True";

            objConn = new SqlConnection(sConnectionString);


            daPlayerAdapter = new SqlDataAdapter("Select * From BlackJackPlayerTB", objConn);

            dsPlayerDataSet = new DataSet();


            daPlayerAdapter.FillSchema(dsPlayerDataSet, SchemaType.Source, "BlackJackPlayerTB");
            daPlayerAdapter.Fill(dsPlayerDataSet, "BlackJackPlayerTB");
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            DataRow newPlayer = dsPlayerDataSet.Tables["BlackJackPlayerTB"].NewRow();
          
            newPlayer["Username"] = tbUsername.Text;
            newPlayer["Password"] = tbPassword.Text;
             //New player starts with $100
            newPlayer["Funds"] = 100;               

            dsPlayerDataSet.Tables["BlackJackPlayerTB"].Rows.Add(newPlayer);

            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(daPlayerAdapter);

            daPlayerAdapter.UpdateCommand = cmdBuilder.GetUpdateCommand();
            daPlayerAdapter.InsertCommand = cmdBuilder.GetInsertCommand();

            daPlayerAdapter.Update(dsPlayerDataSet, "BlackJackPlayerTB");

            objConn.Close();         
        
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
            //if (player != null)
            //{
            //    //sign the player in
            //    MessageBox.Show("Player found!");
            //    Form1.ActiveForm.Hide();
            //    Form2 form2 = new Form2();
            //    form2.Activate();

            //    form2.Show();
            //}
            //else
            //{
            //    MessageBox.Show("User does not exist!");  
            //}
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
