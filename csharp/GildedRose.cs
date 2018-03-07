using csharp.Items;
using csharp.Strategies;
using System;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                GetItemStrategy(item).UpdateQuality(item);
            }
        }

        private IQualityUpdater GetItemStrategy(Item item)
        {
            switch (item.GetItemType()){
                case ItemType.Conjured:
                    return new ConjuredQualityUpdater();
                case ItemType.BackstagePass:
                    return new BackstagePassQualityUpdater();
                case ItemType.Sulfuras:
                    return new SulfurasQualityUpdater();
                case ItemType.AgedBrie:
                    return new AgedBrieQualityUpdater();
                default:
                    return new BaseQualityUpdater();
            }
        }
    }
}
