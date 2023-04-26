using System.Reflection;
using System.Windows.Input;
using Autodesk.Revit.DB;
using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace App1.ViewModels
{
  public partial class App1ViewModel : ObservableObject
  {
    //编译完成在终端运行：
    //assemblyalias --target-directory "D:\Users\fantasy\Desktop\AliasTest\App1\bin" --suffix _App1 --assemblies-to-alias "Newtonsoft*;DevExpress*"


    [ObservableProperty]
    private string keyword = "DevExpress";
    public string Json
    {
      get
      {
        JArray array = new JArray();
        array.Add(DateTime.Now.ToString("MM/dd/yyyy HH:mm"));

        JObject o = new JObject();
        o["Assemblies Version"] = array;
        return o.ToString();
      }
    }

    public string AssembliesName
    {
      get
      {
        var jsons = Thread.GetDomain().GetAssemblies().Where(x => x.GetName().Name.Contains(Keyword)).OrderBy(x => x.ImageRuntimeVersion).ToList();
        var info = string.Join(";\n", jsons.Select(x => x.GetName().ToString() + ":\n\t" + x.CodeBase.ToString()));
        return UseJson ? Json + ":\n" + info : info;
      }
    }

    public bool UseJson { get; set; }
  }
}
