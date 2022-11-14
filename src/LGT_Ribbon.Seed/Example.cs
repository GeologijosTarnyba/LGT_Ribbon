using LGT_Ribbon.Core;
using MapInfo.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGT_Ribbon.Seed
{
  public static class Example
  {
    static Example()
    {
      All = new List<Button>() {
        BackStageButton, BackStageSeparator, BackStageTabItem, BackStageTabSection,
        Button,
        CheckBox,
        ContextMenuItem, ContextMenuSeparator,
        CustomControl,
        DropDownButton, DropDownMenuGroup,
        GalleryControl, GalleryGroup, GalleryItem,
        Image,
        MenuItemSeparator,
        RadioButton,
        RibbonButtonPanel, RibbonMenuGroup, RibbonMenuItem, RibbonSeparator,
        SplitButton,
        StackPanel,
        TextBlock, 
        ToolButton, Unknown, WrapPanel
      };
    }
    public static List<Button> All { get; set; }
    public static Button BackStageButton = new Button("BackStageButton", ControlType.BackStageButton);
    public static Button BackStageSeparator = new Button("BackStageSeparator", ControlType.BackStageSeparator);
    public static Button BackStageTabItem = new Button("BackStageTabItem", ControlType.BackStageTabItem);
    public static Button BackStageTabSection = new Button("BackStageTabSection", ControlType.BackStageTabSection);
    public static Button Button = new Button("Button", ControlType.Button);
    public static Button CheckBox = new Button("CheckBox", ControlType.CheckBox);
    public static Button ContextMenuItem = new Button("ContextMenuItem", ControlType.ContextMenuItem);
    public static Button ContextMenuSeparator = new Button("ContextMenuSeparator", ControlType.ContextMenuSeparator);
    public static Button CustomControl = new Button("CustomControl", ControlType.CustomControl);
    public static Button DropDownButton = new Button("DropDownButton", ControlType.DropDownButton);
    public static Button DropDownMenuGroup = new Button("DropDownMenuGroup", ControlType.DropDownMenuGroup);
    public static Button GalleryControl = new Button("GalleryControl", ControlType.GalleryControl);
    public static Button GalleryGroup = new Button("GalleryGroup", ControlType.GalleryGroup);
    public static Button GalleryItem = new Button("GalleryItem", ControlType.GalleryItem);
    public static Button Image = new Button("Image", ControlType.Image);
    public static Button MenuItemSeparator = new Button("MenuItemSeparator", ControlType.MenuItemSeparator);
    public static Button RadioButton = new Button("RadioButton", ControlType.RadioButton);
    public static Button RibbonButtonPanel = new Button("RibbonButtonPanel", ControlType.RibbonButtonPanel);
    public static Button RibbonMenuGroup = new Button("RibbonMenuGroup", ControlType.RibbonMenuGroup);
    public static Button RibbonMenuItem = new Button("RibbonMenuItem", ControlType.RibbonMenuItem);
    public static Button RibbonSeparator = new Button("RibbonSeparator", ControlType.RibbonSeparator);
    public static Button SplitButton = new Button("SplitButton", ControlType.SplitButton);
    public static Button StackPanel = new Button("StackPanel", ControlType.StackPanel);
    public static Button TextBlock = new Button("TextBlock", ControlType.TextBlock);
    public static Button ToolButton = new Button("ToolButton", ControlType.ToolButton);
    public static Button Unknown = new Button("Unknown", ControlType.Unknown);
    public static Button WrapPanel = new Button("WrapPanel", ControlType.WrapPanel);
  }
}
