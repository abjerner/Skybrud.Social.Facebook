using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Collections;
using Skybrud.Essentials.Enums;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;
using Skybrud.Essentials.Strings.Extensions;
using Skybrud.Essentials.Time.Iso8601;

namespace Skybrud.Social.Facebook.Extensions {

    internal static class FacebookJsonExtensions {

        public static bool HasValue(this JObject json, string path) {
            return Essentials.Json.Extensions.JObjectExtensions.HasValue(json, path);
        }

        internal static string[]? GetStringArrayOrNull(this JObject? json, string propertyName) {
            return GetStringArray(json?.GetValue(propertyName));
        }

        internal static string[]? GetStringArray(JToken? token) {
            return token?.Type switch  {
                JTokenType.String => token.Value<string>().ToStringArray(),
                JTokenType.Array => ConvertArrayTokenToStringArray(token),
                _ => TryGetString(token, out string? result) ? new[] { result } : null
            };
        }

        internal static bool TryGetString(JToken? token, [NotNullWhen(true)] out string? result) {

            switch (token?.Type) {

                case JTokenType.Boolean:
                case JTokenType.Integer:
                case JTokenType.Float:
                case JTokenType.Guid:
                    result = string.Format(CultureInfo.InvariantCulture, "{0}", token);
                    return true;

                case JTokenType.Date:
                    switch (token.ToObject<object>()) {
                        case DateTime dt:
                            result = dt.ToString(Iso8601Constants.DateTimeMilliseconds);
                            return true;
                        case DateTimeOffset dto:
                            result = dto.ToString(Iso8601Constants.DateTimeMilliseconds);
                            return true;
                        default:
                            result = null;
                            return false;
                    }

                case JTokenType.String:
                    result = token.Value<string>();
                    return true;

                default:
                    result = null;
                    return false;

            }

        }

        internal static string[]? ConvertArrayTokenToStringArray(JToken token) {

            if (token is not JArray) return null;

            List<string> temp = new();

            foreach (JToken item in token) {
                if (TryGetString(item, out string? result)) {
                    temp.Add(result);
                }
            }

            return temp.ToArray();

        }

        internal static TEnum? GetEnumOrDefault<TEnum>(this JObject json, string propertyName) where TEnum : struct, Enum {
            if (!json.TryGetString(propertyName, out string? value)) return null;
            return EnumUtils.TryParseEnum(value, out TEnum result) ? result : default;
        }

    }

}