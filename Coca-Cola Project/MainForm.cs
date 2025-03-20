using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Windows.Forms;

namespace Coca_Cola_Project
{

    /// <summary>
    /// Main class for a Coca-Cola Freestyle machine program.
    /// First version, Written Date: 2021
    /// 
    /// Project used to learn how to program.
    /// If any changes are made, be sure to trace variables,
    /// flavorSelectionLogic.MixCount is tightly coupled.
    /// 
    /// </summary>
    public partial class MainForm
    {
        // Create variables needed
        private int intFlavorSelecCount = 0;

        // Array for cost of drinks
        // 8oz,16oz,24oz,32oz
        private double[] dblDrinkCost = new double[] { 2d, 2.5d, 3d, 3.5d };
        // Get todays date
        private DateTime TodaysDate;


        // Initializing Flavor Selection Logic
        FlavorSelectionLogic flavorSelectionLogic = new FlavorSelectionLogic();
        Flavors flavors = new Flavors();
        OzToDispense ozToDispense = new OzToDispense();

        public MainForm()
        {
            InitializeComponent();
        }

        // Event handlers for each soda button click
        private void picCola_Click(object sender, EventArgs e)
        {
            lblCola.Visible = flavorSelectionLogic.SelectFlavor(0, 1);
            ShowNumPickFlavors();
        }

        private void picColaDiet_Click(object sender, EventArgs e)
        {
            lblDietCola.Visible = flavorSelectionLogic.SelectFlavor(1, 2);
            ShowNumPickFlavors();
        }

        private void picColaZero_Click(object sender, EventArgs e)
        {
            lblZeroCola.Visible = flavorSelectionLogic.SelectFlavor(2, 3);
            ShowNumPickFlavors();
        }

        private void picFanta_Click(object sender, EventArgs e)
        {
            lblFanta.Visible = flavorSelectionLogic.SelectFlavor(3, 4);
            ShowNumPickFlavors();
        }

        private void picDrPepper_Click(object sender, EventArgs e)
        {
            lblDrPepper.Visible = flavorSelectionLogic.SelectFlavor(4, 5);
            ShowNumPickFlavors();
        }

        private void picSprite_Click(object sender, EventArgs e)
        {
            lblSprite.Visible = flavorSelectionLogic.SelectFlavor(5, 6);
            ShowNumPickFlavors();
        }

        private void picSpriteZero_Click(object sender, EventArgs e)
        {
            lblSpriteZero.Visible = flavorSelectionLogic.SelectFlavor(6, 7);
            ShowNumPickFlavors();
        }

        private void picMMLemon_Click(object sender, EventArgs e)
        {
            lblMntMaid.Visible = flavorSelectionLogic.SelectFlavor(7, 8);
            ShowNumPickFlavors();
        }

        private void picMMLemonZero_Click(object sender, EventArgs e)
        {
            lblMntMaidZero.Visible = flavorSelectionLogic.SelectFlavor(8, 9);
            ShowNumPickFlavors();
        }

        private void picRootBeer_Click(object sender, EventArgs e)
        {
            lblRootBeer.Visible = flavorSelectionLogic.SelectFlavor(9, 10);
            ShowNumPickFlavors();
        }

