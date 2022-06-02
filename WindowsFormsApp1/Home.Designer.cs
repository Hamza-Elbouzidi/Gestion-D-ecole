namespace WindowsFormsApp1
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbllTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Evaluation = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Absence = new System.Windows.Forms.Button();
            this.Filiere = new System.Windows.Forms.Button();
            this.matieres = new System.Windows.Forms.Button();
            this.prof = new System.Windows.Forms.Button();
            this.student = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.Evaluation);
            this.panelMenu.Controls.Add(this.Exit);
            this.panelMenu.Controls.Add(this.Absence);
            this.panelMenu.Controls.Add(this.Filiere);
            this.panelMenu.Controls.Add(this.matieres);
            this.panelMenu.Controls.Add(this.prof);
            this.panelMenu.Controls.Add(this.student);
            this.panelMenu.Controls.Add(this.Login);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(195, 804);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.btnMini);
            this.panelTitle.Controls.Add(this.btnMax);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.lbllTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(195, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1107, 80);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMini
            // 
            this.btnMini.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMini.ForeColor = System.Drawing.Color.White;
            this.btnMini.Location = new System.Drawing.Point(1017, 0);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(30, 80);
            this.btnMini.TabIndex = 3;
            this.btnMini.Text = "_";
            this.btnMini.UseVisualStyleBackColor = true;
            this.btnMini.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMax
            // 
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(1047, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(30, 80);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "O";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1077, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 80);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lbllTitle
            // 
            this.lbllTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbllTitle.AutoSize = true;
            this.lbllTitle.Font = new System.Drawing.Font("Nirmala UI", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllTitle.ForeColor = System.Drawing.Color.White;
            this.lbllTitle.Location = new System.Drawing.Point(444, 21);
            this.lbllTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllTitle.Name = "lbllTitle";
            this.lbllTitle.Size = new System.Drawing.Size(127, 47);
            this.lbllTitle.TabIndex = 0;
            this.lbllTitle.Text = "HOME";
            this.lbllTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(195, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 724);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.shudhangshu_malakar_education_school_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1103, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Evaluation
            // 
            this.Evaluation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Evaluation.FlatAppearance.BorderSize = 0;
            this.Evaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Evaluation.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Evaluation.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Evaluation.Image = global::WindowsFormsApp1.Properties.Resources.icons8_report_card_32;
            this.Evaluation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Evaluation.Location = new System.Drawing.Point(2, 427);
            this.Evaluation.Margin = new System.Windows.Forms.Padding(2);
            this.Evaluation.Name = "Evaluation";
            this.Evaluation.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.Evaluation.Size = new System.Drawing.Size(207, 96);
            this.Evaluation.TabIndex = 8;
            this.Evaluation.Text = "Evaluation";
            this.Evaluation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Evaluation.UseVisualStyleBackColor = true;
            this.Evaluation.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Exit.Image = global::WindowsFormsApp1.Properties.Resources.icons8_exit_sign_32;
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.Location = new System.Drawing.Point(2, 705);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.Exit.Size = new System.Drawing.Size(207, 79);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "  Exit";
            this.Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Absence
            // 
            this.Absence.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Absence.FlatAppearance.BorderSize = 0;
            this.Absence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Absence.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Absence.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Absence.Image = global::WindowsFormsApp1.Properties.Resources.icons8_bank_card_missing_32;
            this.Absence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Absence.Location = new System.Drawing.Point(2, 628);
            this.Absence.Margin = new System.Windows.Forms.Padding(2);
            this.Absence.Name = "Absence";
            this.Absence.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.Absence.Size = new System.Drawing.Size(207, 73);
            this.Absence.TabIndex = 6;
            this.Absence.Text = "  Absence";
            this.Absence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Absence.UseVisualStyleBackColor = true;
            this.Absence.Click += new System.EventHandler(this.Absence_Click);
            // 
            // Filiere
            // 
            this.Filiere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Filiere.FlatAppearance.BorderSize = 0;
            this.Filiere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filiere.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filiere.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Filiere.Image = global::WindowsFormsApp1.Properties.Resources.icons8_merge_git_32;
            this.Filiere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Filiere.Location = new System.Drawing.Point(2, 528);
            this.Filiere.Margin = new System.Windows.Forms.Padding(2);
            this.Filiere.Name = "Filiere";
            this.Filiere.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.Filiere.Size = new System.Drawing.Size(207, 96);
            this.Filiere.TabIndex = 5;
            this.Filiere.Text = "  Filiere";
            this.Filiere.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Filiere.UseVisualStyleBackColor = true;
            this.Filiere.Click += new System.EventHandler(this.Filiere_Click);
            // 
            // matieres
            // 
            this.matieres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.matieres.FlatAppearance.BorderSize = 0;
            this.matieres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matieres.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matieres.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.matieres.Image = global::WindowsFormsApp1.Properties.Resources.icons8_view_module_32;
            this.matieres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.matieres.Location = new System.Drawing.Point(2, 328);
            this.matieres.Margin = new System.Windows.Forms.Padding(2);
            this.matieres.Name = "matieres";
            this.matieres.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.matieres.Size = new System.Drawing.Size(207, 96);
            this.matieres.TabIndex = 4;
            this.matieres.Text = "  Matieres";
            this.matieres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.matieres.UseVisualStyleBackColor = true;
            this.matieres.Click += new System.EventHandler(this.matieres_Click);
            // 
            // prof
            // 
            this.prof.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prof.FlatAppearance.BorderSize = 0;
            this.prof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prof.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prof.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.prof.Image = global::WindowsFormsApp1.Properties.Resources.icons8_training_32;
            this.prof.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prof.Location = new System.Drawing.Point(2, 228);
            this.prof.Margin = new System.Windows.Forms.Padding(2);
            this.prof.Name = "prof";
            this.prof.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.prof.Size = new System.Drawing.Size(207, 96);
            this.prof.TabIndex = 3;
            this.prof.Text = "  Professeurs";
            this.prof.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.prof.UseVisualStyleBackColor = true;
            this.prof.Click += new System.EventHandler(this.prof_Click);
            // 
            // student
            // 
            this.student.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.student.FlatAppearance.BorderSize = 0;
            this.student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.student.Image = global::WindowsFormsApp1.Properties.Resources.icons8_student_center_32;
            this.student.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.student.Location = new System.Drawing.Point(2, 127);
            this.student.Margin = new System.Windows.Forms.Padding(2);
            this.student.Name = "student";
            this.student.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.student.Size = new System.Drawing.Size(207, 96);
            this.student.TabIndex = 2;
            this.student.Text = "  Etudiant";
            this.student.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.student.UseVisualStyleBackColor = true;
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // Login
            // 
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Login.Image = global::WindowsFormsApp1.Properties.Resources.icons8_login_32;
            this.Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login.Location = new System.Drawing.Point(2, 28);
            this.Login.Margin = new System.Windows.Forms.Padding(2);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.Login.Size = new System.Drawing.Size(207, 96);
            this.Login.TabIndex = 1;
            this.Login.Text = "  Login";
            this.Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1302, 804);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lbllTitle;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button Absence;
        public System.Windows.Forms.Button Filiere;
        public System.Windows.Forms.Button matieres;
        public System.Windows.Forms.Button prof;
        public System.Windows.Forms.Button student;
        public System.Windows.Forms.Button Evaluation;
        public System.Windows.Forms.Button Login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

