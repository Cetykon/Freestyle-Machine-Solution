using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Coca_Cola_Project
{

    /// <summary>
    /// Main class for a Coca-Cola Freestyle machine program.
    /// First version, Written Date: 2021
    /// 
    /// Project used to learn how to program.
    /// If any changes are made, be sure to trace variables,
    /// variables can be tightly coupled.
    /// </summary>
    public partial class MainForm
    {
        // Counter for loops
        private int intCounter = 0;
        // Create variables needed
        private int MixCount = 0;
        private int intFlavorSelecCount = 0;
        private string FirstFlavor = "N/A";
        private int FirstFlavorID;
        private string SecondFlavor = "N/A";
        private int SecondFlavorID;
        private string ThirdFlavor = "N/A";
        private int ThirdFlavorID;
        private int IndexFlavor = 0;
        private double OzPicked = 0d;
        private double OzOfFlavor = 0d;
        private double OzOfCo2 = 0d;
        // Array to keep track of Syrup Used
        private double[] dblSyrupBoxs = new double[] { 34d, 34d, 34d, 34d, 34d, 34d, 34d, 34d, 34d, 34d };
        private string[] StrSodaNames = new string[] { "Coca-Cola", "Coca-Cola Diet", "Coca-Cola Zero", "Fanta", "Dr Pepper", "Sprite", "Sprite Zero", "Minute Maid Lemonade", "Minute Maid Lemonade Zero", "Root Beer" };
        // Co2 Container
        private double dblCo2Box = 170d;
        // Array for cost of drinks
        // 8oz,16oz,24oz,32oz
        private double[] dblDrinkCost = new double[] { 2d, 2.5d, 3d, 3.5d };
        // Get todays date
        private DateTime TodaysDate;
        // Check for flavor Availability 
        private bool FlavorOneAvailable = true;
        private bool FlavorTwoAvailable = true;
        private bool FlavorThreeAvailable = true;

        public MainForm()
        {
            InitializeComponent();
        }

        // Method to handle soda flavor selection
        // Passing the label for lable control in this case to make it visible
        private void SelectFlavor(int flavorID, Label labelControl, int indexFlavor)
        {
            // Check if the flavor is already selected
            if (FirstFlavorID == flavorID || SecondFlavorID == flavorID || ThirdFlavorID == flavorID)
            {
                Interaction.MsgBox("Flavor Already Selected");
                return;
            }

            // Proceed only if the mix count limit is not reached
            if (MixCount < 3)
            {
                // Display the selection label
                labelControl.Visible = true;

                // Update the mix count and flavor index
                MixCountCheck();
                IndexFlavor = indexFlavor;

                // Set and display selected flavors
                SetFlavors();
                ShowNumPickFlavors();
            }
        }

        // Event handlers for each soda button click
        private void picCola_Click(object sender, EventArgs e)
        {
            SelectFlavor(0, lblCola, 1);
        }

        private void picColaDiet_Click(object sender, EventArgs e)
        {
            SelectFlavor(1, lblDietCola, 2);
        }

        private void picColaZero_Click(object sender, EventArgs e)
        {
            SelectFlavor(2, lblZeroCola, 3);
        }

        private void picFanta_Click(object sender, EventArgs e)
        {
            SelectFlavor(3, lblFanta, 4);
        }

        private void picDrPepper_Click(object sender, EventArgs e)
        {
            SelectFlavor(4, lblDrPepper, 5);
        }

        private void picSprite_Click(object sender, EventArgs e)
        {
            SelectFlavor(5, lblSprite, 6);
        }

        private void picSpriteZero_Click(object sender, EventArgs e)
        {
            SelectFlavor(6, lblSpriteZero, 7);
        }

        private void picMMLemon_Click(object sender, EventArgs e)
        {
            SelectFlavor(7, lblMntMaid, 8);
        }

        private void picMMLemonZero_Click(object sender, EventArgs e)
        {
            SelectFlavor(8, lblMntMaidZero, 9);
        }

        private void picRootBeer_Click(object sender, EventArgs e)
        {
            SelectFlavor(9, lblRootBeer, 10);
        }


        // Button to reorder syrup and co2
        private void btnReOrder_Click(object sender, EventArgs e)
        {
            if (btnReOrder.Visible == true & btnOrderInventoryAfterSelection.Visible == true)
            {
                cklbInventory.Visible = false;
                btnOrderInventoryAfterSelection.Visible = false;
            }
            else
            {
                cklbInventory.Visible = true;
                btnOrderInventoryAfterSelection.Visible = true;
            }


        }


        private void btnOrderInventoryAfterSelection_Click(object sender, EventArgs e)
        {
            DateTime ExpirationDate;

            TodaysDate = DateTime.Today;
            // Makes the expiration date 30 days after it was fill
            ExpirationDate = TodaysDate.AddDays(30d);
            // Loop to check what items were selected in the list box
            foreach (int lstItem in cklbInventory.CheckedIndices)

                InventoryTableAdapter.UpdateInventory(Conversions.ToDouble(InventoryTableAdapter.SelectCapacity(lstItem)), Conversions.ToString(ExpirationDate), Conversions.ToString(TodaysDate), lstItem, lstItem);

            // update data set object
            InventoryTableAdapter.Fill(FreeStyleDBDataSet.Inventory);
            // Clear Check list box selections
            foreach (int unchecklst in cklbInventory.CheckedIndices)
                cklbInventory.SetItemChecked(unchecklst, false);

            // hide check list box and order button
            cklbInventory.Visible = false;
            btnOrderInventoryAfterSelection.Visible = false;
        }

        // Button to Fluid Level Report
        private void btnSyrupSt_Click(object sender, EventArgs e)
        {
            string strLowlvlFluids = "";
            string strSyrupSt = "";

            for (intCounter = 0; intCounter <= 9; intCounter++)
            {
                // Add all Flavors and their current amount of liquid to a string
                strSyrupSt = strSyrupSt + StrSodaNames[intCounter] + ": " + dblSyrupBoxs[intCounter].ToString("N2") + "oz" + Constants.vbNewLine;

                // Add fluids that are in a low threshold to a string
                if (dblSyrupBoxs[intCounter] < 12d)
                {
                    strLowlvlFluids = strLowlvlFluids + StrSodaNames[intCounter] + ": " + dblSyrupBoxs[intCounter].ToString("N2") + "oz" + Constants.vbNewLine;
                }
                if (dblCo2Box < 54d)
                {
                    strLowlvlFluids = strLowlvlFluids + Constants.vbNewLine + "Co2: " + dblCo2Box.ToString("N2");
                }
            }

            if (string.IsNullOrEmpty(strLowlvlFluids))
            {
                strLowlvlFluids = "No Fluid Found!";
            }
            strSyrupSt = strSyrupSt + Constants.vbNewLine + "Co2: " + dblCo2Box.ToString("N2") + "oz" + Constants.vbNewLine;

            Interaction.MsgBox("Syrup and Co2 Stats:" + Constants.vbNewLine + Constants.vbNewLine + strSyrupSt + Constants.vbNewLine + "Fluids at low threshold:" + Constants.vbNewLine + Constants.vbNewLine + strLowlvlFluids + Constants.vbNewLine);

        }
        // Maintenance Report
        private void btnMaintenanceRp_Click(object sender, EventArgs e)
        {
            string MaintenanceReport = "";
            double CurrentAmount;
            double Capacity;
            DateTime ExpirationDate;
            DateTime LastFillDate;


            for (int MaintenanceCount = 0; MaintenanceCount <= 10; MaintenanceCount++)
            {
                CurrentAmount = (double)InventoryTableAdapter.SelectCurrentAmount(MaintenanceCount);
                Capacity = Conversions.ToDouble(InventoryTableAdapter.SelectCapacity(MaintenanceCount));

                ExpirationDate = (DateTime)InventoryTableAdapter.SelectExpirationDate(MaintenanceCount);
                LastFillDate = Conversions.ToDate(InventoryTableAdapter.SelectLastFillDate(MaintenanceCount).ToString());

                MaintenanceReport = MaintenanceReport + Capacity.ToString("N2") + "--" + CurrentAmount.ToString("N2") + "--" + ExpirationDate.ToString("MM/dd/yyyy") + "--" + LastFillDate.ToString("MM/dd/yyyy") + Constants.vbNewLine;

            }

            Interaction.MsgBox("Capacity--Current Amount--Expiration Date--Last Fill Date" + Constants.vbNewLine + MaintenanceReport);


        }
        // Order Report
        private void btnSodaSt_Click(object sender, EventArgs e)
        {
            // if Date selection is already visible hide it. 
            if (lblStartDate.Visible == true & lblEndDate.Visible == true)
            {
                lblStartDate.Visible = false;
                lblEndDate.Visible = false;
                DTPStart.Visible = false;
                DTPEnd.Visible = false;
                btnGetOrderReport.Visible = false;
            }
            else
            {
                // if date selection wasn't already visible the make it visible
                lblStartDate.Visible = true;
                lblEndDate.Visible = true;
                DTPStart.Visible = true;
                DTPEnd.Visible = true;
                btnGetOrderReport.Visible = true;
            }



        }

        private void btnGetOrderReport_Click(object sender, EventArgs e)
        {
            try
            {
                // used the selected date to input into the database select statement
                var StartDateRp = DTPStart.Value;
                // Dim strStarDateRp As String = StartDateRp.ToString("yyyy-MM-dd")
                var EndDateRP = DTPEnd.Value;
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
                string strMostRequestedFlavorWDP = StrSodaNames[0];
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

                            strMostRequestedFlavorWDP = StrSodaNames[dblMostRequestedFlavorID];

                            dblMostRequestedFlavorCount = (int)OrderFluidInfoTableAdapter.SelectCountofFluidIDWDP(RequestedCounter, StartDateRp.ToString("MM/dd/yyyy"), EndDateRP.ToString("MM/dd/yyyy"));
                        }

                        else if (dblMostRequestedFlavorCount == dblMostRequestedFlavorCountPlusOne)
                        {

                            strMostRequestedFlavorWDP = strMostRequestedFlavorWDP + ", " + StrSodaNames[RequestedCounter];

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
                string strLeastRequestedFlavorWDP = StrSodaNames[0];


                try
                {
                    int dblLestRequestedFlavorCountPlusOne = 0;

                    dblLeastRequestedFlavorCount = (int)OrderFluidInfoTableAdapter.SelectCountofFluidIDWDP(0, StartDateRp.ToString("MM/dd/yyyy"), EndDateRP.ToString("MM/dd/yyyy"));
                    strLeastRequestedFlavorWDP = StrSodaNames[0];

                    for (int LeastCounter = 1; LeastCounter <= 9; LeastCounter++)
                    {
                        // Get Least Requested flavor
                        dblLestRequestedFlavorCountPlusOne = (int)OrderFluidInfoTableAdapter.SelectCountofFluidIDWDP(LeastCounter, StartDateRp.ToString("MM/dd/yyyy"), EndDateRP.ToString("MM/dd/yyyy"));

                        if (dblLeastRequestedFlavorCount > dblLestRequestedFlavorCountPlusOne)
                        {

                            dblLeastRequestedFlavorID = LeastCounter;

                            strLeastRequestedFlavorWDP = StrSodaNames[dblLeastRequestedFlavorID];

                            dblLeastRequestedFlavorCount = (int)OrderFluidInfoTableAdapter.SelectCountofFluidIDWDP(LeastCounter, StartDateRp.ToString("MM/dd/yyyy"), EndDateRP.ToString("MM/dd/yyyy"));
                        }

                        else if (dblLeastRequestedFlavorCount == dblLestRequestedFlavorCountPlusOne)
                        {


                            strLeastRequestedFlavorWDP = strLeastRequestedFlavorWDP + ", " + StrSodaNames[LeastCounter];


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
                    int intCo2CountOf8oz = Conversions.ToInteger(OrderFluidInfoTableAdapter.SelectTimesofCo2WasUsedGivenStartDateandEndateOfOrder(4d, StartDateRp.ToString("d"), EndDateRP.ToString("d")));
                    int intCo2CountOf16oz = Conversions.ToInteger(OrderFluidInfoTableAdapter.SelectTimesofCo2WasUsedGivenStartDateandEndateOfOrder(8d, StartDateRp.ToString("d"), EndDateRP.ToString("d")));
                    int intCo2CountOf24oz = Conversions.ToInteger(OrderFluidInfoTableAdapter.SelectTimesofCo2WasUsedGivenStartDateandEndateOfOrder(12d, StartDateRp.ToString("d"), EndDateRP.ToString("d")));
                    int intCo2CountOf32oz = Conversions.ToInteger(OrderFluidInfoTableAdapter.SelectTimesofCo2WasUsedGivenStartDateandEndateOfOrder(16d, StartDateRp.ToString("d"), EndDateRP.ToString("d")));



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
                    Interaction.MsgBox("Unable to get Most sizes chosen");
                    strMostCommonSizeWDP = "Unavailable";
                }


                // Get data base values



                // Message formatting
                strOrderReport = StartDateRp.ToString("d") + Constants.vbNewLine + EndDateRP.ToString("d") + Constants.vbNewLine + dblTotalAmountWDP.ToString("N2") + Constants.vbNewLine + strMostCommonSizeWDP + Constants.vbNewLine + strMostRequestedFlavorWDP + Constants.vbNewLine + strLeastRequestedFlavorWDP;

                Interaction.MsgBox(strOrderReport);
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("Not Enough Data inputed to create report!" + Constants.vbNewLine + "or" + Constants.vbNewLine + "Check input date as only data between the dates will be Reported.");
            }

            // testing area


            // hide the date selection and its correspoding objects
            lblStartDate.Visible = false;
            lblEndDate.Visible = false;
            DTPStart.Visible = false;
            DTPEnd.Visible = false;
            btnGetOrderReport.Visible = false;
        }

        // Location Management Report
        private void btnLocationMgRp_Click(object sender, EventArgs e)
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
                string strMostRequestedFlavor = StrSodaNames[0];
                int dblLeastRequestedFlavorID = 0;
                int dblLeastRequestedFlavorCount = 0;
                string strLeastRequestedFlavor = StrSodaNames[0];

                int dblMostRequestedFlavorCountPlusOne = 0;
                int dblLestRequestedFlavorCountPlusOne = 0;
                // Assing variable data from select sql statements
                dblTotalRevenueFromMachine = (double)OrdersTableAdapter.SelectTotalRevenueCollected();
                dblTotalNumberOfOrders = (int)OrdersTableAdapter.SelectCountNumberOfOrders();
                dblAverageOrderSize = (double)OrderFluidInfoTableAdapter.SelectAverageOrderSize(10);
                dblAverageRevenue = dblTotalRevenueFromMachine / dblTotalNumberOfOrders;

                // strMostRequestedFlavor = StrSodaNames(Me.OrderFluidInfoTableAdapter.SelectMaxFluidUsed()).ToString()

                dblMostRequestedFlavorCount = Conversions.ToInteger(OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(0));

                for (int RequestedCounter = 1; RequestedCounter <= 9; RequestedCounter++)
                {

                    // Get Most requested Flavor 
                    dblMostRequestedFlavorCountPlusOne = Conversions.ToInteger(OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(RequestedCounter));

                    if (dblMostRequestedFlavorCount < dblMostRequestedFlavorCountPlusOne)
                    {

                        dblMostRequestedFlavorID = RequestedCounter;

                        strMostRequestedFlavor = StrSodaNames[dblMostRequestedFlavorID];

                        dblMostRequestedFlavorCount = Conversions.ToInteger(OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(RequestedCounter));
                    }

                    else if (dblMostRequestedFlavorCount == dblMostRequestedFlavorCountPlusOne)
                    {


                        strMostRequestedFlavor = strMostRequestedFlavor + ", " + StrSodaNames[RequestedCounter];


                    }

                }

                dblLeastRequestedFlavorCount = Conversions.ToInteger(OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(0));
                strLeastRequestedFlavor = StrSodaNames[0];

                for (int LeastCounter = 1; LeastCounter <= 9; LeastCounter++)
                {
                    // Get Least Requested flavor
                    dblLestRequestedFlavorCountPlusOne = Conversions.ToInteger(OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(LeastCounter));

                    if (dblLeastRequestedFlavorCount > dblLestRequestedFlavorCountPlusOne)
                    {

                        dblLeastRequestedFlavorID = LeastCounter;

                        strLeastRequestedFlavor = StrSodaNames[dblLeastRequestedFlavorID];

                        dblLeastRequestedFlavorCount = Conversions.ToInteger(OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(LeastCounter));
                    }

                    else if (dblLeastRequestedFlavorCount == dblLestRequestedFlavorCountPlusOne)
                    {


                        strLeastRequestedFlavor = strLeastRequestedFlavor + ", " + StrSodaNames[LeastCounter];


                    }
                }


                // strLeastRequestedFlavor = Me.OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(0).ToString()
                // MsgBox(strLeastRequestedFlavor)
                strLocationMgRp = "TotalRevenue: $" + dblTotalRevenueFromMachine.ToString("N2") + Constants.vbNewLine + Constants.vbNewLine + "TotalNumber of Orders: " + dblTotalNumberOfOrders + Constants.vbNewLine + Constants.vbNewLine + "AverageOrderSize: " + dblAverageOrderSize.ToString("N2") + "oz" + Constants.vbNewLine + Constants.vbNewLine + "AverageRevenue: $" + dblAverageRevenue.ToString() + Constants.vbNewLine + Constants.vbNewLine + "Most Requested Flavor:" + Constants.vbNewLine + strMostRequestedFlavor + Constants.vbNewLine + Constants.vbNewLine + "Least Requested Flavor:" + Constants.vbNewLine + strLeastRequestedFlavor;

                Interaction.MsgBox(strLocationMgRp);
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("Data for retrival not available" + Constants.vbNewLine + "An order needs to be made first.");
            }


        }

        private void btnMixDisp_Click(object sender, EventArgs e)
        {
            // Check if you have at least one flavor selected
            if (MixCount == 0)
            {
                Interaction.MsgBox("You Need to pick at least 1 Flavor");
            }

            else
            {
                // If you do have a flavorr or more selected
                // Show the ui for cup sizes
                showgrpSize();
                // Hide the main ui
                hidebtnMain();
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FreeStyleDBDataSet.Orders' table. You can move, or remove it, as needed.
            OrdersTableAdapter.Fill(FreeStyleDBDataSet.Orders);
            // TODO: This line of code loads data into the 'FreeStyleDBDataSet.OrderFluidInfo' table. You can move, or remove it, as needed.
            OrderFluidInfoTableAdapter.Fill(FreeStyleDBDataSet.OrderFluidInfo);
            // TODO: This line of code loads data into the 'FreeStyleDBDataSet.Inventory' table. You can move, or remove it, as needed.
            InventoryTableAdapter.Fill(FreeStyleDBDataSet.Inventory);
            // Hide the ui for cup sizes when the application loads
            hidegrpSize();
            // Hides the selection background
            HideSyrupSelection();
            // Hide re-order inventory popup
            cklbInventory.Visible = false;
            btnOrderInventoryAfterSelection.Visible = false;
            // Udate current Fluid from data base
            for (int SyrupUpdate = 0; SyrupUpdate <= 9; SyrupUpdate++)
                dblSyrupBoxs[SyrupUpdate] = (double)InventoryTableAdapter.SelectCurrentAmount(SyrupUpdate);

            FillByOrdersToolStrip.Visible = false;
            InventoryBindingNavigator.Visible = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Hide cup size ui and show main ui
            hidegrpSize();
            showbtnMain();

        }
        // Button just resets selected flavors
        private void btnResetFlavors_Click(object sender, EventArgs e)
        {
            // Resets the count of flavors selected
            MixCount = 0;
            // Show the number of picked flavors
            ShowNumPickFlavors();
            // Resets the flavors that where picked
            ResetSetFlavors();
            HideSyrupSelection();


        }

        private void rdEightOz_Click(object sender, EventArgs e)
        {

            // Set the amount of soda to dispense
            OzPicked = 8d;
            // Make the calculation to dispense the right amount of syrup and co2
            CalcSyrupUsed();
            // Display the amount of syrup and co2 was dispense
            DisplayStats();
            // Subtract Syrup and Co2 Used
            SubtractLiquidUsed();
            // Check for low fluids
            ResourcesLowCheck();

            if (FlavorOneAvailable == true & FlavorTwoAvailable == true & FlavorThreeAvailable == true)
            {
                try
                {
                    // If you want don't want the data base to reset every time you start the application
                    // Right click on FreeStyleDB.mdf in the solution explorer, go to properties and change the output directory property to "Copy if Newer"

                    // Order Table---------------------------------------------------------------------------
                    // Set current date
                    TodaysDate = DateTime.Today;
                    // Update DataBase with order 
                    OrdersTableAdapter.InsertOrder(dblDrinkCost[0], Conversions.ToString(TodaysDate));
                    // Retrive data from data base and store it in data set object
                    OrdersTableAdapter.Fill(FreeStyleDBDataSet.Orders);
                    // ---------------------------------------------------------------------------------------

                    // Order Info table
                    InsertOrderinfo();

                    // Update Inventorys Current amount
                    InventoryTableAdapter.UpdateInventoryFluidLvl(dblSyrupBoxs[FirstFlavorID], FirstFlavorID, FirstFlavorID);
                    InventoryTableAdapter.UpdateInventoryFluidLvl(dblSyrupBoxs[SecondFlavorID], SecondFlavorID, SecondFlavorID);
                    InventoryTableAdapter.UpdateInventoryFluidLvl(dblSyrupBoxs[ThirdFlavorID], ThirdFlavorID, ThirdFlavorID);
                    // Retrive data from data base and store it in data set object
                    InventoryTableAdapter.Fill(FreeStyleDBDataSet.Inventory);
                }

                // The next pieces of code write to the database
                // Validates the data
                // Me.Validate()

                // Applies any pending edits
                // Me.OrdersBindingSource.EndEdit()

                // Updates the Data base
                // Me.TableAdapterManager.UpdateAll(Me.FreeStyleDBDataSet)

                catch (Exception ex)
                {
                    Interaction.MsgBox("Couln't upload data");
                }

            }

            // Deselect Option
            rdEightOz.Checked = false;
            // Resets the count of flavors selected
            MixCount = 0;
            // Show the number of picked flavors
            ShowNumPickFlavors();
            // Resets the flavors that where picked
            ResetSetFlavors();
            HideSyrupSelection();
            // Hide cup size ui and show main ui
            hidegrpSize();
            showbtnMain();

            // Update DataBase with order 

        }

        private void rdSixTeenOz_Click(object sender, EventArgs e)
        {
            // Set the amount of soda to dispense
            OzPicked = 16d;
            // Make the calculation to dispense the right amount of syrup and co2
            CalcSyrupUsed();
            // Display the amount of syrup and co2 was dispense
            DisplayStats();
            // Subtract Syrup and Co2 Used
            SubtractLiquidUsed();
            // Check for low fluids
            ResourcesLowCheck();
            if (FlavorOneAvailable == true & FlavorTwoAvailable == true & FlavorThreeAvailable == true)
            {
                try
                {

                    // Set current date
                    TodaysDate = DateTime.Today;
                    // Update DataBase with order 
                    OrdersTableAdapter.InsertOrder(dblDrinkCost[1], Conversions.ToString(TodaysDate));
                    // Retrive data from data base and store it in data set object
                    OrdersTableAdapter.Fill(FreeStyleDBDataSet.Orders);

                    // Order Info table
                    InsertOrderinfo();

                    // Update Inventorys Current amount
                    InventoryTableAdapter.UpdateInventoryFluidLvl(dblSyrupBoxs[FirstFlavorID], FirstFlavorID, FirstFlavorID);
                    InventoryTableAdapter.UpdateInventoryFluidLvl(dblSyrupBoxs[SecondFlavorID], SecondFlavorID, SecondFlavorID);
                    InventoryTableAdapter.UpdateInventoryFluidLvl(dblSyrupBoxs[ThirdFlavorID], ThirdFlavorID, ThirdFlavorID);
                    // Retrive data from data base and store it in data set object
                    InventoryTableAdapter.Fill(FreeStyleDBDataSet.Inventory);
                }

                // The next pieces of code write to the database
                // Validates the data
                // Me.Validate()

                // Applies any pending edits
                // Me.OrdersBindingSource.EndEdit()

                // Updates the Data base
                // Me.TableAdapterManager.UpdateAll(Me.FreeStyleDBDataSet)

                catch (Exception ex)
                {
                    Interaction.MsgBox("Couln't upload data");
                }

            }


            // Reset to Main Manu
            // Deselect Option
            rdSixTeenOz.Checked = false;
            // Resets the count of flavors selected
            MixCount = 0;
            // Show the number of picked flavors
            ShowNumPickFlavors();
            // Resets the flavors that where picked
            ResetSetFlavors();
            HideSyrupSelection();
            // Hide cup size ui and show main ui
            hidegrpSize();
            showbtnMain();

        }

        private void rdTwentyFourOz_Click(object sender, EventArgs e)
        {
            // Set the amount of soda to dispense
            OzPicked = 24d;
            // Make the calculation to dispense the right amount of syrup and co2
            CalcSyrupUsed();
            // Display the amount of syrup and co2 was dispense
            DisplayStats();
            // Subtract Syrup and Co2 Used
            SubtractLiquidUsed();
            // Check for low fluids
            ResourcesLowCheck();
            if (FlavorOneAvailable == true & FlavorTwoAvailable == true & FlavorThreeAvailable == true)
            {
                try
                {

                    // Set current date
                    TodaysDate = DateTime.Today;
                    // Update DataBase with order 
                    OrdersTableAdapter.InsertOrder(dblDrinkCost[2], Conversions.ToString(TodaysDate));
                    // Retrive data from data base and store it in data set object
                    OrdersTableAdapter.Fill(FreeStyleDBDataSet.Orders);

                    // Order Info table
                    InsertOrderinfo();

                    // Update Inventorys Current amount
                    InventoryTableAdapter.UpdateInventoryFluidLvl(dblSyrupBoxs[FirstFlavorID], FirstFlavorID, FirstFlavorID);
                    InventoryTableAdapter.UpdateInventoryFluidLvl(dblSyrupBoxs[SecondFlavorID], SecondFlavorID, SecondFlavorID);
                    InventoryTableAdapter.UpdateInventoryFluidLvl(dblSyrupBoxs[ThirdFlavorID], ThirdFlavorID, ThirdFlavorID);
                    // Retrive data from data base and store it in data set object
                    InventoryTableAdapter.Fill(FreeStyleDBDataSet.Inventory);
                }

                // The next pieces of code write to the database
                // Validates the data
                // Me.Validate()

                // Applies any pending edits
                // Me.OrdersBindingSource.EndEdit()

                // Updates the Data base
                // Me.TableAdapterManager.UpdateAll(Me.FreeStyleDBDataSet)

                catch (Exception ex)
                {
                    Interaction.MsgBox("Couln't upload data");
                }
            }


            // Deselect Option
            rdTwentyFourOz.Checked = false;
            // Resets the count of flavors selected
            MixCount = 0;
            // Show the number of picked flavors
            ShowNumPickFlavors();
            // Resets the flavors that where picked
            ResetSetFlavors();
            HideSyrupSelection();
            // Hide cup size ui and show main ui
            hidegrpSize();
            showbtnMain();

            // Update DataBase with order 
        }

        private void rdThirtyTwoOz_Click(object sender, EventArgs e)
        {
            // Set the amount of soda to dispense
            OzPicked = 32d;
            // Make the calculation to dispense the right amount of syrup and co2
            CalcSyrupUsed();
            // Display the amount of syrup and co2 was dispense
            DisplayStats();
            // Subtract Syrup and Co2 Used
            SubtractLiquidUsed();
            // Check for low fluids
            ResourcesLowCheck();
            if (FlavorOneAvailable == true & FlavorTwoAvailable == true & FlavorThreeAvailable == true)
            {
                try
                {

                    // Set current date
                    TodaysDate = DateTime.Today;
                    // Update DataBase with order 
                    OrdersTableAdapter.InsertOrder(dblDrinkCost[3], Conversions.ToString(TodaysDate));
                    // Retrive data from data base and store it in data set object
                    OrdersTableAdapter.Fill(FreeStyleDBDataSet.Orders);

                    // Order Info table
                    InsertOrderinfo();

                    // Update Inventorys Current amount
                    InventoryTableAdapter.UpdateInventoryFluidLvl(dblSyrupBoxs[FirstFlavorID], FirstFlavorID, FirstFlavorID);
                    InventoryTableAdapter.UpdateInventoryFluidLvl(dblSyrupBoxs[SecondFlavorID], SecondFlavorID, SecondFlavorID);
                    InventoryTableAdapter.UpdateInventoryFluidLvl(dblSyrupBoxs[ThirdFlavorID], ThirdFlavorID, ThirdFlavorID);
                    InventoryTableAdapter.UpdateInventoryFluidLvl(dblCo2Box, 10, 10);
                    // Retrive data from data base and store it in data set object
                    InventoryTableAdapter.Fill(FreeStyleDBDataSet.Inventory);
                }

                // The next pieces of code write to the database
                // Validates the data
                // Me.Validate()

                // Applies any pending edits
                // Me.OrdersBindingSource.EndEdit()

                // Updates the Data base
                // Me.TableAdapterManager.UpdateAll(Me.FreeStyleDBDataSet)

                catch (Exception ex)
                {
                    Interaction.MsgBox("Couln't upload data");
                }

            }

            // Deselect Option
            rdThirtyTwoOz.Checked = false;
            // Resets the count of flavors selected
            MixCount = 0;
            // Show the number of picked flavors
            ShowNumPickFlavors();
            // Resets the flavors that where picked
            ResetSetFlavors();
            HideSyrupSelection();
            // Hide cup size ui and show main ui
            hidegrpSize();
            showbtnMain();

        }

        // private sub to show the group box for cup sizes
        private void showgrpSize()
        {

            grpSize.Visible = true;

        }
        // private sub to hide the group box for cup sizes
        private void hidegrpSize()
        {

            grpSize.Visible = false;

        }
        // private sub that hides the main ui buttons
        private void hidebtnMain()
        {

            btnMixDisp.Visible = false;
            btnReOrder.Visible = false;
            btnInventoryRp.Visible = false;
            btnOrderRp.Visible = false;
            btnResetFlavors.Visible = false;
            lblFlavorCount.Visible = false;

        }
        // private sd that shows the main ui buttons
        private void showbtnMain()
        {

            btnMixDisp.Visible = true;
            btnReOrder.Visible = true;
            btnInventoryRp.Visible = true;
            btnOrderRp.Visible = true;
            btnResetFlavors.Visible = true;
            lblFlavorCount.Visible = true;

        }
        // private sub that counts the amount of flavors picked
        private void MixCountCheck()
        {
            if (MixCount == 0)
            {
                MixCount = 1;
            }

            else if (MixCount < 3)
            {
                MixCount += 1;
            }

            // if more than 3 flavors are picked you are alerted
            else
            {
                MixCount = 3;
                Interaction.MsgBox("Oops! You can only mix 3 flavors");

            }

        }
        // private sub that uses the unique flavor number to set the name of the flavor to show stats
        private void SetFlavors()
        {
            // Check the flavor selected in what order to assing the name of drink
            switch (MixCount)
            {
                case 1:
                    FirstFlavorID = IndexFlavor - 1;
                    switch (IndexFlavor)
                    {
                        case 1:
                            FirstFlavor = "Coca-Cola";
                            break;
                        case 2:
                            FirstFlavor = "Coca-cola Diet";
                            break;
                        case 3:
                            FirstFlavor = "Coca-cola Zero";
                            break;
                        case 4:
                            FirstFlavor = "Fanta";
                            break;
                        case 5:
                            FirstFlavor = "DrPepper";
                            break;
                        case 6:
                            FirstFlavor = "Sprite";
                            break;
                        case 7:
                            FirstFlavor = "SpriteZero";
                            break;
                        case 8:
                            FirstFlavor = "Minute Maid Lemonade";
                            break;
                        case 9:
                            FirstFlavor = "Minute Maid Lemonade Zero";
                            break;
                        case 10:
                            FirstFlavor = "Root Bear";
                            break;
                    }
                    break;

                case 2:
                    SecondFlavorID = IndexFlavor - 1;
                    switch (IndexFlavor)
                    {
                        case 1:
                            SecondFlavor = "Coca-Cola";
                            break;
                        case 2:
                            SecondFlavor = "Coca-cola Diet";
                            break;
                        case 3:
                            SecondFlavor = "Coca-cola Zero";
                            break;
                        case 4:
                            SecondFlavor = "Fanta";
                            break;
                        case 5:
                            SecondFlavor = "DrPepper";
                            break;
                        case 6:
                            SecondFlavor = "Sprite";
                            break;
                        case 7:
                            SecondFlavor = "SpriteZero";
                            break;
                        case 8:
                            SecondFlavor = "Minute Maid Lemonade";
                            break;
                        case 9:
                            SecondFlavor = "Minute Maid Lemonade Zero";
                            break;
                        case 10:
                            SecondFlavor = "Root Bear";
                            break;
                    }
                    break;

                case 3:
                    ThirdFlavorID = IndexFlavor - 1;
                    switch (IndexFlavor)
                    {
                        case 1:
                            ThirdFlavor = "Coca-Cola";
                            break;
                        case 2:
                            ThirdFlavor = "Coca-cola Diet";
                            break;
                        case 3:
                            ThirdFlavor = "Coca-cola Zero";
                            break;
                        case 4:
                            ThirdFlavor = "Fanta";
                            break;
                        case 5:
                            ThirdFlavor = "DrPepper";
                            break;
                        case 6:
                            ThirdFlavor = "Sprite";
                            break;
                        case 7:
                            ThirdFlavor = "SpriteZero";
                            break;
                        case 8:
                            ThirdFlavor = "Minute Maid Lemonade";
                            break;
                        case 9:
                            ThirdFlavor = "Minute Maid Lemonade Zero";
                            break;
                        case 10:
                            ThirdFlavor = "Root Bear";
                            break;
                    }
                    break;
            }


        }
        // Display that stats for the different size of cups selected
        // Ask to dispence by pressing OK
        private void DisplayStats()
        {
            // if their is only one flavor, display the amount 
            if (MixCount == 1)
            {
                Interaction.MsgBox("You Selected:" + Constants.vbNewLine + FirstFlavor + " Syrup:  " + OzOfFlavor.ToString("N2") + "oz" + Constants.vbNewLine + "Co2 Used:  " + OzOfCo2.ToString("N2") + "oz" + Constants.vbNewLine + Constants.vbNewLine + "Press Ok to dispense:", MsgBoxStyle.OkCancel);

            }

            // if their 2 flavors, display the amount 
            else if (MixCount == 2)
            {
                Interaction.MsgBox("You Selected:" + Constants.vbNewLine + FirstFlavor + " Syrup:  " + OzOfFlavor.ToString("N2") + "oz" + Constants.vbNewLine + SecondFlavor + " Syrup:  " + OzOfFlavor.ToString("N2") + "oz" + Constants.vbNewLine + "Co2 Used:  " + OzOfCo2.ToString("N2") + "oz" + Constants.vbNewLine + Constants.vbNewLine + "Press Ok to dispense:", MsgBoxStyle.OkCancel);

            }

            // if their is 3 flavors, display the amount 
            else if (MixCount == 3)
            {
                Interaction.MsgBox("You Selected:" + Constants.vbNewLine + FirstFlavor + " Syrup:  " + OzOfFlavor.ToString("N2") + "oz" + Constants.vbNewLine + SecondFlavor + " Syrup:  " + OzOfFlavor.ToString("N2") + "oz" + Constants.vbNewLine + ThirdFlavor + " Syrup:  " + OzOfFlavor.ToString("N2") + "oz" + Constants.vbNewLine + "Co2 Used:  " + OzOfCo2.ToString("N2") + "oz" + Constants.vbNewLine + Constants.vbNewLine + "Press Ok to dispense:", MsgBoxStyle.OkCancel);


            }

        }

        // private sub tha calculates the amount of syrup and co2 needed
        private void CalcSyrupUsed()
        {
            OzOfFlavor = OzPicked / 2d / MixCount;

            OzOfCo2 = OzPicked / 2d;

        }

        // private sub to show the amount of flavors picked
        private void ShowNumPickFlavors()
        {
            lblFlavorCount.Text = "Flavors Picked: " + MixCount;
        }

        // private sub that resets the name of flavors picked
        private void ResetSetFlavors()
        {
            FirstFlavor = "N/A";
            SecondFlavor = "N/A";
            ThirdFlavor = "N/A";
            FirstFlavorID = 0;
            SecondFlavorID = 0;
            ThirdFlavorID = 0;
            FlavorOneAvailable = true;
            FlavorTwoAvailable = true;
            FlavorThreeAvailable = true;


        }

        // private sub to close application
        private void Button1_Click(object sender, EventArgs e)
        {
            Close();

        }
        // substract the amount of liquid use from eaither the syrupbox or the co2 box
        private void SubtractLiquidUsed()
        {


            if (dblSyrupBoxs[FirstFlavorID] - OzOfFlavor <= 0d)
            {

                FlavorOneAvailable = false;

            }

            if (dblSyrupBoxs[SecondFlavorID] - OzOfFlavor <= 0d)
            {

                FlavorTwoAvailable = false;

            }

            if (dblSyrupBoxs[ThirdFlavorID] - OzOfFlavor <= 0d)
            {

                FlavorThreeAvailable = false;

            }

            if (FlavorOneAvailable == false & FlavorTwoAvailable == false & FlavorThreeAvailable == false)
            {

                Interaction.MsgBox("Sorry! We Don't Have:" + Constants.vbNewLine + StrSodaNames[FirstFlavorID] + Constants.vbNewLine + StrSodaNames[SecondFlavorID] + Constants.vbNewLine + StrSodaNames[ThirdFlavorID] + Constants.vbNewLine + "Please Try Another.");
            }

            else if (FlavorOneAvailable == false & FlavorTwoAvailable == false)
            {

                Interaction.MsgBox("Sorry! We Don't Have:" + Constants.vbNewLine + StrSodaNames[FirstFlavorID] + Constants.vbNewLine + StrSodaNames[SecondFlavorID] + Constants.vbNewLine + "Please Try Another.");
            }

            else if (FlavorTwoAvailable == false & FlavorThreeAvailable == false)
            {

                Interaction.MsgBox("Sorry! We Don't Have:" + Constants.vbNewLine + StrSodaNames[SecondFlavorID] + Constants.vbNewLine + StrSodaNames[ThirdFlavorID] + Constants.vbNewLine + "Please Try Another.");
            }

            else if (FlavorOneAvailable == false & FlavorThreeAvailable == false)
            {

                Interaction.MsgBox("Sorry! We Don't Have:" + Constants.vbNewLine + StrSodaNames[FirstFlavorID] + Constants.vbNewLine + StrSodaNames[ThirdFlavorID] + Constants.vbNewLine + "Please Try Another.");
            }

            else if (FlavorOneAvailable == false)
            {
                Interaction.MsgBox("Sorry! We Don't Have:" + Constants.vbNewLine + StrSodaNames[FirstFlavorID] + Constants.vbNewLine + "Please Try Another.");
            }

            else if (FlavorTwoAvailable == false)
            {
                Interaction.MsgBox("Sorry! We Don't Have:" + Constants.vbNewLine + StrSodaNames[SecondFlavorID] + Constants.vbNewLine + "Please Try Another.");
            }

            else if (FlavorThreeAvailable == false)
            {
                Interaction.MsgBox("Sorry! We Don't Have:" + Constants.vbNewLine + StrSodaNames[ThirdFlavorID] + Constants.vbNewLine + "Please Try Another.");
            }

            else
            {

                if (MixCount == 1)
                {
                    dblSyrupBoxs[FirstFlavorID] -= OzOfFlavor;
                }

                else if (MixCount == 2)
                {
                    dblSyrupBoxs[FirstFlavorID] -= OzOfFlavor;
                    dblSyrupBoxs[SecondFlavorID] -= OzOfFlavor;
                }

                else if (MixCount == 3)
                {
                    dblSyrupBoxs[FirstFlavorID] -= OzOfFlavor;
                    dblSyrupBoxs[SecondFlavorID] -= OzOfFlavor;
                    dblSyrupBoxs[ThirdFlavorID] -= OzOfFlavor;
                }

                dblCo2Box -= OzOfCo2;
            }

        }

        // Checks if any of our Fluids are running low
        private void ResourcesLowCheck()
        {
            int intCounter = 0;
            string strMessage = "";

            while (intCounter < 10)
            {
                if (dblSyrupBoxs[intCounter] <= 12d)
                {
                    strMessage = strMessage + Constants.vbNewLine + StrSodaNames[intCounter] + " :" + dblSyrupBoxs[intCounter].ToString("N2") + " oz left";

                }

                intCounter += 1;

            }

            if (dblCo2Box < 54d)
            {
                strMessage = strMessage + Constants.vbNewLine + "Co2 :" + dblCo2Box.ToString("N2") + " oz left";
            }

            if (!string.IsNullOrEmpty(strMessage))
            {
                Interaction.MsgBox("The following liquids Are running Low:" + Constants.vbNewLine + strMessage);

            }

        }

        // Hides the lbls used to show selections
        private void HideSyrupSelection()
        {
            lblCola.Visible = false;
            lblDietCola.Visible = false;
            lblZeroCola.Visible = false;
            lblFanta.Visible = false;
            lblDrPepper.Visible = false;
            lblSprite.Visible = false;
            lblSpriteZero.Visible = false;
            lblMntMaid.Visible = false;
            lblMntMaidZero.Visible = false;
            lblRootBeer.Visible = false;

        }

        private void InsertOrderinfo()
        {
            // Get last order ID number from the orders table and add one
            int intLastOrderNum = 0;
            intLastOrderNum = Conversions.ToInteger(OrdersTableAdapter.GetMaxOrderID());
            // Inserts order info 
            if (MixCount == 1)
            {
                OrderFluidInfoTableAdapter.InsertOrderInfo(intLastOrderNum, FirstFlavorID, "no", OzOfFlavor);
                OrderFluidInfoTableAdapter.InsertOrderInfo(intLastOrderNum, 10, "no", OzOfCo2);
            }
            else if (MixCount == 2)
            {
                OrderFluidInfoTableAdapter.InsertOrderInfo(intLastOrderNum, FirstFlavorID, "yes", OzOfFlavor);
                OrderFluidInfoTableAdapter.InsertOrderInfo(intLastOrderNum, SecondFlavorID, "yes", OzOfFlavor);
                OrderFluidInfoTableAdapter.InsertOrderInfo(intLastOrderNum, 10, "yes", OzOfCo2);
            }
            else if (MixCount == 3)
            {
                OrderFluidInfoTableAdapter.InsertOrderInfo(intLastOrderNum, FirstFlavorID, "yes", OzOfFlavor);
                OrderFluidInfoTableAdapter.InsertOrderInfo(intLastOrderNum, SecondFlavorID, "yes", OzOfFlavor);
                OrderFluidInfoTableAdapter.InsertOrderInfo(intLastOrderNum, ThirdFlavorID, "yes", OzOfFlavor);
                OrderFluidInfoTableAdapter.InsertOrderInfo(intLastOrderNum, 10, "yes", OzOfCo2);
            }

            // Retrive data from data base and store it in data set object
            OrderFluidInfoTableAdapter.Fill(FreeStyleDBDataSet.OrderFluidInfo);
        }

        private void InventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            InventoryBindingSource.EndEdit();
            TableAdapterManager.UpdateAll(FreeStyleDBDataSet);

        }

        private void FillByOrdersToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                OrdersTableAdapter.FillByOrders(FreeStyleDBDataSet.Orders, StartDateToolStripTextBox.Text, EndDateToolStripTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FillByOrdersToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                OrdersTableAdapter.FillByOrders(FreeStyleDBDataSet.Orders, StartDateToolStripTextBox.Text, EndDateToolStripTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}