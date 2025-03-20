namespace Coca_Cola_Project
{
    internal class DBUtil
    {
        FreeStyleDBDataSetTableAdapters.InventoryTableAdapter InventoryTableAdapter = new FreeStyleDBDataSetTableAdapters.InventoryTableAdapter();
        public void UpdateInventory(Flavors flavors, FlavorSelectionLogic flavorSelectionLogic)
        {
            // Update Inventorys Current amount
            InventoryTableAdapter.UpdateInventoryFluidLvl(flavors.dblSyrupBoxs[flavorSelectionLogic.FirstFlavorID], flavorSelectionLogic.FirstFlavorID, flavorSelectionLogic.FirstFlavorID);
            InventoryTableAdapter.UpdateInventoryFluidLvl(flavors.dblSyrupBoxs[flavorSelectionLogic.SecondFlavorID], flavorSelectionLogic.SecondFlavorID, flavorSelectionLogic.SecondFlavorID);
            InventoryTableAdapter.UpdateInventoryFluidLvl(flavors.dblSyrupBoxs[flavorSelectionLogic.ThirdFlavorID], flavorSelectionLogic.ThirdFlavorID, flavorSelectionLogic.ThirdFlavorID);
        }
    }
}
