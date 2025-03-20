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

        // keep as global
        public int IndexFlavor = 0;

        // private sub that uses the unique flavor number to set the name of the flavor to show stats
        private void SetFlavors(int MixCount)
        {
            // Check the flavor selected in what order to assing the name of drink
            switch (MixCount)
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