        // private sub to show the amount of flavors picked
        private void ShowNumPickFlavors()
        {
            lblFlavorCount.Text = "Flavors Picked: " + flavorSelectionLogic.MixCount;
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

            for (int intCounter = 0; intCounter <= 9; intCounter++)
            {
                // Add all Flavors and their current amount of liquid to a string
                strSyrupSt = strSyrupSt + flavors.StrSodaNames[intCounter] + ": " + flavors.dblSyrupBoxs[intCounter].ToString("N2") + "oz" + Constants.vbNewLine;

                // Add fluids that are in a low threshold to a string
                if (flavors.dblSyrupBoxs[intCounter] < 12d)
                {
                    strLowlvlFluids = strLowlvlFluids + flavors.StrSodaNames[intCounter] + ": " + flavors.dblSyrupBoxs[intCounter].ToString("N2") + "oz" + Constants.vbNewLine;
                }
                if (flavors.dblCo2Box < 54d)
                {
                    strLowlvlFluids = strLowlvlFluids + Constants.vbNewLine + "Co2: " + flavors.dblCo2Box.ToString("N2");
                }
            }

            if (string.IsNullOrEmpty(strLowlvlFluids))
            {
                strLowlvlFluids = "No Fluid Found!";
            }
            strSyrupSt = strSyrupSt + Constants.vbNewLine + "Co2: " + flavors.dblCo2Box.ToString("N2") + "oz" + Constants.vbNewLine;

            Interaction.MsgBox("Syrup and Co2 Stats:" + Constants.vbNewLine + Constants.vbNewLine + strSyrupSt + Constants.vbNewLine + "Fluids at low threshold:" + Constants.vbNewLine + Constants.vbNewLine + strLowlvlFluids + Constants.vbNewLine);
        }
        private void btnSodaSt_Click(object sender, EventArgs e)
        {
            // if Date selection is already visible hide it. 
            if (lblStartDate.Visible == true & lblEndDate.Visible == true)
            {
                HideDateSelection();
            }
            else
            {
                // if date selection wasn't already visible the make it visible
                DisplayTimeSelection();
            }
        }

        // Maintenance Report
        private void btnMaintenanceRp_Click(object sender, EventArgs e)
        {
            MaintenanceReport maintenanceReport = new MaintenanceReport();
            Interaction.MsgBox(maintenanceReport.GetReport());
        }

        // Order Report
        private void btnGetOrderReport_Click(object sender, EventArgs e)
        {
            // used the selected date to input into the database select statement
            DateTime StartDateRp = DTPStart.Value;
            // Dim strStarDateRp As String = StartDateRp.ToString("yyyy-MM-dd")
            DateTime EndDateRP = DTPEnd.Value;
            // Dim strEndDateRp As String = EndDateRP.ToString("yyyy-MM-dd")

            OrderReport orderReport = new OrderReport();
            Interaction.MsgBox(orderReport.GetReport(StartDateRp, EndDateRP, flavors));

            // hide the date selection and its correspoding objects
            HideDateSelection();
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

                dblMostRequestedFlavorCount = Conversions.ToInteger(OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(0));

                for (int RequestedCounter = 1; RequestedCounter <= 9; RequestedCounter++)
                {

                    // Get Most requested Flavor 
                    dblMostRequestedFlavorCountPlusOne = Conversions.ToInteger(OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(RequestedCounter));

                    if (dblMostRequestedFlavorCount < dblMostRequestedFlavorCountPlusOne)
                    {

                        dblMostRequestedFlavorID = RequestedCounter;

                        strMostRequestedFlavor = flavors.StrSodaNames[dblMostRequestedFlavorID];

                        dblMostRequestedFlavorCount = Conversions.ToInteger(OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(RequestedCounter));
                    }

                    else if (dblMostRequestedFlavorCount == dblMostRequestedFlavorCountPlusOne)
                    {


                        strMostRequestedFlavor = strMostRequestedFlavor + ", " + flavors.StrSodaNames[RequestedCounter];


                    }

                }

                dblLeastRequestedFlavorCount = Conversions.ToInteger(OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(0));
                strLeastRequestedFlavor = flavors.StrSodaNames[0];

                for (int LeastCounter = 1; LeastCounter <= 9; LeastCounter++)
                {
                    // Get Least Requested flavor
                    dblLestRequestedFlavorCountPlusOne = Conversions.ToInteger(OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(LeastCounter));

                    if (dblLeastRequestedFlavorCount > dblLestRequestedFlavorCountPlusOne)
                    {

                        dblLeastRequestedFlavorID = LeastCounter;

                        strLeastRequestedFlavor = flavors.StrSodaNames[dblLeastRequestedFlavorID];

                        dblLeastRequestedFlavorCount = Conversions.ToInteger(OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(LeastCounter));
                    }

                    else if (dblLeastRequestedFlavorCount == dblLestRequestedFlavorCountPlusOne)
                    {


                        strLeastRequestedFlavor = strLeastRequestedFlavor + ", " + flavors.StrSodaNames[LeastCounter];


                    }
                }


                // strLeastRequestedFlavor = Me.OrderFluidInfoTableAdapter.SelectCountOfSpecifyOrder(0).ToString()
                // MsgBox(strLeastRequestedFlavor)
                strLocationMgRp = "TotalRevenue: $" + dblTotalRevenueFromMachine.ToString("N2") + Constants.vbNewLine + Constants.vbNewLine + "TotalNumber of Orders: " + dblTotalNumberOfOrders + Constants.vbNewLine + Constants.vbNewLine + "AverageOrderSize: " + dblAverageOrderSize.ToString("N2") + "oz" + Constants.vbNewLine + Constants.vbNewLine + "AverageRevenue: $" + dblAverageRevenue.ToString() + Constants.vbNewLine + Constants.vbNewLine + "Most Requested Flavor:" + Constants.vbNewLine + strMostRequestedFlavor + Constants.vbNewLine + Constants.vbNewLine + "Least Requested Flavor:" + Constants.vbNewLine + strLeastRequestedFlavor;

                Interaction.MsgBox(strLocationMgRp);
            }

