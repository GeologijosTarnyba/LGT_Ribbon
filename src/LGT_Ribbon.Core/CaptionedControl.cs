namespace LGT_Ribbon.Core
{
  public class CaptionedControl
  {
    public string ParentName { get; set; }
    public string Caption { get; set; } = string.Empty;
    private string nameEnding = null;
    private string NameEnding
    {
      get
      {
        if (!string.IsNullOrEmpty(this.nameEnding))
          return nameEnding;
        if (!string.IsNullOrEmpty(this.Caption))
          return this.nameEnding = this.Caption.Replace(" ", "").Replace(",", "").Replace(".", "").Replace(";", "").Replace("/", "").Replace(":", "").Replace("-", "").Replace("%", "").Replace("°", "")
            .Replace("(", "").Replace(")", "").Replace("{", "").Replace("}", ""); // tbd replace all special symbols.
        return this.nameEnding = RandomString.Generate(10); // hopefully it wont repeat
      }

    }
    private string name = string.Empty;
    public string Name
    {
      get
      {
        if (name != string.Empty)
          return name;
        if (ParentName == string.Empty)
          return Name = NameEnding;
        return Name = $"{ParentName}_{NameEnding}";
      }
      set => this.name = value;
    }
  }
}
