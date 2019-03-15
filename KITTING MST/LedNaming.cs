using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KITTING_MST
{
    public class LedNaming
    {
        public static string GetLedName(string nameFromDb)
        {
            string[] splitted = SplitName(nameFromDb);
            int cctCriValue = GetCriCCTValue(splitted);
            string cct = "";
            string cri = "";
            if (cctCriValue > 0)
            {
                cri = "CRI" + (Math.Truncate((decimal)cctCriValue / 100) * 10).ToString();
                cct = ((cctCriValue - (Math.Truncate((decimal)cctCriValue / 100) * 100)) * 100) + "K";
            }
            string package = GetPackage(splitted);
            string result = "Dioda LED";
            if (package.Length > 0) result += " "+package;
            if (cct.Length > 0) result += " "+cct;
            if (cri.Length > 0) result += " " +cri;

            return result;
        }

        private static string GetPackage(string[] splitted)
        {
            string[] packages = new string[] { "5630", "2835", "3056", "3528", "3030", "Oslon" };
            foreach (var split in splitted)
            {
                if (packages.Contains(split)) return split;
            }
            return "";
        }

        private static int GetCriCCTValue(string[] splitted)
        {
            
            foreach (var split in splitted)
            {
                int value = 0;
                if (int.TryParse(split, out value))
                {
                    if (value > 700 & value < 1000) 
                    {
                        return value;
                    }
                }
            }
            return 0;
        }


        private static string[] SplitName(string nameFromDb)
        {
            if (nameFromDb.Contains(" ") & nameFromDb.Contains("_"))
                ;
            return nameFromDb.Split(new char[] { '_', ' ' });
            if (nameFromDb.Contains("_"))
            {
                string[] split = nameFromDb.Split('_');
                if (split.Length >= 3) return split;
            }

            if (nameFromDb.Contains(" "))
            {
                string[] split = nameFromDb.Split(' ');
                if (split.Length > nameFromDb.Split('_').Length) return split;
            }

            return null;
        }


    }
}
