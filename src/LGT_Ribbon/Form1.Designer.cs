using System.IO;

namespace LGT_Ribbon
{
  partial class Form1
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
    private void InitializeComponent()
    {
      this.PakeitimuTekstas = new System.Windows.Forms.TextBox();
      this.TabControlMain = new System.Windows.Forms.TabControl();
      this.Pakeitimai = new System.Windows.Forms.TabPage();
      this.Instrukcijos = new System.Windows.Forms.TabPage();
      this.InstrukcijuTekstas = new System.Windows.Forms.TextBox();
      this.TabControlMain.SuspendLayout();
      this.Pakeitimai.SuspendLayout();
      this.Instrukcijos.SuspendLayout();
      this.SuspendLayout();
      // 
      // PakeitimuTekstas
      // 
      this.PakeitimuTekstas.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PakeitimuTekstas.Location = new System.Drawing.Point(3, 3);
      this.PakeitimuTekstas.Multiline = true;
      this.PakeitimuTekstas.Name = "PakeitimuTekstas";
      this.PakeitimuTekstas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.PakeitimuTekstas.Size = new System.Drawing.Size(490, 418);
      this.PakeitimuTekstas.TabIndex = 0;
      this.PakeitimuTekstas.Text = "Nepavyko nuskaityti log failo \\\\granitas\\visi_gis\\visi_gis\\MI_17\\Ribbon\\Vartotoju" +
    " log.txt.";
      // 
      // TabControlMain
      // 
      this.TabControlMain.Controls.Add(this.Pakeitimai);
      this.TabControlMain.Controls.Add(this.Instrukcijos);
      this.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TabControlMain.Location = new System.Drawing.Point(0, 0);
      this.TabControlMain.Name = "TabControlMain";
      this.TabControlMain.SelectedIndex = 0;
      this.TabControlMain.Size = new System.Drawing.Size(504, 450);
      this.TabControlMain.TabIndex = 1;
      // 
      // Pakeitimai
      // 
      this.Pakeitimai.Controls.Add(this.PakeitimuTekstas);
      this.Pakeitimai.Location = new System.Drawing.Point(4, 22);
      this.Pakeitimai.Name = "Pakeitimai";
      this.Pakeitimai.Padding = new System.Windows.Forms.Padding(3);
      this.Pakeitimai.Size = new System.Drawing.Size(496, 424);
      this.Pakeitimai.TabIndex = 0;
      this.Pakeitimai.Text = "Pakeitimai";
      this.Pakeitimai.UseVisualStyleBackColor = true;
      // 
      // Instrukcijos
      // 
      this.Instrukcijos.Controls.Add(this.InstrukcijuTekstas);
      this.Instrukcijos.Location = new System.Drawing.Point(4, 22);
      this.Instrukcijos.Name = "Instrukcijos";
      this.Instrukcijos.Padding = new System.Windows.Forms.Padding(3);
      this.Instrukcijos.Size = new System.Drawing.Size(496, 424);
      this.Instrukcijos.TabIndex = 1;
      this.Instrukcijos.Text = "Instrukcijos";
      this.Instrukcijos.UseVisualStyleBackColor = true;
      // 
      // InstrukcijuTekstas
      // 
      this.InstrukcijuTekstas.Dock = System.Windows.Forms.DockStyle.Fill;
      this.InstrukcijuTekstas.Location = new System.Drawing.Point(3, 3);
      this.InstrukcijuTekstas.Multiline = true;
      this.InstrukcijuTekstas.Name = "InstrukcijuTekstas";
      this.InstrukcijuTekstas.Size = new System.Drawing.Size(490, 418);
      this.InstrukcijuTekstas.TabIndex = 0;
      this.InstrukcijuTekstas.Text = "Nepavyko nuskaityti instrukcijų failo \\\\granitas\\visi_gis\\visi_gis\\MI_17\\Ribbon\\V" +
    "artotoju instrukcijos.txt.";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(504, 450);
      this.Controls.Add(this.TabControlMain);
      this.Name = "Form1";
      this.Text = "LGT Ribbon";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
      this.TabControlMain.ResumeLayout(false);
      this.Pakeitimai.ResumeLayout(false);
      this.Pakeitimai.PerformLayout();
      this.Instrukcijos.ResumeLayout(false);
      this.Instrukcijos.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl TabControlMain;
    private System.Windows.Forms.TabPage Pakeitimai;
    private System.Windows.Forms.TextBox PakeitimuTekstas;
    private System.Windows.Forms.TabPage Instrukcijos;
    private System.Windows.Forms.TextBox InstrukcijuTekstas;

  }
}