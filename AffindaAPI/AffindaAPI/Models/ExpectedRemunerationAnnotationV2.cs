// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Affinda.API.Models
{
    /// <summary> The ExpectedRemunerationAnnotationV2. </summary>
    public partial class ExpectedRemunerationAnnotationV2 : AnnotationV2
    {
        /// <summary> Initializes a new instance of ExpectedRemunerationAnnotationV2. </summary>
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
        /// <param name="contentType"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="contentType"/> is null. </exception>
        public ExpectedRemunerationAnnotationV2(int id, Rectangle rectangle, IEnumerable<Rectangle> rectangles, int? pageIndex, string raw, float? confidence, float? classificationConfidence, float? textExtractionConfidence, bool isVerified, bool isClientVerified, bool isAutoVerified, string contentType) : base(id, rectangle, rectangles, pageIndex, raw, confidence, classificationConfidence, textExtractionConfidence, isVerified, isClientVerified, isAutoVerified, contentType)
        {
            if (contentType == null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }
        }

        /// <summary> Initializes a new instance of ExpectedRemunerationAnnotationV2. </summary>
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
        /// <param name="dataPoint"></param>
        /// <param name="contentType"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="parsed"></param>
        internal ExpectedRemunerationAnnotationV2(int id, Rectangle rectangle, IList<Rectangle> rectangles, int? pageIndex, string raw, float? confidence, float? classificationConfidence, float? textExtractionConfidence, bool isVerified, bool isClientVerified, bool isAutoVerified, string dataPoint, string contentType, IDictionary<string, object> additionalProperties, ExpectedRemunerationAnnotationV2Parsed parsed) : base(id, rectangle, rectangles, pageIndex, raw, confidence, classificationConfidence, textExtractionConfidence, isVerified, isClientVerified, isAutoVerified, dataPoint, contentType, additionalProperties)
        {
            Parsed = parsed;
        }

        /// <summary> Gets or sets the parsed. </summary>
        public ExpectedRemunerationAnnotationV2Parsed Parsed { get; set; }
    }
}
