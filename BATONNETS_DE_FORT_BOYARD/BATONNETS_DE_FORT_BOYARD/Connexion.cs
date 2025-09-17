using BATONNETS_DE_FORT_BOYARD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BATONNETS_DE_FORT_BOYARD
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using FortBoyardRomainMathisContext db = new FortBoyardRomainMathisContext();
                Compte compte = new Compte();

                string VerifyPassword = db.Comptes.Where(o => o.Pseudo == Txt_UserName.Text).ToString();
                if (compte.MotDePasse(VerifyPassword) == HashPassword.Hash(Txt_Password.Text))
                {
                    MessageBox.Show("Test OK");
                }

            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}