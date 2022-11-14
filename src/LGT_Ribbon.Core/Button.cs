using MapInfo.Commands;
using MapInfo.Types;
using System;
using System.Linq;


namespace LGT_Ribbon.Core
{
  [Serializable]
  public class Button : CaptionedControl
  {
    #region Constructors
    public Button()
    {
      // Empty constructor is needed for LiteDB
    }
    public Button(ControlType type)
    {
      this.ControlType = type;
      this.AssignCommand = false;
    }

    public Button(Enum commandEnum, ControlType type = ControlType.Button, bool noWarnings = false)
      : this(commandEnum, null, type, noWarnings) { }
    public Button(Enum commandEnum, IMapInfoCommand command, ControlType type = ControlType.Button, bool noWarnings = false)
      : this(Convert.ToInt32(commandEnum), command, type, noWarnings)
    {
    }
    public Button(int commandId, IMapInfoCommand command, ControlType type = ControlType.Button, bool noWarnings = false)
    {
      this.CommandId = commandId;
      this.Command = command;
      this.ControlType = type;
      this.NoWarnings = noWarnings;
      // MapInfoCommand com = @enum.GetCommand();
    }

    public Button(string caption, ControlType type)
    {
      this.Caption = caption;
      this.ControlType = type;
    }
    #endregion

    #region Public Properties
    public UserLevel AccessableTo { get; set; } = UserLevel.Admin | UserLevel.User;
    public UserLevel VisibleTo { get; set; } = UserLevel.Admin | UserLevel.User;
    public IMapInfoControl Control { get; set; }
    public Button[] Children { get; set; } = new Button[] { };
    public bool AssignCommand { get; set; } = true;
    /// <summary>
    /// <see cref="CommandId"/> naudojamas nustatyti mygtuko funkcionalumą.
    /// </summary>
    public int CommandId { get; set; }
    /// <summary>
    /// <see cref="Command"/> naudojamas nustatyti mygtuko išvaizdą, ne funkcionalumą.
    /// Norėdami keisti ką mygtukas daro - naudokite <see cref="CommandId"/>.
    /// </summary>
    public IMapInfoCommand Command
    {
      set
      {
        if (value is null)
          return;
        // OwnerType
        // Name
        // Enabled
        // IsChecked

        // InputGestures // Reference

        if (value.DisplayText != null) this.DisplayText = value.DisplayText; // DisplayText
        //if (value.MenuItemText != null) this.MenuItemText = value.MenuItemText; // MenuItemText
        //if (value.MenuItemToggleText != null) this.MenuItemToggleText = value.MenuItemToggleText; // MenuItemToggleText
        if (value.SmallIcon != null) this.SmallIconPath = value.SmallIcon; // SmallIcon
        if (value.LargeIcon != null) this.LargeIconPath = value.LargeIcon; // LargeIcon
        if (value.Text != null) this.Caption = value.Text; // Text
        // ToolTip
        this.ToolTipDescription = value.ToolTipDescription; // ToolTipDescription
        this.ToolTipDisabledText = value.ToolTipDisabledText; // ToolTipDisabledText
        this.ToolTipText = value.ToolTipText; // ToolTipText
      }
    }
    public string CommandParameter { get; set; }

    public Double? Width { get; set; }
    public Double? Height { get; set; }
    public Double? ItemWidht { get; set; }
    public Double? ItemHeight { get; set; }
    public int? Index { get; set; }

    public bool Ignore {
      get
      {
        return !PC.Is(AccessableTo);
      }
    }
    public bool Visible {
      get => !PC.Is(VisibleTo);
    }

    public ControlType ControlType { get; set; } = ControlType.Button;

    public bool NoWarnings { get; private set; }
    public bool IsLarge { get; set; } = false;
    public string SmallIconPath { get; set; }
    private Uri SmallIcon
    {
      get
      {
        if (!string.IsNullOrEmpty(this.SmallIconPath))
          return new Uri(this.SmallIconPath);
        return null;
      }
    }
    public string LargeIconPath { get; set; }
    private Uri LargeIcon
    {
      get
      {
        if (!string.IsNullOrEmpty(this.LargeIconPath))
          return new Uri(this.LargeIconPath);
        return null;
      }
    }

    public IRibbonToolTip ToolTip { get; set; }
    public string ToolTipDescription { get; set; }
    public string ToolTipText { get; set; }
    public string ToolTipDisabledText { get; set; }
    #region Interface

    //public bool IsSmall { get => !IsLarge; set => IsLarge = !value; }
    public bool Enabled { get; set; }

    public string MenuItemToggleText { get; private set; }
    public string MenuItemText { get; private set; }
    public string DisplayText { get; private set; }

    //public bool IsQatItem { get; set; }


    #endregion
    #endregion

    #region Needed Properties
    //[XmlAttribute("Name")]
    //public string Name { get; set; }
    //[XmlAttribute("MenuId")]
    //public int MenuId { get; set; }

    //public string DisplayText { get; set; }
    //public string MenuItemText { get; set; }
    //public string MenuItemToggleText { get; set; }
    //public string KeyGesture { get; set; }


    #endregion

    #region Public Methods

    public void Create(IControlGroup parent)
    {
      if (this.Ignore)
        return;
      if (this.Index != null)
        Control = parent.Controls.Insert((int)Index, Name, this.Caption, ControlType);
      else
        Control = parent.Controls.Add(Name, this.Caption, ControlType);
      
      if (ControlType.HasTooltip())
      {
        if (Control is IControl control && !string.IsNullOrEmpty(this.ToolTipText))
        {
          control.ToolTip = new MapInfoRibbonToolTip()
          {
            ToolTipText = this.ToolTipText,
            ToolTipDescription = this.ToolTipDescription,
            ToolTipDisabledText = this.ToolTipDisabledText
          };
        }
      }
      if (Control is ICommandControl CommandControl && AssignCommand && ControlType.IsCommandable())
      {
        //CallingHandler
        //Command+
        //CommandId
        //ComandParameter
        //KeyGesture
        if (this.CommandId > 0) CommandControl.CommandId = this.CommandId;
        if (!string.IsNullOrEmpty(CommandParameter)) CommandControl.CommandParameter = this.CommandParameter;
      }
      if (ControlType.HasImage())
      {
        if (Control is IImageControl ImageControl)
        {
          ImageControl.IsLarge = IsLarge;
          if (LargeIcon != null) ImageControl.LargeIcon = LargeIcon;
          if (SmallIcon != null) ImageControl.SmallIcon = SmallIcon;
        }
      }
      if (ControlType.HasDimensions())
      {
        IWrapPanel wrapPanel = (IWrapPanel)Control;
        if (this.ItemWidht != null) wrapPanel.ItemWidth = (Double)this.ItemWidht;
        if (this.ItemHeight != null) wrapPanel.ItemHeight = (Double)this.ItemHeight;
      }
      foreach (var Child in Children)
      {
        if (Control is IControlGroup group)
          //if (ControlType == ControlType.DropDownButton || ControlType == ControlType.WrapPanel)
          Child.Create((IControlGroup)Control, this.Name);
        else throw new Exception($"{Name} is not a ControlGroup, it cant have children. {Name} is {ControlType}. He has {Children.Count()} children.");
      }
    }

    public void Create(IControlGroup group, string parentName)
    {
      this.ParentName = parentName;
      Create(group);

    }
    public void Unload(IMapInfoControlCollection parentGroup)
    {
      if (Control != null)
        parentGroup.Remove(Control);
    }
    #endregion

    #region Implicit conversion
    public static implicit operator Button[] (Button a) => new Button[] { a };
    #endregion
  }
}
