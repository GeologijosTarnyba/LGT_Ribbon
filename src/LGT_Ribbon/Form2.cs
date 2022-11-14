using MapInfo.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGT_Ribbon
{
  public enum FormEnded
  {
    succeeded,
    cancelled,
    closed, 
    failed
  }
  public partial class Form2:Form
  {
    public IMapInfoPro MapInfoPro;
    protected IWindowInfo[] maps;
    protected IWindowInfo[] layouts;
    protected string[] mapNames;

    public int? MapID {
      get { 
        if (this.comboBox1.SelectedIndex < 0)
          return null;
        return maps [this.comboBox1.SelectedIndex]?.WindowId;
      }
    } 
    public FormEnded State { get; set; } = FormEnded.succeeded;
    public Form2()
    {
      InitializeComponent();
    }

    private void Form2_Load(object sender, EventArgs e)
    {
      this.layouts = MapInfoPro.Windows.Where(item => item.WindowGroup == "Layouts").ToArray();
      if (this.layouts.Length == 0) {
        MessageBox.Show("Layout window doesn't exist.");
        Close();
      }
      this.maps = MapInfoPro.Windows.Where(item => item.WindowType == WindowType.ViewWindow && !item.IsEmbedded).ToArray();
      mapNames = maps.Select(item => item.Caption).ToArray();
      this.comboBox1.Items.Clear();
      this.comboBox1.Items.AddRange(maps.Select(item => item.Caption).ToArray());

    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (this.MapID == null) {
        MessageBox.Show($"Select a map first.");
        return;
      }
      MB.AddMapToLayout(this.MapInfoPro, mapWindowID: this.MapID,
        xy1: this.textBox1.Text,
        xy2: this.textBox2.Text,
        units: "cm"
      );
      this.Close();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      int WIN_INFO_WIDTH = 4;
      int WIN_INFO_HEIGHT = 5;
      this.textBox2.Text = $"({this.MapInfoPro.EvalMapBasicCommand($"WindowInfo({ this.MapID}, {WIN_INFO_WIDTH})")},{this.MapInfoPro.EvalMapBasicCommand($"WindowInfo({this.MapID}, {WIN_INFO_HEIGHT})")})";
    }
  }
}
