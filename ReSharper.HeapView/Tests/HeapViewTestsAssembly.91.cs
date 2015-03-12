using System.Reflection;
using JetBrains.Application.BuildScript;
using JetBrains.Application.Environment;
using JetBrains.Application.Environment.HostParameters;
using JetBrains.Util;

public partial class HeapViewTestsAssembly
{
  protected override JetHostItems.Packages CreateJetHostPackages(JetHostItems.Engine engine)
  {
    var productBinariesDirArtifact = new ProductBinariesDirArtifact(Assembly.GetExecutingAssembly().GetPath().Parent);
    return engine.OnScatteredFilesInFlatFolder(productBinariesDirArtifact, path => path.Parent.IsNullOrEmpty());
  }
}