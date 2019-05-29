using System;
using System.Collections.Generic;
using System.Data;
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
        public string BinLetter { get; set; }
        public string id { get; set; }
        public int currentQty { get; set; }
        public string currentOrderNo { get; set; }
        public DataTable reelSqlTable { get; set; }

        public static void SetUpCurrentBinQtyForNewOrder()
        {
            DataStorage.currentBins = new Dictionary<string, List<CurrentBinStruct>>();
            if (DataStorage.currentOrder.ledsChoosenByPlanner.Count() > 0)
            {
                foreach (var bin12Nc in DataStorage.currentOrder.ledsChoosenByPlanner)
                {
                    DataStorage.currentBins.Add(bin12Nc, new List<CurrentBinStruct>());
                }
            }
            else
            {
                for (int i = 0; i < DataStorage.currentOrder.numberOfBins; i++)
                {
                    DataStorage.currentBins.Add($"bin{i}", new List<CurrentBinStruct>());
                }
            }
        }

        public static void LoadBinReelsToCurrentBins()
        {
            DataStorage.currentBins.Clear();
            DataTable sqlTable = MST.MES.SqlOperations.SparingLedInfo.GetReelsForLot(DataStorage.currentOrder.orderNo);

                var detailedReelsInfo = FullLedInfo(sqlTable);


            if (detailedReelsInfo.Count > 0)
            {
                foreach (var bin12NcEntry in detailedReelsInfo)
                {
                    foreach (var idEntry in bin12NcEntry.Value)
                    {
                        int lastRow = idEntry.Value.Rows.Count - 1;
                        string aktZlecenie = idEntry.Value.Rows[lastRow]["ZlecenieString"].ToString();
                        int currentQty = int.Parse(idEntry.Value.Rows[lastRow]["qty"].ToString());
                        string binLetter = "";
                        foreach (DataRow row in idEntry.Value.Rows)
                        {
                            if(row["ZlecenieString"].ToString() == DataStorage.currentOrder.orderNo)
                            {
                                binLetter = row["Tara"].ToString();
                                break;
                            }
                        }

                        if (!DataStorage.currentBins.ContainsKey(bin12NcEntry.Key))
                        {
                            DataStorage.currentBins.Add(bin12NcEntry.Key, new List<CurrentBinStruct>());
                        }

                        CurrentBinStruct binNfo = new CurrentBinStruct
                        {
                            nc12 = bin12NcEntry.Key,
                            BinLetter = binLetter,
                            id = idEntry.Key,
                            currentOrderNo = aktZlecenie,
                            currentQty = currentQty,
                            reelSqlTable = idEntry.Value
                        };
                        DataStorage.currentBins[bin12NcEntry.Key].Add(binNfo);
                    }
                }

            }
        }

        public static Dictionary<string, Dictionary<string, DataTable>> FullLedInfo(DataTable lotSqlTable)
        {
            Dictionary<string, Dictionary<string, DataTable>> result = new Dictionary<string, Dictionary<string, DataTable>>();
            if (lotSqlTable.Rows.Count == 0) return result;
            List<MST.MES.Data_structures.LedInfo> ledsInLot = new List<MST.MES.Data_structures.LedInfo>();
            foreach (DataRow row in lotSqlTable.Rows)
            {
                string nc12 = row["NC12"].ToString();
                string id = row["ID"].ToString();
                //string partia = row["Partia"].ToString();
                if (ledsInLot.Select(l => l.uniqueNcId).Contains(nc12 + id)) continue;
                ledsInLot.Add(new MST.MES.Data_structures.LedInfo(nc12, id));
            }

            DataTable detailedLedTable = MST.MES.SqlOperations.SparingLedInfo.GetInfoForMultiple12NC_ID(ledsInLot.ToArray());
            DataTable templateTable = new DataTable();
            templateTable.Columns.Add("nc12");
            templateTable.Columns.Add("id");
            templateTable.Columns.Add("Partia");
            templateTable.Columns.Add("qty");
            templateTable.Columns.Add("zuzycie");
            templateTable.Columns.Add("zlecenieString");
            templateTable.Columns.Add("Data_Czas");
            templateTable.Columns.Add("Tara");

            foreach (DataRow row in detailedLedTable.Rows)
            {
                string zlecenieString = row["zlecenieString"].ToString();
                if (zlecenieString == "") continue;

                string nc12 = row["NC12"].ToString();
                string id = row["ID"].ToString();
                string partia = row["Partia"].ToString();
                string tara = row["Tara"].ToString();
                int zuzycie = 0;

                string qty = row["Ilosc"].ToString();

                if (!result.ContainsKey(nc12))
                {
                    result.Add(nc12, new Dictionary<string, DataTable>());
                }

                if (!result[nc12].ContainsKey(id))
                {
                    result[nc12].Add(id, templateTable.Clone());
                }

                if (result[nc12][id].Rows.Count > 0)
                {
                    if (result[nc12][id].Rows[result[nc12][id].Rows.Count - 1]["zlecenieString"].ToString() == zlecenieString)
                    {
                        int lastQty = int.Parse(result[nc12][id].Rows[result[nc12][id].Rows.Count - 1]["qty"].ToString());
                        zuzycie = lastQty - int.Parse(qty);
                    }
                }

                result[nc12][id].Rows.Add(nc12, id, partia, qty, zuzycie, zlecenieString, row["Data_Czas"].ToString(), tara);
            }
            return result;
        }
    }
}
