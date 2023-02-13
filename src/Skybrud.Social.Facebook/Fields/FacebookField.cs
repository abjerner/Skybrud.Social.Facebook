namespace Skybrud.Social.Facebook.Fields {

    /// <summary>
    /// Class representing a field in the Facebook Graph API.
    /// </summary>
    public class FacebookField {

        #region Properties

        /// <summary>
        /// Gets the alias of the field.
        /// </summary>
        public string Alias { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new field with the specified <paramref name="alias"/>.
        /// </summary>
        /// <param name="alias">The name of the field.</param>
        public FacebookField(string alias) {
            Alias = alias;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Initializes a new field based on the specified <paramref name="alias"/>.
        /// </summary>
        /// <param name="alias">The alias of the field.</param>
        public static implicit operator FacebookField(string alias) {
            return new FacebookField(alias);
        }

        /// <summary>
        /// Adding two instances of <see cref="FacebookField"/> will result in a <see cref="FacebookFieldList"/> containing both fields.
        /// </summary>
        /// <param name="left">The left field.</param>
        /// <param name="right">The right field.</param>
        public static FacebookFieldList operator +(FacebookField left, FacebookField right) {
            return new FacebookFieldList(left, right);
        }

        #endregion

    }

}