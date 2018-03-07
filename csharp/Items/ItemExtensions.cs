namespace csharp.Items
{
    internal static class ItemExtensions
    {
        private const string AGED_BRIE_IDENTIFIER = "Aged Brie";
        private const string SULFURAS_IDENTIFIER = "Sulfuras";
        private const int SULFURAS_MAXIMUM_QUALITY = 80;
        private const string BACKSTAGE_PASS_IDENTIFIER = "Backstage passes";
        private const string CONJURED_IDENTIFIER = "Conjured";
        private const int STANDARD_MAXIMUM_QUALITY = 50;


        internal static ItemType GetItemType(this Item item)
        {
            if (item.Name.Contains(CONJURED_IDENTIFIER))
            {
                return ItemType.Conjured;
            }

            if (item.Name.Contains(BACKSTAGE_PASS_IDENTIFIER))
            {
                return ItemType.BackstagePass;
            }

            if (item.Name.Contains(SULFURAS_IDENTIFIER))
            {
                return ItemType.Sulfuras;
            }

            if (item.Name.Contains(AGED_BRIE_IDENTIFIER))
            {
                return ItemType.AgedBrie;
            }

            return ItemType.Standard;
        }

        internal static void EnforceItemRules(this Item item)
        {
            if (item.Quality < 0)
            {
                item.Quality = 0;
            }

            var maximumQuality = item.GetItemMaximumQuality();
            if (item.Quality > maximumQuality)
            {
                item.Quality = maximumQuality;
            }
        }

        internal static int GetItemMaximumQuality(this Item item)
        {
            if (item.GetItemType() == ItemType.Sulfuras)
            {
                return SULFURAS_MAXIMUM_QUALITY;
            }

            return STANDARD_MAXIMUM_QUALITY;
        }
    }
}
