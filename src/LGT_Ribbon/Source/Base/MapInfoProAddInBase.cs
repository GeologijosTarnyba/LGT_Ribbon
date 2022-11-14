using MapInfo.Types;
using System;

namespace LGT_Ribbon
{
  public class MapInfoProAddInBase : IMapInfoProAddIn
  {
    protected IMapInfoPro MapInfoApplication;

    public virtual void Initialize(IMapInfoPro mapInfoApplication, string mbxname)
    {
      UriParser.Register(new GenericUriParser(GenericUriParserOptions.GenericAuthority), "pack", -1);
      MapInfoApplication = mapInfoApplication;
    }

    public virtual void Unload()
    {
    }

    public IMapBasicApplication ThisApplication { get; set; }

    public static Uri PathToUri(string uri)
    {
      try
      {
        return new Uri(uri, UriKind.RelativeOrAbsolute);
      }
      catch (Exception)
      {

        return null;
      }
    }
  }
}
