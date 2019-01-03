using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KITTING_MST.DataStructure
{
    public class LedReelsStruct
    {
        public LedReelsStruct(string nc12, string id, int qty, List<string> lotNumber)
        {
            Nc12 = nc12;
            Id = id;
            Qty = qty;
            LotNumber = lotNumber;
        }

        public string Nc12 { get; }
        public string Id { get; }
        public int Qty { get; }
        public List<string> LotNumber { get; }
    }
}
