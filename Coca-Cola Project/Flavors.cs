using Microsoft.VisualBasic;

namespace Coca_Cola_Project
{
    internal class Flavors
    {
        // Array to keep track of Syrup Used
        public double[] dblSyrupBoxs = new double[] { 34d, 34d, 34d, 34d, 34d, 34d, 34d, 34d, 34d, 34d };
        public string[] StrSodaNames = new string[] { "Coca-Cola", "Coca-Cola Diet", "Coca-Cola Zero", "Fanta",
            "Dr Pepper", "Sprite", "Sprite Zero", "Minute Maid Lemonade", "Minute Maid Lemonade Zero", "Root Beer" };
        // Co2 Container
        public double dblCo2Box = 170d;


        // Checks if any of our Fluids are running low
        public void ResourcesLowCheck()
        {

            string strMessage = "";
            int intCounter = 0;

            while (intCounter < 10)
            {
                if (this.dblSyrupBoxs[intCounter] <= 12d)
                {
                    strMessage = strMessage + Constants.vbNewLine + this.StrSodaNames[intCounter] + " :" + this.dblSyrupBoxs[intCounter].ToString("N2") + " oz left";

                }

                intCounter += 1;

            }

            if (this.dblCo2Box < 54d)
            {
                strMessage = strMessage + Constants.vbNewLine + "Co2 :" + dblCo2Box.ToString("N2") + " oz left";
            }

            if (!string.IsNullOrEmpty(strMessage))
            {
                Interaction.MsgBox("The following liquids Are running Low:" + Constants.vbNewLine + strMessage);

            }
        }

    }
}
