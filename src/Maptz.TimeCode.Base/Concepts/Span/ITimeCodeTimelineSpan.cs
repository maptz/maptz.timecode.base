using Maptz.Timelines;
namespace Maptz
{

    public interface ITimeCodeTimelineSpan : ITimeCodeTimelineItem, ITimelineSpan
    {
        /// <summary>
        /// The end timecode. 
        /// </summary>
        ITimeCode RecordOut
        {
            get;
        }
    }
}