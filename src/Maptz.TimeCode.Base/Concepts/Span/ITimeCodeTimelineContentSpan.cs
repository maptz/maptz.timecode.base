using Maptz.Timelines;
namespace Maptz
{

    public interface ITimeCodeTimelineContentSpan : ITimelineContentSpan, ITimeCodeTimelineSpan, ITimeCodeTimelineContentItem
    {


    }

    /// <summary>
    /// A span between two timecodes. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ITimeCodeTimelineContentSpan<T> : ITimeCodeTimelineContentSpan, ITimelineContentSpan<T>
    {


    }
}