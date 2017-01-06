using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RURGenetika {
    public partial class JedinciForm: Form {
        public JedinciForm() {
            InitializeComponent();
        }
        private void obnovit(object sender, EventArgs e) {
            obnovit();
        }

        public void obnovit() {
            zobrazitJedince();
        }

        private void JedinciForm_FormClosed(object sender, FormClosedEventArgs e) {
            Program.jedinciForm = null;
        }

        private void JedinciForm_Load(object sender, EventArgs e) {
            zobrazit.DataSource = Program.moznostiZobrazeniJedincu;
            zobrazit.SelectedIndex = 2;
            obnovit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            obnovit();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        public void zobrazitJedince() {
            panel.Controls.Clear();
            if (Populace.jedinci.pocet < 2) {
                vypsatNaPanel("naživu nejsou žádní jedinci");
            } else {
                switch (zobrazit.SelectedIndex) {
                    case 0: //genotypy
                        for (int hash = 0; hash < Populace.sledovaneGenyPocetNaTreti; hash++) {
                            vypsatNaPanel(new Genotyp(hash).ToString() + ": " + Populace.sledovaneGenotypy[hash].ToString("N0") + " (" + (Populace.sledovaneGenotypy[hash] * 100 / Populace.jedinci.pocet) + "%)");
                        }
                        break;
                    case 1: //alelové páry
                        int[,] pary = new int[Populace.sledovaneGenyPocet, 3];   //pary[gen,typ]
                        for (int hash = 0; hash < Populace.sledovaneGenyPocetNaTreti; hash++) {
                            Genotyp genotyp = new Genotyp(hash);
                            for (int gen = 0; gen < Populace.sledovaneGenyPocet; gen++) {
                                pary[gen, genotyp.pary[gen].ToInt()] += Populace.sledovaneGenotypy[hash];
                            }
                        }
                        for (int gen = 0; gen < Populace.sledovaneGenyPocet; gen++) {
                            vypsatNaPanel(Populace.sledovaneGenyPole[gen].ToString() + ": ",true);
                            for (int typ = 0; typ < 3; typ++) {
                                vypsatNaPanel(new AlelovyPar(Populace.sledovaneGenyPole[gen], (AlelovyPar.Typ)typ).ToString() + ": " + pary[gen, typ].ToString("N0") + " (" + (pary[gen, typ] * 100 / Populace.jedinci.pocet) + "%)");
                            }
                        }
                        break;
                    case 2: //fenotypy
                        Populace.sledovaneFenotypy = new int[Populace.sledovaneGenyPocetNaTreti];
                        for (int hash = 0; hash < Populace.sledovaneGenyPocetNaTreti; hash++) {
                            Populace.sledovaneFenotypy[new Genotyp(hash).ToFenotypInt()] += Populace.sledovaneGenotypy[hash];
                        }
                        for (int hash = 0; hash < Populace.sledovaneGenyPocetNaTreti; hash++) {
                            if (Populace.sledovaneFenotypy[hash]>0) {
                                vypsatNaPanel(new Genotyp(hash).ToFenotyp() + ": " + Populace.sledovaneFenotypy[hash].ToString("N0") + " (" + (Populace.sledovaneFenotypy[hash] * 100 / Populace.jedinci.pocet) + "%)");
                            }
                        }
                        break;
                    case 3: //znaky
                        int[,] znaky = new int[Populace.sledovaneGenyPocet, 3];   //znaky[gen,typ]
                        //naplní pole Populace.sledovaneFenotypy
                        Populace.sledovaneFenotypy = new int[Populace.sledovaneGenyPocetNaTreti];
                        for (int hash = 0; hash < Populace.sledovaneGenyPocetNaTreti; hash++) {
                            Populace.sledovaneFenotypy[new Genotyp(hash).ToFenotypInt()] += Populace.sledovaneGenotypy[hash];
                        }
                        for (int hash = 0; hash < Populace.sledovaneGenyPocetNaTreti; hash++) {
                            Genotyp genotyp = new Genotyp(hash);
                            for (int gen = 0; gen < Populace.sledovaneGenyPocet; gen++) {
                                znaky[gen, genotyp.pary[gen].ToZnakInt()] += Populace.sledovaneFenotypy[hash];
                            }
                        }
                        for (int gen = 0; gen < Populace.sledovaneGenyPocet; gen++) {
                            vypsatNaPanel(Populace.sledovaneGenyPole[gen].ToString() + ": ", true);
                            for (int typ = 0; typ < 3; typ++) {
                                if (znaky[gen, typ] > 0) {
                                    vypsatNaPanel(new AlelovyPar(Populace.sledovaneGenyPole[gen], (AlelovyPar.Typ)typ).ToZnak() + ": " + znaky[gen, typ].ToString("N0") + " (" + (znaky[gen, typ] * 100 / Populace.jedinci.pocet) + "%)");
                                }
                            }
                        }
                        break;
                    case 4: //genotypy i fenotypy
                        Genotyp g;
                        for (int hash = 0; hash < Populace.sledovaneGenyPocetNaTreti; hash++) {
                            g = new Genotyp(hash);
                            vypsatNaPanel(g.ToString() + ": " + Populace.sledovaneGenotypy[hash].ToString("N0") + " (" + (Populace.sledovaneGenotypy[hash] * 100 / Populace.jedinci.pocet) + "%) - " + g.ToFenotyp());
                        }
                        break;
                    case 5: //jednotliví jedinci
                        Jedinec jedinec = Populace.jedinci.posledni;
                        for (int i = 0; i < Populace.jedinci.pocet; i++) {
                            jedinec = jedinec.dalsi;
                            vypsatNaPanel(jedinec.genotyp.ToString() + " - " + jedinec.genotyp.ToFenotyp() + ". Věk " + (Populace.cas - jedinec.narozeni) + " let, " + (jedinec.partner == null ? "sám" : "zadaný") + ", už měl " + jedinec.pocetPartneru.ToString("N0") + " partnerů. Atraktivita: " + jedinec.atraktivita + ", délka života: " + jedinec.delkaZivota);
                        }
                        break;
                    case 6: //50 jedinců
                        jedinec = Populace.jedinci.posledni;
                        //Jedinec jedinec = Populace.jedinci.posledni;
                        for (int i = 0; i < Math.Min(50,Populace.jedinci.pocet); i++) {
                            jedinec = jedinec.dalsi;
                            vypsatNaPanel(jedinec.genotyp.ToString() + " - " + jedinec.genotyp.ToFenotyp() + ". Věk " + (Populace.cas - jedinec.narozeni) + " let, " + (jedinec.partner == null ? "sám" : "zadaný") + ", už měl " + jedinec.pocetPartneru.ToString("N0") + " partnerů. Atraktivita: " + jedinec.atraktivita + ", délka života: " + jedinec.delkaZivota);
                        }
                        break;
                    default:
                        MessageBox.Show("špatný typ - zobrazitJedince!");
                        break;
                }
            }
            pocetJedincu.Text = pocetJedincu.Tag + Populace.jedinci.pocet.ToString("N0");
        }

        void vypsatNaPanel(string text) {
            vypsatNaPanel(text, false);
        }
        void vypsatNaPanel(string text,bool tucne) {
            Label vystup = new Label();
            vystup.Text = text;
            vystup.AutoSize = true;
            if (tucne) vystup.Font = new Font(vystup.Font, FontStyle.Bold);
            vystup.Parent = panel;
        }

    }

}
