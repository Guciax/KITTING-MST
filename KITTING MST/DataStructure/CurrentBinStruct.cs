using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KITTING_MST.DataStructure
{
    public class CurrentBinStruct
    {
        public string nc12 { get; set; }
        public string nc12_formated
        {
            get
            {
                return nc12.Insert(4, " ").Insert(8, " ");
            }
        }
        public string name { get; set; }
        public string cct { get; set; }
        public float cctLedQuantityInBom {get; set;}
    }
}
