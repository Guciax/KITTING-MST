using KITTING_MST.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KITTING_MST.Karty_technologiczne
{
    public class DataPreparation
    {
        public static Dictionary<string, LedStructForTechnologicSpec> LedForTechCard(ref bool ledCheck)
        {
            Dictionary<string, float> quantityPerCct = new Dictionary<string, float>();
            var dtModel = DataStorage.devToolsDb.Where(nc => nc.nc12 == DataStorage.currentOrder.modelId + "00").First();

            Dictionary<string, LedStructForTechnologicSpec> result = new Dictionary<string, LedStructForTechnologicSpec>();
            foreach (var binEntry in DataStorage.currentBins)
            {
                var ledInfo = DataStorage.nc12ToOracleSpec[binEntry.Value.nc12];
                var dtLedInfo = DataStorage.devToolsDb.Where(nc => nc.nc12 == ledInfo.collective);

                if (!dtModel.qtyPerComponent.ContainsKey(ledInfo.collective))
                {
                    ledCheck = false;
                    break;
                }

                if (!result.ContainsKey(ledInfo.collective))
                {
                    result.Add(ledInfo.collective, new LedStructForTechnologicSpec
                    {
                        collective12NC = ledInfo.collective,
                        qtyPerModel = dtModel.qtyPerComponent[ledInfo.collective],
                        name = binEntry.Value.name
                    });

                    if (dtLedInfo.Count() > 0)
                    {
                        foreach (var atrEntry in dtLedInfo.First().atributes)
                        {
                            if (atrEntry.Key.ToUpper().Contains("CCT"))
                            {
                                result[ledInfo.collective].CCT = atrEntry.Value;
                            }
                            if (atrEntry.Key.ToUpper().Contains("CRI"))
                            {
                                result[ledInfo.collective].CRI = atrEntry.Value;
                            }
                            if (atrEntry.Key.ToUpper().Contains("OBUDOWA"))
                            {
                                result[ledInfo.collective].package = atrEntry.Value;
                            }
                        }
                    }

                }

                result[ledInfo.collective].membersList.Add(ledInfo);
            }
            return result;
        }
    }
}
