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
        public static void PrepareDgvForBins(DataGridView grid, int binQty)
        {
            grid.Rows.Clear();
            Char binId = 'A';
            for (int b = 0; b < binQty; b++)
            {
                grid.Rows.Add(binId.ToString(),"BIN " + binId.ToString());
                foreach (DataGridViewCell cell in grid.Rows[grid.Rows.Count - 1].Cells)
                {
                    if (cell.Value != null)
                    {
                        if (cell.Value.ToString() == binId.ToString())
                        {
                            cell.Style.ForeColor = Color.DimGray;
                        }
                        else
                        {
                            cell.Style.ForeColor = Color.White;
                        }
                    }
                    cell.Style.BackColor = Color.DimGray;
                    
                }
                binId++;
                grid.Rows.Add();
            }
            if (grid.Rows.Count>0) grid.Rows.RemoveAt(grid.Rows.Count - 1);
        }

        public static void SumUpLedsInBins(DataGridView grid)
        {
            int lastBin = 0;
            double binSum = 0;
            for (int r = 0; r < grid.Rows.Count; r++) 
            {
                if (grid.Rows[r].Cells[0].Value == null) continue;
                if (grid.Rows[r].Cells[0].Value.ToString().Length == 1) 
                {
                    grid.Rows[lastBin].Cells[2].Value = binSum;
                    binSum = 0;
                    lastBin = r;
                    continue;
                }

                if (grid.Rows[r].Cells[2].Value == null) continue;
                binSum += double.Parse(grid.Rows[r].Cells[2].Value.ToString());

                if (r == grid.Rows.Count - 1)
                {
                    grid.Rows[lastBin].Cells[2].Value = binSum;
                }
            }
        }
    }
}
