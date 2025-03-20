namespace Coca_Cola_Project
{
    internal class OzToDispense
    {
        public double OzPicked = 0d;
        public double OzOfFlavor = 0d;
        public double OzOfCo2 = 0d;

        public void CalcSyrupUsed(int mixCount)
        {
            this.OzOfFlavor = this.OzPicked / 2d / mixCount;

            this.OzOfCo2 = this.OzPicked / 2d;

        }

    }
}