            catch (Exception)
            {
                Interaction.MsgBox("Data for retrival not available" + Constants.vbNewLine + "An order needs to be made first.");
            }
        }

        private void btnMixDisp_Click(object sender, EventArgs e)
        {
            // Check if you have at least one flavor selected
            if (flavorSelectionLogic.MixCount == 0)
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
                flavors.dblSyrupBoxs[SyrupUpdate] = (double)InventoryTableAdapter.SelectCurrentAmount(SyrupUpdate);

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
            flavorSelectionLogic.MixCount = 0;
            // Show the number of picked flavors
            ShowNumPickFlavors();
            // Resets the flavors that where picked
            flavorSelectionLogic.ResetSetFlavors();
            HideSyrupSelection();

        }

        private void rdEightOz_Click(object sender, EventArgs e)
        {

            // Set the amount of soda to dispense
            ozToDispense.OzPicked = 8d;
            // Make the calculation to dispense the right amount of syrup and co2
            ozToDispense.CalcSyrupUsed(flavorSelectionLogic.MixCount);
            // Display the amount of syrup and co2 was dispense
            DisplayStats();
            // Subtract Syrup and Co2 Used
            SubtractLiquidUsed();
            // Check for low fluids
            flavors.ResourcesLowCheck();

            if (flavorSelectionLogic.flavorAvailability[0] == true & flavorSelectionLogic.flavorAvailability[1] == true & flavorSelectionLogic.flavorAvailability[2] == true)
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
                    InventoryTableAdapter.UpdateInventoryFluidLvl(flavors.dblSyrupBoxs[flavorSelectionLogic.FirstFlavorID], flavorSelectionLogic.FirstFlavorID, flavorSelectionLogic.FirstFlavorID);
                    InventoryTableAdapter.UpdateInventoryFluidLvl(flavors.dblSyrupBoxs[flavorSelectionLogic.SecondFlavorID], flavorSelectionLogic.SecondFlavorID, flavorSelectionLogic.SecondFlavorID);
                    InventoryTableAdapter.UpdateInventoryFluidLvl(flavors.dblSyrupBoxs[flavorSelectionLogic.ThirdFlavorID], flavorSelectionLogic.ThirdFlavorID, flavorSelectionLogic.ThirdFlavorID);
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
            flavorSelectionLogic.MixCount = 0;
            // Show the number of picked flavors
            ShowNumPickFlavors();
            // Resets the flavors that where picked
            flavorSelectionLogic.ResetSetFlavors();
            HideSyrupSelection();
            // Hide cup size ui and show main ui
            hidegrpSize();
            showbtnMain();

            // Update DataBase with order 
        }

