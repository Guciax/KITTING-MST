using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KITTING_MST
{
    public class TesterProgramFiles
    {
        public static bool CheckIfProgramAvailable(string modelId10Nc)
        {
            var allPrograms = GetAllProgramNames();
            return allPrograms.Contains(modelId10Nc + "00");
        }

        private static string[] GetAllProgramNames()
        {
            string programsPath = @"\\mstip001\C\PARAM\BTS";
            if (!Directory.Exists(programsPath)) return null;

            DirectoryInfo dirNfo = new DirectoryInfo(programsPath);
            var files = dirNfo.GetFiles().Select(f => new string(f.Name.Where(c => Char.IsDigit(c)).ToArray()))
                                         .Where(nc => nc.Length == 12)
                                         .ToArray();
            return files;
        }
    }
}
