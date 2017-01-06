using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RURGenetika
{
    public partial class SledovaneGenyForm : Form
    {
        public SledovaneGenyForm()
        {
            InitializeComponent();
        }

        private void SledovaneGeny_Activated(object sender, EventArgs e) {
            obnovit();
        }

        public void obnovit() {
            zobrazitSledovaneGeny();
        }

        private void SledovaneGenyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.sledovaneGenyForm = null;
        }

        public void zobrazitSledovaneGeny() {
            panel.Controls.Clear();
            if (Populace.sledovaneGeny.Count == 0) {
                vypsatNaPanel("nejsou vloženy žádné geny ke sledování");
            } else {
                for (int i = 0; i < Populace.sledovaneGeny.Count; i++) {
                    vypsatGen(Populace.sledovaneGeny[i]);
                }
            }
            pocetSledovanychGenu.Text = pocetSledovanychGenu.Tag + Populace.sledovaneGeny.Count.ToString("N0");
        }

        void vypsatGen(Gen gen) {
            FlowLayoutPanel p = new FlowLayoutPanel();
            p.AutoSize = true;
            vypsatNaPanel(p, gen.nazev + ":", true);
            vypsatNaPanel(p, gen.alelaDom + ", " + gen.alelaRec + " - " + Program.VztahAlel[gen.vztahAlel] + " (" + gen.expr[1] + " / " + gen.expr[0] + " / " + gen.expr[2] + ")");
            odstranitGenNaPanel(p, gen);
            p.Parent = panel;
        }

        void odstranitGenNaPanel() {
            odstranitGenNaPanel(panel);
        }
        void odstranitGenNaPanel(FlowLayoutPanel panel) {
            odstranitGenNaPanel(panel, null);
        }
        void odstranitGenNaPanel(FlowLayoutPanel panel, Gen gen) {
            PictureBox obrazek = new PictureBox();
            obrazek.Image = global::RURGenetika.Obrazky.Recycle;
            obrazek.Size = new System.Drawing.Size(18, 18);
            obrazek.Margin = new Padding(0);
            obrazek.Tag = gen;
            obrazek.TabStop = true;
            obrazek.Click += new EventHandler(this.odstranitGen);
            obrazek.Parent = panel;
            toolTip1.SetToolTip(obrazek, "odstranit gen " + gen.ToString());
        }

        void vypsatNaPanel(string text) {
            vypsatNaPanel(panel, text, false);
        }
        void vypsatNaPanel(string text, bool tucne) {
            vypsatNaPanel(panel, text, tucne);
        }
        void vypsatNaPanel(FlowLayoutPanel panel, string text) {
            vypsatNaPanel(panel, text, false);
        }
        void vypsatNaPanel(FlowLayoutPanel panel, string text, bool tucne) {
            Label vystup = new Label();
            vystup.Text = text;
            vystup.AutoSize = true;
            if (tucne) vystup.Font = new Font(vystup.Font, FontStyle.Bold);
            vystup.Parent = panel;
        }

        void odstranitGen(object sender, EventArgs e) {
            if (Populace.modelBezi) {
                MessageBox.Show("Nelze odstraňovat geny z běžícího modelu!", "Chyba");
            } else {
                Control s = sender as Control;
                if (MessageBox.Show("Odstranit gen " + s.Tag.ToString() + "?", "Odstranit gen", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    Gen gen = s.Tag as Gen;
                    Populace.sledovaneGeny.Remove(gen);
                    obnovit();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }


    }
}
