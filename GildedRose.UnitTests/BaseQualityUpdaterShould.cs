using csharp.Items;
using csharp.Strategies;
using NUnit.Framework;

namespace GildedRose.UnitTests
{
    [TestFixture]
    public class BaseQualityUpdaterShould
    {
        private const string STANDARD_ITEM_NAME = "Standard item";

        [Test]
        public void reduce_sellin_in_one()
        {
            var item = new Item() { Name = STANDARD_ITEM_NAME, Quality = 0, SellIn = 1 };
            var updater = new BaseQualityUpdater();
            updater.UpdateQuality(item);
            Assert.AreEqual(0, item.SellIn);
        }

        [Test]
        public void reduce_quality_by_one_if_the_item_has_not_expired()
        {
            var item = new Item() { Name = STANDARD_ITEM_NAME, Quality = 10, SellIn = 1 };
            var updater = new BaseQualityUpdater();
            updater.UpdateQuality(item);
            Assert.AreEqual(9, item.Quality);
        }

        [Test]
        public void reduce_quality_by_two_if_the_item_has_expired()
        {
            var item = new Item() { Name = STANDARD_ITEM_NAME, Quality = 10, SellIn = 0 };
            var updater = new BaseQualityUpdater();
            updater.UpdateQuality(item);
            Assert.AreEqual(8, item.Quality);
        }

        [Test]
        public void not_reduce_quality_below_zero()
        {
            var item = new Item() { Name = STANDARD_ITEM_NAME, Quality = 0, SellIn = 1 };
            var updater = new BaseQualityUpdater();
            updater.UpdateQuality(item);
            Assert.AreEqual(0, item.Quality);
        }
    }
}
