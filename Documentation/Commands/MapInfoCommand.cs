// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.MapInfoCommand
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

using MapInfo.Controls.Resources;
using MapInfo.StyleResources.Converters;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace MapInfo.Commands
{
  public class MapInfoCommand : RoutedUICommand, INotifyPropertyChanged, IMapInfoCommand, ICommand
  {
    private string _toolTipDescription = string.Empty;
    public const string ResourceFormat = "Command_{0}_{1}";
    private const string _toolTipDescriptionFormat = "{0} ({1})";
    private string _toolTipDisabledText;
    private string _smallIcon;
    private string _largeIcon;
    private string _menuItemText;
    private string _menuItemToggleText;
    private static double? _tipWidth;
    private bool _isChecked;
    protected bool _enabled;

    public string ToolTipDescription
    {
      get
      {
        return this._toolTipDescription;
      }
      set
      {
        this._toolTipDescription = value;
        if (string.IsNullOrWhiteSpace(this.InputGestureText) || string.IsNullOrWhiteSpace(value))
          return;
        this._toolTipDescription = string.Format("{0} ({1})", (object) Regex.Replace(value, "([\\w\\s]+\\w+)([\\s]*)(\\()(.+)", "$1"), (object) this.InputGestureText);
      }
    }

    public ToolTip ToolTip { get; set; }

    public string ToolTipText { get; set; }

    public string ToolTipDisabledText
    {
      get
      {
        return this._toolTipDisabledText;
      }
      internal set
      {
        if (!string.IsNullOrWhiteSpace(this.Name))
        {
          string overrideString = MapInfoProResourceManager.GetOverrideString(string.Format("Command_{0}_{1}", (object) this.Name, (object) "ToolTip_DisabledText"));
          if (!string.IsNullOrWhiteSpace(overrideString))
            value = overrideString;
        }
        this._toolTipDisabledText = value;
      }
    }

    public string DisplayText { get; set; }

    public string SmallIcon
    {
      get
      {
        return this._smallIcon;
      }
      set
      {
        if (!string.IsNullOrWhiteSpace(this.Name))
        {
          string overrideString = MapInfoProResourceManager.GetOverrideString(string.Format("Command_{0}_{1}", (object) this.Name, (object) nameof (SmallIcon)));
          if (!string.IsNullOrWhiteSpace(overrideString))
            value = overrideString;
        }
        this._smallIcon = value;
      }
    }

    public string LargeIcon
    {
      get
      {
        return this._largeIcon;
      }
      set
      {
        if (!string.IsNullOrWhiteSpace(this.Name))
        {
          string overrideString = MapInfoProResourceManager.GetOverrideString(string.Format("Command_{0}_{1}", (object) this.Name, (object) nameof (LargeIcon)));
          if (!string.IsNullOrWhiteSpace(overrideString))
            value = overrideString;
        }
        this._largeIcon = value;
      }
    }

    public string MenuItemText
    {
      get
      {
        return this._menuItemText ?? (this._menuItemText = this.Text);
      }
      set
      {
        this._menuItemText = value;
      }
    }

    public string MenuItemToggleText
    {
      get
      {
        return this._menuItemToggleText ?? (this._menuItemToggleText = this.MenuItemText);
      }
      set
      {
        this._menuItemToggleText = value;
      }
    }

    public string Category { get; set; }

    public new virtual event EventHandler CanExecuteChanged
    {
      add
      {
        if (value == null)
          return;
        CommandManager.RequerySuggested += value;
      }
      remove
      {
        if (value == null)
          return;
        CommandManager.RequerySuggested -= value;
      }
    }

    public static double TipWidth
    {
      get
      {
        if (!MapInfoCommand._tipWidth.HasValue)
        {
          double result;
          MapInfoCommand._tipWidth = new double?(double.TryParse(MapInfo.Controls.Properties.Resources.ScreenTip_Width, out result) ? result : 175.0);
        }
        return MapInfoCommand._tipWidth.Value;
      }
    }

    public bool IsChecked
    {
      get
      {
        return this._isChecked;
      }
      set
      {
        if (this._isChecked == value)
          return;
        this._isChecked = value;
        this.OnPropertyChanged(nameof (IsChecked));
      }
    }

    public virtual bool Enabled
    {
      get
      {
        return this._enabled;
      }
      set
      {
        if (this._enabled == value)
          return;
        this._enabled = value;
        this.OnPropertyChanged(nameof (Enabled));
      }
    }

    public string InputGestureText { get; set; }

    internal static InputGestureCollection CreateGesture(string name)
    {
      if (!string.IsNullOrWhiteSpace(name))
      {
        string overrideString = MapInfoProResourceManager.GetOverrideString(string.Format("Command_{0}_{1}", (object) name, (object) "KeyGesture"));
        if (!string.IsNullOrWhiteSpace(overrideString))
          return MapInfoCommand.GetGesture(overrideString);
      }
      return (InputGestureCollection) null;
    }

    public MapInfoCommand(
      string text,
      string name,
      Type ownerType,
      InputGestureCollection inputGestureCollection)
      : base(text, name, ownerType, inputGestureCollection ?? MapInfoCommand.CreateGesture(name))
    {
      if (!string.IsNullOrWhiteSpace(this.Name))
      {
        string overrideString1 = MapInfoProResourceManager.GetOverrideString(string.Format("Command_{0}_{1}", (object) this.Name, (object) nameof (MenuItemText)));
        if (!string.IsNullOrWhiteSpace(overrideString1))
          this._menuItemText = overrideString1;
        string overrideString2 = MapInfoProResourceManager.GetOverrideString(string.Format("Command_{0}_{1}", (object) this.Name, (object) nameof (MenuItemToggleText)));
        if (!string.IsNullOrWhiteSpace(overrideString2))
          this._menuItemToggleText = overrideString2;
      }
      if (inputGestureCollection != null && inputGestureCollection.Count > 1)
        throw new ArgumentException(MapInfo.Controls.Properties.Resources.Command_MapInfoCommand_MultipleKeyGesture_Error, nameof (inputGestureCollection));
      this.InputGestureText = this.InputGestures == null || this.InputGestures.Count <= 0 || !(this.InputGestures[0] is KeyGesture) ? string.Empty : ((KeyGesture) this.InputGestures[0]).GetDisplayStringForCulture(CultureInfo.CurrentUICulture);
    }

    public MapInfoCommand(string text, string name, InputGestureCollection inputGestureCollection)
      : this(text, name, typeof (MapInfoCommand), inputGestureCollection)
    {
    }

    public virtual void Execute(object sender, ExecutedRoutedEventArgs e)
    {
    }

    public virtual bool CanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
      return true;
    }

    public virtual void RaiseCanExecuteChanged()
    {
    }

    internal static InputGestureCollection GetGesture(string shortcut)
    {
      try
      {
        if (string.IsNullOrWhiteSpace(shortcut))
          return (InputGestureCollection) null;
        InputGestureCollection gestureCollection = new InputGestureCollection();
        KeyGesture keyGesture = (KeyGesture) new KeyGestureConverter().ConvertFromString(shortcut);
        if (keyGesture != null)
          gestureCollection.Add((InputGesture) keyGesture);
        return gestureCollection;
      }
      catch
      {
        return (InputGestureCollection) null;
      }
    }

    internal static ToolTip GetScreenTip(
      string description,
      string tooltipText,
      string disabledText)
    {
      ScreenTip screenTip = new ScreenTip();
      screenTip.Description = description;
      screenTip.HelpText = MapInfo.Controls.Properties.Resources.Command_ToolTip_HelpText;
      StackPanel stackPanel = new StackPanel();
      TextBlock textBlock1 = new TextBlock();
      textBlock1.Width = MapInfoCommand.TipWidth;
      textBlock1.FontSize = 11.0;
      textBlock1.HorizontalAlignment = HorizontalAlignment.Left;
      textBlock1.Foreground = (Brush) new SolidColorBrush(Color.FromArgb(byte.MaxValue, (byte) 76, (byte) 76, (byte) 76));
      TextBlock textBlock2 = textBlock1;
      Binding binding = new Binding()
      {
        RelativeSource = new RelativeSource(RelativeSourceMode.FindAncestor, typeof (ScreenTip), 1),
        Path = new PropertyPath("PlacementTarget.IsEnabled", Array.Empty<object>()),
        Converter = (IValueConverter) new BoolToInvertedVisibilityConverter()
      };
      textBlock2.TextWrapping = TextWrapping.Wrap;
      textBlock2.Inlines.Add((Inline) new Run(disabledText));
      textBlock2.Inlines.Add((Inline) new LineBreak());
      stackPanel.Children.Add((UIElement) textBlock2);
      textBlock2.SetBinding(UIElement.VisibilityProperty, (BindingBase) binding);
      TextBlock textBlock3 = new TextBlock();
      textBlock3.Text = tooltipText;
      textBlock3.FontSize = 11.0;
      textBlock3.Width = MapInfoCommand.TipWidth;
      textBlock3.HorizontalAlignment = HorizontalAlignment.Left;
      textBlock3.Foreground = (Brush) new SolidColorBrush(Color.FromArgb(byte.MaxValue, (byte) 76, (byte) 76, (byte) 76));
      textBlock3.TextWrapping = TextWrapping.Wrap;
      TextBlock textBlock4 = textBlock3;
      if (textBlock4.Text == null || textBlock4.Text.Trim().Length == 0)
        textBlock4.Visibility = Visibility.Collapsed;
      stackPanel.Children.Add((UIElement) textBlock4);
      screenTip.Content = (object) stackPanel;
      return (ToolTip) screenTip;
    }

    internal void CreateScreenTip()
    {
      this.ToolTip = MapInfoCommand.GetScreenTip(this.ToolTipDescription, this.ToolTipText, this.ToolTipDisabledText);
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
      if (propertyChanged == null)
        return;
      propertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    [SpecialName]
    string IMapInfoCommand.get_Text()
    {
      return this.Text;
    }

    [SpecialName]
    void IMapInfoCommand.set_Text(string value)
    {
      this.Text = value;
    }

    [SpecialName]
    string IMapInfoCommand.get_Name()
    {
      return this.Name;
    }

    [SpecialName]
    Type IMapInfoCommand.get_OwnerType()
    {
      return this.OwnerType;
    }

    [SpecialName]
    InputGestureCollection IMapInfoCommand.get_InputGestures()
    {
      return this.InputGestures;
    }
  }
}
