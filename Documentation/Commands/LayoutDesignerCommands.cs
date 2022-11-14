// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.LayoutDesignerCommands
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.MiPro.Controls;
using MapInfo.MiPro.MiSense;
using System;
using System.Reflection;
using System.Windows.Input;

namespace MapInfo.Commands
{
  [Serializable]
  public class LayoutDesignerCommands : MapBasicCommand
  {
    private readonly string _actualPropertyName;
    private readonly object _commandParam;

    public LayoutDesignerCommands()
    {
    }

    public LayoutDesignerCommands(
      string name,
      InputGestureCollection inputGestureCollection,
      string propertyName,
      object cmdParam = null)
      : base(string.Empty, name, string.Empty, inputGestureCollection)
    {
      this._actualPropertyName = propertyName;
      this._commandParam = cmdParam;
    }

    public override void Execute(object sender, ExecutedRoutedEventArgs e)
    {
      ICommand command = this.GetCommand((ICommand) this);
      if (command == null)
        return;
      command.Execute(e == null || e.Parameter == null ? this._commandParam : e.Parameter);
      UsageLogger.LogCommandEvent("layout", this._actualPropertyName, (string) null);
    }

    public override bool CanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
      ICommand command = this.GetCommand((ICommand) this);
      if (command != null)
      {
        this.Enabled = command.CanExecute(e == null || e.Parameter == null ? this._commandParam : e.Parameter);
        return this._enabled;
      }
      this.Enabled = false;
      return this._enabled;
    }

    private ICommand GetCommand(ICommand e)
    {
      if (MapBasicCommand.CommandController != null)
      {
        string s = MapBasicCommand.CommandController.EvalMapBasicCommand("frontwindow()", false, true);
        if (!string.IsNullOrEmpty(s))
        {
          ILayoutCommand layoutCommand = MapBasicCommand.CommandController.LayoutCommand(int.Parse(s));
          if (layoutCommand != null)
          {
            MapBasicCommand mapBasicCommand = e as MapBasicCommand;
            try
            {
              if (mapBasicCommand != null)
              {
                PropertyInfo property = layoutCommand.GetType().GetProperty(this._actualPropertyName);
                if (property != (PropertyInfo) null)
                  return (ICommand) property.GetValue((object) layoutCommand, (object[]) null);
              }
            }
            catch
            {
            }
          }
        }
      }
      return (ICommand) null;
    }
  }
}
