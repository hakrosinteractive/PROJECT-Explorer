using System.Collections.Generic;
using System.IO;

namespace HAKROS.Classes
{
    public static class ClassVisualStudio
    {
        //Root folders
        public static List<string> TotalRootFolders = new List<string>();

        //Total structure
        public static List<List<string>> TotalFilesProject = new List<List<string>>();
        public static List<List<string>> TotalFilesSolution = new List<List<string>>();

        //Current structure
        public static List<string> CurrentFilesProject = new List<string>();
        public static List<string> CurrentFilesSolution = new List<string>();

        public static bool CheckRootFolder(bool reset = false)
        {
            var pos = TotalRootFolders.IndexOf(ClassGeneral.RootFolder);

            if(pos != -1 && reset)
            {
                TotalRootFolders.RemoveAt(pos);
                TotalFilesProject.RemoveAt(pos);
                TotalFilesSolution.RemoveAt(pos);
                pos = -1;
            }

            if(pos != -1)
            {
                CurrentFilesProject = new List<string>();
                CurrentFilesSolution = new List<string>();
                CurrentFilesProject = TotalFilesProject[pos];
                CurrentFilesSolution = TotalFilesSolution[pos];
            }

            return (pos != -1);
        }

        public static void GetSolutionProjectForFile(string f, ref string solution, ref string project)
        {
            solution = "";
            project = "";
            if (CheckRootFolder())
            {

                var relative = Path.GetDirectoryName(f).Replace(ClassGeneral.RootFolder, "");
                var values = relative.Split('\\');

                var k = values.Length - 1;

                var prjNames = new List<string>();
                var prjPaths = new List<string>();

                foreach (var prj in CurrentFilesProject)
                {
                    prjNames.Add(Path.GetFileNameWithoutExtension(prj));
                    prjPaths.Add(prj);
                }

                while (k >= 0)
                {
                    var posible = values[k];
                    var pos = prjNames.IndexOf(posible);
                    if (pos != -1)
                    {
                        var fileprj = prjPaths[pos];
                        var filesln = GetSolutionForProject(fileprj);
                        solution = Path.GetFileNameWithoutExtension(filesln);
                        project = Path.GetFileNameWithoutExtension(fileprj);
                        break;
                    }
                    k -= 1;
                }

                if(solution == "" && project == "")
                {
                    var dirfile = Path.GetDirectoryName(f);
                    foreach (var fileprj in CurrentFilesProject)
                    {
                        var dirprj = Path.GetDirectoryName(fileprj);
                        if (dirfile.Contains(dirprj))
                        {
                            var filesln = GetSolutionForProject(fileprj);

                            solution = Path.GetFileNameWithoutExtension(filesln);
                            project = Path.GetFileNameWithoutExtension(fileprj);

                            break;
                        }
                    }
                }

            }
        }

        public static string GetSolutionForProject(string fileprj)
        {
            var res = "";
            var k = 0;
            foreach(var prj in CurrentFilesProject)
            {
                var sln = CurrentFilesSolution[k];
                if (!sln.ToLowerInvariant().Contains("old") && fileprj.ToLowerInvariant() == prj.ToLowerInvariant())
                {
                    res = sln;
                    break;
                }
                k += 1;
            }
            return res;
        }


    }
}
