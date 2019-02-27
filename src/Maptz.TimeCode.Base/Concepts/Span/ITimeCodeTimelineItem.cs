using Maptz.Timelines;
namespace Maptz
{

    public interface ITimeCodeTimelineItem : ITimelineItem
    {
        SmpteFrameRate FrameRate { get; }

        /// <summary>
        /// The start timecode. 
        /// </summary>
        ITimeCode RecordIn
        {
            get;
        }
    }



}