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
    public partial class Absence : Form
    {
        public Absence()
        {
            InitializeComponent();
        }
        // Chaine de Connexion 
        static string ch = @"Data Source=DESKTOP-2CE72MO\SQLEXPRESS;Initial Catalog=Gestion_Ecole;Integrated Security=True";
        SqlConnection con = new SqlConnection(ch);
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();



        // Remplissage Combobox 
        public void ComboFill()
        {
            string req = "select * from Etudiant";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            dr.Fill(ds, "Etudiant");

            for (int i = 0; i < ds.Tables["Etudiant"].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables["Etudiant"].Rows[i][0]);
            }
        }
        // Remplissage Combo2
        public void ComboFill2()
        {
            string req = "select * from Matiére";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            dr.Fill(ds, "Matiére");

            for (int i = 0; i < ds.Tables["Matiére"].Rows.Count; i++)
            {
                comboBox2.Items.Add(ds.Tables["Matiére"].Rows[i][0]);
            }
        }
        //Remplissage Combo3
        public void ComboFill3()
        {
            string req = "select * from Professeur";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            dr.Fill(ds, "Professeur");

            for (int i = 0; i < ds.Tables["Professeur"].Rows.Count; i++)
            {
                comboBox3.Items.Add(ds.Tables["Professeur"].Rows[i][0]);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
      
        }

        //Affichage de DatagridView
        private void Absence_Load(object sender, EventArgs e)
        {
            string req2 = "select * from AbsenceE";
            SqlDataAdapter dr2 = new SqlDataAdapter(req2, con);
            dr2.Fill(ds, "AbsenceE");

            string req1 = "select * from AbsenceP";
            SqlDataAdapter dr1 = new SqlDataAdapter(req1, con);
            dr1.Fill(ds1, "AbsenceP");
            dataGridView2.DataSource = ds1.Tables["AbsenceP"];
            dataGridView1.DataSource = ds.Tables["AbsenceE"];
            
            ComboFill();
            ComboFill2();
            ComboFill3();

        }

        //Button Rechercher Et Affichage de DatagridView (Etudiant)
        private void button1_Click(object sender, EventArgs e)
        {


           
            int p = -1;
            for (int i = 0; i < ds.Tables["AbsenceE"].Rows.Count; i++)
            {
                if (comboBox1.Text == ds.Tables["AbsenceE"].Rows[i][0].ToString())
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
                comboBox1.Text = ds.Tables["AbsenceE"].Rows[p][0].ToString();
                comboBox2.Text = ds.Tables["AbsenceE"].Rows[p][1].ToString();
                dateTimePicker1.Text = ds.Tables["AbsenceE"].Rows[p][2].ToString();


            }

        }

        //Button Rechercher Et Affichage de DatagridView (Professeur)
        private void Rechercher_Click(object sender, EventArgs e)
        {
            int p = -1;
            for (int i = 0; i < ds1.Tables["AbsenceP"].Rows.Count; i++)
            {
                if (comboBox3.Text == ds1.Tables["AbsenceP"].Rows[i][0].ToString())
                {
                    p = i;
                    break;
                }


            }
            if (p == -1)
            {
                MessageBox.Show(" Absence Professeur n'existe pas ");

            }
            else
            {
                comboBox3.Text = ds1.Tables["AbsenceP"].Rows[p][0].ToString();
                dateTimePicker2.Text = ds1.Tables["AbsenceP"].Rows[p][1].ToString();
               


            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        //Button Ajouter  Absence Etudiant 
        private void AjouterE_Click(object sender, EventArgs e)
        {
            int p = 0;

            if (comboBox1.Text == "" || comboBox2.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("Tous les Champs doit etre insére");
            }
            else
            {
                int t = 0;
            
                for (int i = 0; i < ds.Tables["AbsenceE"].Rows.Count; i++)
                {

                    if (comboBox1.Text == ds.Tables["AbsenceE"].Rows[i][0].ToString())
                    {
                        t = 1; break;
                    }
                }
                {
                    if (t == 0)


                    {
                        DataRow l;
                        l = ds.Tables["AbsenceE"].NewRow();
                        l[0] = comboBox1.Text;
                        l[1] = comboBox2.Text;
                        l[2] = dateTimePicker1.Text;



                        ds.Tables["AbsenceE"].Rows.Add(l);
                        MessageBox.Show("Absence Etudiant Ajouteé");
                        p = 1;
                    }
                    if (p == 0)
                    {
                        MessageBox.Show("Absence Etudiant Déja Existe");
                    }
                }
            }
        }

        //Button Ajouter Absence Professeur
        private void AjouterP_Click(object sender, EventArgs e)
        {
            int p = 0;

            if (comboBox3.Text == ""  || dateTimePicker2.Text == "")
            {
                MessageBox.Show("Tous les Champs doit etre insére");
            }
            else
            {
                int t = 0;
              
                for (int i = 0; i < ds1.Tables["AbsenceP"].Rows.Count; i++)
                {

                    if (comboBox3.Text == ds1.Tables["AbsenceP"].Rows[i][0].ToString())
                    {
                        t = 1; break;
                    }
                }
                {
                    if (t == 0)


                    {
                        DataRow l;
                        l = ds1.Tables["AbsenceP"].NewRow();
                        l[0] = comboBox3.Text;
                        
                        l[1] = dateTimePicker2.Text;



                        ds1.Tables["AbsenceP"].Rows.Add(l);
                        MessageBox.Show("Absence Professeur Ajouteé");
                        p = 1;
                    }
                    if (p == 0)
                    {
                        MessageBox.Show("Absence Professeur Déja Existe");
                    }
                }
            }
        }

        //Button Supprimer Absence Etudiant
        private void SupprimerE_Click(object sender, EventArgs e)
        {

            int p = 0;

            for (int i = 0; i < ds.Tables["AbsenceE"].Rows.Count; i++)
            {
                if (comboBox1.Text == ds.Tables["AbsenceE"].Rows[i][0].ToString())
                {
                    ds.Tables["AbsenceE"].Rows[i].Delete();
                    MessageBox.Show("Les Champs de Cet Absence Sont Supprimé");
                    p = 1;
                    break;
                }
            }
            if (p == 0)
            {
                MessageBox.Show("Absence  n'existe Pas");

            }
        }

        //Button Supprimer Absence Professeur
        private void SupprimerP_Click(object sender, EventArgs e)
        {

            int p = 0;

            for (int i = 0; i < ds1.Tables["AbsenceP"].Rows.Count; i++)
            {
                if (comboBox3.Text == ds1.Tables["AbsenceP"].Rows[i][0].ToString())
                {
                    ds1.Tables["AbsenceP"].Rows[i].Delete();
                    MessageBox.Show("Les Champs de Cet Absence Sont Supprimé");
                    p = 1;
                    break;
                }
            }
            if (p == 0)
            {
                MessageBox.Show("Absence  n'existe Pas");

            }
        }


        //Button Modifer Absence Etudiant
        private void ModifierE_Click(object sender, EventArgs e)
        {

            int p = 0;
            for (int i = 0; i < ds.Tables["AbsenceE"].Rows.Count; i++)
            {

                if (comboBox1.Text == ds.Tables["AbsenceE"].Rows[i][0].ToString())
                {
                    ds.Tables["AbsenceE"].Rows[i][1] = comboBox2.Text;
                    ds.Tables["AbsenceE"].Rows[i][2] = dateTimePicker1.Text;


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


        //Button Modifer Absence Professeur
        private void ModifierP_Click(object sender, EventArgs e)
        {
            int p = 0;
            for (int i = 0; i < ds1.Tables["AbsenceP"].Rows.Count; i++)
            {

               
                if (comboBox3.Text == ds1.Tables["AbsenceP"].Rows[i][0].ToString())
                {
                    ds1.Tables["AbsenceP"].Rows[i][1] = dateTimePicker2.Text;
                  


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

        //Button Confirmer Absence Etudiant
        private void button3_Click(object sender, EventArgs e)
        {
            string req = "select * from AbsenceE";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(dr);
            dr.Update(ds, "AbsenceE");
            MessageBox.Show("Les Champs sont Enregistrer");
        }


        //Button Confirmer Absence Professeur
        private void button4_Click(object sender, EventArgs e)
        {
            string req1 = "select * from AbsenceP";
            SqlDataAdapter dr1 = new SqlDataAdapter(req1, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(dr1);
            dr1.Update(ds1, "AbsenceP");
            MessageBox.Show("Les Champs sont Enregistrer");
        }

        //Vider Les Champs d'absence Etudiant
        private void Vider_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }


        //Vider Les Champs d'absence Professeur 
        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Text = "";
            comboBox3.Text = "";
        }


        //Button Retourne 
        private void Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
