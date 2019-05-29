using KITTING_MST.DataStructure;
using KITTING_MST.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KITTING_MST
{
    public class OrderLoader
    {
        public static bool OrderExistOrCreatedNewOne(string orderNo)
        {
            DataStorage.currentOrder = MST.MES.SqlDataReaderMethods.Kitting.GetOneOrderByDataReader(orderNo);
            if (DataStorage.currentOrder.orderNo == "")
            {
                //new order
                using (AddNewLot lotForm = new AddNewLot(orderNo, DataStorage.mesModels))
                {
                    if (lotForm.ShowDialog() == DialogResult.OK)
                    {
                        DataStorage.currentOrder = MST.MES.SqlDataReaderMethods.Kitting.GetOneOrderByDataReader(orderNo);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
