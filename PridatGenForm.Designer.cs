namespace RURGenetika
{
    partial class PridatGenForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PridatGenForm));
            this.alelaDom = new System.Windows.Forms.TextBox();
            this.nazev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.alelaRec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vztahAlel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.homRecVek = new System.Windows.Forms.NumericUpDown();
            this.hetVek = new System.Windows.Forms.NumericUpDown();
            this.homRecPorodnost = new System.Windows.Forms.NumericUpDown();
            this.hetPorodnost = new System.Windows.Forms.NumericUpDown();
            this.homDomVek = new System.Windows.Forms.NumericUpDown();
            this.homDomPorodnost = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.hetAtr = new System.Windows.Forms.NumericUpDown();
            this.homRecAtr = new System.Windows.Forms.NumericUpDown();
            this.homDomAtr = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.homRec = new System.Windows.Forms.TextBox();
            this.het = new System.Windows.Forms.TextBox();
            this.homDom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.homRecPom = new System.Windows.Forms.NumericUpDown();
            this.hetPom = new System.Windows.Forms.NumericUpDown();
            this.homDomPom = new System.Windows.Forms.NumericUpDown();
            this.hw = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.vychoziRozlozeniGenu = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homRecVek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hetVek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homRecPorodnost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hetPorodnost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homDomVek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homDomPorodnost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hetAtr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homRecAtr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homDomAtr)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homRecPom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hetPom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homDomPom)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // alelaDom
            // 
            this.alelaDom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.alelaDom.Location = new System.Drawing.Point(76, 47);
            this.alelaDom.MaxLength = 6;
            this.alelaDom.Name = "alelaDom";
            this.alelaDom.Size = new System.Drawing.Size(53, 20);
            this.alelaDom.TabIndex = 2;
            this.alelaDom.TextChanged += new System.EventHandler(this.alelaDom_TextChanged);
            // 
            // nazev
            // 
            this.nazev.Location = new System.Drawing.Point(76, 21);
            this.nazev.Name = "nazev";
            this.nazev.Size = new System.Drawing.Size(116, 20);
            this.nazev.TabIndex = 1;
            this.nazev.TextChanged += new System.EventHandler(this.nazev_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alely:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Název:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vztah alel:";
            // 
            // alelaRec
            // 
            this.alelaRec.Location = new System.Drawing.Point(207, 47);
            this.alelaRec.MaxLength = 6;
            this.alelaRec.Name = "alelaRec";
            this.alelaRec.Size = new System.Drawing.Size(62, 20);
            this.alelaRec.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "(dom.)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "(rec.)";
            // 
            // vztahAlel
            // 
            this.vztahAlel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vztahAlel.FormattingEnabled = true;
            this.vztahAlel.Location = new System.Drawing.Point(76, 73);
            this.vztahAlel.Name = "vztahAlel";
            this.vztahAlel.Size = new System.Drawing.Size(121, 21);
            this.vztahAlel.TabIndex = 4;
            this.vztahAlel.SelectedIndexChanged += new System.EventHandler(this.vztahAlel_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.homRecVek);
            this.groupBox1.Controls.Add(this.hetVek);
            this.groupBox1.Controls.Add(this.homRecPorodnost);
            this.groupBox1.Controls.Add(this.hetPorodnost);
            this.groupBox1.Controls.Add(this.homDomVek);
            this.groupBox1.Controls.Add(this.homDomPorodnost);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.hetAtr);
            this.groupBox1.Controls.Add(this.homRecAtr);
            this.groupBox1.Controls.Add(this.homDomAtr);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.homRec);
            this.groupBox1.Controls.Add(this.het);
            this.groupBox1.Controls.Add(this.homDom);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 135);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exprese genu";
            // 
            // homRecVek
            // 
            this.homRecVek.Location = new System.Drawing.Point(356, 98);
            this.homRecVek.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.homRecVek.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.homRecVek.Name = "homRecVek";
            this.homRecVek.Size = new System.Drawing.Size(99, 20);
            this.homRecVek.TabIndex = 22;
            this.homRecVek.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.homRecVek.ThousandsSeparator = true;
            this.homRecVek.ValueChanged += new System.EventHandler(this.vek_ValueChanged);
            // 
            // hetVek
            // 
            this.hetVek.Location = new System.Drawing.Point(356, 72);
            this.hetVek.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.hetVek.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.hetVek.Name = "hetVek";
            this.hetVek.Size = new System.Drawing.Size(99, 20);
            this.hetVek.TabIndex = 21;
            this.hetVek.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hetVek.ThousandsSeparator = true;
            this.hetVek.ValueChanged += new System.EventHandler(this.vek_ValueChanged);
            // 
            // homRecPorodnost
            // 
            this.homRecPorodnost.Location = new System.Drawing.Point(251, 98);
            this.homRecPorodnost.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.homRecPorodnost.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.homRecPorodnost.Name = "homRecPorodnost";
            this.homRecPorodnost.Size = new System.Drawing.Size(99, 20);
            this.homRecPorodnost.TabIndex = 19;
            this.homRecPorodnost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.homRecPorodnost.ThousandsSeparator = true;
            this.homRecPorodnost.ValueChanged += new System.EventHandler(this.porodnost_ValueChanged);
            // 
            // hetPorodnost
            // 
            this.hetPorodnost.Location = new System.Drawing.Point(251, 71);
            this.hetPorodnost.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.hetPorodnost.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.hetPorodnost.Name = "hetPorodnost";
            this.hetPorodnost.Size = new System.Drawing.Size(99, 20);
            this.hetPorodnost.TabIndex = 18;
            this.hetPorodnost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hetPorodnost.ThousandsSeparator = true;
            this.hetPorodnost.ValueChanged += new System.EventHandler(this.porodnost_ValueChanged);
            // 
            // homDomVek
            // 
            this.homDomVek.Location = new System.Drawing.Point(356, 45);
            this.homDomVek.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.homDomVek.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.homDomVek.Name = "homDomVek";
            this.homDomVek.Size = new System.Drawing.Size(99, 20);
            this.homDomVek.TabIndex = 20;
            this.homDomVek.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.homDomVek.ThousandsSeparator = true;
            this.homDomVek.ValueChanged += new System.EventHandler(this.vek_ValueChanged);
            // 
            // homDomPorodnost
            // 
            this.homDomPorodnost.Location = new System.Drawing.Point(251, 44);
            this.homDomPorodnost.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.homDomPorodnost.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.homDomPorodnost.Name = "homDomPorodnost";
            this.homDomPorodnost.Size = new System.Drawing.Size(99, 20);
            this.homDomPorodnost.TabIndex = 16;
            this.homDomPorodnost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.homDomPorodnost.ThousandsSeparator = true;
            this.homDomPorodnost.ValueChanged += new System.EventHandler(this.porodnost_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(360, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Délka života";
            this.toolTip1.SetToolTip(this.label13, "o kolik let více nebo méně bude žít nositel znaku");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(255, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Porodnost";
            this.toolTip1.SetToolTip(this.label12, "o kolik dětí více nebo méně se narodí nositeli znaku");
            // 
            // hetAtr
            // 
            this.hetAtr.Location = new System.Drawing.Point(177, 71);
            this.hetAtr.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.hetAtr.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.hetAtr.Name = "hetAtr";
            this.hetAtr.Size = new System.Drawing.Size(68, 20);
            this.hetAtr.TabIndex = 12;
            this.hetAtr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hetAtr.ValueChanged += new System.EventHandler(this.atr_ValueChanged);
            // 
            // homRecAtr
            // 
            this.homRecAtr.Location = new System.Drawing.Point(177, 98);
            this.homRecAtr.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.homRecAtr.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.homRecAtr.Name = "homRecAtr";
            this.homRecAtr.Size = new System.Drawing.Size(68, 20);
            this.homRecAtr.TabIndex = 13;
            this.homRecAtr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.homRecAtr.ValueChanged += new System.EventHandler(this.atr_ValueChanged);
            // 
            // homDomAtr
            // 
            this.homDomAtr.Location = new System.Drawing.Point(177, 44);
            this.homDomAtr.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.homDomAtr.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.homDomAtr.Name = "homDomAtr";
            this.homDomAtr.Size = new System.Drawing.Size(68, 20);
            this.homDomAtr.TabIndex = 11;
            this.homDomAtr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.homDomAtr.ValueChanged += new System.EventHandler(this.atr_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(6, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Pár";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(49, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Projev genu (znak)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(181, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Atraktivita";
            this.toolTip1.SetToolTip(this.label9, "o kolik stupňů stoupne nebo klesne atraktivita nositele znaku");
            // 
            // homRec
            // 
            this.homRec.Location = new System.Drawing.Point(50, 98);
            this.homRec.Name = "homRec";
            this.homRec.Size = new System.Drawing.Size(121, 20);
            this.homRec.TabIndex = 7;
            this.homRec.TextChanged += new System.EventHandler(this.alely_TextChanged);
            // 
            // het
            // 
            this.het.Location = new System.Drawing.Point(50, 71);
            this.het.Name = "het";
            this.het.Size = new System.Drawing.Size(121, 20);
            this.het.TabIndex = 6;
            this.het.TextChanged += new System.EventHandler(this.alely_TextChanged);
            // 
            // homDom
            // 
            this.homDom.Location = new System.Drawing.Point(50, 44);
            this.homDom.Name = "homDom";
            this.homDom.Size = new System.Drawing.Size(121, 20);
            this.homDom.TabIndex = 5;
            this.homDom.TextChanged += new System.EventHandler(this.alely_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "aa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Aa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "AA:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.alelaDom);
            this.groupBox2.Controls.Add(this.vztahAlel);
            this.groupBox2.Controls.Add(this.nazev);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.alelaRec);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Přidat gen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(223, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Storno";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // homRecPom
            // 
            this.homRecPom.Location = new System.Drawing.Point(251, 46);
            this.homRecPom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.homRecPom.Name = "homRecPom";
            this.homRecPom.Size = new System.Drawing.Size(52, 20);
            this.homRecPom.TabIndex = 28;
            this.homRecPom.Tag = 0;
            this.homRecPom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.homRecPom.ThousandsSeparator = true;
            this.toolTip1.SetToolTip(this.homRecPom, "Zastoupení recesivních homozygotů (aa)");
            this.homRecPom.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.homRecPom.ValueChanged += new System.EventHandler(this.pom_ValueChanged);
            // 
            // hetPom
            // 
            this.hetPom.Enabled = false;
            this.hetPom.Location = new System.Drawing.Point(169, 46);
            this.hetPom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.hetPom.Name = "hetPom";
            this.hetPom.Size = new System.Drawing.Size(52, 20);
            this.hetPom.TabIndex = 27;
            this.hetPom.Tag = 0;
            this.hetPom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hetPom.ThousandsSeparator = true;
            this.toolTip1.SetToolTip(this.hetPom, "Zastoupení heterozygotů (Aa)");
            this.hetPom.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.hetPom.ValueChanged += new System.EventHandler(this.pom_ValueChanged);
            // 
            // homDomPom
            // 
            this.homDomPom.Location = new System.Drawing.Point(93, 46);
            this.homDomPom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.homDomPom.Name = "homDomPom";
            this.homDomPom.Size = new System.Drawing.Size(52, 20);
            this.homDomPom.TabIndex = 26;
            this.homDomPom.Tag = 0;
            this.homDomPom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.homDomPom.ThousandsSeparator = true;
            this.toolTip1.SetToolTip(this.homDomPom, "Zastoupení dominantních homozygotů (AA)");
            this.homDomPom.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.homDomPom.ValueChanged += new System.EventHandler(this.pom_ValueChanged);
            // 
            // hw
            // 
            this.hw.AutoSize = true;
            this.hw.Checked = true;
            this.hw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hw.Location = new System.Drawing.Point(352, 47);
            this.hw.Name = "hw";
            this.hw.Size = new System.Drawing.Size(103, 17);
            this.hw.TabIndex = 31;
            this.hw.Text = "Hardy-Weinberg";
            this.toolTip1.SetToolTip(this.hw, "přepočítávat podle Hardy-Weinbergova vzorce");
            this.hw.UseVisualStyleBackColor = true;
            this.hw.CheckedChanged += new System.EventHandler(this.hw_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hw);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.homRecPom);
            this.groupBox3.Controls.Add(this.homDomPom);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.vychoziRozlozeniGenu);
            this.groupBox3.Controls.Add(this.hetPom);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(12, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 76);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Výchozí rozložení genů";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(303, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "‰";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(220, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "‰";
            this.toolTip1.SetToolTip(this.label16, "Zastoupení heterozygotů (Aa)");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Zastoupení alel:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(144, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "‰";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Předvolby:";
            // 
            // vychoziRozlozeniGenu
            // 
            this.vychoziRozlozeniGenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vychoziRozlozeniGenu.FormattingEnabled = true;
            this.vychoziRozlozeniGenu.Location = new System.Drawing.Point(93, 19);
            this.vychoziRozlozeniGenu.Name = "vychoziRozlozeniGenu";
            this.vychoziRozlozeniGenu.Size = new System.Drawing.Size(362, 21);
            this.vychoziRozlozeniGenu.TabIndex = 16;
            this.vychoziRozlozeniGenu.Tag = 0;
            this.vychoziRozlozeniGenu.SelectedIndexChanged += new System.EventHandler(this.vychoziRozlozeniGenu_SelectedIndexChanged);
            // 
            // PridatGenForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(504, 385);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PridatGenForm";
            this.Text = "Přidat gen";
            this.Load += new System.EventHandler(this.PridatGen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homRecVek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hetVek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homRecPorodnost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hetPorodnost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homDomVek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homDomPorodnost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hetAtr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homRecAtr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homDomAtr)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homRecPom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hetPom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homDomPom)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox alelaDom;
        private System.Windows.Forms.TextBox nazev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox alelaRec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox vztahAlel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox homRec;
        private System.Windows.Forms.TextBox het;
        private System.Windows.Forms.TextBox homDom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown hetAtr;
        private System.Windows.Forms.NumericUpDown homRecAtr;
        private System.Windows.Forms.NumericUpDown homDomAtr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown homDomPorodnost;
        private System.Windows.Forms.NumericUpDown homDomVek;
        private System.Windows.Forms.NumericUpDown homRecVek;
        private System.Windows.Forms.NumericUpDown hetVek;
        private System.Windows.Forms.NumericUpDown homRecPorodnost;
        private System.Windows.Forms.NumericUpDown hetPorodnost;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox vychoziRozlozeniGenu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown homRecPom;
        private System.Windows.Forms.NumericUpDown hetPom;
        private System.Windows.Forms.NumericUpDown homDomPom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox hw;
        private System.Windows.Forms.Label label18;
    }
}