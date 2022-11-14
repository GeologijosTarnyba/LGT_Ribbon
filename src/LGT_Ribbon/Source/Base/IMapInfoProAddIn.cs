using MapInfo.Types;

namespace LGT_Ribbon
{
  public interface IMapInfoProAddIn
  {
    void Initialize(IMapInfoPro mapInfoApplication, string mbxname);
    void Unload();
    IMapBasicApplication ThisApplication { get; set; }

  }
}
