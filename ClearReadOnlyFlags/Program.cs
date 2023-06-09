string ProjectDir = Directory.GetCurrentDirectory();
string PluginsDir = ProjectDir + "\\Plugins";

if (Directory.Exists(ProjectDir))
{
    string[] ProjectBinaries = Directory.GetDirectories(ProjectDir, "Binaries", SearchOption.AllDirectories);
    string[] PluginBinaries = Directory.GetDirectories(PluginsDir, "Binaries", SearchOption.AllDirectories);

    List<string> Binaries = new List<string>();
    foreach (string b in ProjectBinaries)
    {
        Binaries.Add(b);
    }
    foreach (string b in PluginBinaries)
    {
        Binaries.Add(b);
    }

    foreach (string d in Binaries)
    {
        string[] Files = Directory.GetFiles(d, "*", SearchOption.AllDirectories);
        foreach (string f in Files)
        {
            FileInfo fi = new FileInfo(f);
            fi.IsReadOnly = false;
        }
    }
}