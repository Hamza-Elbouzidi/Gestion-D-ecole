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
namespace WindowsFormsApp1.Forms
{
    public partial class Login : Form
    {
        Home H1;
        public Login(Home H)
        {
            InitializeComponent();
            this.H1 = H;
        }

       

        //Chaine de connexion
        static string ch = @"Data Source=DESKTOP-2CE72MO\SQLEXPRESS;Initial Catalog=Gestion_Ecole;Integrated Security=True";
        SqlConnection con = new SqlConnection(ch);
        DataSet ds = new DataSet();

        private void Login_Load(object sender, EventArgs e)
        {

        }

        // Button De Connexion 
        static int cmp = 0;
        private void connexion_Click(object sender, EventArgs e)
        {
            string req = "select * from Login";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            dr.Fill(ds, "Login");

            for (int i = 0; i < ds.Tables["Login"].Rows.Count; i++)
            {
                string l = ds.Tables["Login"].Rows[i][0].ToString();
                string p = ds.Tables["Login"].Rows[i][1].ToString();
                if (l == LoginTextBox.Text && p == PasswordTextBox.Text)
                {
  
                    H1.student.Enabled = true;
                    H1.prof.Enabled = true;
                    H1.Absence.Enabled = true;
                    H1.matieres.Enabled = true;
                    H1.Filiere.Enabled = true;
                    H1.Evaluation.Enabled = true;
                    H1.Login.Enabled = false;

                    MessageBox.Show("Connecter");
                    this.Close();
                    break;

                }
                else if (l == LoginTextBox.Text && p != PasswordTextBox.Text) { cmp++; MessageBox.Show("Mot De Passe Incorrect"); PasswordTextBox.Clear(); break; }
                else if (l != LoginTextBox.Text && p == PasswordTextBox.Text) { cmp++; MessageBox.Show("Login Incorrect"); LoginTextBox.Clear(); PasswordTextBox.Clear(); break; }
                else { cmp++; MessageBox.Show("Les Champs Incorrect"); LoginTextBox.Clear(); PasswordTextBox.Clear(); break; }

            }
            // Pour desactiver le compte apres 4 tenta 
            if (cmp == 4)
            {
                connexion.Enabled = false;
            }

        }

        // Button Cancel 
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MDP_oublier mDP = new MDP_oublier();
            mDP.Show();
            this.Close();
        }
    }
}

