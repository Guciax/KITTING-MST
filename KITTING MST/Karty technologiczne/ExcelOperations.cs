using KITTING_MST.DataStructure;
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
            public static string katyTechnologiczneDirPath = @"Y:\Manufacturing_Center\Integral Quality Management\Karty technologiczne\Karty technologiczne LED\";
            public static string orderNoAddress = "L2";
            public static string quantityAddress = "K6";
            public static string tempFileName = "kartaTechnologiczna.xlsx";

            public static Dictionary<string, BinDescription> binDescriptions = new Dictionary<string, BinDescription>
            {
                {"A", new BinDescription{nc12Address="E17", nameAddress="C17"} },
                {"B", new BinDescription{nc12Address="E18", nameAddress="C18"} },
                {"C", new BinDescription{nc12Address="E19", nameAddress="C19"} },
                {"D", new BinDescription{nc12Address="E20", nameAddress="C20"} },
            };
        }

        public static ExcelPackage GetExcelPackage(string nc12)
        {
            string filePath = Path.Combine(ExcelParameters.katyTechnologiczneDirPath, $"{nc12}46.xlsx");
            if (!Directory.Exists(@"Y:\"))
            {
                MessageBox.Show($"Brak dostępu do dysku Y:");
                return null;
            }
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Brak karty technologicznej dla modelu: {nc12}46");
                return null;
            }

            return new ExcelPackage(new System.IO.FileInfo(filePath));
        }

        public static void FillOutExcelData(MST.MES.OrderStructureByOrderNo.Kitting currentOrder, ref ExcelPackage excelPck, Dictionary<string, CurrentBinStruct> currentBins, Dictionary<string, string> nc12ToName)
        {
            //excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.orderNoAddress].Value = currentOrder.orderNo.ToString();
            //excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.quantityAddress].Value = currentOrder.orderedQty.ToString();

            foreach (var binEntry in currentBins)
            {
                //excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.binDescriptions[binEntry.Key].nc12Address].Value = binEntry.Value.nc12_formated;
                //excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.binDescriptions[binEntry.Key].nameAddress].Value = nc12ToName[binEntry.Value.nc12];
            }
        }

        public static string SaveExcelAndReturnPath(ExcelPackage excelPck)
        {
            //var bytes = excelPck.GetAsByteArray();
            string tempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), ExcelParameters.tempFileName);
            //System.IO.File.WriteAllBytes(tempFile, bytes);
           // excelPck.SaveAs(new FileInfo(tempFile));

            Stream stream = File.Create(tempFile);
            excelPck.SaveAs(stream);
            stream.Close();

            return tempFile;
        }
    }
}
