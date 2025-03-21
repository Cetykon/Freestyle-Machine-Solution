using Coca_Cola_Project.FreeStyleDBDataSetTableAdapters;
using Microsoft.VisualBasic;
using System;

namespace Coca_Cola_Project
{
    internal class LocationManagementReport
    {
        FreeStyleDBDataSetTableAdapters.OrdersTableAdapter OrdersTableAdapter = new FreeStyleDBDataSetTableAdapters.OrdersTableAdapter();
        FreeStyleDBDataSetTableAdapters.OrderFluidInfoTableAdapter OrderFluidInfoTableAdapter = new FreeStyleDBDataSetTableAdapters.OrderFluidInfoTableAdapter();
        public String GetReport(Flavors flavors)
        {
            try
            {
                string strLocationMgRp = "";
                double dblTotalRevenueFromMachine = 0d;
                int dblTotalNumberOfOrders = 0;
                double dblAverageOrderSize = 0d;
                double dblAverageRevenue = 0d;
                int dblMostRequestedFlavorID = 0;
                int dblMostRequestedFlavorCount = 0;
                string strMostRequestedFlavor = flavors.StrSodaNames[0];
                int dblLeastRequestedFlavorID = 0;
                int dblLeastRequestedFlavorCount = 0;
                string strLeastRequestedFlavor = flavors.StrSodaNames[0];

                int dblMostRequestedFlavorCountPlusOne = 0;
                int dblLestRequestedFlavorCountPlusOne = 0;
                // Assing variable data from select sql statements
                dblTotalRevenueFromMachine = (double)OrdersTableAdapter.SelectTotalRevenueCollected();
                dblTotalNumberOfOrders = (int)OrdersTableAdapter.SelectCountNumberOfOrders();
                dblAverageOrderSize = (double)OrderFluidInfoTableAdapter.SelectAverageOrderSize(10);
                dblAverageRevenue = dblTotalRevenueFromMachine / dblTotalNumberOfOrders;

                // strMostRequestedFlavor = flavors.StrSodaNames(Me.OrderFluidInfoTableAdapter.SelectMaxFluidUsed()).ToString()

                dblMostRequestedFlavorCount = Convert.ToInt32(OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(0));

                for (int RequestedCounter = 1; RequestedCounter <= 9; RequestedCounter++)
                {

                    // Get Most requested Flavor 
                    dblMostRequestedFlavorCountPlusOne = Convert.ToInt32(OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(RequestedCounter));

                    if (dblMostRequestedFlavorCount < dblMostRequestedFlavorCountPlusOne)
                    {

                        dblMostRequestedFlavorID = RequestedCounter;
                        strMostRequestedFlavor = flavors.StrSodaNames[dblMostRequestedFlavorID];

                        dblMostRequestedFlavorCount = Convert.ToInt32(OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(RequestedCounter));
                    }

                    else if (dblMostRequestedFlavorCount == dblMostRequestedFlavorCountPlusOne)
                    {


                        strMostRequestedFlavor = strMostRequestedFlavor + ", " + flavors.StrSodaNames[RequestedCounter];
                    }
                }

                dblLeastRequestedFlavorCount = Convert.ToInt32(OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(0));
                strLeastRequestedFlavor = flavors.StrSodaNames[0];

                for (int LeastCounter = 1; LeastCounter <= 9; LeastCounter++)
                {
                    // Get Least Requested flavor
                    dblLestRequestedFlavorCountPlusOne = Convert.ToInt32(OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(LeastCounter));

                    if (dblLeastRequestedFlavorCount > dblLestRequestedFlavorCountPlusOne)
                    {

                        dblLeastRequestedFlavorID = LeastCounter;
                        strLeastRequestedFlavor = flavors.StrSodaNames[dblLeastRequestedFlavorID];

                        dblLeastRequestedFlavorCount = Convert.ToInt32(OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(LeastCounter));
                    }

                    else if (dblLeastRequestedFlavorCount == dblLestRequestedFlavorCountPlusOne)
                    {


                        strLeastRequestedFlavor = strLeastRequestedFlavor + ", " + flavors.StrSodaNames[LeastCounter];


                    }
                }


                // strLeastRequestedFlavor = Me.OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(0).ToString()
                // MsgBox(strLeastRequestedFlavor)
                strLocationMgRp = "TotalRevenue: $" + dblTotalRevenueFromMachine.ToString("N2") + Constants.vbNewLine + Constants.vbNewLine + "TotalNumber of Orders: " + dblTotalNumberOfOrders + Constants.vbNewLine + Constants.vbNewLine + "AverageOrderSize: " + dblAverageOrderSize.ToString("N2") + "oz" + Constants.vbNewLine + Constants.vbNewLine + "AverageRevenue: $" + dblAverageRevenue.ToString() + Constants.vbNewLine + Constants.vbNewLine + "Most Requested Flavor:" + Constants.vbNewLine + strMostRequestedFlavor + Constants.vbNewLine + Constants.vbNewLine + "Least Requested Flavor:" + Constants.vbNewLine + strLeastRequestedFlavor;

                return strLocationMgRp;
            }

            catch (Exception)
            {
                return "Data for retrival not available" + Constants.vbNewLine + "An order needs to be made first.";
            }
        }
    }
}
