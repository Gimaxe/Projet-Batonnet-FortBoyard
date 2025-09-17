namespace BATONNETS_DE_FORT_BOYARD
{
    partial class PageRejoindrePartie
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
            labNomPartie = new Label();
            textBox1 = new TextBox();
            labCodePartie = new Label();
            btnRejoidrePartie = new Button();
            SuspendLayout();
            // 
            // labNomPartie
            // 
            labNomPartie.AutoSize = true;
            labNomPartie.Location = new Point(301, 47);
            labNomPartie.Name = "labNomPartie";
            labNomPartie.Size = new Size(223, 32);
            labNomPartie.TabIndex = 0;
            labNomPartie.Text = "Rejoindre la Partie *";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(404, 207);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 1;
            // 
            // labCodePartie
            // 
            labCodePartie.AutoSize = true;
            labCodePartie.Location = new Point(161, 200);
            labCodePartie.Name = "labCodePartie";
            labCodePartie.Size = new Size(184, 32);
            labCodePartie.TabIndex = 2;
            labCodePartie.Text = "Code de partie :";
            // 
            // btnRejoidrePartie
            // 
            btnRejoidrePartie.Location = new Point(175, 308);
            btnRejoidrePartie.Name = "btnRejoidrePartie";
            btnRejoidrePartie.Size = new Size(270, 46);
            btnRejoidrePartie.TabIndex = 3;
            btnRejoidrePartie.Text = "Rejoindre la partie";
            btnRejoidrePartie.UseVisualStyleBackColor = true;
            // 
            // PageRejoindrePartie
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRejoidrePartie);
            Controls.Add(labCodePartie);
            Controls.Add(textBox1);
            Controls.Add(labNomPartie);
            Name = "PageRejoindrePartie";
            Text = "PageRejoindrePartie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labNomPartie;
        private TextBox textBox1;
        private Label labCodePartie;
        private Button btnRejoidrePartie;
    }
}