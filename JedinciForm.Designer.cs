namespace RURGenetika {
    partial class JedinciForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JedinciForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pocetJedincu = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.zobrazit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pocetJedincu});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(342, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pocetJedincu
            // 
            this.pocetJedincu.Name = "pocetJedincu";
            this.pocetJedincu.Size = new System.Drawing.Size(84, 17);
            this.pocetJedincu.Tag = "Počet jedinců: ";
            this.pocetJedincu.Text = "Počet jedinců: 0";
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel.Location = new System.Drawing.Point(0, 54);
            this.panel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 25);
            this.panel.MinimumSize = new System.Drawing.Size(150, 20);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(150, 20);
            this.panel.TabIndex = 9;
            this.panel.WrapContents = false;
            // 
            // zobrazit
            // 
            this.zobrazit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zobrazit.FormattingEnabled = true;
            this.zobrazit.Location = new System.Drawing.Point(56, 25);
            this.zobrazit.Name = "zobrazit";
            this.zobrazit.Size = new System.Drawing.Size(256, 21);
            this.zobrazit.TabIndex = 10;
            this.zobrazit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 28);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Zobrazit:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // JedinciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.ClientSize = new System.Drawing.Size(342, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zobrazit);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "JedinciForm";
            this.Text = "Jedinci";
            this.Load += new System.EventHandler(this.JedinciForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JedinciForm_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel pocetJedincu;
        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.ComboBox zobrazit;
        private System.Windows.Forms.Label label1;
    }
}