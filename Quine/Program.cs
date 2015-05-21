using System.IO;
using System.Text;

namespace Quine
{
    internal class Program
    {
        private static void Main()
        {
            var dq = (char) 34;
            var src = new[]
                          {
                              "using System.IO; using System.Text;", "namespace Quine", "{", "class Program", "{",
                              "static void Main()", "{", "var dq = (char)34;", "var src = REPLACE",
                              "var srcCombined = new StringBuilder(new string(new[]{'n','e','w','[',']',' ', '{', ' '}));",
                              "foreach (var s in src) { srcCombined.Append(dq + s + dq + ',' + ' '); }",
                              "srcCombined.Append(new string(new[]{'}',';'}));",
                              "src[8] = src[8].Replace(new string(new[]{'R','E', 'P', 'L', 'A', 'C', 'E'}), srcCombined.ToString());"
                              , "File.WriteAllLines(Directory.GetCurrentDirectory() + Path.GetRandomFileName(), src);", "}"
                              , "}", "}",
                          };
            var srcCombined = new StringBuilder(new string(new[] {'n', 'e', 'w', '[', ']', ' ', '{', ' '}));
            foreach (var s in src)
            {
                srcCombined.Append(dq + s + dq + ',' + ' ');
            }
            srcCombined.Append(new string(new[] {'}', ';'}));
            src[8] = src[8].Replace(new string(new[] {'R', 'E', 'P', 'L', 'A', 'C', 'E'}), srcCombined.ToString());
            File.WriteAllLines(Directory.GetCurrentDirectory() + Path.GetRandomFileName(), src);
        }
    }
}
