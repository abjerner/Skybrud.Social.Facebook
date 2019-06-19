using System.Collections.Generic;

namespace Skybrud.Social.Facebook.Scopes {
    
    /// <summary>
    /// Class representing a scope of the Facebook Graph API.
    /// </summary>
    public class FacebookScope {

        #region Private fields

        private static readonly Dictionary<string, FacebookScope> Scopes = new Dictionary<string, FacebookScope>();

        #endregion

        #region Properties

        /// <summary>
        /// Gets the name of the scope.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the description of the scope.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Indicates whether the scope requires your app to be reviewed by Facebook.
        /// </summary>
        public FacebookScopeReview Review { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default and private constructor.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        /// <param name="description">The description of the scope.</param>
        public FacebookScope(string name, string description = null) {
            Name = name;
            Description = string.IsNullOrWhiteSpace(description) ? null : description.Trim();
        }

        /// <summary>
        /// Default and private constructor.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        /// <param name="description">The description of the scope.</param>
        /// <param name="review">Whether the scope requires your app to be reviewed by Facebook.</param>
        public FacebookScope(string name, string description, FacebookScopeReview review = FacebookScopeReview.Unspecified) {
            Name = name;
            Description = string.IsNullOrWhiteSpace(description) ? null : description.Trim();
            Review = review;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Returns a string representation (the name) of the scope.
        /// </summary>
        /// <returns>A string representation of the scope.</returns>
        public override string ToString() {
            return Name;
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Registers a scope in the internal dictionary.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        /// <param name="description">The description of the scope.</param>
        internal static FacebookScope RegisterScope(string name, string description = null) {
            FacebookScope scope = new FacebookScope(name, description);
            Scopes.Add(scope.Name, scope);
            return scope;
        }

        /// <summary>
        /// Attempts to get a scope with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        /// <returns>Gets a scope matching the specified <paramref name="name"/>, or <c>null</c> if not found-</returns>
        public static FacebookScope GetScope(string name) {
            return Scopes.TryGetValue(name, out var scope) ? scope : null;
        }

        /// <summary>
        /// Gets whether the scope is a known scope.
        /// </summary>
        /// <param name="name">The name of the scope.</param>
        /// <returns>Returns <c>true</c> if the specified <paramref name="name"/> matches a known scope, otherwise <c>false</c>.</returns>
        public static bool ScopeExists(string name) {
            return Scopes.ContainsKey(name);
        }

        #endregion
        
        #region Operators

        /// <summary>
        /// Adding two instances of <see cref="FacebookScope"/> will result in a <see cref="FacebookScopeCollection"/> containing both scopes.
        /// </summary>
        /// <param name="left">The left scope.</param>
        /// <param name="right">The right scope.</param>
        public static FacebookScopeCollection operator +(FacebookScope left, FacebookScope right) {
            return new FacebookScopeCollection(left, right);
        }

        #endregion

    }

}