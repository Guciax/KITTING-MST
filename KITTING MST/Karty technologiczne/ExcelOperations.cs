using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KITTING_MST.Karty_technologiczne
{
    public class ExcelOperations
    {
        public class BinDescription
        {
            public string nc12Address;
            public string nameAddress;
        }

        public class ExcelParameters
        {
            public static string katyTechnologiczneDirPath = @"";
            public static string orderNoAddress = "A1";
            public static string quantityAddress = "A3";
            public static string tempFileName = "kartaTechnologiczna.xlsx";

            public static Dictionary<string, BinDescription> binDescriptions = new Dictionary<string, BinDescription>
            {
                {"A", new BinDescription{nc12Address="B4", nameAddress="A4"} },
                {"B", new BinDescription{nc12Address="B5", nameAddress="A5"} },
                {"C", new BinDescription{nc12Address="B6", nameAddress="A6"} },
                {"D", new BinDescription{nc12Address="B7", nameAddress="A7"} },
            };
        }

        public static ExcelPackage GetExcelPackage(string nc12)
        {
            return new ExcelPackage(new System.IO.FileInfo(Path.Combine( ExcelParameters.katyTechnologiczneDirPath, nc12)));
        }

        public static void FillOutExcelData(MST.MES.OrderStructureByOrderNo.Kitting currentOrder, ref ExcelPackage excelPck, Dictionary<string, string> currentBins, Dictionary<string, string> nc12ToName)
        {
            excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.orderNoAddress].Value = currentOrder.orderNo;
            excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.quantityAddress].Value = currentOrder.orderedQty;

            foreach (var binEntry in currentBins)
            {
                excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.binDescriptions[binEntry.Key].nc12Address].Value = binEntry.Value;
                excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.binDescriptions[binEntry.Key].nameAddress].Value = nc12ToName[binEntry.Value];
            }
        }

        public static string SaveExcelAndReturnPath(ExcelPackage excelPck)
        {
            var bytes = excelPck.GetAsByteArray();
            string tempFile = Path.Combine(Path.GetTempPath(), ExcelParameters.tempFileName);
            System.IO.File.WriteAllBytes(tempFile, bytes);
            
            return tempFile;
        }
    }
}
