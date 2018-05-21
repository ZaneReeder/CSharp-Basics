using System.IO;

namespace Lect9
{
    class Directories
    {
        static void DirectLect()
        {
            Directory.CreateDirectory(@:"c:\temp\folder1");
            var files = Directory.GetFiles(@"c:\documents\c#basics", ".sln", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                System.Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"c:\projects\c#basics", ".", SearchOption.AllDirectories);
            foreach (var direct in directories)
            {
                System.Console.WriteLine(direct);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
