using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json.Linq;

namespace App2.ViewModels
{
  public partial class App2ViewModel : ObservableObject
  {
    //编译完成在终端运行：
    //assemblyalias --target-directory "D:\Users\fantasy\Desktop\AliasTest\App2\bin" --suffix _App2 --assemblies-to-alias "Newtonsoft*"

    [ObservableProperty]
    private string keyword = "Newtonsoft";
    public string Json
    {
      get
      {
        JArray array = new JArray();
        array.Add(DateTime.Now.ToString("MM/dd/yyyy HH:mm"));

        JObject o = new JObject();
        o["Newtonsoft Version"] = array;
        return o.ToString();
      }
    }

    public string AssembliesName
    {
      get
      {
        var jsons = Thread.GetDomain().GetAssemblies().Where(x => x.GetName().Name.Contains(Keyword)).OrderBy(x => x.ImageRuntimeVersion).ToList();
        var info = string.Join(";\n", jsons.Select(x => x.GetName().ToString() + ":\n\t" + x.CodeBase.ToString()));
        return UseJson? Json + ":\n" + info : info;
      }
    }

    public bool UseJson { get; set; }
  }
}