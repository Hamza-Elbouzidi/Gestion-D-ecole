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
    public partial class filiere : Form
    {
        public filiere()
        {
            InitializeComponent();
        }
        // Chaine de Connexion 
        static string ch = @"Data Source=DESKTOP-2CE72MO\SQLEXPRESS;Initial Catalog=Gestion_Ecole;Integrated Security=True";
        SqlConnection con = new SqlConnection(ch);
        DataSet ds = new DataSet();
        private DataRow ligne;


        private void filiere_Load(object sender, EventArgs e)
        {
            string req = "select * from Filiére";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            dr.Fill(ds, "Filiére");

            dataGridView1.DataSource = ds.Tables["Filiére"];
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Buttton Ajouter
        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" )
            {
                MessageBox.Show("Merci de remplir les informations");

            }

            else
            {

                for (int i = 0; i < ds.Tables["Filiére"].Rows.Count; i++)
                {

                    if (textBox1.Text == ds.Tables["Filiére"].Rows[i][0].ToString())

                    {
                        MessageBox.Show("Filiére Deja Existe ");
                    }
                    else
                    {

                        int b;
                        if (radioButton1.Checked == true)
                        {
                            b = 1;
                        }
                        else
                        {
                            b = 2;
                        }
                        ligne = ds.Tables["Filiére"].NewRow();
                        ligne[0] = textBox1.Text;
                        ligne[1] = textBox2.Text;
                        ligne[2] = b;
                        ds.Tables["Filiére"].Rows.Add(ligne);
                        MessageBox.Show("Filiére bien ajouter");
                        break;

                    }



                }


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Button Modifier 
        
        private void Modifier_Click(object sender, EventArgs e)
        {
            int g = 0;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Merci de remplir le champ");
            }
            else
            {
                
                for (int i = 0; i < ds.Tables["Filiére"].Rows.Count; i++)
                
                    if (textBox1.Text == ds.Tables["Filiére"].Rows[i][0].ToString())
                    {
                        g = 1;

                        int b;
                    if (radioButton1.Checked == true)
                    {
                        b = 1;
                    }
                    else
                    {
                        b = 2;
                    }
                    ds.Tables["Filiére"].Rows[i][0] = textBox1.Text;
                    ds.Tables["Filiére"].Rows[i][1] = textBox2.Text;
                    ds.Tables["Filiére"].Rows[i][2] = b;
                    MessageBox.Show("Bien modifier");
                    }
            }
            if (g == 0)
            {
                MessageBox.Show("il n'exist aucune Matiére correspandant");
            }

        }

        

        // Button Supprimer 
        private void Supprimer_Click(object sender, EventArgs e)
        {
            int p = 0;

            for (int i = 0; i < ds.Tables["Filiére"].Rows.Count; i++)
            {
                if (textBox1.Text == ds.Tables["Filiére"].Rows[i][0].ToString())
                {
                    ds.Tables["Filiére"].Rows[i].Delete();
                    MessageBox.Show("Les Champs de Ce Filiére Sont Supprimé");
                    p = 1;
                    break;
                }
            }
            if (p == 0)
            {
                MessageBox.Show("Filiére n'existe Pas");

            }
        }


        // Button Vider 
        private void Vider_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
           
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        // Button retour 
        private void Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Button Enregistrer 
        private void button1_Click(object sender, EventArgs e)
        {
            string req = "select * from Filiére";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(dr);
            dr.Update(ds, "Filiére");
            MessageBox.Show("Les Champs sont Enregistrer");
        }


        //Button Rechercher 
        private void Rechercher_Click(object sender, EventArgs e)
        {

            //string req = "select * from Filiére";
            //SqlDataAdapter dr = new SqlDataAdapter(req, con);
            //dr.Fill(ds, "Filiére");
            int p = -1;
            for (int i = 0; i < ds.Tables["Filiére"].Rows.Count; i++)
            {
                if (textBox1.Text == ds.Tables["Filiére"].Rows[i][0].ToString())
                {
                    p = i;
                    break;
                }


            }
            if (p == -1)
            {
                MessageBox.Show(" Filiére n'existe pas ");

            }
            else
            {
                textBox1.Text = ds.Tables["Filiére"].Rows[p][0].ToString();
                textBox2.Text = ds.Tables["Filiére"].Rows[p][1].ToString();

                

            }
            
        }
    }
}
