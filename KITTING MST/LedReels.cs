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
        public static void AddLedReelsForLot(DataGridView grid)
        {
            foreach (var bin12NcEntry in DataStorage.currentBins)
            {
                AddReelToGrid(bin12NcEntry.Key, bin12NcEntry.Value, grid);
            }
        }

        public static void AddReelToGrid(string nc12, List<CurrentBinStruct> bins, DataGridView grid)
        {
            int bin12NcIndex = 0;
            var sumOfBins = bins.Select(b => b.currentQty).Sum();
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if(row.Cells[0].Value.ToString() == nc12)
                    {
                        bin12NcIndex = row.Index;
                        row.Cells[2].Value = sumOfBins;
                        break;
                    }
                }
            }

            foreach (var bin in bins)
            {
                grid.Rows.Insert(bin12NcIndex + 1, nc12, bin.id, bin.currentQty, bin.currentOrderNo);
            }

            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
