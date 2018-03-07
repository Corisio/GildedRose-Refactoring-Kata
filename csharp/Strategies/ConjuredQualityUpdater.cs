using csharp.Items;

namespace csharp.Strategies
{
    internal class ConjuredQualityUpdater : BaseQualityUpdater
    {
 
        protected override int GetQualityModifier(Item item)
        {
            return -1;
        }
    }
}
