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
    public partial class Professeur : Form
    {
        public Professeur()
        {
            InitializeComponent();
        }
        // Chaine de Connexion 
        static string ch = @"Data Source=DESKTOP-2CE72MO\SQLEXPRESS;Initial Catalog=Gestion_Ecole;Integrated Security=True";
        SqlConnection con = new SqlConnection(ch);
        DataSet ds = new DataSet();


        //Button de Retour
        private void Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Remplissage Data GridView
        private void proffesseur_Load(object sender, EventArgs e)
        {
            string req = "select * from Professeur";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            dr.Fill(ds, "Professeur");

            dataGridView1.DataSource = ds.Tables["Professeur"];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Button Ajouter 
        private void Ajouter_Click(object sender, EventArgs e)
        {
            int p = 0;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" )
            {
                MessageBox.Show("Tous les Champs doit etre insére");
            }
            else
            {
                int t = 0;
                //string req = "select * from Professeur ";
                //SqlDataAdapter dr = new SqlDataAdapter(req, con);
                //dr.Fill(ds, "Professeur");
                for (int i = 0; i < ds.Tables["Professeur"].Rows.Count; i++)
                {

                    if (textBox1.Text == ds.Tables["Professeur"].Rows[i][0].ToString())
                    {
                        t = 1; break;
                    }
                }
                {
                    if (t == 0)


                    {
                        DataRow l;
                        l = ds.Tables["Professeur"].NewRow();
                        l[0] = textBox1.Text;
                        l[1] = textBox2.Text;
                        l[2] = textBox3.Text;
                     


                        ds.Tables["Professeur"].Rows.Add(l);
                        MessageBox.Show("Professeur Ajouteé");
                        p = 1;
                    }
                    if (p == 0)
                    {
                        MessageBox.Show("Professeur Déja Existe");
                    }
                }
            }
        }

        // Button Modifier
        private void Modifier_Click(object sender, EventArgs e)
        {
            int p = 0;

            for (int i = 0; i < ds.Tables["Professeur"].Rows.Count; i++)
            {
                

                if (textBox1.Text == ds.Tables["Professeur"].Rows[i][0].ToString())
                {
                    ds.Tables["Professeur"].Rows[i][1] = textBox2.Text;
                    ds.Tables["Professeur"].Rows[i][2] = textBox3.Text;
               

                    MessageBox.Show("Modifier Avec Succes");
                    p = 1;
                    break;
                }


            }

            if (p == 0)
            {
                MessageBox.Show("Vérifier Que tous les champs sont Convenable");
            }
        }

        // Button Supprimer
        private void Supprimer_Click(object sender, EventArgs e)
        {
            int p = 0;

            for (int i = 0; i < ds.Tables["Professeur"].Rows.Count; i++)
            {
                if (textBox1.Text == ds.Tables["Professeur"].Rows[i][0].ToString())
                {
                    ds.Tables["Professeur"].Rows[i].Delete();
                    MessageBox.Show("Les Champs de Ce Professeur Sont Supprimé");
                    p = 1;
                    break;
                }
            }
            if (p == 0)
            {
                MessageBox.Show("Professeur n'existe Pas");

            }
        }

        // Button Confirmer
        private void button1_Click(object sender, EventArgs e)
        {
            string req = "select * from Professeur";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(dr);
            dr.Update(ds, "Professeur");
            MessageBox.Show("Les Champs sont Enregistrer");
        }

        //Button Vider
        private void Vider_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        // Button rechercher
        private void Rechercher_Click(object sender, EventArgs e)
        {

            //string req = "select * from Professeur";
            //SqlDataAdapter dr = new SqlDataAdapter(req, con);
            //dr.Fill(ds, "Professeur");
            int p = -1;
            for (int i = 0; i < ds.Tables["Professeur"].Rows.Count; i++)
            {
                if (textBox1.Text == ds.Tables["Professeur"].Rows[i][0].ToString())
                {
                    p = i;
                    break;
                }


            }
            if (p == -1)
            {
                MessageBox.Show(" Professeur n'existe pas ");

            }
            else
            {
                textBox1.Text = ds.Tables["Professeur"].Rows[p][0].ToString();
                textBox2.Text = ds.Tables["Professeur"].Rows[p][1].ToString();
                textBox3.Text = ds.Tables["Professeur"].Rows[p][2].ToString();
              

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

