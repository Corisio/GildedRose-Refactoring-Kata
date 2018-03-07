using csharp.Items;
using System;

namespace csharp.Strategies
{
    internal class BaseQualityUpdater : IQualityUpdater
    {
        protected const int NON_EXPIRED_DEGRADATION_RATE = 1;
        protected const int EXPIRED_DEGRADATION_RATE = 2;
        protected const int MINIMUM_QUALITY = 0;
        protected const int STANDARD_QUALITY_MODIFIER = -1;
        protected const int STANDARD_SELL_IN_MODIFIER = -1;

        public void UpdateQuality(Item item)
        {
            item.EnforceItemRules();
            item.SellIn += GetSellInModifier(item);
            item.Quality = GetUpdatedQuality(item);
        }

        protected virtual int GetUpdatedQuality(Item item)
        {
            var newQuality = item.Quality + (GetQualityModifier(item) * GetDegradationRate(item));
            if (newQuality < MINIMUM_QUALITY)
            {
                return MINIMUM_QUALITY;
            }

            if (newQuality > item.GetItemMaximumQuality())
            {
                return item.GetItemMaximumQuality();
            }

            return newQuality;
        }

        protected int GetDegradationRate(Item item)
        {
            if (item.SellIn < 0)
            {
                return EXPIRED_DEGRADATION_RATE;
            }

            return NON_EXPIRED_DEGRADATION_RATE;
        }

        protected virtual int GetQualityModifier(Item item)
        {
            return STANDARD_QUALITY_MODIFIER;
        }

        protected virtual int GetSellInModifier(Item item)
        {
            return STANDARD_SELL_IN_MODIFIER;
        }
    }
}
