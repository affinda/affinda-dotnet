// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Affinda.API.Models
{
    /// <summary> The FloatAnnotation. </summary>
    public partial class FloatAnnotation : Annotation
    {
        /// <summary> Initializes a new instance of FloatAnnotation. </summary>
        /// <param name="id"> Annotation&apos;s ID. </param>
        /// <param name="rectangle"> x/y coordinates for the rectangular bounding box containing the data. </param>
        /// <param name="rectangles"> x/y coordinates for the rectangles containing the data. An annotation can be contained within multiple rectangles. </param>
        /// <param name="document"> Unique identifier for the document. </param>
        /// <param name="pageIndex"> The page number within the document, starting from 0. </param>
        /// <param name="raw"> Raw data extracted from the before any post-processing. </param>
        /// <param name="confidence"> The overall confidence that the model&apos;s prediction is correct. </param>
        /// <param name="classificationConfidence"> The model&apos;s confidence that the text has been classified correctly. </param>
        /// <param name="textExtractionConfidence"> If the document was submitted as an image, this is the confidence that the text in the image has been correctly read by the model. </param>
        /// <param name="isVerified"> Indicates whether the data has been validated, either by a human using our validation tool or through auto-validation rules. </param>
        /// <param name="isClientVerified"> Indicates whether the data has been validated by a human. </param>
        /// <param name="isAutoVerified"> Indicates whether the data has been auto-validated. </param>
        /// <param name="dataPoint"> Data point&apos;s identifier. </param>
        /// <param name="contentType"> The different data types of annotations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rectangles"/>, <paramref name="document"/> or <paramref name="dataPoint"/> is null. </exception>
        public FloatAnnotation(int id, Rectangle rectangle, IEnumerable<Rectangle> rectangles, string document, int? pageIndex, string raw, float? confidence, float? classificationConfidence, float? textExtractionConfidence, bool isVerified, bool isClientVerified, bool isAutoVerified, string dataPoint, AnnotationContentType contentType) : base(id, rectangle, rectangles, document, pageIndex, raw, confidence, classificationConfidence, textExtractionConfidence, isVerified, isClientVerified, isAutoVerified, dataPoint, contentType)
        {
            if (rectangles == null)
            {
                throw new ArgumentNullException(nameof(rectangles));
            }
            if (document == null)
            {
                throw new ArgumentNullException(nameof(document));
            }
            if (dataPoint == null)
            {
                throw new ArgumentNullException(nameof(dataPoint));
            }
        }

        /// <summary> Initializes a new instance of FloatAnnotation. </summary>
        /// <param name="id"> Annotation&apos;s ID. </param>
        /// <param name="rectangle"> x/y coordinates for the rectangular bounding box containing the data. </param>
        /// <param name="rectangles"> x/y coordinates for the rectangles containing the data. An annotation can be contained within multiple rectangles. </param>
        /// <param name="document"> Unique identifier for the document. </param>
        /// <param name="pageIndex"> The page number within the document, starting from 0. </param>
        /// <param name="raw"> Raw data extracted from the before any post-processing. </param>
        /// <param name="confidence"> The overall confidence that the model&apos;s prediction is correct. </param>
        /// <param name="classificationConfidence"> The model&apos;s confidence that the text has been classified correctly. </param>
        /// <param name="textExtractionConfidence"> If the document was submitted as an image, this is the confidence that the text in the image has been correctly read by the model. </param>
        /// <param name="isVerified"> Indicates whether the data has been validated, either by a human using our validation tool or through auto-validation rules. </param>
        /// <param name="isClientVerified"> Indicates whether the data has been validated by a human. </param>
        /// <param name="isAutoVerified"> Indicates whether the data has been auto-validated. </param>
        /// <param name="dataPoint"> Data point&apos;s identifier. </param>
        /// <param name="contentType"> The different data types of annotations. </param>
        /// <param name="parent"> The parent annotation&apos;s ID. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="parsed"></param>
        internal FloatAnnotation(int id, Rectangle rectangle, IList<Rectangle> rectangles, string document, int? pageIndex, string raw, float? confidence, float? classificationConfidence, float? textExtractionConfidence, bool isVerified, bool isClientVerified, bool isAutoVerified, string dataPoint, AnnotationContentType contentType, int? parent, IDictionary<string, object> additionalProperties, float? parsed) : base(id, rectangle, rectangles, document, pageIndex, raw, confidence, classificationConfidence, textExtractionConfidence, isVerified, isClientVerified, isAutoVerified, dataPoint, contentType, parent, additionalProperties)
        {
            Parsed = parsed;
        }

        /// <summary> Gets or sets the parsed. </summary>
        public float? Parsed { get; set; }
    }
}
