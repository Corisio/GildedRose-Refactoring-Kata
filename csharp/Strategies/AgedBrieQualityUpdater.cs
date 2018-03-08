using csharp.Items;

namespace csharp.Strategies
{
    public class AgedBrieQualityUpdater : BaseQualityUpdater
    {
 
        protected override int GetQualityModifier(Item item)
        {
            return 1;
        }
    }
}
