namespace BATONNETS_DE_FORT_BOYARD
{
    partial class PagePartie
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
            labJoueur1 = new Label();
            labJoueur2 = new Label();
            labNombresBatons = new Label();
            btn1Baton = new Button();
            btn2Baton = new Button();
            btn3Baton = new Button();
            labNomJoueur1 = new Label();
            labNomJoueur2 = new Label();
            labBatonRestant = new Label();
            labSelectionnerNombreBaton = new Label();
            SuspendLayout();
            // 
            // labJoueur1
            // 
            labJoueur1.AutoSize = true;
            labJoueur1.Location = new Point(44, 19);
            labJoueur1.Name = "labJoueur1";
            labJoueur1.Size = new Size(118, 32);
            labJoueur1.TabIndex = 0;
            labJoueur1.Text = "Joueur 1 :";
            // 
            // labJoueur2
            // 
            labJoueur2.AutoSize = true;
            labJoueur2.Location = new Point(591, 19);
            labJoueur2.Name = "labJoueur2";
            labJoueur2.Size = new Size(118, 32);
            labJoueur2.TabIndex = 1;
            labJoueur2.Text = "Joueur 2 :";
            // 
            // labNombresBatons
            // 
            labNombresBatons.AutoSize = true;
            labNombresBatons.Location = new Point(218, 135);
            labNombresBatons.Name = "labNombresBatons";
            labNombresBatons.Size = new Size(317, 32);
            labNombresBatons.TabIndex = 2;
            labNombresBatons.Text = "Nombre de bâtons restants :";
            // 
            // btn1Baton
            // 
            btn1Baton.Location = new Point(79, 297);
            btn1Baton.Name = "btn1Baton";
            btn1Baton.Size = new Size(150, 46);
            btn1Baton.TabIndex = 3;
            btn1Baton.Text = "1 Bâton";
            btn1Baton.UseVisualStyleBackColor = true;
            // 
            // btn2Baton
            // 
            btn2Baton.Location = new Point(309, 297);
            btn2Baton.Name = "btn2Baton";
            btn2Baton.Size = new Size(150, 46);
            btn2Baton.TabIndex = 4;
            btn2Baton.Text = "2 Bâtons";
            btn2Baton.UseVisualStyleBackColor = true;
            // 
            // btn3Baton
            // 
            btn3Baton.Location = new Point(547, 297);
            btn3Baton.Name = "btn3Baton";
            btn3Baton.Size = new Size(150, 46);
            btn3Baton.TabIndex = 5;
            btn3Baton.Text = "3 Bâtons";
            btn3Baton.UseVisualStyleBackColor = true;
            // 
            // labNomJoueur1
            // 
            labNomJoueur1.AutoSize = true;
            labNomJoueur1.Location = new Point(44, 61);
            labNomJoueur1.Name = "labNomJoueur1";
            labNomJoueur1.Size = new Size(106, 32);
            labNomJoueur1.TabIndex = 6;
            labNomJoueur1.Text = "Joueur 1";
            // 
            // labNomJoueur2
            // 
            labNomJoueur2.AutoSize = true;
            labNomJoueur2.Location = new Point(591, 61);
            labNomJoueur2.Name = "labNomJoueur2";
            labNomJoueur2.Size = new Size(106, 32);
            labNomJoueur2.TabIndex = 7;
            labNomJoueur2.Text = "Joueur 2";
            // 
            // labBatonRestant
            // 
            labBatonRestant.AutoSize = true;
            labBatonRestant.Location = new Point(344, 186);
            labBatonRestant.Name = "labBatonRestant";
            labBatonRestant.Size = new Size(40, 32);
            labBatonRestant.TabIndex = 8;
            labBatonRestant.Text = "15";
            // 
            // labSelectionnerNombreBaton
            // 
            labSelectionnerNombreBaton.AutoSize = true;
            labSelectionnerNombreBaton.Location = new Point(12, 247);
            labSelectionnerNombreBaton.Name = "labSelectionnerNombreBaton";
            labSelectionnerNombreBaton.Size = new Size(494, 32);
            labSelectionnerNombreBaton.TabIndex = 9;
            labSelectionnerNombreBaton.Text = "Séléctionner le nombre de bâtons a enlever :";
            // 
            // PagePartie
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 365);
            Controls.Add(labSelectionnerNombreBaton);
            Controls.Add(labBatonRestant);
            Controls.Add(labNomJoueur2);
            Controls.Add(labNomJoueur1);
            Controls.Add(btn3Baton);
            Controls.Add(btn2Baton);
            Controls.Add(btn1Baton);
            Controls.Add(labNombresBatons);
            Controls.Add(labJoueur2);
            Controls.Add(labJoueur1);
            Name = "PagePartie";
            Text = "PagePartie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labJoueur1;
        private Label labJoueur2;
        private Label labNombresBatons;
        private Button btn1Baton;
        private Button btn2Baton;
        private Button btn3Baton;
        private Label labNomJoueur1;
        private Label labNomJoueur2;
        private Label labBatonRestant;
        private Label labSelectionnerNombreBaton;
    }
}