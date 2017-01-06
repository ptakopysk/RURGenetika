using System;
using System.Collections.Generic;
//using System.Linq;
using System.Windows.Forms;

namespace RURGenetika
{
    static class Program {
        
        #region Main()
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += osetriVyjimku;
            AppDomain.CurrentDomain.UnhandledException += osetriVyjimku;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Hlavni());
        }
        #endregion

        #region Formy

        #region Ukazatelé na Formy

        public static Hlavni hlavniForm;
        public static SledovaneGenyForm sledovaneGenyForm;
        //public static PridatGenForm pridatGenForm;
        public static VlastnostiPopulaceForm vlastnostiPopulaceForm;
        public static JedinciForm jedinciForm;
        //public static ZadejtePocetForm zadejtePocetForm;

        #endregion

        #region Metody pro aktivaci Formů

        /// <summary>aktivuje daný form</summary>
        public static void aktivujForm(ref Hlavni form) { if (form == null) { form = new Hlavni(); form.Show(); } else { form.Focus(); } }
        public static void aktivujForm(ref SledovaneGenyForm form) { if (form == null) { form = new SledovaneGenyForm(); form.Show(); } else { form.Focus(); } }
        public static void aktivujForm(ref PridatGenForm form) { if (form == null) { form = new PridatGenForm(); form.Show(); } else { form.Focus(); } }
        public static void aktivujForm(ref VlastnostiPopulaceForm form) { if (form == null) { form = new VlastnostiPopulaceForm(); form.Show(); } else { form.Focus(); } }
        public static void aktivujForm(ref JedinciForm form) { if (form == null) { form = new JedinciForm(); form.Show(); } else { form.Focus(); } }
        //public static void aktivujForm(ref  form) { if (form == null) { form = new (); form.Show(); } else { form.Focus(); } }

        public static void obnovitSledovaneGenyForm()
        {
            if (sledovaneGenyForm != null)
            {
                sledovaneGenyForm.obnovit();
            }
        }

        public static void obnovitJedinciForm() {
            if (jedinciForm != null) {
                jedinciForm.obnovit();
            }
        }

        #endregion

        /// <summary>nechá uživatele zadat počet a provede s ním vybranou akci</summary>
        public static class ZadejtePocet {
            public enum Akce { krok };
            public static Akce akce;
            public static void zadat(Akce a) {
                akce = a;
                ZadejtePocetForm zadejtePocetForm = new ZadejtePocetForm();
                zadejtePocetForm.Show();
            }
            public static void proved(int pocet) {
                switch (akce) {
                    case Akce.krok:
                        Populace.modelKrok(pocet);
                        break;
                    default:
                        break;
                }
            }
        }
        
        #endregion

        #region Datové zdroje
        //některé stringy, které jsou používány v programu a které je pohodlné mít v poli

        /// <summary>předvolby: jakým způsobem se mají při inicializaci modelu rozložit alely genů - pole, využívají se indexy položek - viz druhý řádek</summary>
        public static string[] vychoziRozlozeniGenu = { "Vlastní rozložení...", "Homozygotní populace (P)", "Uniformní heterozygotní populace (F1)", "Typické rovnoměrné rozložení - preference heterozygotů (F2)" };
        //                                               0                       1                           2                                        3
        /// <summary>poměry distribuce alel příslušící jednotlivým předvolbám</summary>
        public static int[,] vychoziRozlozeniGenuPom ={ {0,0,0},                {500,0,500},                {0,1000,0},                              {250,500,250}                                                 };

        /// <summary>zobrazení jedinců - pole, využívají se indexy položek - viz druhý řádek</summary>
        public static string[] moznostiZobrazeniJedincu = { "Podle genotypů", "Podle jednotlivých alelových párů", "Podle fenotypů", "Podle jednotlivých znaků", "Podle genotypů i s fenotypy", "Jednotlivě (není vhodné pro větší počet jedinců!)", "Jednotlivě, max. 50 jedinců." };
        //                                                   0                 1                                    2                 3                           4                              5                                                    6

        /// <summary>dominance (úplná): AA = Aa > aa; semidominance (neúplná dominance): AA > Aa > aa; kodominance: A != a; AA = A, aa = a, Aa = A a; superdominance: AA = aa > Aa </summary>
        public static string[] VztahAlel = { "Úplná dominance", "Neúplná dominance", "Kodominance", "Superdominance" };
        
        /// <summary>generátor náhodných čísel</summary>
        public static Random random = new Random();

        #endregion

        #region Metody

        /// <summary>
        /// H-W vzorec: z podílu jedněch homozygotů spočte podíl heterozygotů a druhých homozygotů (v promile)
        /// </summary>
        /// <param name="vstup">podíl jedněch homozygotů v promile</param>
        /// <returns>[0]: podíl druhých homozygotů a [1]: podíl heterozygotů, v promile</returns>
        public static int[] hw(int vstup) {
            double p = Math.Sqrt((double)vstup/1000);
            double q = 1 - p;
            int hom = (int)(q*q * 1000);
            int het = 1000 - vstup - hom;
            return new int[2] {hom,het};
        }

        #region Výjimky

        /// <summary>pokus o uvolnění paměti - když nastane výjimka</summary>
        static void uvolnitPamet(){
            Populace.jedinci = new Jedinci();
            Populace.Kalendar.nullovatKalendar();
        }

        static void osetriVyjimku(object sender, UnhandledExceptionEventArgs u) {
            Exception e = (Exception)u.ExceptionObject;
            osetriVyjimku(e);
        }
        static void osetriVyjimku(object sender, System.Threading.ThreadExceptionEventArgs t) {
            osetriVyjimku(t.Exception);
        }
        static void osetriVyjimku(Exception e) {
            uvolnitPamet();
            MessageBox.Show("V aplikaci bohužel došlo k chybě.\nDůvodem jsou pravděpodobně nevhodná vstupní data (příliš rozsáhlá nebo výpočetně náročná) nebo chyba v aplikaci. Pokud se domníváte, že se jedná o chybu v aplikaci, informujte mě prosím na můj email rur@seznam.cz.\nAplikace nyní bude restartována.\n---\nInformace o chybě:\n" + e.Message, "Chyba");
            Application.Restart();
        }

        /*catch (OutOfMemoryException e) {
            uvolnitPamet();
            Populace.modelBezi = false;
            MessageBox.Show("V aplikaci bohužel došlo k chybě.\nPaměť Vašeho počítače bohužel nemá dostatečnou velikost pro modelování této populace. Příčinou budou pravděpodobně příliš velká čísla ve vlastnostech populace nebo genů, případně pokus o provedení příliš velkého počtu kroků.\nModel byl zastaven, vlastnosti populace i sledované geny by měly být zachovány. Zkuste to, prosím, znovu a skromněji.", "Chyba");
        }
        catch (Exception e) {
            uvolnitPamet();
            MessageBox.Show("V aplikaci bohužel došlo k chybě.\nDůvodem jsou pravděpodobně nevhodná vstupní data (příliš rozsáhlá nebo výpočetně náročná) nebo chyba v aplikaci. Pokud se domníváte, že se jedná o chybu v aplikaci, informujte mě prosím na můj email rur@seznam.cz.\nAplikace nyní bude restartována.\n---\nInformace o chybě:\n" + e.Message, "Chyba");
            Application.Restart();
        }*/
        #endregion

        #endregion

    }

    /// <summary>Populace: základní statický objekt reprezentující právě modelovanou populaci</summary>
    static class Populace {

        #region Datové položky

        public static Jedinci jedinci = new Jedinci();

        /// <summary>čas modelu (typicky představuje roky od stvoření populace)</summary>
        public static int cas = 0;

        /// <summary>zda probíhá modelování</summary>
        public static bool modelBezi = false;

        /// <summary>při nastavování sledovaných genů (flexibilnější)</summary>
        public static List<Gen> sledovaneGeny = new List<Gen>();
        /// <summary>při běhu modelu (rychlejší)</summary>
        public static Gen[] sledovaneGenyPole;
        /// <summary>při běhu modelu</summary>
        public static int sledovaneGenyPocet;
        /// <summary>při běhu modelu - pro hašování genotypů a fenotypů</summary>
        public static int sledovaneGenyPocetNaTreti;
        /// <summary>při běhu modelu - počet jedinců s daným genotypem (index = hash)</summary>
        public static int[] sledovaneGenotypy;
        /// <summary>při běhu modelu, na vyžádání - počet jedinců s daným fenotypem (index = hash)</summary>
        public static int[] sledovaneFenotypy;

        public static VlastnostiPopulace vlastnosti = new VlastnostiPopulace();

        /// <summary>Kalendář pro plánování událostí</summary>
        public static class Kalendar {
            static List<UdalostiRoku> udalosti = new List<UdalostiRoku>();
            public static void pridat(Udalost udalost, int rok) {
                while (udalosti.Count <= rok) {
                    udalosti.Add(new UdalostiRoku());
                }
                udalosti[rok].pridat(udalost);
            }
            /// <summary>vykoná všechny události daného roku</summary>
            public static void provestUdalostiRoku(int rok) {
                Udalost udalost;
                while (null != (udalost = vzit(rok))) {
                    if (jedinci.pocet < 2) { return; } //vymření
                    udalost.provest();
                }
            }
            static UdalostiRoku vzitUdalostiRoku(int rok) {
                if (udalosti.Count > rok) {
                    return udalosti[rok];
                } else {
                    return null;
                }
            }
            /// <summary>vybere první událost tohoto roku (a smaže z kalendáře); pokud neexistuje, vrací null</summary>
            static Udalost vzit(int rok) {
                UdalostiRoku udalostiRoku = vzitUdalostiRoku(rok);
                if (udalostiRoku == null) {
                    return null;
                } else {
                    return udalostiRoku.vzit();
                }
            }
            /// <summary>"odstraní" (nastaví na null) udalosti roku pro daný rok</summary>
            public static void nullovatUdalostiRoku(int rok) {
                udalosti[rok] = null;
            }
            public static void nullovatKalendar() {
                udalosti = new List<UdalostiRoku>();
            }
        }

        #endregion

        #region Metody

        #region Model

        /// <summary>spustit modelaci vývoje populace (vytvoří výchozí jedince a další věci)</summary>
        public static void modelSpustit() {
            
            //inicializace
            cas = 0;
            jedinci = new Jedinci();
            Kalendar.nullovatKalendar();
            modelBezi = true;

            //zafixování proměnných typu sledovaneGeny*
            sledovaneGenyPocet = sledovaneGeny.Count;
            sledovaneGenyPole = new Gen[sledovaneGenyPocet];
            for (int index = 0; index < sledovaneGenyPocet; index++) {    //přechod od Listu k poli
                sledovaneGenyPole[index] = sledovaneGeny[index];
            }
            sledovaneGenyPocetNaTreti = (int)Math.Pow(3, sledovaneGenyPocet);   //předvypočítaná hodnota potřebná při počítání s hashem genotypu
            sledovaneGenotypy = new int[sledovaneGenyPocetNaTreti];

            //vytvořit jedince
            Genotyp genotyp; Gen gen; int random; int typ;
            for (int jedinec = 0; jedinec < vlastnosti.vychoziPocetJedincu; jedinec++) {
                //sestavit genotyp
                genotyp = new Genotyp();
                for (int index = 0; index < sledovaneGenyPocet; index++) {
                    gen = sledovaneGenyPole[index];
                    random = Program.random.Next(1000);
                    if (random < gen.zastoupeniAlel[0]) {
                        typ = 0;    //Aa
                    } else if (random < gen.zastoupeniAlel[1]) {
                        typ = 1;    //AA
                    } else {
                        typ = 2;    //aa
                    }
                    genotyp.pary[index] = new AlelovyPar(gen, (AlelovyPar.Typ)typ);
                }
                //vytvořit jedince
                new Jedinec(genotyp);
            }

            Program.obnovitJedinciForm();
            Program.hlavniForm.obnovit();
        }
        /// <summary>krok modelu</summary> <param name="kolik">kolik kroků modelu se má vykonat</param>
        public static void modelKrok(int kolik) {
            if (!Populace.modelBezi) {
                MessageBox.Show("Model neběží! Nejprve musíte model spustit příkazem Spustit model.", "Chyba");
                return;
            }
            Cursor.Current = Cursors.WaitCursor;
            for (int i = 0; i < kolik; i++) {
                //čas
                cas++;
                //vykonání událostí roku
                Kalendar.provestUdalostiRoku(cas);
                //žije ještě populace?
                if (jedinci.pocet < 2) {
                    modelZastavit();
                    MessageBox.Show("Populace vymřela.", "Populace vymřela");
                    break;  //ukončení hlavního cyklu
                }
            }
            //výstup
            Cursor.Current = Cursors.Default;
            Program.obnovitJedinciForm();
            Program.hlavniForm.obnovit();
        }
        /// <summary>jeden krok modelu</summary>
        public static void modelKrok() {
            modelKrok(1);
        }
        /// <summary>zastaví model</summary>
        public static void modelZastavit() {
            modelBezi = false;
            Kalendar.nullovatKalendar();
            Program.hlavniForm.obnovit();
            Program.obnovitJedinciForm();
        }

        #endregion

        #region Ostatní

        /// <summary>vytvoří novou populaci - jakoby restart programu</summary>
        public static void nova() {
            if (MessageBox.Show("Všechna data budou ztracena. Pokračovat?", "Nová populace", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                //ukončení modelu
                modelBezi = false;
                cas = 0;
                jedinci = new Jedinci();
                Kalendar.nullovatKalendar();
                //sledovaneGeny* a jiná data
                sledovaneGeny.Clear();
                sledovaneGenyPole = null;
                sledovaneGenotypy = null;
                sledovaneFenotypy = null;
                vlastnosti = new VlastnostiPopulace();
                //formy
                Program.obnovitSledovaneGenyForm();
                Program.obnovitJedinciForm();
                Program.hlavniForm.obnovit();
                Program.aktivujForm(ref Program.vlastnostiPopulaceForm);
            }
        }

        /// <summary>přidá gen do sledovaných genů</summary>
        public static void pridatSledovanyGen(Gen gen) {
            sledovaneGeny.Add(gen);
            Program.obnovitSledovaneGenyForm();
        }
        
        #endregion
        
        #endregion

    }

    class VlastnostiPopulace {

        /// <summary>kolik jedinců vytvoří při spuštení modelu</summary>
        public int vychoziPocetJedincu = 5000;
        /// <summary>maximální počet jedinců - při jeho dosažení nebude probíhat rozmnožování</summary>
        public int maxPocetJedincu = 10000;
        /// <summary>hodnota z pole Program.vychoziRozlozeniGenu</summary>
        public int vychoziRozlozeniGenu = 3;
        /// <summary>po kolika letech zemře</summary>
        public int prumernaDelkaZivota = 70;
        /// <summary>věk dospělosti (pohlavní)</summary>
        public int dospelost = 18;
        /// <summary>po kolika letech se znova rozmnožuje se stejným partnerem</summary>
        public int sexInterval = 20;
        /// <summary>počet dětí</summary>
        public int porodnost = 1;
        /// <summary>kolik let vydrží s jedním partnerem</summary>
        public int vernost = 30;
        /// <summary>z kolika partnerů si vybírá (1: bere prvního co potká)</summary>
        public int vybiravost = 3;
        /// <summary>pravděpodobnost mutace alely je 1:pravdepodobnostMutace</summary>
        public int pravdepodobnostMutace = 10000;
    }

    #region Udalost, UdalostiRoku

    /// <summary>událost kalendáře</summary>
    class Udalost {
        public enum TypUdalosti { svatba, rozmnozovani, rozvod, smrt }   //svatba a rozvod jsou nejlepší jednoslovná pojmenování, která mě napadla pro vytvoření páru a pro jeho zánik
        TypUdalosti typ;
        Jedinec jedinec;
        int pocetPartneru = -1; //slouží pro rozhodnutí o platnosti událostí vázaných na partnera
        public Udalost dalsi = null;   //pro vytvoření spojáku
        public Udalost(TypUdalosti typ, Jedinec jedinec, int pocetPartneru) {
            this.typ = typ;
            this.jedinec = jedinec;
            this.pocetPartneru = pocetPartneru;
        }
        public Udalost(TypUdalosti typ, Jedinec jedinec) {
            this.typ = typ;
            this.jedinec = jedinec;
        }
        public void provest() {
            if (pocetPartneru == -1 || pocetPartneru == jedinec.pocetPartneru) {
                switch (typ) {
                    case TypUdalosti.rozmnozovani:
                        if (Populace.jedinci.pocet < Populace.vlastnosti.maxPocetJedincu) {
                            jedinec.rozmnozit();
                        }
                        break;
                    case TypUdalosti.rozvod:
                        jedinec.rozvod();
                        break;
                    case TypUdalosti.smrt:
                        jedinec.smrt();
                        break;
                    case TypUdalosti.svatba:
                        jedinec.svatba();
                        break;
                    default:
                        MessageBox.Show("chyba: špatný typ události - Udalost.provest");
                        break;
                }
            }
            /*
            int soucet=0;
            for (int gt = 0; gt < Populace.sledovaneGenyPocetNaTreti; gt++) {
                soucet += Populace.sledovaneGenotypy[gt];
            }
            if (soucet != Populace.jedinci.pocet) { throw (new Exception("neseděj počty!")); }
            */
        }
    }

    /// <summary>události jednoho roku</summary>
    class UdalostiRoku {
        //vždy beru ze začátku nebo přidávám na konec -> je to jako dělané na SPOJÁK
        Udalost prvni = null;   //ukazatel na první událost
        Udalost posledni = null;   //ukazatel na poslední událost
        public void pridat(Udalost udalost) {
            if (prvni == null) {    //prázdný spoják
                prvni = udalost;
                posledni = udalost;
            } else {    //připojit na konec
                posledni.dalsi = udalost;
                posledni = udalost;
            }
        }
        /// <summary>vybere první událost tohoto roku (a smaže z kalendáře); pokud neexistuje, vrací null</summary>
        public Udalost vzit() {
            if (prvni != null) {    //vrátí první událost a posune ukazatel (možná ho posune na null, což je korektní)
                Udalost udalost = prvni;
                prvni = prvni.dalsi;
                return udalost;
            } else {    //už nejsou žádné události
                return null;
            }
        }
    }

    #endregion

    #region Gen, Alela, AlelovyPar, Genotyp

    public class Gen {
        public string nazev;
        /// <summary>symbol dominantní alely</summary>
        public string alelaDom;
        /// <summary>symbol recesivní alely</summary>
        public string alelaRec;
        public int vztahAlel = 0;
        /// <summary>exprese genu - Aa, AA, aa</summary>
        public string[] expr;
        /// <summary>atraktivita nositele alely (Aa, AA, aa) - relativní (+/-)</summary>
        public int[] atr;
        /// <summary>porodnost nositele alely (Aa, AA, aa) - relativní (+/-)</summary>
        public int[] porodnost;
        /// <summary>délka života nositele alely (Aa, AA, aa) - relativní (+/-)</summary>
        public int[] delkaZivota;
        /// <summary>zastoupení alel jako částečné součty: např. poměr 200:500:300 bude vyjádřen polem {200,700} (hodnoty jsou v promile, takže poslední součet je vždy 1000 a tedy není třeba jej ukládat)</summary>
        public int[] zastoupeniAlel;

        public Gen(string nazev, string alelaDom, string alelaRec, int vztahAlel, string exprAA, string exprAa, string expraa, int atrAA, int atrAa, int atraa, int porAA, int porAa, int poraa, int vekAA, int vekAa, int vekaa, int pomAA, int pomAa, int pomaa) {
            this.nazev = nazev;
            this.alelaDom = alelaDom;
            this.alelaRec = alelaRec;
            this.vztahAlel = vztahAlel;
            expr = new string[3] { exprAa, exprAA, expraa };
            atr = new int[3] { atrAa, atrAA, atraa };
            porodnost = new int[3] { porAa, porAA, poraa };
            delkaZivota = new int[3] { vekAa, vekAA, vekaa };
            zastoupeniAlel = new int[2] { pomAa, pomAa+pomAA };
            Populace.pridatSledovanyGen(this);
        }
        public override string ToString() {
            return nazev;
        }
    }

    public class AlelovyPar {
        /// <summary>typ alelového páru - AA (obě alely dominantní), Aa nebo aa</summary>
        public enum Typ { Aa, AA, aa };
        public enum TypAlely { A, a };

        public Gen gen;
        public Typ typ;

        #region Metody
        public AlelovyPar(Gen gen, Typ typ) {
            this.gen = gen;
            this.typ = typ;
        }
        public override string ToString() {
            switch (typ) {
                case Typ.AA:
                    return gen.alelaDom + gen.alelaDom;
                case Typ.Aa:
                    return gen.alelaDom + gen.alelaRec;
                case Typ.aa:
                    return gen.alelaRec + gen.alelaRec;
                default:
                    return "{" + gen.nazev + "}";
            }
        }
        /// <summary>vrací typ alelového páru jako int</summary>
        public int ToInt() {
            return (int)typ;
        }
        public string ToZnak() {
            return gen.expr[(int)typ];
        }
        /// <summary>vrací typ alelového páru jako int; podle vztahu alel jej případně převede na jinou formu se shodným projevem (podrobněji viz kód)</summary>
        public int ToZnakInt() {
            int vysledek = (int)typ;
            if (vysledek == 1) { //typ = Typ.AA
                if (gen.vztahAlel == 0) {   //úplná dominance
                    vysledek = 0;   //AA -> Aa
                } else if (gen.vztahAlel == 3) {    //superdominance
                    vysledek = 2;   //AA -> aa
                }
            }
            return vysledek;
        }
        /// <summary>atraktivita vyplývající z daného alelového páru</summary>
        public int ToAtr() {
            return gen.atr[(int)typ];
        }
        /// <summary>porodnost vyplývající z daného alelového páru</summary>
        public int ToPor() {
            return gen.porodnost[(int)typ];
        }
        /// <summary>délka života vyplývající z daného alelového páru</summary>
        public int ToVek() {
            return gen.delkaZivota[(int)typ];
        }
        #endregion
    }

    public class Genotyp {
        public AlelovyPar[] pary;
        public Genotyp() {
            pary = new AlelovyPar[Populace.sledovaneGenyPocet];
        }
        public Genotyp(int hash) {
            pary = new AlelovyPar[Populace.sledovaneGenyPocet];
            for (int gen = 0; gen < Populace.sledovaneGenyPocet; gen++) {
                pary[gen] = new AlelovyPar(Populace.sledovaneGenyPole[gen], (AlelovyPar.Typ)(hash % 3));
                hash = hash / 3;
            }
        }
        public override string ToString() {
            string vystup = "";
            foreach (AlelovyPar alelovyPar in pary) {
                vystup += " " + alelovyPar.ToString();
            }
            return vystup.Substring(1);
        }
        public int ToInt() {    //hash genotypu: číslo, jehož trojkový zápis vyjadřuje jednotlivé typy jednotlivých alelových párů; úplný heterozygót má čistě náhodou hash roven nule ;-); 0.řád = 0.gen
            int hash = 0;
            for (int gen = Populace.sledovaneGenyPocet - 1; gen >= 0; gen--) {
                hash = pary[gen].ToInt() + hash * 3;
            }
            return hash;
        }
        public string ToFenotyp() {
            string vystup = "";
            foreach (AlelovyPar alelovyPar in pary) {
                vystup += (alelovyPar.ToZnak() == "") ? ("") : (", " + alelovyPar.ToZnak());
            }
            if (vystup == "") {
                return "";
            } else {
                return vystup.Substring(2);
            }
        }
        public int ToFenotypInt() {    //hash fenotypu: číslo, jehož trojkový zápis vyjadřuje jednotlivé projevy znaků jednotlivých genů; 0.řád = 0.gen
            int hash = 0;
            for (int gen = Populace.sledovaneGenyPocet - 1; gen >= 0; gen--) {
                hash = pary[gen].ToZnakInt() + hash * 3;
            }
            return hash;
        }
    }

    #endregion

    #region Jedinec, Jedinci

    class Jedinec {

        #region Data

        public Genotyp genotyp;

        //vlastnosti dané životem
        /// <summary>partner jedince; null pokud nemá partnera</summary>
        public Jedinec partner = null;
        /// <summary>datum narození jedince</summary>
        public int narozeni = 0;

        //geneticky dané vlastnosti
        /// <summary>atraktivita jedince</summary>
        public int atraktivita = 0;
        /// <summary>jak dlouho bude jedinec žít</summary>
        public int delkaZivota = Populace.vlastnosti.prumernaDelkaZivota;
        /// <summary>kolik dětí bude jedinec typicky mít</summary>
        public int porodnost = Populace.vlastnosti.porodnost;
        
        //technická data
        /// <summary>počet partnerů, které jedinec již měl - při změně partnera se inkrementuje, slouží pro rozhodnutí o platnosti událostí vázaných na partnera; -2 = mrtvý jedinec</summary>
        public int pocetPartneru = 0;
        /// <summary>poslední partner, kterého jedinec měl - od něj se "odpíchne" hledání nového partnera, viz metoda svatba()</summary>
        Jedinec minulyPartner = null;
        /// <summary>předcházející ve spojáku</summary>
        public Jedinec predchozi;
        /// <summary>následující ve spojáku</summary>
        public Jedinec dalsi;

        #endregion

        #region Metody
        /// <summary>narodí se, zjistí jak je na tom a naplánuje si život</summary><param name="narozeni">rok narození</param><param name="genotyp">genotyp</param>
        public Jedinec(Genotyp genotyp) {
            this.genotyp = genotyp;
            narozeni = Populace.cas;
            for (int gen = 0; gen < Populace.sledovaneGenyPocet; gen++) {
                atraktivita += genotyp.pary[gen].ToAtr();
                porodnost   += genotyp.pary[gen].ToPor();
                delkaZivota += genotyp.pary[gen].ToVek();
            }
            if (delkaZivota > 0) {
                Populace.jedinci.add(this);
                Populace.sledovaneGenotypy[genotyp.ToInt()]++;
                Populace.Kalendar.pridat(new Udalost(Udalost.TypUdalosti.svatba, this, 0), Populace.cas + Populace.vlastnosti.dospelost);  //až bude dospělý, bude mít svatbu
                Populace.Kalendar.pridat(new Udalost(Udalost.TypUdalosti.smrt, this), Populace.cas + delkaZivota);  //až bude starý, umře
            }
        }
        /// <summary>řekne, jestli chce za partnera srstku</summary>
        public bool chceteMe(Jedinec srstka) {
            if (narozeni + Populace.vlastnosti.dospelost > Populace.cas || pocetPartneru==-2) {
                return false;   //ěště není dospělý nebo už je mrtvý, takže z toho nic nebude
            }
            if (partner == null) {
                return true;    //když je sám, bere každého
            }
            if (srstka.atraktivita > partner.atraktivita) {
                return true;    //je atraktivnější než současný partner => bere ho
            } else {
                return false;   //není atraktivnější než současný partner => nebere ho
            }
        }
        /// <summary>pokud nemá partnera, najde si ho a naplánuje si život s ním</summary>
        public void svatba() {
            if (partner == null) {
                //vybírá si co nejatraktivnějšího partnera
                Jedinec novy = Populace.jedinci.nahodnyJedinec(minulyPartner == null ? this : minulyPartner);
                Jedinec temp = novy;
                for (int i = 1; i < Populace.vlastnosti.vybiravost; i++) {
                    temp = Populace.jedinci.nahodnyJedinec(temp);
                    if (temp.chceteMe(this) && (temp.atraktivita > novy.atraktivita || !novy.chceteMe(this))) { //pokud mě temp chce a je atraktivnější než současný novy (nebo pokud mě novy nechce), vezmu si ho radši než noveho
                        novy = temp;
                    }
                }
                if (novy.chceteMe(this)) {
                    novyPartner(novy);
                    novy.novyPartner(this);
                    Populace.Kalendar.pridat(new Udalost(Udalost.TypUdalosti.rozmnozovani, this, pocetPartneru), Populace.cas); //tento rok má v plánu se rozmnožit, ale přes kalendář
                    Populace.Kalendar.pridat(new Udalost(Udalost.TypUdalosti.rozvod, this, pocetPartneru), Populace.cas + Populace.vlastnosti.vernost);
                } else {
                    Populace.Kalendar.pridat(new Udalost(Udalost.TypUdalosti.svatba, this, pocetPartneru), Populace.cas + 1);   //!
                }
            }
        }
        /// <summary>korektní zbavení se současného partnera</summary><param name="planovatSvatbu">zda má při rozvodu už plánovat další svatbu</param>
        public void rozvod(bool planovatSvatbu) {
            if (partner != null) {
                minulyPartner = partner;
                partner = null;
                minulyPartner.rozvod();
            }
            if (planovatSvatbu) {
                Populace.Kalendar.pridat(new Udalost(Udalost.TypUdalosti.svatba, this, pocetPartneru), Populace.cas + 1);
            }
        }
        public void rozvod() { rozvod(true); }
        public void smrt() {
            rozvod(false);
            pocetPartneru = -2; //spec. hodnota pro mrtvého jedince
            Populace.jedinci.remove(this);
            Populace.sledovaneGenotypy[genotyp.ToInt()]--;
        }
        /// <summary>má-li partnera, rozmnoží se s ním</summary>
        public void rozmnozit() {
            if (partner != null) {
                int pocet = Program.random.Next(Math.Min(porodnost, partner.porodnost), Math.Max(porodnost, partner.porodnost) + 1);
                for (int dite = 0; dite < pocet; dite++) {
                    Genotyp genotyp = new Genotyp();
                    for (int gen = 0; gen < Populace.sledovaneGenyPocet; gen++) {
                        genotyp.pary[gen] = new AlelovyPar(Populace.sledovaneGenyPole[gen], alely2par(vyberAlelu(this.genotyp.pary[gen].typ), vyberAlelu(partner.genotyp.pary[gen].typ)));
                    }
                    new Jedinec(genotyp);
                }
                Populace.Kalendar.pridat(new Udalost(Udalost.TypUdalosti.rozmnozovani, this, pocetPartneru), Populace.cas + Populace.vlastnosti.sexInterval);
            }
        }
        //pomocné metody
        public void novyPartner(Jedinec partner) {
            rozvod(false);
            this.partner = partner;
            pocetPartneru++;
        }
        AlelovyPar.TypAlely vyberAlelu(AlelovyPar.Typ typ) {
            AlelovyPar.TypAlely vysledek;
            switch (typ) {
                case AlelovyPar.Typ.aa:
                    vysledek = AlelovyPar.TypAlely.a;
                    break;
                case AlelovyPar.Typ.AA:
                    vysledek = AlelovyPar.TypAlely.A;
                    break;
                case AlelovyPar.Typ.Aa:
                    vysledek = (AlelovyPar.TypAlely)Program.random.Next(2);
                    break;
                default:
                    MessageBox.Show("chybná alela");
                    vysledek = AlelovyPar.TypAlely.a;   //pro formu
                    break;
            }
            //mutace - jedna alela zmutuje na druhou
            if (Program.random.Next(Populace.vlastnosti.pravdepodobnostMutace) == 0) {
                if (vysledek == AlelovyPar.TypAlely.a) {
                    vysledek = AlelovyPar.TypAlely.A;
                } else {
                    vysledek = AlelovyPar.TypAlely.a;
                }
            }
            return vysledek;
        }
        AlelovyPar.Typ alely2par(AlelovyPar.TypAlely a1, AlelovyPar.TypAlely a2) {
            switch ((int)a1 + (int)a2) {
                case 0:
                    return AlelovyPar.Typ.AA;
                case 1:
                    return AlelovyPar.Typ.Aa;
                case 2:
                    return AlelovyPar.Typ.aa;
                default:
                    MessageBox.Show("chybný alelový součet");
                    return AlelovyPar.Typ.aa;   //pro formu
            }
        }
        #endregion
    }

    class Jedinci { //obousměrný cyklický spoják
        
        public Jedinec posledni = null;    //další je první
        public int pocet;

        /// <summary>přidat jedince</summary>
        public void add(Jedinec jedinec) {
            if (posledni == null) { //prázdný spoják
                posledni = jedinec;
                jedinec.predchozi = jedinec;
                jedinec.dalsi = jedinec;
            } else {
                //sebeurčení
                jedinec.predchozi = posledni;
                jedinec.dalsi = posledni.dalsi;
                //zařazení
                posledni.dalsi.predchozi = jedinec;
                posledni.dalsi = jedinec;
                //nastavení ukazatele
                posledni = jedinec;
            }
            pocet++;
        }
        //overloads
        public void add(Genotyp genotyp) {
            add(new Jedinec(genotyp));
        }
        public void add(Genotyp genotyp, int pocet) {
            for (int i = 0; i < pocet; i++) {
                add(new Jedinec(genotyp));
            }
        }

        public void remove(Jedinec jedinec) {
            jedinec.predchozi.dalsi = jedinec.dalsi;
            jedinec.dalsi.predchozi = jedinec.predchozi;
            posledni = jedinec.dalsi;   //posledni musí ukazovat na žijícího jedince, takže by vznikl problém, kdyby posledni umřel; spoják je ale cyklický, takže posledni může být kterýkoli žijící jedinec, tak proč ne jedinec.dalsi
            pocet--;    //!tady dojde k vymření populace
        }
        /// <summary>vybere náhodného jedince</summary><param name="vychozi">odkud se začne hledat</param>
        public Jedinec nahodnyJedinec(Jedinec jedinec) {
            int rand = Program.random.Next(1, 5);   //o kolik jedinců se posunu
            for (int i = 0; i < rand; i++) {
                jedinec = jedinec.predchozi;
            }
            return jedinec;
        }
    }

    #endregion

}
