// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The JobDescription. </summary>
    public partial class JobDescription : Document
    {
        /// <summary> Initializes a new instance of JobDescription. </summary>
        /// <param name="meta"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="meta"/> is null. </exception>
        public JobDescription(DocumentMeta meta) : base(meta)
        {
            if (meta == null)
            {
                throw new ArgumentNullException(nameof(meta));
            }

            Extractor = "job-description";
        }

        /// <summary> Initializes a new instance of JobDescription. </summary>
        /// <param name="extractor"></param>
        /// <param name="meta"></param>
        /// <param name="error"></param>
        /// <param name="data"></param>
        internal JobDescription(string extractor, DocumentMeta meta, DocumentError error, JobDescriptionData data) : base(extractor, meta, error)
        {
            Data = data;
            Extractor = extractor ?? "job-description";
        }

        /// <summary> Gets or sets the data. </summary>
        public JobDescriptionData Data { get; set; }
    }
}
