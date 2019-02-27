using Maptz.Timelines;
namespace Maptz
{

    public interface ITimeCodeTimelineContentItem : ITimelineContentItem, ITimeCodeTimelineItem
    {

    }

    public interface ITimeCodeTimelineContentItem<T> : ITimeCodeTimelineContentItem, ITimelineContentItem<T>
    {

    }
}