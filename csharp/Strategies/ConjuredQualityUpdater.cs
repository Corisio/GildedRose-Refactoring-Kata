using csharp.Items;

namespace csharp.Strategies
{
    public class ConjuredQualityUpdater : BaseQualityUpdater
    {
 
        protected override int GetQualityModifier(Item item)
        {
            return -2;
        }
    }
}
