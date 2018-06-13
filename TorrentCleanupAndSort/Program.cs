using System.IO;
using System.Reflection;
using TorrentCleanupDLL;
using TorrentSortDLL;

namespace TorrentCleanupAndSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cleanup cleanup = new Cleanup();
            cleanup.Clean();

            Sorter sort = new Sorter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            sort.Sort();
        }
    }
}
