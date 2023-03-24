// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The DataPointCreate. </summary>
    public partial class DataPointCreate
    {
        /// <summary> Initializes a new instance of DataPointCreate. </summary>
        /// <param name="slug"></param>
        /// <param name="annotationContentType"></param>
        /// <param name="organization"> Uniquely identify an organization. </param>
        /// <param name="extractor"> Uniquely identify an extractor. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="slug"/>, <paramref name="organization"/> or <paramref name="extractor"/> is null. </exception>
        public DataPointCreate(string slug, AnnotationContentType annotationContentType, string organization, string extractor)
        {
            if (slug == null)
            {
                throw new ArgumentNullException(nameof(slug));
            }
            if (organization == null)
            {
                throw new ArgumentNullException(nameof(organization));
            }
            if (extractor == null)
            {
                throw new ArgumentNullException(nameof(extractor));
            }

            Slug = slug;
            AnnotationContentType = annotationContentType;
            Organization = organization;
            Extractor = extractor;
        }

        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets the slug. </summary>
        public string Slug { get; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
        /// <summary> Gets the annotation content type. </summary>
        public AnnotationContentType AnnotationContentType { get; }
        /// <summary> Uniquely identify an organization. </summary>
        public string Organization { get; }
        /// <summary> Uniquely identify an extractor. </summary>
        public string Extractor { get; }
        /// <summary> Gets or sets the multiple. </summary>
        public bool? Multiple { get; set; }
        /// <summary> Gets or sets the no rect. </summary>
        public bool? NoRect { get; set; }
    }
}