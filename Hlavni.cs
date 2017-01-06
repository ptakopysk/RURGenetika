using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RURGenetika {
    public partial class Hlavni: Form {

        public Hlavni() {
            InitializeComponent();
            Program.hlavniForm = this;
        }

        private void přidatGenToolStripMenuItem_Click(object sender, EventArgs e) {
            PridatGenForm pridatGenForm = new PridatGenForm();
            pridatGenForm.Show();
        }

        private void sledovanéGenyToolStripMenuItem_Click(object sender, EventArgs e) {
            Program.aktivujForm(ref Program.sledovaneGenyForm);
        }

        private void nováPopulaceToolStripMenuItem_Click(object sender, EventArgs e) {
            Populace.nova();
        }

        private void vlastnostiPopulaceToolStripMenuItem_Click(object sender, EventArgs e) {
            Program.aktivujForm(ref Program.vlastnostiPopulaceForm);
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBoxForm aboutBoxForm = new AboutBoxForm();
            aboutBoxForm.Show();
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void problémSFormátemČíselToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Váš nastavneý jazyk je " + System.Globalization.CultureInfo.CurrentCulture.NativeName + ", proto používejte pro zápis čísel způsob obvyklý v tomto jazyce a zemi.", "Informace");
        }

        private void jinéToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Napište mi e-mail na rur@seznam.cz.");
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Populace.sledovaneGeny.Count == 0) {
                MessageBox.Show("Nejsou zadány žádné sledované geny!", "Chyba!");
                PridatGenForm pridatGenForm = new PridatGenForm();
                pridatGenForm.Show();
                return;
            }
            if (MessageBox.Show("Model bude spuštěn od začátku. Pokračovat?", "Spustit model", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                Populace.modelSpustit();
            }
        }

        private void jedinciToolStripMenuItem_Click(object sender, EventArgs e) {
            Program.aktivujForm(ref Program.jedinciForm);
        }

        public void obnovit() {
            pocetJedincu.Text = pocetJedincu.Tag + Populace.jedinci.pocet.ToString("N0");
            cas.Text = cas.Tag + Populace.cas.ToString("N0");
            //menu
            přidatGenToolStripMenuItem.Enabled = !(Populace.modelBezi);
            krokToolStripMenuItem.Enabled = Populace.modelBezi;
            zastavitModelToolStripMenuItem.Enabled = Populace.modelBezi;
            víceKrokůToolStripMenuItem.Enabled = Populace.modelBezi;
            jedenkrokToolStripMenuItem.Enabled = Populace.modelBezi;
        }

        public void obnovitRychle(){
            pocetJedincu.Text = pocetJedincu.Tag + Populace.jedinci.pocet.ToString();
            cas.Text = cas.Tag + Populace.cas.ToString();
        }

        private void zastavitModelToolStripMenuItem_Click(object sender, EventArgs e) {
            Populace.modelZastavit();
        }

        private void jedenkrokToolStripMenuItem_Click(object sender, EventArgs e) {
            Populace.modelKrok();
        }

        private void víceKrokůToolStripMenuItem_Click(object sender, EventArgs e) {
            Program.ZadejtePocet.zadat(Program.ZadejtePocet.Akce.krok);
        }

        private void Hlavni_Load(object sender, EventArgs e) {
            obnovit();
        }

        private void restartovatToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            Application.Restart();
        }

    }

}
