namespace Maptz
{

    /// <summary>
    /// An SMTPE TimeCode object. 
    /// </summary>
    public interface ITimeCode
    {
        /// <summary>
        /// Get the hours segment of the timecode. 
        /// </summary>
        int HoursSegment { get; }

        /// <summary>
        /// Get the minutes segment of the timecode. 
        /// </summary>
        int MinutesSegment { get; }

        /// <summary>
        /// Get the seconds segment of the timecode. 
        /// </summary>
        int SecondsSegment { get; }

        /// <summary>
        /// Get the frames segment of the timecode. 
        /// </summary>
        int FramesSegment { get; }

        /// <summary>
        /// Get the total number of frames. 
        /// </summary>
        long TotalFrames { get; }
        /// <summary>
        /// Get the total number of hours. 
        /// </summary>
        double TotalHours { get; }
        /// <summary>
        /// Get the total number of minutes
        /// </summary>
        double TotalMinutes { get; }
        /// <summary>
        /// Get the total number of seconds. 
        /// </summary>
        double TotalSeconds { get; }
        /// <summary>
        /// Get the framerate for the timecode object.
        /// </summary>
        SmpteFrameRate FrameRate { get; }
    }
}