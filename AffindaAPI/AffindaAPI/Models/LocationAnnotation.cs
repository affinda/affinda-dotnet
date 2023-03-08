// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Affinda.API.Models
{
    /// <summary> The LocationAnnotation. </summary>
    public partial class LocationAnnotation : Annotation
    {
        /// <summary> Initializes a new instance of LocationAnnotation. </summary>
        /// <param name="id"></param>
        /// <param name="rectangle"> x/y coordinates for the rectangular bounding box containing the data. </param>
        /// <param name="rectangles"></param>
        /// <param name="pageIndex"> The page number within the document, starting from 0. </param>
        /// <param name="raw"> Raw data extracted from the before any post-processing. </param>
        /// <param name="confidence"> The overall confidence that the model&apos;s prediction is correct. </param>
        /// <param name="classificationConfidence"> The model&apos;s confidence that the text has been classified correctly. </param>
        /// <param name="textExtractionConfidence"> If the document was submitted as an image, this is the confidence that the text in the image has been correctly read by the model. </param>
        /// <param name="isVerified"> Indicates whether the data has been validated, either by a human using our validation tool or through auto-validation rules. </param>
        /// <param name="isClientVerified"> Indicates whether the data has been validated by a human. </param>
        /// <param name="isAutoVerified"> Indicates whether the data has been auto-validated. </param>
        /// <param name="dataPoint"></param>
        /// <param name="contentType"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataPoint"/> or <paramref name="contentType"/> is null. </exception>
        public LocationAnnotation(int id, Rectangle rectangle, IEnumerable<Rectangle> rectangles, int? pageIndex, string raw, float? confidence, float? classificationConfidence, float? textExtractionConfidence, bool isVerified, bool isClientVerified, bool isAutoVerified, string dataPoint, string contentType) : base(id, rectangle, rectangles, pageIndex, raw, confidence, classificationConfidence, textExtractionConfidence, isVerified, isClientVerified, isAutoVerified, dataPoint, contentType)
        {
            if (dataPoint == null)
            {
                throw new ArgumentNullException(nameof(dataPoint));
            }
            if (contentType == null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }
        }

        /// <summary> Initializes a new instance of LocationAnnotation. </summary>
        /// <param name="id"></param>
        /// <param name="rectangle"> x/y coordinates for the rectangular bounding box containing the data. </param>
        /// <param name="rectangles"></param>
        /// <param name="pageIndex"> The page number within the document, starting from 0. </param>
        /// <param name="raw"> Raw data extracted from the before any post-processing. </param>
        /// <param name="confidence"> The overall confidence that the model&apos;s prediction is correct. </param>
        /// <param name="classificationConfidence"> The model&apos;s confidence that the text has been classified correctly. </param>
        /// <param name="textExtractionConfidence"> If the document was submitted as an image, this is the confidence that the text in the image has been correctly read by the model. </param>
        /// <param name="isVerified"> Indicates whether the data has been validated, either by a human using our validation tool or through auto-validation rules. </param>
        /// <param name="isClientVerified"> Indicates whether the data has been validated by a human. </param>
        /// <param name="isAutoVerified"> Indicates whether the data has been auto-validated. </param>
        /// <param name="dataPoint"></param>
        /// <param name="contentType"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="parsed"></param>
        internal LocationAnnotation(int id, Rectangle rectangle, IList<Rectangle> rectangles, int? pageIndex, string raw, float? confidence, float? classificationConfidence, float? textExtractionConfidence, bool isVerified, bool isClientVerified, bool isAutoVerified, string dataPoint, string contentType, IDictionary<string, object> additionalProperties, Location parsed) : base(id, rectangle, rectangles, pageIndex, raw, confidence, classificationConfidence, textExtractionConfidence, isVerified, isClientVerified, isAutoVerified, dataPoint, contentType, additionalProperties)
        {
            Parsed = parsed;
        }

        /// <summary> Gets or sets the parsed. </summary>
        public Location Parsed { get; set; }
    }
}
