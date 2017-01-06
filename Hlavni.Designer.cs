namespace RURGenetika
{
    partial class Hlavni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hlavni));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jedenkrokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.víceKrokůToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zastavitModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.populaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nováPopulaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vlastnostiPopulaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jedinciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přidatGenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sledovanéGenyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nápovědaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cas = new System.Windows.Forms.ToolStripStatusLabel();
            this.pocetJedincu = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.restartovatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelToolStripMenuItem,
            this.populaceToolStripMenuItem,
            this.genyToolStripMenuItem,
            this.nápovědaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem,
            this.krokToolStripMenuItem,
            this.zastavitModelToolStripMenuItem});
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.modelToolStripMenuItem.Text = "&Model";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sToolStripMenuItem.Image")));
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.sToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.sToolStripMenuItem.Text = "Spustit &model";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // krokToolStripMenuItem
            // 
            this.krokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jedenkrokToolStripMenuItem,
            this.víceKrokůToolStripMenuItem});
            this.krokToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("krokToolStripMenuItem.Image")));
            this.krokToolStripMenuItem.Name = "krokToolStripMenuItem";
            this.krokToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.krokToolStripMenuItem.Text = "&Krok";
            // 
            // jedenkrokToolStripMenuItem
            // 
            this.jedenkrokToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("jedenkrokToolStripMenuItem.Image")));
            this.jedenkrokToolStripMenuItem.Name = "jedenkrokToolStripMenuItem";
            this.jedenkrokToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.jedenkrokToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.jedenkrokToolStripMenuItem.Text = "Jeden &krok";
            this.jedenkrokToolStripMenuItem.Click += new System.EventHandler(this.jedenkrokToolStripMenuItem_Click);
            // 
            // víceKrokůToolStripMenuItem
            // 
            this.víceKrokůToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("víceKrokůToolStripMenuItem.Image")));
            this.víceKrokůToolStripMenuItem.Name = "víceKrokůToolStripMenuItem";
            this.víceKrokůToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.K)));
            this.víceKrokůToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.víceKrokůToolStripMenuItem.Text = "&Více kroků...";
            this.víceKrokůToolStripMenuItem.Click += new System.EventHandler(this.víceKrokůToolStripMenuItem_Click);
            // 
            // zastavitModelToolStripMenuItem
            // 
            this.zastavitModelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zastavitModelToolStripMenuItem.Image")));
            this.zastavitModelToolStripMenuItem.Name = "zastavitModelToolStripMenuItem";
            this.zastavitModelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.M)));
            this.zastavitModelToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.zastavitModelToolStripMenuItem.Text = "&Zastavit model";
            this.zastavitModelToolStripMenuItem.Click += new System.EventHandler(this.zastavitModelToolStripMenuItem_Click);
            // 
            // populaceToolStripMenuItem
            // 
            this.populaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nováPopulaceToolStripMenuItem,
            this.vlastnostiPopulaceToolStripMenuItem,
            this.jedinciToolStripMenuItem});
            this.populaceToolStripMenuItem.Name = "populaceToolStripMenuItem";
            this.populaceToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.populaceToolStripMenuItem.Text = "&Populace";
            // 
            // nováPopulaceToolStripMenuItem
            // 
            this.nováPopulaceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nováPopulaceToolStripMenuItem.Image")));
            this.nováPopulaceToolStripMenuItem.Name = "nováPopulaceToolStripMenuItem";
            this.nováPopulaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nováPopulaceToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.nováPopulaceToolStripMenuItem.Text = "&Nová populace";
            this.nováPopulaceToolStripMenuItem.Click += new System.EventHandler(this.nováPopulaceToolStripMenuItem_Click);
            // 
            // vlastnostiPopulaceToolStripMenuItem
            // 
            this.vlastnostiPopulaceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vlastnostiPopulaceToolStripMenuItem.Image")));
            this.vlastnostiPopulaceToolStripMenuItem.Name = "vlastnostiPopulaceToolStripMenuItem";
            this.vlastnostiPopulaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.V)));
            this.vlastnostiPopulaceToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.vlastnostiPopulaceToolStripMenuItem.Text = "&Vlastnosti populace";
            this.vlastnostiPopulaceToolStripMenuItem.Click += new System.EventHandler(this.vlastnostiPopulaceToolStripMenuItem_Click);
            // 
            // jedinciToolStripMenuItem
            // 
            this.jedinciToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("jedinciToolStripMenuItem.Image")));
            this.jedinciToolStripMenuItem.Name = "jedinciToolStripMenuItem";
            this.jedinciToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.J)));
            this.jedinciToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.jedinciToolStripMenuItem.Text = "&Jedinci";
            this.jedinciToolStripMenuItem.Click += new System.EventHandler(this.jedinciToolStripMenuItem_Click);
            // 
            // genyToolStripMenuItem
            // 
            this.genyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.přidatGenToolStripMenuItem,
            this.sledovanéGenyToolStripMenuItem});
            this.genyToolStripMenuItem.Name = "genyToolStripMenuItem";
            this.genyToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.genyToolStripMenuItem.Text = "&Geny a znaky";
            // 
            // přidatGenToolStripMenuItem
            // 
            this.přidatGenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("přidatGenToolStripMenuItem.Image")));
            this.přidatGenToolStripMenuItem.Name = "přidatGenToolStripMenuItem";
            this.přidatGenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.přidatGenToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.přidatGenToolStripMenuItem.Text = "Přidat &gen";
            this.přidatGenToolStripMenuItem.Click += new System.EventHandler(this.přidatGenToolStripMenuItem_Click);
            // 
            // sledovanéGenyToolStripMenuItem
            // 
            this.sledovanéGenyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sledovanéGenyToolStripMenuItem.Image")));
            this.sledovanéGenyToolStripMenuItem.Name = "sledovanéGenyToolStripMenuItem";
            this.sledovanéGenyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.S)));
            this.sledovanéGenyToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.sledovanéGenyToolStripMenuItem.Text = "&Sledované geny";
            this.sledovanéGenyToolStripMenuItem.Click += new System.EventHandler(this.sledovanéGenyToolStripMenuItem_Click);
            // 
            // nápovědaToolStripMenuItem
            // 
            this.nápovědaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oToolStripMenuItem,
            this.restartovatToolStripMenuItem,
            this.konecToolStripMenuItem});
            this.nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            this.nápovědaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.nápovědaToolStripMenuItem.Text = "&Aplikace";
            // 
            // oToolStripMenuItem
            // 
            this.oToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("oToolStripMenuItem.Image")));
            this.oToolStripMenuItem.Name = "oToolStripMenuItem";
            this.oToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.O)));
            this.oToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.oToolStripMenuItem.Text = "&O...";
            this.oToolStripMenuItem.Click += new System.EventHandler(this.oToolStripMenuItem_Click);
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("konecToolStripMenuItem.Image")));
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.konecToolStripMenuItem.Text = "&Konec";
            this.konecToolStripMenuItem.Click += new System.EventHandler(this.konecToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "program je spuštěn";
            this.notifyIcon1.BalloonTipTitle = "RURGenetika";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "RURGenetika";
            this.notifyIcon1.Visible = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cas,
            this.pocetJedincu,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 186);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(292, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cas
            // 
            this.cas.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.cas.Name = "cas";
            this.cas.Size = new System.Drawing.Size(42, 17);
            this.cas.Tag = "Čas: ";
            this.cas.Text = "Čas: 0";
            // 
            // pocetJedincu
            // 
            this.pocetJedincu.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.pocetJedincu.Name = "pocetJedincu";
            this.pocetJedincu.Size = new System.Drawing.Size(88, 17);
            this.pocetJedincu.Tag = "Počet jedinců: ";
            this.pocetJedincu.Text = "Počet jedinců: 0";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Visible = false;
            // 
            // restartovatToolStripMenuItem
            // 
            this.restartovatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restartovatToolStripMenuItem.Image")));
            this.restartovatToolStripMenuItem.Name = "restartovatToolStripMenuItem";
            this.restartovatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F5)));
            this.restartovatToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.restartovatToolStripMenuItem.Text = "Restartovat";
            this.restartovatToolStripMenuItem.Click += new System.EventHandler(this.restartovatToolStripMenuItem_Click);
            // 
            // Hlavni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 208);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Hlavni";
            this.Text = "RURGenetika";
            this.Load += new System.EventHandler(this.Hlavni_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem populaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nováPopulaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vlastnostiPopulaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přidatGenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nápovědaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sledovanéGenyToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem oToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jedinciToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel pocetJedincu;
        private System.Windows.Forms.ToolStripStatusLabel cas;
        private System.Windows.Forms.ToolStripMenuItem zastavitModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jedenkrokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem víceKrokůToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartovatToolStripMenuItem;
    }
}

