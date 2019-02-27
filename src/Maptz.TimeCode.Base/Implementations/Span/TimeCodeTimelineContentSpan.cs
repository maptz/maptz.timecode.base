using Maptz.Timelines;

namespace Maptz
{

    /// <summary>
    /// A span between two timecodes. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TimeCodeTimelineContentSpan<T> : TimelineContentSpan<T>, ITimeCodeTimelineContentSpan<T>
    {
        public TimeCodeTimelineContentSpan(long startFrame, long lengthFrames, T content, SmpteFrameRate frameRate) : base(startFrame, lengthFrames, content)
        {
            this.FrameRate = frameRate;
        }

        /// <summary>
        /// The framerate. 
        /// </summary>
        public SmpteFrameRate FrameRate { get; private set; }

        /// <summary>
        /// The record start timecode. 
        /// </summary>
        public ITimeCode RecordIn
        {
            get { return TimeCode.FromFrames(this.Start, this.FrameRate); }
        }

        /// <summary>
        /// The end timecode. 
        /// </summary>
        public ITimeCode RecordOut
        {
            get { return TimeCode.FromFrames(this.End, this.FrameRate); }
        }

    }
}