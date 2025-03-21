using Microsoft.VisualBasic;

namespace Coca_Cola_Project
{
    internal class FluidLevelReport
    {
        public string GetReport(Flavors flavors)
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

            return "Syrup and Co2 Stats:" + Constants.vbNewLine + Constants.vbNewLine + strSyrupSt + Constants.vbNewLine + "Fluids at low threshold:" + Constants.vbNewLine + Constants.vbNewLine + strLowlvlFluids + Constants.vbNewLine;

        }
    }
}
