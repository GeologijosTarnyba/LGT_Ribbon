using MapInfo.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace LGT_Ribbon.Core
{
  public static class ControlTypeDetails
  {
    public static bool IsCommandable(this ControlType controlType)
    {
      switch (controlType)
      {
        case ControlType.ToolButton:
        case ControlType.Button:
        case ControlType.BackStageButton:
        case ControlType.SplitButton:
          return true;
        default:
          return false;
      }
    }

    public static bool HasDimensions(this ControlType controlType)
    {
      return 
        controlType == ControlType.WrapPanel
      ;
    }
    public static bool HasImage(this ControlType controlType)
    {
      return 
        controlType != ControlType.RibbonMenuItem &&
        controlType != ControlType.ContextMenuItem &&
        controlType != ControlType.GalleryItem &&
        controlType != ControlType.RibbonMenuGroup &&
        controlType != ControlType.DropDownMenuGroup
      ;
    }
    public static bool HasTooltip(this ControlType controlType)
    {
      switch (controlType)
      {
        case ControlType.RibbonMenuItem:
        case ControlType.RibbonButtonPanel:
        case ControlType.RibbonSeparator:
        case ControlType.ContextMenuItem:
        case ControlType.BackStageTabItem:
        case ControlType.BackStageTabSection:
        case ControlType.BackStageSeparator:
        case ControlType.DropDownButton:
        case ControlType.DropDownMenuGroup:
        case ControlType.ContextMenuSeparator:
        case ControlType.CustomControl:
        case ControlType.GalleryGroup:
        case ControlType.MenuItemSeparator:
        case ControlType.RibbonMenuGroup:
        case ControlType.StackPanel:
        case ControlType.Unknown:
        case ControlType.WrapPanel:
          return false;
        case ControlType.Button:
        case ControlType.ToolButton:
        case ControlType.CheckBox:
        case ControlType.RadioButton:
        case ControlType.BackStageButton:
        case ControlType.GalleryControl:
        case ControlType.GalleryItem:
        case ControlType.SplitButton:
        case ControlType.Image:
        case ControlType.TextBlock:
        default:
          return true;
      }
    }
  }
}
