using System.IO;

namespace Lect9
{
    class Paths
    {
        static void PathLect()
        {
            var path = @"c:\documents\udemy\c#basics\intronotes.txt";
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            var extension2 = Path.GetExtension(path);
            var fileName = Path.GetFileName(path);
            var fileName2 = Path.GetFileNameWithoutExtension(path);
        }
    }
}
