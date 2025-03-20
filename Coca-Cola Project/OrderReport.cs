using Coca_Cola_Project.FreeStyleDBDataSetTableAdapters;
using Microsoft.VisualBasic;
using System;

namespace Coca_Cola_Project
{
    internal class OrderReport
    {
        FreeStyleDBDataSetTableAdapters.OrdersTableAdapter OrdersTableAdapter = new FreeStyleDBDataSetTableAdapters.OrdersTableAdapter();
        FreeStyleDBDataSetTableAdapters.OrderFluidInfoTableAdapter OrderFluidInfoTableAdapter = new FreeStyleDBDataSetTableAdapters.OrderFluidInfoTableAdapter();
        public string GetReport(DateTime StartDateRp, DateTime EndDateRP, Flavors flavors)
        {
            try
            {
                // used the selected date to input into the database select statement

                // Dim strStarDateRp As String = StartDateRp.ToString("yyyy-MM-dd")

                // Dim strEndDateRp As String = EndDateRP.ToString("yyyy-MM-dd")
                string strOrderReport;

                // Required data For order info - Order number, Order line number, Order Date, Flavor associated with the line number, Total dollar amount for the order 
                int intCountOfOrderWDP = (int)OrdersTableAdapter.SelectCountOfOrderWDP(StartDateRp.ToString("MM/dd/yyyy"), EndDateRP.ToString("MM/dd/yyyy"));


                // Dim TableStringWDP As String = ""
                // Dim OrderIDWDP As Object

                // For intRowIndex As Integer = 0 To intCountOfOrderWDP
                // OrderIDWDP = OrdersDataGridViewWDP.Rows(intRowIndex).Cells(0).Value
                // TableStringWDP = OrderIDWDP.ToString() & " - "
                // OrderIDWDP = OrdersDataGridViewWDP.Rows(intRowIndex).Cells(1).Value
                // TableStringWDP = OrderIDWDP.ToString() & " - "
                // OrderIDWDP = OrdersDataGridViewWDP.Rows(intRowIndex).Cells(2).Value
                // TableStringWDP = OrderIDWDP.ToString() & " - " & vbNewLine

                // Next

                // MsgBox(TableStringWDP)




                // A total dollar amount of all orders on the report
                double dblTotalAmountWDP = (double)OrdersTableAdapter.SelectTotalOrderAmountGivenStartAndEndDate(StartDateRp.ToString("MM/dd/yyyy"), EndDateRP.ToString("MM/dd/yyyy"));

                // A "Most Requested" flavor
                int dblMostRequestedFlavorID = 0;
                int dblMostRequestedFlavorCount = 0;
                string strMostRequestedFlavorWDP = flavors.StrSodaNames[0];
                try
                {

                    int dblMostRequestedFlavorCountPlusOne = 0;

                    dblMostRequestedFlavorCount = (int)OrderFluidInfoTableAdapter.SelectCountofFluidIDWDP(0, StartDateRp.ToString("MM/dd/yyyy"), EndDateRP.ToString("MM/dd/yyyy"));

                    for (int RequestedCounter = 1; RequestedCounter <= 9; RequestedCounter++)
                    {

                        dblMostRequestedFlavorCountPlusOne = (int)OrderFluidInfoTableAdapter.SelectCountofFluidIDWDP(RequestedCounter, StartDateRp.ToString("MM/dd/yyyy"), EndDateRP.ToString("MM/dd/yyyy"));

                        if (dblMostRequestedFlavorCount < dblMostRequestedFlavorCountPlusOne)
                        {

                            dblMostRequestedFlavorID = RequestedCounter;

                            strMostRequestedFlavorWDP = flavors.StrSodaNames[dblMostRequestedFlavorID];

                            dblMostRequestedFlavorCount = (int)OrderFluidInfoTableAdapter.SelectCountofFluidIDWDP(RequestedCounter, StartDateRp.ToString("MM/dd/yyyy"), EndDateRP.ToString("MM/dd/yyyy"));
                        }

                        else if (dblMostRequestedFlavorCount == dblMostRequestedFlavorCountPlusOne)
                        {

                            strMostRequestedFlavorWDP = strMostRequestedFlavorWDP + ", " + flavors.StrSodaNames[RequestedCounter];

                        }

                    }
                }

                catch (Exception ex)
                {
                    Interaction.MsgBox("Failed to get Most Requested Flavor");
                    strMostRequestedFlavorWDP = "Unavailable";
                }

                // A "Least Requested" flavor

                int dblLeastRequestedFlavorID = 0;
                int dblLeastRequestedFlavorCount = 0;
                string strLeastRequestedFlavorWDP = flavors.StrSodaNames[0];


                try
                {
                    int dblLestRequestedFlavorCountPlusOne = 0;

                    dblLeastRequestedFlavorCount = (int)OrderFluidInfoTableAdapter.SelectCountofFluidIDWDP(0, StartDateRp.ToString("MM/dd/yyyy"), EndDateRP.ToString("MM/dd/yyyy"));
                    strLeastRequestedFlavorWDP = flavors.StrSodaNames[0];

                    for (int LeastCounter = 1; LeastCounter <= 9; LeastCounter++)
                    {
                        // Get Least Requested flavor
                        dblLestRequestedFlavorCountPlusOne = (int)OrderFluidInfoTableAdapter.SelectCountofFluidIDWDP(LeastCounter, StartDateRp.ToString("MM/dd/yyyy"), EndDateRP.ToString("MM/dd/yyyy"));

                        if (dblLeastRequestedFlavorCount > dblLestRequestedFlavorCountPlusOne)
                        {

                            dblLeastRequestedFlavorID = LeastCounter;

                            strLeastRequestedFlavorWDP = flavors.StrSodaNames[dblLeastRequestedFlavorID];

                            dblLeastRequestedFlavorCount = (int)OrderFluidInfoTableAdapter.SelectCountofFluidIDWDP(LeastCounter, StartDateRp.ToString("MM/dd/yyyy"), EndDateRP.ToString("MM/dd/yyyy"));
                        }

                        else if (dblLeastRequestedFlavorCount == dblLestRequestedFlavorCountPlusOne)
                        {


                            strLeastRequestedFlavorWDP = strLeastRequestedFlavorWDP + ", " + flavors.StrSodaNames[LeastCounter];


                        }
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Failed to get Least Requested Flavor");
                    strLeastRequestedFlavorWDP = "Unavailable";
                }

                // The most common size dispensed for all of the orders (8,16,24,32)
                // Dim dblCo2Used() As Double = {4, 8, 12, 16}
                string strMostCommonSizeWDP;



                try
                {
                    strMostCommonSizeWDP = "8 oz";
                    // The date string fail to convert to date for some reason!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    // , StartDateRp.ToString("d"), EndDateRP.ToString("d")
                    int intCo2CountOf8oz = Convert.ToInt32(OrderFluidInfoTableAdapter.SelectTimesofCo2WasUsedGivenStartDateandEndateOfOrder(4d, StartDateRp.ToString("d"), EndDateRP.ToString("d")));
                    int intCo2CountOf16oz = Convert.ToInt32(OrderFluidInfoTableAdapter.SelectTimesofCo2WasUsedGivenStartDateandEndateOfOrder(8d, StartDateRp.ToString("d"), EndDateRP.ToString("d")));
                    int intCo2CountOf24oz = Convert.ToInt32(OrderFluidInfoTableAdapter.SelectTimesofCo2WasUsedGivenStartDateandEndateOfOrder(12d, StartDateRp.ToString("d"), EndDateRP.ToString("d")));
                    int intCo2CountOf32oz = Convert.ToInt32(OrderFluidInfoTableAdapter.SelectTimesofCo2WasUsedGivenStartDateandEndateOfOrder(16d, StartDateRp.ToString("d"), EndDateRP.ToString("d")));



                    if (intCo2CountOf8oz < intCo2CountOf16oz)
                    {
                        strMostCommonSizeWDP = "16 oz";
                    }
                    else if (intCo2CountOf8oz == intCo2CountOf16oz)
                    {
                        strMostCommonSizeWDP = strMostCommonSizeWDP + ", 16 oz";
                    }

                    if (intCo2CountOf16oz < intCo2CountOf24oz)
                    {
                        strMostCommonSizeWDP = "24 oz";
                    }
                    else if (intCo2CountOf16oz == intCo2CountOf24oz)
                    {
                        strMostCommonSizeWDP = strMostCommonSizeWDP + ", 24 oz";
                    }

                    if (intCo2CountOf24oz < intCo2CountOf32oz)
                    {
                        strMostCommonSizeWDP = "32 oz";
                    }
                    else if (intCo2CountOf24oz == intCo2CountOf32oz)
                    {
                        strMostCommonSizeWDP = strMostCommonSizeWDP + ", 32 oz";
                    }
                }
                catch (Exception ex)
                {
                    strMostCommonSizeWDP = "Unavailable";
                    return "Unable to get Most sizes chosen";
                }

                // Message formatting
                strOrderReport = StartDateRp.ToString("d") + Constants.vbNewLine + EndDateRP.ToString("d") + Constants.vbNewLine + dblTotalAmountWDP.ToString("N2") + Constants.vbNewLine + strMostCommonSizeWDP + Constants.vbNewLine + strMostRequestedFlavorWDP + Constants.vbNewLine + strLeastRequestedFlavorWDP;

                return strOrderReport;
            }

            catch (Exception ex)
            {
                return "Not Enough Data inputed to create report!" + Constants.vbNewLine + "or" + Constants.vbNewLine + "Check input date as only data between the dates will be Reported.";
            }

        }
    }
}
