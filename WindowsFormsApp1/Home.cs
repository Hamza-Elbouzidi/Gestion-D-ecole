using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
       
        private Random random;
      
        private Form activeForm;
       

        public Home()
        {
            InitializeComponent();
            random = new Random();
            this.Text =String.Empty;
            this.ControlBox = false;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /*
        private Color SelectThemeColor()
        {
            int index = random.Next(Themecolor.ColorList.Count);
            while (tempIndex == index){
                index = random.Next(Themecolor.ColorList.Count);
            }
                tempIndex = index;
                string color = Themecolor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender) {
            if (btnSender != null)
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Nirmala UI", 11.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    //panelLogo.BackColor = Themecolor.ChangeColorBrightness(color , -0.3);
                }
         }
        */
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor= Color.White;
                    previousBtn.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                
            }
        }

        // Desactivation des Buttons de Navigation //
        private void Form1_Load(object sender, EventArgs e)
        {

            student.Enabled = false;
            prof.Enabled = false;
            Absence.Enabled = false;
            matieres.Enabled = false;
            Filiere.Enabled = false;
            Evaluation.Enabled = false;
            

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                 activeForm.Close();
            }
          //  ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(childForm);
            this.panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbllTitle.Text = childForm. Text;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.Login(), sender);
            Login lg = new Login(this);
            lg.Show();
        }

        private void student_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEtudiant(),sender);

        }

        private void prof_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Professeur(), sender);

        }

        private void matieres_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Matiere(), sender);

        }

        private void Filiere_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.filiere(), sender);

        }

        private void Absence_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Absence(), sender);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Evaluation(), sender);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
