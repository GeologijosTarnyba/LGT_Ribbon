// Decompiled with JetBrains decompiler
// Type: MapInfo.Commands.ApplicationCommandID
// Assembly: MapInfo.Controls.RT, Version=17.0.0.73, Culture=neutral, PublicKeyToken=1c8d81d2ee78b75d
// MVID: BC0BD24C-3BE6-48BB-A804-29FA3B53532D
// Assembly location: C:\Program Files\MapInfo\Runtime\MapInfo.Controls.RT.dll

namespace MapInfo.Commands
{
  [Command(typeof (ApplicationCommands))]
  public enum ApplicationCommandID
  {
    NewTable = 101, // 0x00000065
    OpenTable = 102, // 0x00000066
    CloseTable = 103, // 0x00000067
    CloseAll = 104, // 0x00000068
    SaveTable = 105, // 0x00000069
    SaveCopyAs = 106, // 0x0000006A
    AddWorkspace = 108, // 0x0000006C
    SaveWorkspace = 109, // 0x0000006D
    RunMapBasic = 110, // 0x0000006E
    PageSetup = 111, // 0x0000006F
    Print = 112, // 0x00000070
    [ShowInMoreCommands(false)] Exit = 113, // 0x00000071
    OpenDBMS = 116, // 0x00000074
    SaveQuery = 117, // 0x00000075
    CloseDBMS = 124, // 0x0000007C
    OpenUniversalData = 126, // 0x0000007E
    PrintToPDF = 127, // 0x0000007F
    OpenWorkspace = 132, // 0x00000084
    Import = 401, // 0x00000191
    SaveWindowAs = 609, // 0x00000261
    [ShowInMoreCommands(false)] GetMapBasicUtilities = 1811, // 0x00000713
    [ShowInMoreCommands(false)] CustomMapBasicHandler = 8992, // 0x00002320
    [ShowInMoreCommands(false)] CustomToolButton = 8993, // 0x00002321
  }
  [Command(typeof (BrowseCommands))]
  public enum BrowseCommandsID
  {
    UnselectAll = 304, // 0x00000130
    NewRow = 702, // 0x000002BE
    PickFields = 704, // 0x000002C0
    MultiSort = 710, // 0x000002C6
    ShowGridLines = 712, // 0x000002C8
    BrowserFont = 713, // 0x000002C9
    ClearSort = 2701, // 0x00000A8D
    SortAscending = 2702, // 0x00000A8E
    SortDescending = 2703, // 0x00000A8F
    Filter = 2704, // 0x00000A90
    ClearFilter = 2705, // 0x00000A91
    ToggleSort = 2706, // 0x00000A92
    ClearFilters = 2707, // 0x00000A93
    SelectAll = 2708, // 0x00000A94
    ReapplySort = 2709, // 0x00000A95
    ClearAll = 2710, // 0x00000A96
    CreateQuery = 2711, // 0x00000A97
  }
  [Command(typeof (EditCommands))]
  public enum EditCommandID
  {
    Undo = 201, // 0x000000C9
    Cut = 202, // 0x000000CA
    Copy = 203, // 0x000000CB
    Paste = 204, // 0x000000CC
    ClearMapObjects = 206, // 0x000000CE
    [ShowInMoreCommands(false)] GetInfo = 207, // 0x000000CF
  }
  [Command(typeof (GridlineCommands))]
  public enum GridlineCommandId
  {
    GridlineCreate = 845, // 0x0000034D
    GridlinePropertiesDialog = 846, // 0x0000034E
  }
  [Command(typeof (HelpCommands))]
  public enum HelpCommandID
  {
    HelpContents = 1202, // 0x000004B2
    HelpSearch = 1203, // 0x000004B3
    [ShowInMoreCommands(false)] About = 1205, // 0x000004B5
    [ShowInMoreCommands(false)] DoHelpMode = 1206, // 0x000004B6
    [ShowInMoreCommands(false)] DoContextHelpMode = 1207, // 0x000004B7
    [ShowInMoreCommands(false)] TechSupport = 1208, // 0x000004B8
    [ShowInMoreCommands(false)] MapInfoWwwStoreEuro = 1209, // 0x000004B9
    [ShowInMoreCommands(false)] MapInfoWww = 1210, // 0x000004BA
    [ShowInMoreCommands(false)] MapInfoWwwStore = 1211, // 0x000004BB
    [ShowInMoreCommands(false)] SmartUpdate = 1212, // 0x000004BC
    [ShowInMoreCommands(false)] WwwTutorial = 1213, // 0x000004BD
    [ShowInMoreCommands(false)] TransferLicense = 1216, // 0x000004C0
    [ShowInMoreCommands(false)] BorrowLicense = 1217, // 0x000004C1
    [ShowInMoreCommands(false)] ReturnBorrowedLicense = 1218, // 0x000004C2
    [ShowInMoreCommands(false)] ProductFeedback = 1219, // 0x000004C3
    [ShowInMoreCommands(false)] BingTermsOfUse = 1220, // 0x000004C4
    [ShowInMoreCommands(false)] MapInfoNewsfeed = 1221, // 0x000004C5
    [ShowInMoreCommands(false)] UserBingKey = 1222, // 0x000004C6
    [ShowInMoreCommands(false)] StartAdvancedEvaluation = 1223, // 0x000004C7
    [ShowInMoreCommands(false)] ActivateAdvancedLicense = 1224, // 0x000004C8
    [ShowInMoreCommands(false)] ActivateFlexeraLicenseForSubscriptionLicensedUser = 1225, // 0x000004C9
  }
  [Command(typeof (LayerControlCommands))]
  public enum LayerControlCommandID
  {
    LcViewEntireLayer = 2501, // 0x000009C5
    LcLayerProperties = 2502, // 0x000009C6
    [ShowInMoreCommands(false)] LcLabelFont = 2503, // 0x000009C7
    [ShowInMoreCommands(false)] LcOtherNoSelect = 2504, // 0x000009C8
    LcRenameMap = 2505, // 0x000009C9
    LcMapOptions = 2506, // 0x000009CA
    LcAddGroup = 2507, // 0x000009CB
    LcRenameGroup = 2508, // 0x000009CC
    LcUnGroup = 2509, // 0x000009CD
    AddLayers = 2510, // 0x000009CE
    [ShowInMoreCommands(false)] LcAddDisplayOverride = 2511, // 0x000009CF
    [ShowInMoreCommands(false)] LcAddLabelOverride = 2512, // 0x000009D0
    [ShowInMoreCommands(false)] LcDisplayOverrideProperties = 2513, // 0x000009D1
    [ShowInMoreCommands(false)] LcLabelOverrideProperties = 2514, // 0x000009D2
    [ShowInMoreCommands(false)] LcSplitOverride = 2515, // 0x000009D3
    [ShowInMoreCommands(false)] LcRemoveOverride = 2516, // 0x000009D4
    LcBrowseTable = 2517, // 0x000009D5
    LcZoomToTileServer = 2520, // 0x000009D8
    LcClearCustomLabels = 2521, // 0x000009D9
    LabelPriority = 2522, // 0x000009DA
    [ShowInMoreCommands(false)] LcSelectAll = 2523, // 0x000009DB
    LayerControlOptions = 2524, // 0x000009DC
    RegionStyle = 2526, // 0x000009DE
    RegionStyleStacked = 2527, // 0x000009DF
    ToggleStyleOverride = 2528, // 0x000009E0
    LineStyle = 2529, // 0x000009E1
    SymbolStyle = 2530, // 0x000009E2
    LineStyleStacked = 2531, // 0x000009E3
    SymbolStyleStacked = 2532, // 0x000009E4
    ShowNodes = 2533, // 0x000009E5
    ShowCentroids = 2534, // 0x000009E6
    ShowLineDirection = 2535, // 0x000009E7
    TextStyle = 2536, // 0x000009E8
    ToggleStackedStyle = 2537, // 0x000009E9
    ToggleImageGrayScale = 2538, // 0x000009EA
    LabelDisplayProps = 2539, // 0x000009EB
    LabelRulesProps = 2540, // 0x000009EC
    LabelLineStyle = 2541, // 0x000009ED
    [ShowInMoreCommands(false)] LcRenameToFriendlyName = 2542, // 0x000009EE
  }
  [Command(typeof (LayoutCommands))]
  public enum LayoutCommandID
  {
    RegionStyle = 2399, // 0x0000095F
    LayoutPageSetup = 2903, // 0x00000B57
    FitInWindow = 2904, // 0x00000B58
    ActivateLayoutFrame = 2905, // 0x00000B59
    BringToFront = 2906, // 0x00000B5A
    SendToBack = 2907, // 0x00000B5B
    FrameProperties = 2908, // 0x00000B5C
    LayoutTextStyle = 2909, // 0x00000B5D
    AddLegends = 2910, // 0x00000B5E
    [ShowInMoreCommands(false)] RefreshLegends = 2911, // 0x00000B5F
    ModifyThematic = 2912, // 0x00000B60
    RemoveSelectedFramesContent = 2913, // 0x00000B61
    NewEmptyFrame = 2914, // 0x00000B62
    RemoveSelectedItems = 2915, // 0x00000B63
    [ShowInMoreCommands(false)] StackUndo = 2916, // 0x00000B64
    [ShowInMoreCommands(false)] StackRedo = 2917, // 0x00000B65
    AddBrowserFrame = 2918, // 0x00000B66
    AddHorizontalGuideline = 2919, // 0x00000B67
    AddMapFrame = 2920, // 0x00000B68
    [ShowInMoreCommands(false)] AddSymbol = 2921, // 0x00000B69
    [ShowInMoreCommands(false)] AddLine = 2922, // 0x00000B6A
    [ShowInMoreCommands(false)] AddEllipse = 2923, // 0x00000B6B
    [ShowInMoreCommands(false)] AddRectangle = 2924, // 0x00000B6C
    [ShowInMoreCommands(false)] AddRoundedRectangle = 2925, // 0x00000B6D
    AddVerticalGuideline = 2926, // 0x00000B6E
    ChangeFrameStyle = 2927, // 0x00000B6F
    DisableGuidelines = 2928, // 0x00000B70
    ZoomToHundredPercent = 2929, // 0x00000B71
    ToggleSmartGuides = 2930, // 0x00000B72
    InsertImage = 2931, // 0x00000B73
    InsertText = 2932, // 0x00000B74
    [ShowInMoreCommands(false)] LineSpacingDouble = 2933, // 0x00000B75
    [ShowInMoreCommands(false)] LineSpacingOnePointFive = 2934, // 0x00000B76
    [ShowInMoreCommands(false)] LineSpacingSingle = 2935, // 0x00000B77
    LineStyle = 2936, // 0x00000B78
    SymbolStyle = 2937, // 0x00000B79
    Pan = 2938, // 0x00000B7A
    RemoveGuidelines = 2940, // 0x00000B7C
    Select = 2941, // 0x00000B7D
    SnapToBottom = 2942, // 0x00000B7E
    SnapToGrid = 2943, // 0x00000B7F
    SnapToLeft = 2944, // 0x00000B80
    SnapToRight = 2945, // 0x00000B81
    SnapToTop = 2946, // 0x00000B82
    [ShowInMoreCommands(false)] TextJustifyCenter = 2947, // 0x00000B83
    [ShowInMoreCommands(false)] TextJustifyLeft = 2948, // 0x00000B84
    [ShowInMoreCommands(false)] TextJustifyRight = 2949, // 0x00000B85
    ToggleGridLines = 2950, // 0x00000B86
    ZoomIn = 2951, // 0x00000B87
    ZoomOut = 2952, // 0x00000B88
    AlignHorizontalCenter = 2953, // 0x00000B89
    AlignVerticalCenter = 2954, // 0x00000B8A
    RotateFrameByZeroDegree = 2955, // 0x00000B8B
    RotateFrameByNinetyDegree = 2956, // 0x00000B8C
    RotateFrameByTwoSeventyDegree = 2957, // 0x00000B8D
    [ShowInMoreCommands(false)] AddPolygon = 2958, // 0x00000B8E
    [ShowInMoreCommands(false)] AddPolyline = 2959, // 0x00000B8F
  }
  [Command(typeof (LegendCommands))]
  public enum LegendCommandID
  {
    [ShowInMoreCommands(false)] DisableGuidelines = 2801, // 0x00000AF1
    [ShowInMoreCommands(false)] RemoveGuidelines = 2802, // 0x00000AF2
    [ShowInMoreCommands(false)] RemoveFrames = 2803, // 0x00000AF3
    [ShowInMoreCommands(false)] FrameProperties = 2804, // 0x00000AF4
    RefreshAll = 2805, // 0x00000AF5
    [ShowInMoreCommands(false)] AddFrames = 2806, // 0x00000AF6
    [ShowInMoreCommands(false)] AddTextFrame = 2807, // 0x00000AF7
    ModifyTheme = 2808, // 0x00000AF8
    ToggleGridLines = 2809, // 0x00000AF9
    SnapToGrid = 2810, // 0x00000AFA
    AddHorizontalGuideline = 2811, // 0x00000AFB
    AddVerticalGuideline = 2812, // 0x00000AFC
    SnapToTopGuideline = 2813, // 0x00000AFD
    SnapToBottomGuideline = 2814, // 0x00000AFE
    SnapToLeftGuideline = 2815, // 0x00000AFF
    SnapToRightGuideline = 2816, // 0x00000B00
    QuickRefresh = 2817, // 0x00000B01
  }
  [Command(typeof (MapCommands))]
  public enum MapCommandID
  {
    AddBasemapAerial = 128, // 0x00000080
    AddBasemapHybrid = 129, // 0x00000081
    AddBasemapRoads = 130, // 0x00000082
    AddThematic = 307, // 0x00000133
    ModifyThematic = 308, // 0x00000134
    LayerControlDialog = 801, // 0x00000321
    MapOptions = 802, // 0x00000322
    ChangeView = 805, // 0x00000325
    PreviousView = 806, // 0x00000326
    ViewEntireLayer = 807, // 0x00000327
    SaveCosmetic = 809, // 0x00000329
    ClearCosmetic = 810, // 0x0000032A
    CloneMapper = 811, // 0x0000032B
    SetClipRegion = 812, // 0x0000032C
    ClipRegionOnOff = 813, // 0x0000032D
    ClearCustomLabels = 814, // 0x0000032E
    AutoscrollOnOff = 815, // 0x0000032F
    CreateLegend = 816, // 0x00000330
    [ShowInMoreCommands(false)] Create3Dmap = 817, // 0x00000331
    CreatePrismmap = 818, // 0x00000332
    ViewEntireSelectionLayer = 819, // 0x00000333
    SelectAllFromSelection = 820, // 0x00000334
    MakeSelectionEditable = 821, // 0x00000335
    CreateScalebar = 824, // 0x00000338
    MoveMapTo = 825, // 0x00000339
    CreateLegendPref = 826, // 0x0000033A
    CreateLegendDesigner = 827, // 0x0000033B
    ViewNearestTileServerLevel = 828, // 0x0000033C
    WorkspaceExplorer = 829, // 0x0000033D
    LockScale = 838, // 0x00000346
    SelectableLabels = 839, // 0x00000347
    ViewEntireMap = 840, // 0x00000348
    ViewEntireSelectedObjects = 841, // 0x00000349
    SnapToNode = 842, // 0x0000034A
    RedrawOnOff = 843, // 0x0000034B
    DragMap = 1734, // 0x000006C6
    [ShowInMoreCommands(false)] ViewEntireGrid_3DMap = 2101, // 0x00000835
    [ShowInMoreCommands(false)] Properties_3DMap = 2102, // 0x00000836
    [ShowInMoreCommands(false)] RefreshGridTexture_3DMap = 2103, // 0x00000837
    [ShowInMoreCommands(false)] Wireframe_3DMap = 2104, // 0x00000838
    [ShowInMoreCommands(false)] CloneView_3DMap = 2105, // 0x00000839
    [ShowInMoreCommands(false)] PreviousView_3DMap = 2106, // 0x0000083A
    [ShowInMoreCommands(false)] ViewpointControl_3DMap = 2107, // 0x0000083B
    [ShowInMoreCommands(false)] AdornmentProperties = 2401, // 0x00000961
    [ShowInMoreCommands(false)] RemoveAdornment = 2402, // 0x00000962
    HotlinkOptions = 2525, // 0x000009DD
  }
  [Command(typeof (OracleWorkspaceCommands))]
  public enum OracleWorkspaceCommandID
  {
    CreateWorkspace = 1804, // 0x0000070C
    DeleteWorkspace = 1805, // 0x0000070D
    EnableOracleVersioning = 1806, // 0x0000070E
    DisableOracleVersioning = 1807, // 0x0000070F
    MergeTable = 1808, // 0x00000710
    RefreshOracleTable = 1809, // 0x00000711
  }
  [Command(typeof (PreferenceCommands))]
  public enum PreferenceCommandID
  {
    Preferences = 208, // 0x000000D0
    SystemPreferences = 210, // 0x000000D2
    StartUpPreferences = 211, // 0x000000D3
    MapPreferences = 212, // 0x000000D4
    CountryPreferences = 213, // 0x000000D5
    PathPreferences = 214, // 0x000000D6
    LegendPreferences = 215, // 0x000000D7
    OutputPreferences = 216, // 0x000000D8
    PrinterPreferences = 217, // 0x000000D9
    StylesPreferences = 218, // 0x000000DA
    ProcImagePreferences = 219, // 0x000000DB
    WebservicesPreferences = 220, // 0x000000DC
    LayoutPreferences = 221, // 0x000000DD
    BrowserPreferences = 222, // 0x000000DE
    NotificationsPreferences = 223, // 0x000000DF
    PerformancePreferences = 224, // 0x000000E0
    WorkspacePreferences = 225, // 0x000000E1
    MapBasicWindowPreferences = 226, // 0x000000E2
    ExplorerPreferences = 227, // 0x000000E3
    WindowStatePreferences = 228, // 0x000000E4
    TaskManagerPreferences = 229, // 0x000000E5
    WindowListPreferences = 230, // 0x000000E6
  }
  [Command(typeof (QueryCommands))]
  public enum QueryCommandID
  {
    SelectQuery = 301, // 0x0000012D
    SqlQuery = 302, // 0x0000012E
    SelectAll = 303, // 0x0000012F
    UnSelect = 304, // 0x00000130
    Find = 305, // 0x00000131
    FindSelection = 306, // 0x00000132
    InvertSelect = 311, // 0x00000137
    FindFrontSelection = 312, // 0x00000138
    FindAddress = 313, // 0x00000139
  }
  [Command(typeof (RedistrictCommands))]
  public enum RedistrictCommandID
  {
    Assign = 705, // 0x000002C1
    Target = 706, // 0x000002C2
    Add = 707, // 0x000002C3
    Delete = 708, // 0x000002C4
    Options = 709, // 0x000002C5
  }
  [Command(typeof (SpatialCommands))]
  public enum SpatialCommandID
  {
    VoronoiTable = 420, // 0x000001A4
    DriveRegionsTable = 425, // 0x000001A9
    LineStyle = 501, // 0x000001F5
    RegionStyle = 502, // 0x000001F6
    SymbolStyle = 503, // 0x000001F7
    TextStyle = 504, // 0x000001F8
    DigitizerSetup = 803, // 0x00000323
    Reshape = 1601, // 0x00000641
    Smooth = 1602, // 0x00000642
    Unsmooth = 1603, // 0x00000643
    ConvertToPolyline = 1604, // 0x00000644
    CombineObjects = 1605, // 0x00000645
    Buffer = 1606, // 0x00000646
    ConvertToRegion = 1607, // 0x00000647
    SetTarget = 1610, // 0x0000064A
    ClearTarget = 1611, // 0x0000064B
    SplitTarget = 1612, // 0x0000064C
    EraseTarget = 1613, // 0x0000064D
    EraseOutsideTarget = 1614, // 0x0000064E
    OverlayNode = 1615, // 0x0000064F
    ConvexHull = 1616, // 0x00000650
    Enclose = 1617, // 0x00000651
    CheckRegions = 1618, // 0x00000652
    Clean = 1619, // 0x00000653
    Snap = 1620, // 0x00000654
    Disaggregate = 1621, // 0x00000655
    Voronoi = 1622, // 0x00000656
    PolylineSplit = 1623, // 0x00000657
    OffsetObject = 1624, // 0x00000658
    RotateObject = 1625, // 0x00000659
    PolylineSplitAtNode = 1626, // 0x0000065A
    CreateDriveRegions = 1627, // 0x0000065B
    InsertText = 1709, // 0x000006AD
    InsertSymbol = 1711, // 0x000006AF
    InsertLine = 1712, // 0x000006B0
    InsertPolyline = 1713, // 0x000006B1
    InsertPolygon = 1714, // 0x000006B2
    InsertEllipse = 1715, // 0x000006B3
    InsertArc = 1716, // 0x000006B4
    InsertRectangle = 1717, // 0x000006B5
    InsertRoundedRectangle = 1718, // 0x000006B6
  }
  [Command(typeof (TableCommands))]
  public enum TableCommandID
  {
    RevertTable = 107, // 0x0000006B
    CalcColStats = 309, // 0x00000135
    Import = 401, // 0x00000191
    Export = 402, // 0x00000192
    Pack = 403, // 0x00000193
    ModifyStructure = 404, // 0x00000194
    UpdateColumn = 405, // 0x00000195
    MergeUsingColumn = 406, // 0x00000196
    GeoCode = 407, // 0x00000197
    CreatePoints = 408, // 0x00000198
    Delete = 409, // 0x00000199
    Rename = 410, // 0x0000019A
    Append = 411, // 0x0000019B
    RasterReg = 413, // 0x0000019D
    RasterStyle = 414, // 0x0000019E
    MakeMappable = 415, // 0x0000019F
    Unlink = 416, // 0x000001A0
    RefreshDBMS = 417, // 0x000001A1
    ChangeSymbol = 418, // 0x000001A2
    Buffer = 419, // 0x000001A3
    WebGeoCode = 424, // 0x000001A8
    UniversalDataRefresh = 426, // 0x000001AA
    HotlinkOptions = 714, // 0x000002CA
    AddToLibrary = 1740, // 0x000006CC
    ViewEditMetadata = 1741, // 0x000006CD
    OpenDBMSTable = 3101, // 0x00000C1D
    CloseDBMSTable = 3102, // 0x00000C1E
    CloseDBMSConnection = 3103, // 0x00000C1F
  }
  [Command(typeof (TableListCommands))]
  public enum TableListCommandID
  {
    [ShowInMoreCommands(false)] TlvSelectAllFromTable = 2601, // 0x00000A29
    TlvBrowseTable = 2602, // 0x00000A2A
    TlvOpenNewMap = 2603, // 0x00000A2B
    TlvExportTable = 2604, // 0x00000A2C
    [ShowInMoreCommands(false)] TlvRefreshTable = 2605, // 0x00000A2D
    TlvTableStructure = 2606, // 0x00000A2E
    [ShowInMoreCommands(false)] TlvCreatePoints = 2607, // 0x00000A2F
    TlvUpdateColumn = 2608, // 0x00000A30
    TlvCloseTable = 2609, // 0x00000A31
    TlvViewMetaData = 2610, // 0x00000A32
    TlvAddToLibrary = 2611, // 0x00000A33
    [ShowInMoreCommands(false)] TlvCompareStructure = 2612, // 0x00000A34
    TlvRenameTable = 2613, // 0x00000A35
  }
  [Command(typeof (ThemeCommands))]
  public enum ThemeCommandId
  {
    ThmSaveAsTemplate = 321, // 0x00000141
    ThmSaveAsDefault = 322, // 0x00000142
    ThmRemoveDefault = 323, // 0x00000143
    ThmRefreshData = 324, // 0x00000144
    ThmRangeSetField = 325, // 0x00000145
    ThmRangeSetRanges = 326, // 0x00000146
    ThmRangeSetRoundBy = 327, // 0x00000147
    ThmRangeEqualCount = 328, // 0x00000148
    ThmRangeEqualRange = 329, // 0x00000149
    ThmRangeStdDev = 330, // 0x0000014A
    ThmRangeNaturalBreak = 331, // 0x0000014B
    ThmRangeQuantile = 332, // 0x0000014C
    ThmRangeCustom = 333, // 0x0000014D
    ThmCustomize = 334, // 0x0000014E
    ThemeColorPaletteColorChanged = 335, // 0x0000014F
    ThmSymbolSetField = 336, // 0x00000150
    ThmSymbolMethodSquareRoot = 337, // 0x00000151
    ThmSymbolMethodConstant = 338, // 0x00000152
    ThmSymbolMethodLog = 339, // 0x00000153
    ThmSymbolShowNegativeValueSymbol = 340, // 0x00000154
    ThmSymbolSetNegativeSymbol = 341, // 0x00000155
    ThmSymbolSetPositiveSymbol = 342, // 0x00000156
    ThmSymbolSetSymbolSize = 343, // 0x00000157
    ThmSymbolSetValueAtMax = 344, // 0x00000158
    ThmBarStacked = 345, // 0x00000159
    ThmBarStackedGraduated = 346, // 0x0000015A
    ThmBarMultiple = 347, // 0x0000015B
    ThmBarMultipleIndependentScale = 348, // 0x0000015C
    ThmBarHeight = 349, // 0x0000015D
    ThmBarWidth = 350, // 0x0000015E
    ThmBarOrientation = 351, // 0x0000015F
    ThmBarMethodSquareRoot = 352, // 0x00000160
    ThmBarMethodConstant = 353, // 0x00000161
    ThmBarMethodLog = 354, // 0x00000162
    ThmPieWholePies = 355, // 0x00000163
    ThmPieHalfPies = 356, // 0x00000164
    ThmPieGraduationSqRoot = 357, // 0x00000165
    ThmPieGraduationConstant = 358, // 0x00000166
    ThmPieGraduationLog = 359, // 0x00000167
    ThmPieGraduationNone = 360, // 0x00000168
    ThmPiePlacement = 361, // 0x00000169
    ThmPieStyles = 362, // 0x0000016A
    ThmPieSize = 363, // 0x0000016B
    ThmPieAngle = 364, // 0x0000016C
    ThmDotDensitySetField = 365, // 0x0000016D
    ThmDotDensityChartTypeCircle = 366, // 0x0000016E
    ThmDotDensityChartTypeSquare = 367, // 0x0000016F
    ThmDotDensitySetColor = 368, // 0x00000170
    ThmDotDensitySetSize = 369, // 0x00000171
    ThmDotDensitySetMaxSizeValue = 370, // 0x00000172
    ThmIndividualSetField = 371, // 0x00000173
    ThmIndividualValueColorChanged = 372, // 0x00000174
  }
  [Command(typeof (ToolCommands))]
  public enum ToolCommandID
  {
    Select = 1701, // 0x000006A5
    Recenter = 1702, // 0x000006A6
    SearchRadius = 1703, // 0x000006A7
    SearchBoundary = 1704, // 0x000006A8
    ZoomIn = 1705, // 0x000006A9
    ZoomOut = 1706, // 0x000006AA
    PointQuery = 1707, // 0x000006AB
    LabelTool = 1708, // 0x000006AC
    Ruler = 1710, // 0x000006AE
    SearchRect = 1722, // 0x000006BA
    AddNode = 1723, // 0x000006BB
    SelectRasterRegPoint = 1730, // 0x000006C2
    SearchPolygon = 1733, // 0x000006C5
    HotLink = 1736, // 0x000006C8
  }
  [Command(typeof (WebServicesCommands))]
  public enum WebServicesCommandID
  {
    OpenWms = 118, // 0x00000076
    OpenWfs = 119, // 0x00000077
    OpenWmts = 120, // 0x00000078
    ServerList = 236, // 0x000000EC
    WmsProps = 421, // 0x000001A5
    WfsRefresh = 422, // 0x000001A6
    WfsProps = 423, // 0x000001A7
    WmtsProps = 427, // 0x000001AB
  }
  [Command(typeof (WindowCommands))]
  public enum WindowCommandID
  {
    NewBrowserWindow = 601, // 0x00000259
    NewMapWindow = 602, // 0x0000025A
    GraphWindow = 603, // 0x0000025B
    MapBasicWindow = 608, // 0x00000260
    RedrawWindow = 610, // 0x00000262
    RedistrictWindow = 615, // 0x00000267
    StatusBarWindow = 616, // 0x00000268
    CustomColors = 617, // 0x00000269
    RecoverWindows = 619, // 0x0000026B
    NewLayoutWindow = 620, // 0x0000026C
    [ShowInMoreCommands(false)] ClearMsgWin = 621, // 0x0000026D
    CloneWindow = 622, // 0x0000026E
    ThreeDWindow = 817, // 0x00000331
    PrismWindow = 818, // 0x00000332
    LayerControl = 822, // 0x00000336
    WorkspaceExplorer = 829, // 0x0000033D
    WindowList = 830, // 0x0000033E
    ToolManager = 831, // 0x0000033F
    TaskManager = 832, // 0x00000340
    ConnectionList = 833, // 0x00000341
    InfoWindow = 834, // 0x00000342
    MessageWindow = 835, // 0x00000343
    StatisticsWindow = 836, // 0x00000344
    RulerWindow = 837, // 0x00000345
    LegendWindow = 844, // 0x0000034C
    TableList = 1738, // 0x000006CA
    [ShowInMoreCommands(false)] StatisticsWindowCopy = 2301, // 0x000008FD
  }
  [Command(typeof (WindowListCommands))]
  public enum WindowListCommandID
  {
    [ShowInMoreCommands(false)] SelectAllOfType = 3001, // 0x00000BB9
    [ShowInMoreCommands(false)] HideSelectedWindow = 3002, // 0x00000BBA
    [ShowInMoreCommands(false)] ActivateSelectedWindow = 3003, // 0x00000BBB
    [ShowInMoreCommands(false)] CloseSelectedWindow = 3004, // 0x00000BBC
    [ShowInMoreCommands(false)] RenameSelectedWindow = 3005, // 0x00000BBD
    [ShowInMoreCommands(false)] CloneSelectedWindow = 3006, // 0x00000BBE
  }
}
