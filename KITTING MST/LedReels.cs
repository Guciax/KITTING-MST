using KITTING_MST.DataStructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KITTING_MST
{
    class LedReels
    {
        public static void AddLedReelsForLot(string lot, DataGridView grid, ref Dictionary<string, CurrentBinStruct> currentBins, Dictionary<string, string> nc12ToName)
        {
            DataTable sqlTable = MST.MES.SqlOperations.SparingLedInfo.GetReelsForLot(lot);
            List<string> checkList = new List<string>();

            if (sqlTable.Rows.Count > 0)
            {
                foreach (DataRow row in sqlTable.Rows)
                {
                    string nc12 = row["NC12"].ToString();
                    string id = row["ID"].ToString();
                    if (checkList.Contains(nc12 + id)) continue;

                    var reelTable = MST.MES.SqlOperations.SparingLedInfo.GetInfoFor12NC_ID(nc12, id);
                    string aktZlecenie = reelTable.Rows[0]["ZlecenieString"].ToString();

                    string qty = row["Ilosc"].ToString();
                    string bin = row["Tara"].ToString();

                    if (!currentBins.ContainsKey(bin))
                    {
                        var ledName = LedNaming.GetLedName(nc12ToName[nc12]);
                        string cct = "";
                        foreach (var part in ledName.Split(' '))
                        {
                            if (part[part.Length - 1] == 'K') cct = part;
                        }
                        CurrentBinStruct binNfo = new CurrentBinStruct
                        {
                             cct = cct,
                             name = ledName,
                             nc12 = nc12
                        };
                        currentBins.Add(bin, binNfo);
                    }

                    AddReelToGrid(nc12, id, aktZlecenie, grid, ref currentBins, nc12ToName);
                    checkList.Add(nc12 + id);
                }
            }
        }

        public static void AddReelToGrid(string nc12, string id, string aktZlecenie, DataGridView grid, ref Dictionary<string, CurrentBinStruct> currentBins, Dictionary<string, string> nc12ToName)
        {
            DataTable reelTable = MST.MES.SqlOperations.SparingLedInfo.GetInfoFor12NC_ID(nc12, id);
            string qty = reelTable.Rows[0]["Ilosc"].ToString();
            string binId = reelTable.Rows[0]["Tara"].ToString();
            if (!currentBins.ContainsKey(binId))
            {
                var ledName = LedNaming.GetLedName(nc12ToName[nc12]);
                string cct = "";
                foreach (var part in ledName.Split(' '))
                {
                    if (part[part.Length - 1] == 'K') cct = part;
                }
                CurrentBinStruct binNfo = new CurrentBinStruct
                {
                    cct = cct,
                    name = ledName,
                    nc12 = nc12
                };
                currentBins.Add(binId, binNfo);
            }


            int binRow = 0;
            for (int r = 0; r < grid.Rows.Count; r++)
            {
                if (grid.Rows[r].Cells[0].Value == null) continue;
                if (grid.Rows[r].Cells[0].Value.ToString() == binId)
                {
                    binRow = r;
                    break;
                }
            }

            grid.Rows.Insert(binRow + 1, nc12, id, qty, aktZlecenie);
            
            dgvTools.SumUpLedsInBins(grid);

            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
