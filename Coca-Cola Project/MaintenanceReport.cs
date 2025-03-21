using Coca_Cola_Project.FreeStyleDBDataSetTableAdapters;
using Microsoft.VisualBasic;
using System;

namespace Coca_Cola_Project
{
    internal class MaintenanceReport
    {
        public String GetReport()
        {
            FreeStyleDBDataSetTableAdapters.InventoryTableAdapter InventoryTableAdapter = new FreeStyleDBDataSetTableAdapters.InventoryTableAdapter();

            string report = "";
            double CurrentAmount;
            double Capacity;
            DateTime ExpirationDate;
            DateTime LastFillDate;


            for (int MaintenanceCount = 0; MaintenanceCount <= 10; MaintenanceCount++)
            {
                CurrentAmount = Convert.ToDouble(InventoryTableAdapter.SelectCurrentAmount(MaintenanceCount));
                Capacity = Convert.ToDouble(InventoryTableAdapter.SelectCapacity(MaintenanceCount));

                ExpirationDate = (DateTime)InventoryTableAdapter.SelectExpirationDate(MaintenanceCount);
                LastFillDate = Convert.ToDateTime(InventoryTableAdapter.SelectLastFillDate(MaintenanceCount).ToString());

                report = report + Capacity.ToString("N2") + "--" + CurrentAmount.ToString("N2") + "--" + ExpirationDate.ToString("MM/dd/yyyy") + "--" + LastFillDate.ToString("MM/dd/yyyy") + Constants.vbNewLine;

            }

            return "Capacity--Current Amount--Expiration Date--Last Fill Date" + Constants.vbNewLine + report;
        }

    }
}
