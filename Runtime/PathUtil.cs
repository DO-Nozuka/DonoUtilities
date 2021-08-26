using System.IO;
using System.Linq;

namespace Dono.Utilities
{
    public static class PathUtil    // Šg’£ƒƒ\ƒbƒh‚Íì‚ê‚È‚¢
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