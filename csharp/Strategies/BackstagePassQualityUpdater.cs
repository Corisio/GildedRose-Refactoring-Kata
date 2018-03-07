using csharp.Items;

namespace csharp.Strategies
{
    internal class BackstagePassQualityUpdater : BaseQualityUpdater
    {

        protected override int GetUpdatedQuality(Item item)
        {
            if (item.SellIn < 0)
            {
                return 0;
            }

            return base.GetUpdatedQuality(item);
        }

        protected override int GetQualityModifier(Item item)
        {
            if (item.SellIn < 5)
            {
                return 3;
            }

            if (item.SellIn < 10)
            {
                return 2;
            }

            return 1;
        }
    }
}
