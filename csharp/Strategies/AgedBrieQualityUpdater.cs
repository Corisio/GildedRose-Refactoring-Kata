using csharp.Items;

namespace csharp.Strategies
{
    internal class AgedBrieQualityUpdater : BaseQualityUpdater
    {
 
        protected override int GetQualityModifier(Item item)
        {
            return 1;
        }
    }
}
