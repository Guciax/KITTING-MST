using KITTING_MST.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KITTING_MST
{
    public class DataStorage
    {
        public static MST.MES.OrderStructureByOrderNo.Kitting currentOrder = new MST.MES.OrderStructureByOrderNo.Kitting();
        public static List<MST.MES.Data_structures.DevToolsModelStructure> devToolsDb = new List<MST.MES.Data_structures.DevToolsModelStructure>();

        public static Dictionary<string, List<CurrentBinStruct>> currentBins = new Dictionary<string, List<CurrentBinStruct>>();
        public static Dictionary<string, MST.MES.ModelInfo.ModelSpecification> mesModels;
        public static Dictionary<string, LedOracleSpec> nc12ToOracleSpec;

    }
}
