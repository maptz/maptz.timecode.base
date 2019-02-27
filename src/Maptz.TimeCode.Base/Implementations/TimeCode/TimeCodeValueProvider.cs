using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using Newtonsoft.Json.Serialization;
using System.Reflection;
namespace Maptz
{
    public class TimeCodeValueProvider : IValueProvider
    {
        public PropertyInfo Member { get; private set; }

        public TimeCodeValueProvider(PropertyInfo member)
        {
            this.Member = member;
        }

        public void SetValue(object target, object value)
        {
            var timecode = new TimeCode(value as string, SmpteFrameRate.Smpte25);
            this.Member.SetValue(target, timecode);
        }

        public object GetValue(object target)
        {
            var val = this.Member.GetValue(target);
            return val.ToString();
        }
    }
}