        private void rdSixTeenOz_Click(object sender, EventArgs e)
        {
            // Set the amount of soda to dispense
            ozToDispense.OzPicked = 16d;
            // Make the calculation to dispense the right amount of syrup and co2
            ozToDispense.CalcSyrupUsed(flavorSelectionLogic.MixCount);
            // Display the amount of syrup and co2 was dispense
            DisplayStats();
            // Subtract Syrup and Co2 Used
            SubtractLiquidUsed();
            // Check for low fluids
            flavors.ResourcesLowCheck();
            if (flavorSelectionLogic.flavorAvailability[0] == true & flavorSelectionLogic.flavorAvailability[1] == true & flavorSelectionLogic.flavorAvailability[2] == true)
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
                    InventoryTableAdapter.UpdateInventoryFluidLvl(flavors.dblSyrupBoxs[flavorSelectionLogic.FirstFlavorID], flavorSelectionLogic.FirstFlavorID, flavorSelectionLogic.FirstFlavorID);
                    InventoryTableAdapter.UpdateInventoryFluidLvl(flavors.dblSyrupBoxs[flavorSelectionLogic.SecondFlavorID], flavorSelectionLogic.SecondFlavorID, flavorSelectionLogic.SecondFlavorID);
                    InventoryTableAdapter.UpdateInventoryFluidLvl(flavors.dblSyrupBoxs[flavorSelectionLogic.ThirdFlavorID], flavorSelectionLogic.ThirdFlavorID, flavorSelectionLogic.ThirdFlavorID);
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
            flavorSelectionLogic.MixCount = 0;
            // Show the number of picked flavors
            ShowNumPickFlavors();
            // Resets the flavors that where picked
            flavorSelectionLogic.ResetSetFlavors();
            HideSyrupSelection();
            // Hide cup size ui and show main ui
            hidegrpSize();
            showbtnMain();

        }

        private void rdTwentyFourOz_Click(object sender, EventArgs e)
        {
            // Set the amount of soda to dispense
            ozToDispense.OzPicked = 24d;
            // Make the calculation to dispense the right amount of syrup and co2
            ozToDispense.CalcSyrupUsed(flavorSelectionLogic.MixCount);
            // Display the amount of syrup and co2 was dispense
            DisplayStats();
            // Subtract Syrup and Co2 Used
            SubtractLiquidUsed();
            // Check for low fluids
            flavors.ResourcesLowCheck();
            if (flavorSelectionLogic.flavorAvailability[0] == true & flavorSelectionLogic.flavorAvailability[1] == true & flavorSelectionLogic.flavorAvailability[2] == true)
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
                    InventoryTableAdapter.UpdateInventoryFluidLvl(flavors.dblSyrupBoxs[flavorSelectionLogic.FirstFlavorID], flavorSelectionLogic.FirstFlavorID, flavorSelectionLogic.FirstFlavorID);
                    InventoryTableAdapter.UpdateInventoryFluidLvl(flavors.dblSyrupBoxs[flavorSelectionLogic.SecondFlavorID], flavorSelectionLogic.SecondFlavorID, flavorSelectionLogic.SecondFlavorID);
                    InventoryTableAdapter.UpdateInventoryFluidLvl(flavors.dblSyrupBoxs[flavorSelectionLogic.ThirdFlavorID], flavorSelectionLogic.ThirdFlavorID, flavorSelectionLogic.ThirdFlavorID);
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
            flavorSelectionLogic.MixCount = 0;
            // Show the number of picked flavors
            ShowNumPickFlavors();
            // Resets the flavors that where picked
            flavorSelectionLogic.ResetSetFlavors();
            HideSyrupSelection();
            // Hide cup size ui and show main ui
            hidegrpSize();
            showbtnMain();

            // Update DataBase with order 
        }

