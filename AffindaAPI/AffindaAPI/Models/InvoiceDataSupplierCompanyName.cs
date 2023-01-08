// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Affinda.API.Models
{
    /// <summary> The InvoiceDataSupplierCompanyName. </summary>
    public partial class InvoiceDataSupplierCompanyName : TextAnnotation
    {
        /// <summary> Initializes a new instance of InvoiceDataSupplierCompanyName. </summary>
        /// <param name="rectangle"></param>
        /// <param name="pageIndex"></param>
        /// <param name="raw"></param>
        /// <param name="confidence"> Combined confidence from the model confidence and the OCR confidence. </param>
        /// <param name="classificationConfidence"> The AI model confidence. </param>
        /// <param name="textExtractionConfidence"> The OCR confidence. </param>
        /// <param name="isVerified"></param>
        /// <param name="classification"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="classification"/> is null. </exception>
        internal InvoiceDataSupplierCompanyName(Rectangle rectangle, int? pageIndex, string raw, float? confidence, float? classificationConfidence, float? textExtractionConfidence, bool isVerified, string classification) : base(rectangle, pageIndex, raw, confidence, classificationConfidence, textExtractionConfidence, isVerified, classification)
        {
            if (classification == null)
            {
                throw new ArgumentNullException(nameof(classification));
            }
        }

        /// <summary> Initializes a new instance of InvoiceDataSupplierCompanyName. </summary>
        /// <param name="id"></param>
        /// <param name="rectangle"></param>
        /// <param name="pageIndex"></param>
        /// <param name="raw"></param>
        /// <param name="confidence"> Combined confidence from the model confidence and the OCR confidence. </param>
        /// <param name="classificationConfidence"> The AI model confidence. </param>
        /// <param name="textExtractionConfidence"> The OCR confidence. </param>
        /// <param name="isVerified"></param>
        /// <param name="isClientVerified"></param>
        /// <param name="isAutoVerified"></param>
        /// <param name="classification"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="parsed"></param>
        internal InvoiceDataSupplierCompanyName(int? id, Rectangle rectangle, int? pageIndex, string raw, float? confidence, float? classificationConfidence, float? textExtractionConfidence, bool isVerified, bool? isClientVerified, bool? isAutoVerified, string classification, IReadOnlyDictionary<string, object> additionalProperties, string parsed) : base(id, rectangle, pageIndex, raw, confidence, classificationConfidence, textExtractionConfidence, isVerified, isClientVerified, isAutoVerified, classification, additionalProperties, parsed)
        {
        }
    }
}
