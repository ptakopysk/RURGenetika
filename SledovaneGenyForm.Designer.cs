namespace RURGenetika
{
    partial class SledovaneGenyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SledovaneGenyForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pocetSledovanychGenu = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pocetSledovanychGenu});
            this.statusStrip1.Location = new System.Drawing.Point(0, 79);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(239, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pocetSledovanychGenu
            // 
            this.pocetSledovanychGenu.Name = "pocetSledovanychGenu";
            this.pocetSledovanychGenu.Size = new System.Drawing.Size(137, 17);
            this.pocetSledovanychGenu.Tag = "Počet sledovaných genů: ";
            this.pocetSledovanychGenu.Text = "Počet sledovaných genů: 0";
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel.Location = new System.Drawing.Point(5, 5);
            this.panel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 25);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(220, 62);
            this.panel.TabIndex = 6;
            // 
            // SledovaneGenyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(239, 101);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SledovaneGenyForm";
            this.Text = "Sledované geny";
            this.Activated += new System.EventHandler(this.SledovaneGeny_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SledovaneGenyForm_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel pocetSledovanychGenu;
        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}