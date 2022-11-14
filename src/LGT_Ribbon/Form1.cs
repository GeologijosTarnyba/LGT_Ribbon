using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGT_Ribbon
{
  public partial class Form1:Form
  {
    public Form1()
    {
      InitializeComponent();
      if (File.Exists(Resource1.LogFileLoc)) {
        this.PakeitimuTekstas.Text = File.ReadAllText(Resource1.LogFileLoc);
      }
      if (File.Exists(Resource1.InstrukcijuFileLoc)) {
        this.InstrukcijuTekstas.Text = File.ReadAllText(Resource1.InstrukcijuFileLoc);
      }
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      this.Dispose();
    }
  }
}
