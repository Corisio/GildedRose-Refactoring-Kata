using csharp.Items;
using csharp.Strategies;
using NUnit.Framework;

namespace GildedRose.UnitTests
{
    [TestFixture]
    public class ConjuredQualityUpdaterShould
    {
        private const string STANDARD_ITEM_NAME = "Standard item";

        private Item item;
        private ConjuredQualityUpdater updater = new ConjuredQualityUpdater();

        [SetUp]
        public void Setup()
        {
            item = new Item() { Name = STANDARD_ITEM_NAME, Quality = 10, SellIn = 1 };
        }

        [Test]
        public void reduce_sellin_in_one()
        {
            updater.UpdateQuality(item);
            Assert.AreEqual(0, item.SellIn);
        }

        [Test]
        public void reduce_quality_by_two_if_the_item_has_not_expired()
        {
            updater.UpdateQuality(item);
            Assert.AreEqual(8, item.Quality);
        }

        [Test]
        public void reduce_quality_by_four_if_the_item_has_expired()
        {
            item.SellIn = 0;
            updater.UpdateQuality(item);
            Assert.AreEqual(6, item.Quality);
        }

        [Test]
        public void not_reduce_quality_below_zero()
        {
            item.Quality = 0;
            item.SellIn = 1;
            updater.UpdateQuality(item);
            Assert.AreEqual(0, item.Quality);
        }
    }
}
