using System;
//using System.Linq;
using System.Windows.Forms;

namespace RURGenetika {
    public partial class ZadejtePocetForm: Form {
        public ZadejtePocetForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int cislo;
            if (int.TryParse(pocet.Text, System.Globalization.NumberStyles.AllowThousands, System.Globalization.CultureInfo.CurrentCulture, out cislo)) {
                this.Close();
                Program.ZadejtePocet.proved(cislo);
            } else {
                MessageBox.Show("Zadejte počet kroků!","Chyba");
                pocet.Select();
            }
        }

        private void ZadejtePocetForm_Load(object sender, EventArgs e) {
            switch (Program.ZadejtePocet.akce) {
                case Program.ZadejtePocet.Akce.krok:
                    label1.Text = "Počet kroků:";
                    this.Text = "Zadejte počet kroků";
                    break;
                default:
                    break;
            }
            pocet.Select();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void pocet_Leave(object sender, EventArgs e) {
            int temp;
            if (!int.TryParse(pocet.Text, System.Globalization.NumberStyles.AllowThousands, System.Globalization.CultureInfo.CurrentCulture, out temp) || temp == 0) { pocet.Text = "1"; }
        }
    }
}
