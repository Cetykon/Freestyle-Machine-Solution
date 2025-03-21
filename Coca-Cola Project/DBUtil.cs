using Coca_Cola_Project.FreeStyleDBDataSetTableAdapters;
using System;

namespace Coca_Cola_Project
{
    internal class DBUtil
    {
        FreeStyleDBDataSetTableAdapters.OrderFluidInfoTableAdapter OrderFluidInfoTableAdapter = new FreeStyleDBDataSetTableAdapters.OrderFluidInfoTableAdapter();
        FreeStyleDBDataSetTableAdapters.InventoryTableAdapter InventoryTableAdapter = new FreeStyleDBDataSetTableAdapters.InventoryTableAdapter();
        FreeStyleDBDataSetTableAdapters.OrdersTableAdapter OrdersTableAdapter = new FreeStyleDBDataSetTableAdapters.OrdersTableAdapter();
        FreeStyleDBDataSet FreeStyleDBDataSet = new FreeStyleDBDataSet();
        public void UpdateInventory(Flavors flavors, FlavorSelectionLogic flavorSelectionLogic)
        {
            // Update Inventorys Current amount
            InventoryTableAdapter.UpdateInventoryFluidLvl(flavors.dblSyrupBoxs[flavorSelectionLogic.FirstFlavorID], flavorSelectionLogic.FirstFlavorID, flavorSelectionLogic.FirstFlavorID);
            InventoryTableAdapter.UpdateInventoryFluidLvl(flavors.dblSyrupBoxs[flavorSelectionLogic.SecondFlavorID], flavorSelectionLogic.SecondFlavorID, flavorSelectionLogic.SecondFlavorID);
            InventoryTableAdapter.UpdateInventoryFluidLvl(flavors.dblSyrupBoxs[flavorSelectionLogic.ThirdFlavorID], flavorSelectionLogic.ThirdFlavorID, flavorSelectionLogic.ThirdFlavorID);
        }

        public void InsertOrderInfo(FlavorSelectionLogic flavorSelectionLogic, OzToDispense ozToDispense)
        {
            // Get last order ID number from the orders table and add one
            int intLastOrderNum = 0;
            intLastOrderNum = Convert.ToInt32(OrdersTableAdapter.GetMaxOrderID());
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
    }
}
