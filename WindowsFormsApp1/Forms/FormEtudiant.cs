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
    public partial class FormEtudiant : Form
    {
        public FormEtudiant()
        {
            InitializeComponent();
        }
        // Chaine de Connexion 
        static string ch = @"Data Source=DESKTOP-2CE72MO\SQLEXPRESS;Initial Catalog=Gestion_Ecole;Integrated Security=True";
        SqlConnection con = new SqlConnection(ch);
        DataSet ds = new DataSet();


        // Combobox
        public void ComboFill()
        {
            string req = "select * from Filiére";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            dr.Fill(ds, "Filiére");

            for (int i = 0; i < ds.Tables["Filiére"].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables["Filiére"].Rows[i][0]);
            }
        }


        // Remplissage DataGridView
        private void FormProduct_Load(object sender, EventArgs e)
        {
            string req = "select * from Etudiant";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            dr.Fill(ds, "Etudiant");

            dataGridView1.DataSource = ds.Tables["Etudiant"];

            ComboFill();

        }

        // Button De Retour 
        private void Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Button Ajouter
        private void Ajouter_Click(object sender, EventArgs e)
        {
            int p = 0;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || dateTimePicker1.Text == "" || textBox6.Text == "" ||
                textBox7.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Tous les Champs doit etre insére");
            }
            else
            {
                int t = 0;
                //string req = "select * from Etudiant ";
                //SqlDataAdapter dr = new SqlDataAdapter(req, con);
                //dr.Fill(ds, "Etudiant");
                for (int i = 0; i < ds.Tables["Etudiant"].Rows.Count; i++)
                {

                    if (textBox1.Text == ds.Tables["Etudiant"].Rows[i][0].ToString())
                    {
                        t = 1; break;
                    }
                }
                {
                    if (t == 0)


                    {
                        DataRow l;
                        l = ds.Tables["Etudiant"].NewRow();
                        l[0] = textBox1.Text;
                        l[1] = textBox2.Text;
                        l[2] = textBox3.Text;
                        l[3] = textBox4.Text;
                        l[4] = dateTimePicker1.Text;
                        l[5] = textBox7.Text;
                        l[6] = textBox6.Text;
                        l[7] = comboBox1.Text;


                        ds.Tables["Etudiant"].Rows.Add(l);
                        MessageBox.Show("Etudiant Ajouteé");
                        p = 1;
                    }
                    if (p == 0)
                    {
                        MessageBox.Show("Etudiant Déja Existe");
                    }
                }
            }
        }

        // Button Confirmer
        private void button1_Click(object sender, EventArgs e)
        {
            string req = "select * from Etudiant";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(dr);
            dr.Update(ds, "Etudiant");
            MessageBox.Show("Les Champs sont Enregistrer");
        }

        // Button Vider
        private void Vider_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            dateTimePicker1.Text = "";

        }

        // Button Supprimer
        private void Supprimer_Click(object sender, EventArgs e)
        {

            int p = 0;

            for (int i = 0; i < ds.Tables["Etudiant"].Rows.Count; i++)
            {
                if (textBox1.Text == ds.Tables["Etudiant"].Rows[i][0].ToString())
                {
                    ds.Tables["Etudiant"].Rows[i].Delete();
                    MessageBox.Show("Les Champs de Ce Etudiant Sont Supprimé");
                    p = 1;
                    break;
                }
            }
            if (p == 0)
            {
                MessageBox.Show("Etudiant n'existe Pas");

            }

        }
        // Button Modifier
        private void Modifier_Click(object sender, EventArgs e)
        {
            int p = 0;
            for (int i = 0; i < ds.Tables["Etudiant"].Rows.Count; i++)
            {
                

                if (textBox1.Text == ds.Tables["Etudiant"].Rows[i][0].ToString())
                {
                    ds.Tables["Etudiant"].Rows[i][1] = textBox2.Text;
                    ds.Tables["Etudiant"].Rows[i][2] = textBox3.Text;
                    ds.Tables["Etudiant"].Rows[i][3] = textBox4.Text;
                    ds.Tables["Etudiant"].Rows[i][4] = dateTimePicker1.Text;
                    ds.Tables["Etudiant"].Rows[i][5] = textBox7.Text;
                    ds.Tables["Etudiant"].Rows[i][6] = textBox6.Text;
                    ds.Tables["Etudiant"].Rows[i][7] = comboBox1.Text;

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

        // Button Rechercher
        private void Rechercher_Click(object sender, EventArgs e)
        {

            //string req = "select * from Etudiant";
            //SqlDataAdapter dr = new SqlDataAdapter(req, con);
            //dr.Fill(ds, "Etudiant");
            int p = -1;
            for (int i = 0; i < ds.Tables["Etudiant"].Rows.Count; i++)
            {
                if (textBox1.Text == ds.Tables["Etudiant"].Rows[i][0].ToString())
                {
                    p = i;
                    break;
                }


            }
            if (p == -1)
            {
                MessageBox.Show(" Etudiant n'existe pas ");

            }
            else
            {
                textBox1.Text = ds.Tables["Etudiant"].Rows[p][0].ToString();
                textBox2.Text = ds.Tables["Etudiant"].Rows[p][1].ToString();
                textBox3.Text = ds.Tables["Etudiant"].Rows[p][2].ToString();
                textBox4.Text = ds.Tables["Etudiant"].Rows[p][3].ToString();
                dateTimePicker1.Text = ds.Tables["Etudiant"].Rows[p][4].ToString();
                textBox7.Text = ds.Tables["Etudiant"].Rows[p][5].ToString();
                textBox6.Text = ds.Tables["Etudiant"].Rows[p][6].ToString();
                comboBox1.Text = ds.Tables["Etudiant"].Rows[p][7].ToString();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
