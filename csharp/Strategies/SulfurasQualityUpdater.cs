using csharp.Items;

namespace csharp.Strategies
{
    internal class SulfurasQualityUpdater : BaseQualityUpdater
    {
 
        protected override int GetQualityModifier(Item item)
        {
            return 0;
        }

        protected override int GetSellInModifier(Item item)
        {
            return 0;
        }
    }
}
