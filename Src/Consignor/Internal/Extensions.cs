using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Consignor.Internal
{
    internal static class Extensions
    {
        public static string ToJson(this object obj, bool ignoreDefaultValue = true)
        {
            if (obj == null) return null;
            var settings = new JsonSerializerSettings 
            { 
                NullValueHandling = NullValueHandling.Ignore,
            };
            if (ignoreDefaultValue) settings.DefaultValueHandling = DefaultValueHandling.Ignore;
            return JsonConvert.SerializeObject(obj, Formatting.Indented, settings);
        }

        public static T ToObject<T>(this string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static JObject ToObject(this string json)
        {
            if (string.IsNullOrWhiteSpace(json)) return null;
            return JObject.Parse(json);
        }

        public static bool IsAnonymous(this Type type)
        {
            if (type == null) throw new ArgumentNullException("type");
            return Attribute.IsDefined(type, typeof(CompilerGeneratedAttribute), false)
                && type.IsGenericType && type.Name.Contains("AnonymousType")
                && (type.Name.StartsWith("<>") || type.Name.StartsWith("VB$"))
                && (type.Attributes & TypeAttributes.NotPublic) == TypeAttributes.NotPublic;
        }
    }
}