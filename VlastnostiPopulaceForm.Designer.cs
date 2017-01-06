namespace RURGenetika
{
    partial class VlastnostiPopulaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VlastnostiPopulaceForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vychoziRozlozeniGenu = new System.Windows.Forms.ComboBox();
            this.pocetJedincu = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.delkaZivota = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.porodnost = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vernost = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sexinterval = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dospelost = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.vybiravost = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.maxPocetJedincu = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.mutace = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pocetJedincu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delkaZivota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porodnost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vernost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexinterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dospelost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vybiravost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPocetJedincu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutace)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 100;
            this.button1.Text = "Nastavit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(145, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 101;
            this.button2.Text = "Zavřít (beze změn)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Výchozí počet jedinců:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Výchozí rozložení genů:";
            this.label2.Visible = false;
            // 
            // vychoziRozlozeniGenu
            // 
            this.vychoziRozlozeniGenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vychoziRozlozeniGenu.FormattingEnabled = true;
            this.vychoziRozlozeniGenu.Location = new System.Drawing.Point(171, 62);
            this.vychoziRozlozeniGenu.Name = "vychoziRozlozeniGenu";
            this.vychoziRozlozeniGenu.Size = new System.Drawing.Size(362, 21);
            this.vychoziRozlozeniGenu.TabIndex = 3;
            this.vychoziRozlozeniGenu.Visible = false;
            // 
            // pocetJedincu
            // 
            this.pocetJedincu.Location = new System.Drawing.Point(171, 10);
            this.pocetJedincu.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.pocetJedincu.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.pocetJedincu.Name = "pocetJedincu";
            this.pocetJedincu.Size = new System.Drawing.Size(99, 20);
            this.pocetJedincu.TabIndex = 1;
            this.pocetJedincu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pocetJedincu.ThousandsSeparator = true;
            this.pocetJedincu.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "Délka života:";
            // 
            // delkaZivota
            // 
            this.delkaZivota.Location = new System.Drawing.Point(171, 89);
            this.delkaZivota.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.delkaZivota.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delkaZivota.Name = "delkaZivota";
            this.delkaZivota.Size = new System.Drawing.Size(99, 20);
            this.delkaZivota.TabIndex = 4;
            this.delkaZivota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.delkaZivota.ThousandsSeparator = true;
            this.delkaZivota.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 104;
            this.label4.Text = "Porodnost:";
            // 
            // porodnost
            // 
            this.porodnost.Location = new System.Drawing.Point(171, 115);
            this.porodnost.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.porodnost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.porodnost.Name = "porodnost";
            this.porodnost.Size = new System.Drawing.Size(99, 20);
            this.porodnost.TabIndex = 5;
            this.porodnost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.porodnost.ThousandsSeparator = true;
            this.porodnost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 13);
            this.label5.TabIndex = 106;
            this.label5.Text = "počet narozených dětí z jednoho porodu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 13);
            this.label6.TabIndex = 109;
            this.label6.Text = "jak dlouho vydrží jedinec s jedním partnerem";
            // 
            // vernost
            // 
            this.vernost.Location = new System.Drawing.Point(171, 141);
            this.vernost.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.vernost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.vernost.Name = "vernost";
            this.vernost.Size = new System.Drawing.Size(99, 20);
            this.vernost.TabIndex = 6;
            this.vernost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vernost.ThousandsSeparator = true;
            this.vernost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 108;
            this.label7.Text = "Věrnost:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(273, 13);
            this.label8.TabIndex = 112;
            this.label8.Text = "po jaké době se znovu rozmnožuje se stejným partnerem";
            // 
            // sexinterval
            // 
            this.sexinterval.Location = new System.Drawing.Point(171, 167);
            this.sexinterval.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.sexinterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sexinterval.Name = "sexinterval";
            this.sexinterval.Size = new System.Drawing.Size(99, 20);
            this.sexinterval.TabIndex = 7;
            this.sexinterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sexinterval.ThousandsSeparator = true;
            this.sexinterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 111;
            this.label9.Text = "Sex interval:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 115;
            this.label10.Text = "věk pohlavní dospělosti";
            // 
            // dospelost
            // 
            this.dospelost.Location = new System.Drawing.Point(171, 193);
            this.dospelost.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.dospelost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dospelost.Name = "dospelost";
            this.dospelost.Size = new System.Drawing.Size(99, 20);
            this.dospelost.TabIndex = 8;
            this.dospelost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dospelost.ThousandsSeparator = true;
            this.dospelost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 114;
            this.label11.Text = "Dospělost:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(276, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(255, 13);
            this.label12.TabIndex = 118;
            this.label12.Text = "z kolika partnerů si vybírá (1: bere prvního co potká)";
            // 
            // vybiravost
            // 
            this.vybiravost.Location = new System.Drawing.Point(171, 219);
            this.vybiravost.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.vybiravost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.vybiravost.Name = "vybiravost";
            this.vybiravost.Size = new System.Drawing.Size(99, 20);
            this.vybiravost.TabIndex = 9;
            this.vybiravost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vybiravost.ThousandsSeparator = true;
            this.vybiravost.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 13);
            this.label13.TabIndex = 117;
            this.label13.Text = "Partnerská vybíravost:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(276, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(241, 13);
            this.label14.TabIndex = 121;
            this.label14.Text = "při jeho dosažení nebude probíhat rozmnožování";
            // 
            // maxPocetJedincu
            // 
            this.maxPocetJedincu.Location = new System.Drawing.Point(171, 36);
            this.maxPocetJedincu.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.maxPocetJedincu.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.maxPocetJedincu.Name = "maxPocetJedincu";
            this.maxPocetJedincu.Size = new System.Drawing.Size(99, 20);
            this.maxPocetJedincu.TabIndex = 2;
            this.maxPocetJedincu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maxPocetJedincu.ThousandsSeparator = true;
            this.maxPocetJedincu.Value = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 13);
            this.label15.TabIndex = 120;
            this.label15.Text = "Maximální počet jedinců:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(276, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(220, 13);
            this.label16.TabIndex = 122;
            this.label16.Text = "kolik jedinců se \"narodí\" při spuštení modelu";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(276, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 13);
            this.label17.TabIndex = 123;
            this.label17.Text = "po kolika letech zemře";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(276, 248);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 13);
            this.label18.TabIndex = 126;
            this.label18.Text = "pravděpodobnost mutace alely";
            // 
            // mutace
            // 
            this.mutace.Location = new System.Drawing.Point(171, 245);
            this.mutace.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.mutace.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mutace.Name = "mutace";
            this.mutace.Size = new System.Drawing.Size(99, 20);
            this.mutace.TabIndex = 10;
            this.mutace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mutace.ThousandsSeparator = true;
            this.mutace.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 248);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(155, 13);
            this.label19.TabIndex = 125;
            this.label19.Text = "Pravděpodobnost mutace:   1 /";
            // 
            // VlastnostiPopulaceForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(562, 362);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.mutace);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.maxPocetJedincu);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.vybiravost);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dospelost);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sexinterval);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vernost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.porodnost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delkaZivota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pocetJedincu);
            this.Controls.Add(this.vychoziRozlozeniGenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VlastnostiPopulaceForm";
            this.Text = "Vlastnosti populace";
            this.Load += new System.EventHandler(this.VlastnostiPopulaceForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VlastnostiPopulaceForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pocetJedincu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delkaZivota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porodnost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vernost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexinterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dospelost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vybiravost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPocetJedincu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vychoziRozlozeniGenu;
        private System.Windows.Forms.NumericUpDown pocetJedincu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown delkaZivota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown porodnost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown vernost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown sexinterval;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown dospelost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown vybiravost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown maxPocetJedincu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown mutace;
        private System.Windows.Forms.Label label19;
    }
}