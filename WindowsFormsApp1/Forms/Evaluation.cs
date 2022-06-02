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
using WindowsFormsApp1.DataSet1TableAdapters;
using CrystalDecisions.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Evaluation : Form
    {
        public Evaluation()
        {
            InitializeComponent();
        }
        // Chaine de Connexion 
        static string ch = @"Data Source=DESKTOP-2CE72MO\SQLEXPRESS;Initial Catalog=Gestion_Ecole;Integrated Security=True";
        SqlConnection con = new SqlConnection(ch);
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();

        //Combobox1
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

        // Combobox2
        public void ComboFill1()
        {
            string req = "select * from Matiére";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            dr.Fill(ds, "Matiére");

            for (int i = 0; i < ds.Tables["Matiére"].Rows.Count; i++)
            {
                comboBox2.Items.Add(ds.Tables["Matiére"].Rows[i][0]);
            }
        }


        // remplissage DataGrid View
        private void Evaluation_Load(object sender, EventArgs e)
        {
            string req = "select * from Evaluation";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            dr.Fill(ds, "Evaluation");

            dataGridView1.DataSource = ds.Tables["Evaluation"];

            // remplissage DataGrid View Etudiant


            string req1 = "select * from Etudiant";
            SqlDataAdapter dr1 = new SqlDataAdapter(req1, con);
            dr1.Fill(ds1, "Etudiant");

            dataGridView2.DataSource = ds1.Tables["Etudiant"];

            ComboFill();
            ComboFill1();
        }

        // Button Ajouter
        private void Ajouter_Click(object sender, EventArgs e)
        {
            int p = 0;

            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox3.Text == "" )
            {
                MessageBox.Show("Tous les Champs doit etre insére");
            }
            else
            {
                int t = 0;
                //string req = "select * from Evaluation ";
                //SqlDataAdapter dr = new SqlDataAdapter(req, con);
                //dr.Fill(ds, "Evaluation");
                for (int i = 0; i < ds.Tables["Evaluation"].Rows.Count; i++)
                {

                    if (comboBox1.Text == ds.Tables["Evaluation"].Rows[i][0].ToString())
                    {
                        t = 1; break;
                    }
                }
                {
                    if (t == 0)


                    {
                        DataRow l;
                        l = ds.Tables["Evaluation"].NewRow();
                        l[0] = comboBox1.Text;
                        l[1] = comboBox2.Text;
                        l[2] = textBox3.Text;
                       


                        ds.Tables["Evaluation"].Rows.Add(l);
                        MessageBox.Show("Evaluation Ajouteé");
                        p = 1;
                    }
                    if (p == 0)
                    {
                        MessageBox.Show("Evaluation Déja Existe");
                    }
                }
            }
        }

        // Button Modifier
        private void Modifier_Click(object sender, EventArgs e)
        {
            int p = 0;

            for (int i = 0; i < ds.Tables["Evaluation"].Rows.Count; i++)
            {

              
                if (comboBox1.Text == ds.Tables["Evaluation"].Rows[i][0].ToString())
                {
                    ds.Tables["Evaluation"].Rows[i][1] = comboBox2.Text;
                    ds.Tables["Evaluation"].Rows[i][2] = textBox3.Text;
               

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

        //Button Supprimer
        private void Supprimer_Click(object sender, EventArgs e)
        {
            int p = 0;

            for (int i = 0; i < ds.Tables["Evaluation"].Rows.Count; i++)
            {
                if (comboBox1.Text == ds.Tables["Evaluation"].Rows[i][0].ToString())
                {
                    ds.Tables["Evaluation"].Rows[i].Delete();
                    MessageBox.Show("Les Champs de Cet Evaluation Sont Supprimé");
                    p = 1;
                    break;
                }
            }
            if (p == 0)
            {
                MessageBox.Show("Evaluation n'existe Pas");

            }
        }

        //Button De Confirmation
        private void button1_Click(object sender, EventArgs e)
        {
            string req = "select * from Evaluation";
            SqlDataAdapter dr = new SqlDataAdapter(req, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(dr);
            dr.Update(ds, "Evaluation");
            MessageBox.Show("Les Champs sont Enregistrer");

        }

        //Button Vider
        private void Vider_Click(object sender, EventArgs e)
        {

            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox3.Text = "";
        }

        
        //Button Vider
        private void Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Button Rechercher
        private void Rechercher_Click(object sender, EventArgs e)
        {

         
            int p = -1;
            for (int i = 0; i < ds.Tables["Evaluation"].Rows.Count; i++)
            {
                if (comboBox1.Text == ds.Tables["Evaluation"].Rows[i][0].ToString())
                {
                    p = i;
                    break;
                }


            }
            if (p == -1)
            {
                MessageBox.Show(" Evaluation n'existe pas ");

            }
            else
            {
                comboBox1.Text = ds.Tables["Evaluation"].Rows[p][0].ToString();
                comboBox2.Text = ds.Tables["Evaluation"].Rows[p][1].ToString();
                textBox3.Text = ds.Tables["Evaluation"].Rows[p][2].ToString();
          
            }
        }


        // Button Imprimer
        private void button2_Click(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            DataTable1TableAdapter d = new DataTable1TableAdapter();
            d.Fill(ds.DataTable1, Convert.ToInt32(comboBox1.Text));
            CrystalReport1 report = new CrystalReport1();
            report.SetDataSource(ds);
            IMPRIMER form = new IMPRIMER();
            (form.Controls["crystalReportViewer1"] as CrystalReportViewer).ReportSource = report;
            form.Show();
        }
    }
    }
