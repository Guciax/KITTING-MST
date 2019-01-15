using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KITTING_MST.DataStructure
{
    public class CurrentOrder
    {
        public CurrentOrder(string lotNumber, DateTime startDate, Int32 orderedQty, int binQty, string modelNc10, string modelName, int ledsPerModel, int connQty,int resQty)
        {
            LotNumber = lotNumber;
            StartDate = startDate;
            OrderedQty = orderedQty;
            BinQty = binQty;
            ModelNc10 = modelNc10;
            ModelName = modelName;
            LedsPerModel = ledsPerModel;
            ResQty = resQty;
        }

        public string LotNumber { get; set; }
        public DateTime StartDate { get; set; }
        public Int32 OrderedQty { get; set; }
        public int BinQty { get; set; }
        public string ModelNc10 { get; set; }
        public string ModelName { get; set; }
        public int LedsPerModel { get; set; }
        public int ResQty { get; }
    }
}
