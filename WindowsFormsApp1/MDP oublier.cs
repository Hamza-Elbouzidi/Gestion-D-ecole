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
    public partial class MDP_oublier : Form
    {
      
        public MDP_oublier()
        {
            InitializeComponent();
        }

        //Chaine de connexion
        static string ch = @"Data Source=DESKTOP-2CE72MO\SQLEXPRESS;Initial Catalog=Gestion_Ecole;Integrated Security=True";
        SqlConnection con = new SqlConnection(ch);
        DataSet ds = new DataSet();

    


        private void MDP_oublier_Load(object sender, EventArgs e)
        {
            string req = "select * from Login ";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            dr.Fill(ds, "Login");

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Button Modifier 
        private void Modifier_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ds.Tables["Login"].Rows.Count; i++) 
            {


                if (LoginTextBox.Text == ds.Tables["Login"].Rows[i][2].ToString() && textBox4.Text == ds.Tables["Login"].Rows[i][3].ToString())
                {
                    ds.Tables["Login"].Rows[i][1] = textBox2.Text;
                    MessageBox.Show("Le Mot de Passe est Modifié Veuiller Confirmer le Changement ");

                }
            }
        }


        // Button Enregistrer
        private void button1_Click(object sender, EventArgs e)
        {
            string req = "select * from Login";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(dr);
            dr.Update(ds, "Login");
            MessageBox.Show("Nouvea Mot de Passe Validé");
        }
    }
}
