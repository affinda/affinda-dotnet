// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The DocumentWarning. </summary>
    public partial class DocumentWarning
    {
        /// <summary> Initializes a new instance of DocumentWarning. </summary>
        public DocumentWarning()
        {
        }

        /// <summary> Initializes a new instance of DocumentWarning. </summary>
        /// <param name="warningCode"></param>
        /// <param name="warningDetail"></param>
        internal DocumentWarning(string warningCode, string warningDetail)
        {
            WarningCode = warningCode;
            WarningDetail = warningDetail;
        }

        /// <summary> Gets or sets the warning code. </summary>
        public string WarningCode { get; set; }
        /// <summary> Gets or sets the warning detail. </summary>
        public string WarningDetail { get; set; }
    }
}
