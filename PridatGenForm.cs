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
    public partial class PridatGenForm : Form
    {
        public PridatGenForm()
        {
            InitializeComponent();
        }

        private void PridatGen_Load(object sender, EventArgs e)
        {
            vychoziRozlozeniGenu.DataSource = Program.vychoziRozlozeniGenu;
            vychoziRozlozeniGenu.SelectedIndex = Populace.vlastnosti.vychoziRozlozeniGenu;
            vztahAlel.DataSource = Program.VztahAlel;
            vztahAlel.SelectedIndex = 0;
            nazev.Select();

        }

        private void alelaDom_TextChanged(object sender, EventArgs e)
        {
            if (alelaRec.Text == "") {
                alelaRec.Text = alelaDom.Text.ToLower();
            }
        }

        private void nazev_TextChanged(object sender, EventArgs e)
        {
            if (nazev.Text != "" && alelaDom.Text=="") {
                alelaDom.Text = nazev.Text.Substring(0, 1).ToUpper();
            }
        }

        private void button1_Click_1(object sender, EventArgs e) {
            if (Populace.modelBezi) {
                MessageBox.Show("Nelze přidávat geny do běžícího modelu!", "Chyba");
                return;
            }
            //kontrola zastoupení alel
            int pom = (int)(homDomPom.Value + hetPom.Value + homRecPom.Value);
            if (pom != 1000) {
                DialogResult odpoved = MessageBox.Show("Zastoupení jednotlivých alelových párů nedává dohromady součet 1000! Opravit automaticky?", "Chyba", MessageBoxButtons.YesNo);
                if (odpoved == DialogResult.Yes) {
                    if (pom == 0) {
                        homDomPom.Value = 250;
                        hetPom.Value = 500;
                        homRecPom.Value = 250;
                    } else {
                        homDomPom.Value = Math.Floor(1000 * homDomPom.Value / pom);
                        homRecPom.Value = Math.Floor(1000 * homRecPom.Value / pom);
                        hetPom.Value = 1000 - homDomPom.Value - homRecPom.Value;
                    }
                } else {
                    homDomPom.Select();
                    return;
                }
            }
            if (nazev.Text == "") {
                MessageBox.Show("Vyplňte název!", "Chyba");
                nazev.Select();
                return;
            }
            if (alelaDom.Text == "") {
                MessageBox.Show("Vyplňte dominantní alelu!", "Chyba");
                alelaDom.Select();
                return;
            }
            if (alelaRec.Text=="") {
                MessageBox.Show("Vyplňte recesivní alelu!", "Chyba");
                alelaRec.Select();
                return;
            }
            if (homDom.Text=="" && het.Text=="" && homRec.Text=="") {
                MessageBox.Show("Vyplňte projev alespoň u jedné alely!", "Chyba");
                homDom.Select();
                return;
            }
            new Gen(nazev.Text, alelaDom.Text, alelaRec.Text, vztahAlel.SelectedIndex, homDom.Text, het.Text, homRec.Text, (int)homDomAtr.Value, (int)hetAtr.Value, (int)homRecAtr.Value, (int)homDomPorodnost.Value, (int)hetPorodnost.Value, (int)homRecPorodnost.Value, (int)homDomVek.Value, (int)hetVek.Value, (int)homRecVek.Value, (int)homDomPom.Value, (int)hetPom.Value, (int)homRecPom.Value);
            MessageBox.Show("Gen " + nazev.Text + " byl přidán!", "O.K.");
            this.Close();

        }

        private void button2_Click_1(object sender, EventArgs e) {
            this.Close();

        }

        private void vztahAlel_SelectedIndexChanged(object sender, EventArgs e) {
            
            //nastavit výchozí hodnoty
            homDom.Text = "";
            homRec.Text = "";
            het.Text = "";
            homDomAtr.Value = 0;
            homRecAtr.Value = 0;
            hetAtr.Value = 0;
            homDomPorodnost.Value = 0;
            homRecPorodnost.Value = 0;
            hetPorodnost.Value = 0;
            homDomVek.Value = 0;
            homRecVek.Value = 0;
            hetVek.Value = 0;

            //(de)aktivovat vstupní pole
            switch (vztahAlel.SelectedIndex) {
                case 0:  //"Úplná dominance"
                    tb_a(homDom);
                    tb_a(homRec);
                    tb_d(het);
                    tn_a(homDomAtr);
                    tn_a(homRecAtr);
                    tn_d(hetAtr);
                    tn_a(homDomPorodnost);
                    tn_a(homRecPorodnost);
                    tn_d(hetPorodnost);
                    tn_a(homDomVek);
                    tn_a(homRecVek);
                    tn_d(hetVek);
                    hetAtr.Minimum = -50;
                    hetAtr.Maximum = 50;
                    return;
                case 1:  //"Neúplná dominance"
                    tb_a(homDom);
                    tb_a(homRec);
                    tb_a(het);
                    tn_a(homDomAtr);
                    tn_a(homRecAtr);
                    tn_a(hetAtr);
                    tn_a(homDomPorodnost);
                    tn_a(homRecPorodnost);
                    tn_a(hetPorodnost);
                    tn_a(homDomVek);
                    tn_a(homRecVek);
                    tn_a(hetVek);
                    hetAtr.Minimum = -50;
                    hetAtr.Maximum = 50;
                    return;
                case 2:  //"Kodominance"
                    tb_a(homDom);
                    tb_a(homRec);
                    tb_d(het);
                    tn_a(homDomAtr);
                    tn_a(homRecAtr);
                    tn_d(hetAtr);
                    tn_a(homDomPorodnost);
                    tn_a(homRecPorodnost);
                    tn_d(hetPorodnost);
                    tn_a(homDomVek);
                    tn_a(homRecVek);
                    tn_d(hetVek);
                    hetAtr.Minimum = -100;
                    hetAtr.Maximum = 100;
                    return;
                case 3:  //"Superdominance"
                    tb_a(homDom);
                    tb_d(homRec);
                    tb_a(het);
                    tn_a(homDomAtr);
                    tn_d(homRecAtr);
                    tn_a(hetAtr);
                    tn_a(homDomPorodnost);
                    tn_d(homRecPorodnost);
                    tn_a(hetPorodnost);
                    tn_a(homDomVek);
                    tn_d(homRecVek);
                    tn_a(hetVek);
                    hetAtr.Minimum = -50;
                    hetAtr.Maximum = 50;
                    return;
            }
        }

        /// <summary>"Aktivovat" textbox</summary>
        void tb_a(TextBox t) {
            t.ReadOnly = false;
            t.TabStop = true;
        }
        /// <summary>"Deaktivovat" textbox</summary>
        void tb_d(TextBox t) {
            t.ReadOnly = true;
            t.TabStop = false;
        }

        /// <summary>"Aktivovat" numbox</summary>
        void tn_a(NumericUpDown t) {
            t.ReadOnly = false;
            t.TabStop = true;
        }
        /// <summary>"Deaktivovat" numbox</summary>
        void tn_d(NumericUpDown t) {
            t.ReadOnly = true;
            t.TabStop = false;
        }

        private void alely_TextChanged(object sender, EventArgs e) {
            switch (vztahAlel.SelectedIndex) {
                case 0:  //"Úplná dominance"
                    het.Text = homDom.Text;
                    return;
                case 1:  //"Neúplná dominance"
                    return;
                case 2:  //"Kodominance"
                    het.Text = (homDom.Text == "" || homRec.Text == "") ? (homDom.Text + homRec.Text) : (homDom.Text + ", " + homRec.Text);
                    return;
                case 3:  //"Superdominance"
                    homRec.Text = homDom.Text;
                    return;
            }
        }

        private void atr_ValueChanged(object sender, EventArgs e) {
            switch (vztahAlel.SelectedIndex) {
                case 0:  //"Úplná dominance"
                    hetAtr.Value = homDomAtr.Value;
                    return;
                case 1:  //"Neúplná dominance"
                    return;
                case 2:  //"Kodominance"
                    hetAtr.Value = homDomAtr.Value + homRecAtr.Value;
                    return;
                case 3:  //"Superdominance"
                    homRecAtr.Value = homDomAtr.Value;
                    return;
            }
        }


        private void porodnost_ValueChanged(object sender, EventArgs e) {
            switch (vztahAlel.SelectedIndex) {
                case 0:  //"Úplná dominance"
                    hetPorodnost.Value = homDomPorodnost.Value;
                    return;
                case 1:  //"Neúplná dominance"
                    return;
                case 2:  //"Kodominance"
                    hetPorodnost.Value = homDomPorodnost.Value + homRecPorodnost.Value;
                    return;
                case 3:  //"Superdominance"
                    homRecPorodnost.Value = homDomPorodnost.Value;
                    return;
            }
        }


        private void vek_ValueChanged(object sender, EventArgs e) {
            switch (vztahAlel.SelectedIndex) {
                case 0:  //"Úplná dominance"
                    hetVek.Value = homDomVek.Value;
                    return;
                case 1:  //"Neúplná dominance"
                    return;
                case 2:  //"Kodominance"
                    hetVek.Value = homDomVek.Value + homRecVek.Value;
                    return;
                case 3:  //"Superdominance"
                    homRecVek.Value = homDomVek.Value;
                    return;
            }
        }

        private void vychoziRozlozeniGenu_SelectedIndexChanged(object sender, EventArgs e) {
            int rozlozeni= vychoziRozlozeniGenu.SelectedIndex;
            if (rozlozeni!= 0) {  //rozložení není "vlastní"
                vychoziRozlozeniGenu.Tag = 1;  //zámek - je nastavována předvolba
                homDomPom.Value = Program.vychoziRozlozeniGenuPom[rozlozeni, 0];
                hetPom.Value = Program.vychoziRozlozeniGenuPom[rozlozeni,1];
                homRecPom.Value = Program.vychoziRozlozeniGenuPom[rozlozeni,2];
                vychoziRozlozeniGenu.Tag = 0;  //konec zámku
            }
        }

        private void pom_ValueChanged(object sender, EventArgs e) {
            NumericUpDown vstup = sender as NumericUpDown;
            if ((int)vychoziRozlozeniGenu.Tag == 0) {   //je odemčeno
                vychoziRozlozeniGenu.SelectedIndex = 0;
                if (hw.Checked) {   //přepočet podle H-W 
                    vychoziRozlozeniGenu.Tag = 1;   //zamknout
                    vstup.Tag = 1;  //zamknu si vstup
                    int[] vystup = Program.hw((int)vstup.Value);
                    if ((int)homDomPom.Tag == 0) {  //není zamčen -> není to vstup
                        homDomPom.Value = vystup[0];
                    }
                    else {
                        homRecPom.Value = vystup[0];
                    }
                    hetPom.Value = vystup[1];
                    vstup.Tag = 0;  //konec zámku
                    vychoziRozlozeniGenu.Tag = 0;   //odemknout
                }
            }
        }

        private void hw_CheckedChanged(object sender, EventArgs e) {
            hetPom.Enabled = !hw.Checked;   //při H-W nelze měnit podíl heterozygotů
            if (hw.Checked && (int)vychoziRozlozeniGenu.Tag==0) {   //H-W a odemčený zámek -> přepočíst aktuální hodnoty
                pom_ValueChanged(homDomPom, null);
            }
        }


    }

}
