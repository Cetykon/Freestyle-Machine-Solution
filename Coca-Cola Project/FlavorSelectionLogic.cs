﻿using Microsoft.VisualBasic;

namespace Coca_Cola_Project
{

    internal class FlavorSelectionLogic
    {
        public string FirstFlavor = "N/A";
        public int FirstFlavorID;
        public string SecondFlavor = "N/A";
        public int SecondFlavorID;
        public string ThirdFlavor = "N/A";
        public int ThirdFlavorID;
        public int MixCount = 0;

        public int IndexFlavor = 0;

        // Check for flavor Availability 
        public bool[] flavorAvailability = new bool[] { true, true, true };


        // Method to handle soda flavor selection
        public bool SelectFlavor(int flavorID, int indexFlavor)
        {
            bool labelControlVisible = false;

            // Check if the flavor is already selected
            if (this.FirstFlavorID == flavorID || this.SecondFlavorID == flavorID || this.ThirdFlavorID == flavorID)
            {
                Interaction.MsgBox("Flavor Already Selected");
                return false;
            }

            // Proceed only if the mix count limit is not reached
            if (this.MixCount < 3)
            {
                // Display the selection label
                labelControlVisible = true;

                // Update the mix count and flavor index
                MixCountCheck();
                this.IndexFlavor = indexFlavor;

                // Set and display selected flavors
                this.SetFlavors();


            }

            return labelControlVisible;
        }

        // private sub that counts the amount of flavors picked
        private void MixCountCheck()
        {
            if (this.MixCount == 0)
            {
                this.MixCount = 1;
            }

            else if (this.MixCount < 3)
            {
                this.MixCount += 1;
            }

            // if more than 3 flavors are picked you are alerted
            else
            {
                this.MixCount = 3;
                Interaction.MsgBox("Oops! You can only mix 3 flavors");

            }
        }

        //  resets the flavors picked
        public void ResetSetFlavors()
        {
            this.FirstFlavor = "N/A";
            this.SecondFlavor = "N/A";
            this.ThirdFlavor = "N/A";
            this.FirstFlavorID = 0;
            this.SecondFlavorID = 0;
            this.ThirdFlavorID = 0;

            this.flavorAvailability = new bool[] { true, true, true };
        }


        // private sub that uses the unique flavor number to set the name of the flavor to show stats
        private void SetFlavors()
        {
            // Check the flavor selected in what order to assing the name of drink
            switch (this.MixCount)
            {
                case 1:
                    this.FirstFlavorID = IndexFlavor - 1;
                    switch (IndexFlavor)
                    {
                        case 1:
                            this.FirstFlavor = "Coca-Cola";
                            break;
                        case 2:
                            this.FirstFlavor = "Coca-cola Diet";
                            break;
                        case 3:
                            this.FirstFlavor = "Coca-cola Zero";
                            break;
                        case 4:
                            this.FirstFlavor = "Fanta";
                            break;
                        case 5:
                            this.FirstFlavor = "DrPepper";
                            break;
                        case 6:
                            this.FirstFlavor = "Sprite";
                            break;
                        case 7:
                            this.FirstFlavor = "SpriteZero";
                            break;
                        case 8:
                            this.FirstFlavor = "Minute Maid Lemonade";
                            break;
                        case 9:
                            this.FirstFlavor = "Minute Maid Lemonade Zero";
                            break;
                        case 10:
                            this.FirstFlavor = "Root Bear";
                            break;
                    }
                    break;

                case 2:
                    this.SecondFlavorID = IndexFlavor - 1;
                    switch (IndexFlavor)
                    {
                        case 1:
                            this.SecondFlavor = "Coca-Cola";
                            break;
                        case 2:
                            this.SecondFlavor = "Coca-cola Diet";
                            break;
                        case 3:
                            this.SecondFlavor = "Coca-cola Zero";
                            break;
                        case 4:
                            this.SecondFlavor = "Fanta";
                            break;
                        case 5:
                            this.SecondFlavor = "DrPepper";
                            break;
                        case 6:
                            this.SecondFlavor = "Sprite";
                            break;
                        case 7:
                            this.SecondFlavor = "SpriteZero";
                            break;
                        case 8:
                            this.SecondFlavor = "Minute Maid Lemonade";
                            break;
                        case 9:
                            this.SecondFlavor = "Minute Maid Lemonade Zero";
                            break;
                        case 10:
                            this.SecondFlavor = "Root Bear";
                            break;
                    }
                    break;

                case 3:
                    this.ThirdFlavorID = IndexFlavor - 1;
                    switch (IndexFlavor)
                    {
                        case 1:
                            this.ThirdFlavor = "Coca-Cola";
                            break;
                        case 2:
                            this.ThirdFlavor = "Coca-cola Diet";
                            break;
                        case 3:
                            this.ThirdFlavor = "Coca-cola Zero";
                            break;
                        case 4:
                            this.ThirdFlavor = "Fanta";
                            break;
                        case 5:
                            this.ThirdFlavor = "DrPepper";
                            break;
                        case 6:
                            this.ThirdFlavor = "Sprite";
                            break;
                        case 7:
                            this.ThirdFlavor = "SpriteZero";
                            break;
                        case 8:
                            this.ThirdFlavor = "Minute Maid Lemonade";
                            break;
                        case 9:
                            this.ThirdFlavor = "Minute Maid Lemonade Zero";
                            break;
                        case 10:
                            this.ThirdFlavor = "Root Bear";
                            break;
                    }
                    break;
            }
        }
    }
}
