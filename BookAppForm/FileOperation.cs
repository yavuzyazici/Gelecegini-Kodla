using System.Security.Policy;
using System.Text;
using System.IO;

using static System.Net.WebRequestMethods;

namespace Book
{
    public class FileOperation
    {
        public static string ReadFile()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\books.json";

            string output = System.IO.File.ReadAllText(path);
            return output;
        }

        public static void SaveFile(string data)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\books.json";
            System.IO.File.WriteAllText(path, data, Encoding.UTF8);
        }
    }
}
