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
            public string quantity;
        }

        public class ExcelParameters
        {
            public static string katyTechnologiczneDirPath = @"Y:\Manufacturing_Center\Integral Quality Management\Karty technologiczne\Karty technologiczne LED\";
            public static string orderNoAddress = "L4";
            public static string quantityAddress = "K8";
            public static string tempFileName = "kartaTechnologiczna.xlsx";

            public static Dictionary<string, BinDescription> binDescriptions = new Dictionary<string, BinDescription>
            {
                {"A", new BinDescription{nameAddress="C19",nc12Address="E19", quantity="F19"} },
                {"B", new BinDescription{nameAddress="C20",nc12Address="E20", quantity="F20"} },
                {"C", new BinDescription{nameAddress="C21",nc12Address="E21", quantity="F21"} },
                {"D", new BinDescription{nameAddress="C22",nc12Address="E22", quantity="F22"} },
            };
        }

        public static ExcelPackage GetExcelPackage(string nc12)
        {
            string filePath = Path.Combine(ExcelParameters.katyTechnologiczneDirPath, $"{nc12}.xlsx");
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

        public static void FillOutExcelData(MST.MES.OrderStructureByOrderNo.Kitting currentOrder, ref ExcelPackage excelPck, Dictionary<string, LedStructForTechnologicSpec> ledForTechCard)
        {
            excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.orderNoAddress].Value = currentOrder.orderNo.ToString();
            excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.quantityAddress].Value = currentOrder.orderedQty.ToString();

            char binId = 'A';
            foreach (var collectiveEntry in ledForTechCard)
            {
                foreach (var binEntry in collectiveEntry.Value.membersList)
                {
                    string name = "";
                    if (collectiveEntry.Value.CRI!=null & collectiveEntry.Value.CCT!=null & collectiveEntry.Value.package != null)
                    {
                        name = $"Dioda LED {collectiveEntry.Value.package.Split('(')[0].Trim()} {collectiveEntry.Value.CCT}K CRI{collectiveEntry.Value.CRI}";
                    }
                    else
                    {
                        name = collectiveEntry.Value.name;
                    }
                    excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.binDescriptions[binId.ToString()].nameAddress].Value = name;
                    excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.binDescriptions[binId.ToString()].nc12Address].Value = binEntry.nc12.Insert(4," ").Insert(8," ");
                    excelPck.Workbook.Worksheets[1].Cells[ExcelParameters.binDescriptions[binId.ToString()].quantity].Value = collectiveEntry.Value.qtyPerModel/collectiveEntry.Value.membersList.Count;
                    binId++;
                }
            }
        }

        public static string SaveExcelAndReturnPath(ExcelPackage excelPck)
        {
            //var bytes = excelPck.GetAsByteArray();
            string tempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), ExcelParameters.tempFileName);
            //System.IO.File.WriteAllBytes(tempFile, bytes);
            //excelPck.SaveAs(new FileInfo(tempFile));

            Stream stream = File.Create(tempFile);
            excelPck.SaveAs(stream);
            stream.Close();

            return tempFile;
        }
    }
}
