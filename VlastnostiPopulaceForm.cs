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
    public partial class VlastnostiPopulaceForm : Form
    {
        public VlastnostiPopulaceForm()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VlastnostiPopulaceForm_Load(object sender, EventArgs e)
        {
            vychoziRozlozeniGenu.DataSource = Program.vychoziRozlozeniGenu;
            vychoziRozlozeniGenu.SelectedIndex=Populace.vlastnosti.vychoziRozlozeniGenu;
            
            pocetJedincu.Value = Populace.vlastnosti.vychoziPocetJedincu;
            maxPocetJedincu.Value = Populace.vlastnosti.maxPocetJedincu;
            delkaZivota.Value = Populace.vlastnosti.prumernaDelkaZivota;
            porodnost.Value = Populace.vlastnosti.porodnost;
            vernost.Value = Populace.vlastnosti.vernost;
            sexinterval.Value = Populace.vlastnosti.sexInterval;
            dospelost.Value = Populace.vlastnosti.dospelost;
            vybiravost.Value = Populace.vlastnosti.vybiravost;
            mutace.Value = Populace.vlastnosti.pravdepodobnostMutace;
            
            pocetJedincu.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //počet jedinců
            Populace.vlastnosti.vychoziRozlozeniGenu = vychoziRozlozeniGenu.SelectedIndex;

            Populace.vlastnosti.vychoziPocetJedincu = (int)pocetJedincu.Value;
            Populace.vlastnosti.prumernaDelkaZivota = (int)delkaZivota.Value;
            Populace.vlastnosti.porodnost = (int)porodnost.Value;
            Populace.vlastnosti.vernost = (int)vernost.Value;
            Populace.vlastnosti.sexInterval = (int)sexinterval.Value;
            Populace.vlastnosti.dospelost = (int)dospelost.Value;
            Populace.vlastnosti.maxPocetJedincu = (int)maxPocetJedincu.Value;
            Populace.vlastnosti.vybiravost = (int)vybiravost.Value;
            Populace.vlastnosti.pravdepodobnostMutace = (int)mutace.Value;

            Close();
        }

        private void VlastnostiPopulaceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.vlastnostiPopulaceForm = null;
        }


    }
}
