﻿namespace Skybrud.Social.Facebook.Models.Pages {

    /// <summary>
    /// Enum class representing the verification status of a Facebook page.
    /// </summary>
    public enum FacebookPageVerificationStatus {

        /// <summary>
        /// Indicates that the <c>verification_status</c> wasn't part of the response from the Facebook Graph API.
        /// </summary>
        NotSpecified,

        /// <summary>
        /// Indicates that the page is not yet verified.
        /// </summary>
        NotVerified,

        /// <summary>
        /// Indicates that the page has been verified for beeing the page of a business or organisation.
        /// </summary>
        GreyVerified,

        /// <summary>
        /// Indicates that the page has been verified for beeing the page of a public figure, celebrity or brand.
        /// </summary>
        BlueVerified

    }

}