        private void rdThirtyTwoOz_Click(object sender, EventArgs e)
        {
            // Set the amount of soda to dispense
            ozToDispense.OzPicked = 32d;
            // Make the calculation to dispense the right amount of syrup and co2
            ozToDispense.CalcSyrupUsed(flavorSelectionLogic.MixCount);
            // Display the amount of syrup and co2 was dispense
            DisplayStats();
            // Subtract Syrup and Co2 Used
            SubtractLiquidUsed();
            // Check for low fluids
            flavors.ResourcesLowCheck();
            if (flavorSelectionLogic.flavorAvailability[0] == true & flavorSelectionLogic.flavorAvailability[1] == true & flavorSelectionLogic.flavorAvailability[2] == true)
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
                    InventoryTableAdapter.UpdateInventoryFluidLvl(flavors.dblSyrupBoxs[flavorSelectionLogic.FirstFlavorID], flavorSelectionLogic.FirstFlavorID, flavorSelectionLogic.FirstFlavorID);
                    InventoryTableAdapter.UpdateInventoryFluidLvl(flavors.dblSyrupBoxs[flavorSelectionLogic.SecondFlavorID], flavorSelectionLogic.SecondFlavorID, flavorSelectionLogic.SecondFlavorID);
                    InventoryTableAdapter.UpdateInventoryFluidLvl(flavors.dblSyrupBoxs[flavorSelectionLogic.ThirdFlavorID], flavorSelectionLogic.ThirdFlavorID, flavorSelectionLogic.ThirdFlavorID);
                    InventoryTableAdapter.UpdateInventoryFluidLvl(flavors.dblCo2Box, 10, 10);
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
            flavorSelectionLogic.MixCount = 0;
            // Show the number of picked flavors
            ShowNumPickFlavors();
            // Resets the flavors that where picked
            flavorSelectionLogic.ResetSetFlavors();
            HideSyrupSelection();
            // Hide cup size ui and show main ui
            hidegrpSize();
            showbtnMain();
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


        // Display that stats for the different size of cups selected
        // Ask to dispence by pressing OK
        private void DisplayStats()
        {
            // if their is only one flavor, display the amount 
            switch (flavorSelectionLogic.MixCount)
            {
                case 1:
                    Interaction.MsgBox("You Selected:" + Constants.vbNewLine + flavorSelectionLogic.FirstFlavor + " Syrup:  " + ozToDispense.OzOfFlavor.ToString("N2") + "oz" + Constants.vbNewLine + "Co2 Used:  " + ozToDispense.OzOfCo2.ToString("N2") + "oz" + Constants.vbNewLine + Constants.vbNewLine + "Press Ok to dispense:", MsgBoxStyle.OkCancel);
                    break;
                case 2:
                    Interaction.MsgBox("You Selected:" + Constants.vbNewLine + flavorSelectionLogic.FirstFlavor + " Syrup:  " + ozToDispense.OzOfFlavor.ToString("N2") + "oz" + Constants.vbNewLine + flavorSelectionLogic.SecondFlavor + " Syrup:  " + ozToDispense.OzOfFlavor.ToString("N2") + "oz" + Constants.vbNewLine + "Co2 Used:  " + ozToDispense.OzOfCo2.ToString("N2") + "oz" + Constants.vbNewLine + Constants.vbNewLine + "Press Ok to dispense:", MsgBoxStyle.OkCancel);
                    break;
                case 3:
                    Interaction.MsgBox("You Selected:" + Constants.vbNewLine + flavorSelectionLogic.FirstFlavor + " Syrup:  " + ozToDispense.OzOfFlavor.ToString("N2") + "oz" + Constants.vbNewLine + flavorSelectionLogic.SecondFlavor + " Syrup:  " + ozToDispense.OzOfFlavor.ToString("N2") + "oz" + Constants.vbNewLine + flavorSelectionLogic.ThirdFlavor + " Syrup:  " + ozToDispense.OzOfFlavor.ToString("N2") + "oz" + Constants.vbNewLine + "Co2 Used:  " + ozToDispense.OzOfCo2.ToString("N2") + "oz" + Constants.vbNewLine + Constants.vbNewLine + "Press Ok to dispense:", MsgBoxStyle.OkCancel);
                    break;
            }
        }


        // substract the amount of liquid use from eaither the syrupbox or the co2 box
        private void SubtractLiquidUsed()
        {


            if (flavors.dblSyrupBoxs[flavorSelectionLogic.FirstFlavorID] - ozToDispense.OzOfFlavor <= 0d)
            {
                flavorSelectionLogic.flavorAvailability[0] = false;
            }

            if (flavors.dblSyrupBoxs[flavorSelectionLogic.SecondFlavorID] - ozToDispense.OzOfFlavor <= 0d)
            {
                flavorSelectionLogic.flavorAvailability[1] = false;
            }

            if (flavors.dblSyrupBoxs[flavorSelectionLogic.ThirdFlavorID] - ozToDispense.OzOfFlavor <= 0d)
            {
                flavorSelectionLogic.flavorAvailability[2] = false;
            }


            if (flavorSelectionLogic.flavorAvailability[0] == false & flavorSelectionLogic.flavorAvailability[1] == false & flavorSelectionLogic.flavorAvailability[2] == false)
            {
                Interaction.MsgBox("Sorry! We Don't Have:" + Constants.vbNewLine + flavors.StrSodaNames[flavorSelectionLogic.FirstFlavorID] + Constants.vbNewLine + flavors.StrSodaNames[flavorSelectionLogic.SecondFlavorID] + Constants.vbNewLine + flavors.StrSodaNames[flavorSelectionLogic.ThirdFlavorID] + Constants.vbNewLine + "Please Try Another.");
            }

            else if (flavorSelectionLogic.flavorAvailability[0] == false & flavorSelectionLogic.flavorAvailability[1] == false)
            {
                Interaction.MsgBox("Sorry! We Don't Have:" + Constants.vbNewLine + flavors.StrSodaNames[flavorSelectionLogic.FirstFlavorID] + Constants.vbNewLine + flavors.StrSodaNames[flavorSelectionLogic.SecondFlavorID] + Constants.vbNewLine + "Please Try Another.");
            }

            else if (flavorSelectionLogic.flavorAvailability[1] == false & flavorSelectionLogic.flavorAvailability[2] == false)
            {
                Interaction.MsgBox("Sorry! We Don't Have:" + Constants.vbNewLine + flavors.StrSodaNames[flavorSelectionLogic.SecondFlavorID] + Constants.vbNewLine + flavors.StrSodaNames[flavorSelectionLogic.ThirdFlavorID] + Constants.vbNewLine + "Please Try Another.");
            }

            else if (flavorSelectionLogic.flavorAvailability[0] == false & flavorSelectionLogic.flavorAvailability[2] == false)
            {
                Interaction.MsgBox("Sorry! We Don't Have:" + Constants.vbNewLine + flavors.StrSodaNames[flavorSelectionLogic.FirstFlavorID] + Constants.vbNewLine + flavors.StrSodaNames[flavorSelectionLogic.ThirdFlavorID] + Constants.vbNewLine + "Please Try Another.");
            }

            else if (flavorSelectionLogic.flavorAvailability[0] == false)
            {
                Interaction.MsgBox("Sorry! We Don't Have:" + Constants.vbNewLine + flavors.StrSodaNames[flavorSelectionLogic.FirstFlavorID] + Constants.vbNewLine + "Please Try Another.");
            }

            else if (flavorSelectionLogic.flavorAvailability[1] == false)
            {
                Interaction.MsgBox("Sorry! We Don't Have:" + Constants.vbNewLine + flavors.StrSodaNames[flavorSelectionLogic.SecondFlavorID] + Constants.vbNewLine + "Please Try Another.");
            }

            else if (flavorSelectionLogic.flavorAvailability[2] == false)
            {
                Interaction.MsgBox("Sorry! We Don't Have:" + Constants.vbNewLine + flavors.StrSodaNames[flavorSelectionLogic.ThirdFlavorID] + Constants.vbNewLine + "Please Try Another.");
            }

            else
            {

                if (flavorSelectionLogic.MixCount == 1)
                {
                    flavors.dblSyrupBoxs[flavorSelectionLogic.FirstFlavorID] -= ozToDispense.OzOfFlavor;
                }

                else if (flavorSelectionLogic.MixCount == 2)
                {
                    flavors.dblSyrupBoxs[flavorSelectionLogic.FirstFlavorID] -= ozToDispense.OzOfFlavor;
                    flavors.dblSyrupBoxs[flavorSelectionLogic.SecondFlavorID] -= ozToDispense.OzOfFlavor;
                }

                else if (flavorSelectionLogic.MixCount == 3)
                {
                    flavors.dblSyrupBoxs[flavorSelectionLogic.FirstFlavorID] -= ozToDispense.OzOfFlavor;
                    flavors.dblSyrupBoxs[flavorSelectionLogic.SecondFlavorID] -= ozToDispense.OzOfFlavor;
                    flavors.dblSyrupBoxs[flavorSelectionLogic.ThirdFlavorID] -= ozToDispense.OzOfFlavor;
                }

                flavors.dblCo2Box -= ozToDispense.OzOfCo2;
            }
        }

        private void InsertOrderinfo()
        {
            // Get last order ID number from the orders table and add one
            int intLastOrderNum = 0;
            intLastOrderNum = Conversions.ToInteger(OrdersTableAdapter.GetMaxOrderID());
            // Inserts order info 
            if (flavorSelectionLogic.MixCount == 1)
            {
                OrderFluidInfoTableAdapter.InsertOrderInfo(intLastOrderNum, flavorSelectionLogic.FirstFlavorID, "no", ozToDispense.OzOfFlavor);
                OrderFluidInfoTableAdapter.InsertOrderInfo(intLastOrderNum, 10, "no", ozToDispense.OzOfCo2);
            }
            else if (flavorSelectionLogic.MixCount == 2)
            {
                OrderFluidInfoTableAdapter.InsertOrderInfo(intLastOrderNum, flavorSelectionLogic.FirstFlavorID, "yes", ozToDispense.OzOfFlavor);
                OrderFluidInfoTableAdapter.InsertOrderInfo(intLastOrderNum, flavorSelectionLogic.SecondFlavorID, "yes", ozToDispense.OzOfFlavor);
                OrderFluidInfoTableAdapter.InsertOrderInfo(intLastOrderNum, 10, "yes", ozToDispense.OzOfCo2);
            }
            else if (flavorSelectionLogic.MixCount == 3)
            {
                OrderFluidInfoTableAdapter.InsertOrderInfo(intLastOrderNum, flavorSelectionLogic.FirstFlavorID, "yes", ozToDispense.OzOfFlavor);
                OrderFluidInfoTableAdapter.InsertOrderInfo(intLastOrderNum, flavorSelectionLogic.SecondFlavorID, "yes", ozToDispense.OzOfFlavor);
                OrderFluidInfoTableAdapter.InsertOrderInfo(intLastOrderNum, flavorSelectionLogic.ThirdFlavorID, "yes", ozToDispense.OzOfFlavor);
                OrderFluidInfoTableAdapter.InsertOrderInfo(intLastOrderNum, 10, "yes", ozToDispense.OzOfCo2);
            }

            // Retrive data from data base and store it in data set object
            OrderFluidInfoTableAdapter.Fill(FreeStyleDBDataSet.OrderFluidInfo);
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

        private void HideDateSelection()
        {
            lblStartDate.Visible = false;
            lblEndDate.Visible = false;
            DTPStart.Visible = false;
            DTPEnd.Visible = false;
            btnGetOrderReport.Visible = false;
        }

        private void DisplayTimeSelection()
        {
            lblStartDate.Visible = true;
            lblEndDate.Visible = true;
            DTPStart.Visible = true;
            DTPEnd.Visible = true;
            btnGetOrderReport.Visible = true;
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

        // private sub to close application
        private void Button1_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}