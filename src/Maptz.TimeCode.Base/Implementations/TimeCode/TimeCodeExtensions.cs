using System;
namespace Maptz
{
    /// <summary>
    /// Contains extension methods for a TimeCode object. 
    /// </summary>
    public static class TimeCodeExtensions
    {


        public static string ToFractionalString(this ITimeCode timecode, string fractionSymb = ".")
        {
            var secs = timecode.GetSecondsFraction().ToString("00.000").Replace(".", fractionSymb);
            return $"{timecode.HoursSegment.ToString("00")}:{timecode.MinutesSegment.ToString("00")}:{secs}";
        }

        /* #region Public Static Methods */
        /// <summary>
        /// GEt the number of seconds as a fraction.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static double GetSecondsFraction(this ITimeCode t)
        {
            var divider = 1.0;
            switch (t.FrameRate)
            {

                case SmpteFrameRate.Smpte25:
                    divider = 25.0;
                    break;
                case SmpteFrameRate.Smpte24:
                    divider = 24.0;
                    break;
                case SmpteFrameRate.Smpte30:
                    divider = 30.0;
                    break;
                default:
                    throw new NotImplementedException();

            }
            var fractionalSeconds = (((double)t.FramesSegment) / divider);
            return t.SecondsSegment + fractionalSeconds;
        }
        /* #endregion Public Static Methods */

    }
}