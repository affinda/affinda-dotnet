// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The Error. </summary>
    public partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        public Error()
        {
        }

        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorDetail"></param>
        internal Error(string errorCode, string errorDetail)
        {
            ErrorCode = errorCode;
            ErrorDetail = errorDetail;
        }

        /// <summary> Gets or sets the error code. </summary>
        public string ErrorCode { get; set; }
        /// <summary> Gets or sets the error detail. </summary>
        public string ErrorDetail { get; set; }
    }
}
