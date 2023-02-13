using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Facebook.Extensions {

    internal static class FacebookJsonExtensions {

        public static bool HasValue(this JObject json, string path) {
            return Essentials.Json.Extensions.JObjectExtensions.HasValue(json, path);
        }

    }

}