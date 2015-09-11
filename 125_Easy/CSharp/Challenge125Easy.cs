using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Challenge125Easy
    {
        static void Main(string[] args)
        {
            var test = File.ReadAllLines(@"./InputText.txt");
            int wordCount = 0;
            foreach (var line in test)
            {
                var trimmedLine = line.Trim();
                if (!trimmedLine.Equals(String.Empty))
                {
                    var splitLine = line.Split(' ')
                        .ToList();
                    splitLine.RemoveAll(x => x == string.Empty);
                    wordCount += splitLine.Count();
                }
            }
        }
    }
}
