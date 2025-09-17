namespace BATONNETS_DE_FORT_BOYARD
{
    partial class Accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labJeuFortBoyard = new Label();
            btConnexion = new Button();
            btnInscription = new Button();
            SuspendLayout();
            // 
            // labJeuFortBoyard
            // 
            labJeuFortBoyard.AutoSize = true;
            labJeuFortBoyard.Location = new Point(42, 34);
            labJeuFortBoyard.Name = "labJeuFortBoyard";
            labJeuFortBoyard.Size = new Size(383, 32);
            labJeuFortBoyard.TabIndex = 0;
            labJeuFortBoyard.Text = "Le jeu des bâtonnet de FortBoyard";
            // 
            // btConnexion
            // 
            btConnexion.Location = new Point(56, 123);
            btConnexion.Name = "btConnexion";
            btConnexion.Size = new Size(150, 46);
            btConnexion.TabIndex = 1;
            btConnexion.Text = "Connexion";
            btConnexion.UseVisualStyleBackColor = true;
            // 
            // btnInscription
            // 
            btnInscription.Location = new Point(227, 123);
            btnInscription.Name = "btnInscription";
            btnInscription.Size = new Size(150, 46);
            btnInscription.TabIndex = 2;
            btnInscription.Text = "Inscription";
            btnInscription.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 200);
            Controls.Add(btnInscription);
            Controls.Add(btConnexion);
            Controls.Add(labJeuFortBoyard);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labJeuFortBoyard;
        private Button btConnexion;
        private Button btnInscription;
    }
}
