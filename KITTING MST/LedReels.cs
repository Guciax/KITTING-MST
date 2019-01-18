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
        public static void AddLedReelsForLot(string lot, DataGridView grid, ref Dictionary<string, string> currentBins)
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
                    string qty = row["Ilosc"].ToString();
                    string bin = row["Tara"].ToString();

                    if (!currentBins.ContainsKey(bin))
                    {
                        currentBins.Add(bin, nc12);
                    }

                    AddReelToGrid(nc12, id, grid, ref currentBins);
                    checkList.Add(nc12 + id);
                }
            }
        }

        public static void AddReelToGrid(string nc12, string id, DataGridView grid, ref Dictionary<string, string> currentBins)
        {
            DataTable reelTable = MST.MES.SqlOperations.SparingLedInfo.GetInfoFor12NC_ID(nc12, id);
            string qty = reelTable.Rows[0]["Ilosc"].ToString();
            string binId = reelTable.Rows[0]["Tara"].ToString();
            if (!currentBins.ContainsKey(binId))
            {
                currentBins.Add(binId, nc12);
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

            grid.Rows.Insert(binRow + 1, nc12, id, qty);
            
            dgvTools.SumUpLedsInBins(grid);

            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
