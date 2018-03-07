using csharp.Items;

namespace csharp.Strategies
{
    internal interface IQualityUpdater
    {
        void UpdateQuality(Item item);
    }
}
