using KITTING_MST.DataStructure;
using KITTING_MST.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KITTING_MST
{
    class dgvTools
    {

        public static void PrepareDgvForBins(DataGridView grid)
        {
            int binQty = (int)DataStorage.currentOrder.numberOfBins;
            grid.Rows.Clear();
            Char binId = 'A';
            foreach (var bin12NcEntry in DataStorage.currentBins)
            {
                string bin12Nc = bin12NcEntry.Key.Length == 12 ? bin12NcEntry.Key : binId.ToString();
                grid.Rows.Add(bin12Nc, "BIN " + binId.ToString());
                foreach (DataGridViewCell cell in grid.Rows[grid.Rows.Count - 1].Cells)
                {
                    cell.Style.ForeColor = Color.White;
                    cell.Style.BackColor = Color.DimGray;
                }
                binId++;
                grid.Rows.Add();
            }
            if (grid.Rows.Count > 0) grid.Rows.RemoveAt(grid.Rows.Count - 1);
        }



        public static void ShowLedDetails(DataGridView dataGridViewLedReels, int rowIndex)
        {
            if (dataGridViewLedReels.Rows[rowIndex].Cells[3].Value != null)
            {
                string bin = "";
                for (int r = rowIndex; r >= 0; r--)
                {
                    if (dataGridViewLedReels.Rows[r].Cells[1].Value.ToString().Contains("BIN"))
                    {
                        bin = dataGridViewLedReels.Rows[r].Cells[1].Value.ToString().Replace("BIN", "").Trim();
                        break;
                    }
                }
                string aktZlec = dataGridViewLedReels.Rows[rowIndex].Cells[3].Value.ToString();
                string nc12 = dataGridViewLedReels.Rows[rowIndex].Cells[0].Value.ToString();
                string id = dataGridViewLedReels.Rows[rowIndex].Cells[1].Value.ToString();

                
            }
        }
    }
}
