using System.IO;
using System.Linq;

namespace Dono.Utilities
{
    public static class PathUtil    // 拡張メソッドは作れない
    {
        public static string GetFileNameWithoutMultiExtensions(string path)
        {
            string result = path;
            string before;
            do
            {
                before = result;
                result = Path.GetFileNameWithoutExtension(result);
            } while (result != before);

            return result;
        }
    }
}