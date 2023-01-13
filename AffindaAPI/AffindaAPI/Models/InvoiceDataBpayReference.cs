// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Affinda.API.Models
{
    /// <summary> The InvoiceDataBpayReference. </summary>
    public partial class InvoiceDataBpayReference : TextAnnotation
    {
        /// <summary> Initializes a new instance of InvoiceDataBpayReference. </summary>
        /// <param name="rectangle"></param>
        /// <param name="pageIndex"></param>
        /// <param name="raw"></param>
        /// <param name="confidence"> The overall confidence that the model&apos;s prediction is correct. </param>
        /// <param name="classificationConfidence"> The model&apos;s confidence that the text has been classified correctly. </param>
        /// <param name="textExtractionConfidence"> If the document was submitted as an image, this is the confidence that the text in the image has been correctly read by the model. </param>
        /// <param name="isVerified"></param>
        /// <param name="classification"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="classification"/> is null. </exception>
        internal InvoiceDataBpayReference(Rectangle rectangle, int? pageIndex, string raw, float? confidence, float? classificationConfidence, float? textExtractionConfidence, bool isVerified, string classification) : base(rectangle, pageIndex, raw, confidence, classificationConfidence, textExtractionConfidence, isVerified, classification)
        {
            if (classification == null)
            {
                throw new ArgumentNullException(nameof(classification));
            }
        }

        /// <summary> Initializes a new instance of InvoiceDataBpayReference. </summary>
        /// <param name="id"></param>
        /// <param name="rectangle"></param>
        /// <param name="rectangles"></param>
        /// <param name="pageIndex"></param>
        /// <param name="raw"></param>
        /// <param name="confidence"> The overall confidence that the model&apos;s prediction is correct. </param>
        /// <param name="classificationConfidence"> The model&apos;s confidence that the text has been classified correctly. </param>
        /// <param name="textExtractionConfidence"> If the document was submitted as an image, this is the confidence that the text in the image has been correctly read by the model. </param>
        /// <param name="isVerified"></param>
        /// <param name="isClientVerified"></param>
        /// <param name="isAutoVerified"></param>
        /// <param name="classification"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="parsed"></param>
        internal InvoiceDataBpayReference(int? id, Rectangle rectangle, IReadOnlyList<Rectangle> rectangles, int? pageIndex, string raw, float? confidence, float? classificationConfidence, float? textExtractionConfidence, bool isVerified, bool? isClientVerified, bool? isAutoVerified, string classification, IReadOnlyDictionary<string, object> additionalProperties, string parsed) : base(id, rectangle, rectangles, pageIndex, raw, confidence, classificationConfidence, textExtractionConfidence, isVerified, isClientVerified, isAutoVerified, classification, additionalProperties, parsed)
        {
        }
    }
}
