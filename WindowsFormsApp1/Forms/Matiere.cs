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
    public partial class Matiere : Form
    {
        public Matiere()
        {
            InitializeComponent();
        }
        
        // Chaine de Connexion 
        static string ch = @"Data Source=DESKTOP-2CE72MO\SQLEXPRESS;Initial Catalog=Gestion_Ecole;Integrated Security=True";
        SqlConnection con = new SqlConnection(ch);
        DataSet ds = new DataSet();
        private DataRow ligne;

        public void ComboFill()
        {
            string req = "select * from Professeur";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            dr.Fill(ds, "Professeur");

            for (int i = 0; i < ds.Tables["Professeur"].Rows.Count; i++)
            { 
                comboBox1.Items.Add(ds.Tables["Professeur"].Rows[i][0]);
            }
        }
        // Remplissage Data GridView

        private void Matiere_Load(object sender, EventArgs e)
        {
            string req = "select * from Matiére";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            dr.Fill(ds, "Matiére");



            dataGridView1.DataSource = ds.Tables["Matiére"];

            ComboFill();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        // Button Ajouter 
        private void Ajouter_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" ||comboBox1.Text == "")
            {
                MessageBox.Show("Merci de remplir les informations");

            }
            
            else
            {
                int t = 0;
                
                for (int i = 0; i < ds.Tables["Matiére"].Rows.Count; i++)
                {

                    if (textBox1.Text == ds.Tables["Matiére"].Rows[i][0].ToString())
                    
                    {
                    MessageBox.Show("Matiere Deja Existe ");
                        t = 1; break;
                    }
               
                }
                if (t == 0)
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
                    DataRow l;
                    l = ds.Tables["Matiére"].NewRow();
                    l[0] = textBox1.Text;
                    l[1] = textBox2.Text;
                    l[2] = b;
                    l[3] = comboBox1.Text;
                    ds.Tables["Matiére"].Rows.Add(l);
                    MessageBox.Show("Matiére bien ajouter");
                    

                }


            }
        }


        // Modifier 
      
        private void Modifier_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Merci de remplir le champ");
            }
            else
            {
                int g = 0;
                for (int i = 0; i < ds.Tables["Matiére"].Rows.Count; i++)
                {
                    if (textBox1.Text == ds.Tables["Matiére"].Rows[i][0].ToString())
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
                        //ds.Tables["Matiére"].Rows[i][0] = textBox1.Text;
                        ds.Tables["Matiére"].Rows[i][1] = textBox2.Text;
                        ds.Tables["Matiére"].Rows[i][3] = comboBox1.Text;
                        ds.Tables["Matiére"].Rows[i][2] = b;
                        MessageBox.Show("Bien modifier");
                    }
                }
                if (g == 0)
                {
                    MessageBox.Show("il n'exist aucune Matiére correspandant");
                }
            }
        }

        // Supprimer 
        private void Supprimer_Click(object sender, EventArgs e)
        {
            int p = 0;

            for (int i = 0; i < ds.Tables["Matiére"].Rows.Count; i++)
            {
                if (textBox1.Text == ds.Tables["Matiére"].Rows[i][0].ToString())
                {
                    ds.Tables["Matiére"].Rows[i].Delete();
                    MessageBox.Show("Les Champs de Ce Matiére Sont Supprimé");
                    p = 1;
                    break;
                }
            }
            if (p == 0)
            {
                MessageBox.Show("Matiére n'existe Pas");

            }

        }

        // Button Vider
        private void Vider_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        // Retour 
        private void Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Button Enregistrer
        private void button1_Click(object sender, EventArgs e)
        {
            string req = "select * from Matiére";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(dr);
            dr.Update(ds, "Matiére");
            MessageBox.Show("Les Champs sont Enregistrer");
        }

        //Button Rechercher 
        private void Rechercher_Click(object sender, EventArgs e)
        {
            //string req = "select * from Matiére";
            //SqlDataAdapter dr = new SqlDataAdapter(req, con);
            //dr.Fill(ds, "Matiére");
            int p = -1;
            for (int i = 0; i < ds.Tables["Matiére"].Rows.Count; i++)
            {
                if (textBox1.Text == ds.Tables["Matiére"].Rows[i][0].ToString())
                {
                    p = i;
                    break;
                }


            }
            if (p == -1)
            {
                MessageBox.Show(" Mati ére n'existe pas ");

            }
            else
            {
                textBox1.Text = ds.Tables["Matiére"].Rows[p][0].ToString();
                textBox2.Text = ds.Tables["Matiére"].Rows[p][1].ToString();
                comboBox1.Text = ds.Tables["Matiére"].Rows[p][3].ToString();

            }
        }
    }

}





