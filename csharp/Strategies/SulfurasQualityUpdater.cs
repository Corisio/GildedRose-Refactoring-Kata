using csharp.Items;

namespace csharp.Strategies
{
    public class SulfurasQualityUpdater : BaseQualityUpdater
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
