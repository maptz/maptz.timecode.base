using System;
namespace Maptz
{

    public static class TimeCodeHelpers
    {
        public static long ToFrameCount(this TimeSpan timespan, SmpteFrameRate framerate)
        {
            var retval = new TimeCode(timespan, framerate).TotalFrames;
            return retval;
        }
    }
}