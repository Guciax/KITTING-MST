using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KITTING_MST.DataStructure
{
    public class LedStructForTechnologicSpec
    {
        public string collective12NC;
        public float qtyPerModel;
        public string CCT;
        public string CRI;
        public string package;
        public string name;
        public List<LedOracleSpec> membersList = new List<LedOracleSpec>();
    }
}
