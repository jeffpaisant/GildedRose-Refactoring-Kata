namespace GildedRose
{
    public class ConjuredItem : Item
    {

        public void DecrementSellIn()
        {
            this.SellIn--;
        }

        public void DecrementQuality()
        {
            this.Quality -= 2;
        }

        public bool IsQualityGreaterThan0()
        {
            return this.Quality >= 0;
        }

        public void ManageQuality()
        {
            if (this.CanDecreaseQuality())
            {
                this.DecrementQuality();
            }
            else
            {
                this.ResetQuality();
            }
        }

        private void ResetQuality()
        {
            this.Quality = 0;
        }

        private bool CanDecreaseQuality()
        {
            return this.Quality - 2 > 0;
        }
    }
}
