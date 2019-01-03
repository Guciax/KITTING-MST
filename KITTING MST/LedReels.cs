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
        public static void AddLedReelsForLot(string lot, DataGridView grid)
        {
            DataTable sqlTable = MST.MES.SqlOperations.SparingLedInfo.GetReelsForLot(lot);
            List<string> checkList = new List<string>();

            if (sqlTable.Rows.Count > 0)
            {
                grid.Rows.Clear();
                foreach (DataRow row in sqlTable.Rows)
                {
                    string nc12 = row["NC12"].ToString();
                    string id = row["ID"].ToString();
                    if (checkList.Contains(nc12 + id)) continue;
                    AddReelToGrid(nc12, id, grid);
                    checkList.Add(nc12 + id);
                }
            }
        }

        public static void AddReelToGrid(string nc12, string id, DataGridView grid)
        {
            DataTable reelTable = MST.MES.SqlOperations.SparingLedInfo.GetInfoFor12NC_ID(nc12, id);
            HashSet<string> lotNumbers = new HashSet<string>();
            foreach (DataRow row in reelTable.Rows)
            {
                if (row["ZlecenieString"].ToString() == "" || row["ZlecenieString"].ToString() == "NULL") continue;
                lotNumbers.Add(row["ZlecenieString"].ToString());
            }

            string qty = reelTable.Rows[0]["Ilosc"].ToString();
            if (lotNumbers.Count>1)
            {
                qty = "(" + qty + @") /" + lotNumbers.Count;
            }

            grid.Rows.Add(nc12, id, qty);

            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
