using System.Collections.Generic;
using Maptz.Timelines;
namespace Maptz
{

    public class TimeCodeTimelineContentItem<T> : TimelineItem<T>, ITimeCodeTimelineContentItem<T>
    {
        public TimeCodeTimelineContentItem(long time, T item, SmpteFrameRate frameRate) : base(time, item)
        {
            this.FrameRate = frameRate;
        }



        public ITimeCode RecordIn => TimeCode.FromFrames(this.Time, this.FrameRate);

        public SmpteFrameRate FrameRate { get; }
    }
}