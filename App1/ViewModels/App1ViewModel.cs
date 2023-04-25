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
    //assemblyalias --target-directory "D:\Users\fantasy\Desktop\AliasTest\App1\bin" --suffix _App1 --assemblies-to-alias "Newtonsoft*"


    [ObservableProperty]
    private string keyword = "Newtonsoft";
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
        return Json + "\n\r" + string.Join(";\n\r", jsons.Select(x => x.GetName().ToString() +":\n\t" +x.CodeBase.ToString()));
      }
    }

    public bool UseJson { get; set; }
  }
}
