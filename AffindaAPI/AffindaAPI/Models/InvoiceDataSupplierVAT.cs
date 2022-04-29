// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Affinda.API.Models
{
    /// <summary> The InvoiceDataSupplierVAT. </summary>
    public partial class InvoiceDataSupplierVAT : Annotation
    {
        /// <summary> Initializes a new instance of InvoiceDataSupplierVAT. </summary>
        /// <param name="rectangle"></param>
        /// <param name="pageIndex"></param>
        /// <param name="raw"></param>
        /// <param name="confidence"></param>
        /// <param name="isVerified"></param>
        /// <param name="classification"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="rectangle"/> or <paramref name="classification"/> is null. </exception>
        internal InvoiceDataSupplierVAT(Rectangle rectangle, int? pageIndex, string raw, float confidence, bool isVerified, string classification) : base(rectangle, pageIndex, raw, confidence, isVerified, classification)
        {
            if (rectangle == null)
            {
                throw new ArgumentNullException(nameof(rectangle));
            }
            if (classification == null)
            {
                throw new ArgumentNullException(nameof(classification));
            }
        }

        /// <summary> Initializes a new instance of InvoiceDataSupplierVAT. </summary>
        /// <param name="rectangle"></param>
        /// <param name="pageIndex"></param>
        /// <param name="raw"></param>
        /// <param name="parsed"></param>
        /// <param name="confidence"></param>
        /// <param name="isVerified"></param>
        /// <param name="classification"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal InvoiceDataSupplierVAT(Rectangle rectangle, int? pageIndex, string raw, string parsed, float confidence, bool isVerified, string classification, IReadOnlyDictionary<string, object> additionalProperties) : base(rectangle, pageIndex, raw, parsed, confidence, isVerified, classification, additionalProperties)
        {
        }
    }
}
