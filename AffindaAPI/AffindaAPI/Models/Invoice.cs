// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The Invoice. </summary>
    public partial class Invoice : Document
    {
        /// <summary> Initializes a new instance of Invoice. </summary>
        /// <param name="meta"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="meta"/> is null. </exception>
        public Invoice(DocumentMeta meta) : base(meta)
        {
            if (meta == null)
            {
                throw new ArgumentNullException(nameof(meta));
            }

            Extractor = "invoice";
        }

        /// <summary> Initializes a new instance of Invoice. </summary>
        /// <param name="data"> Any object. </param>
        /// <param name="extractor"></param>
        /// <param name="meta"></param>
        /// <param name="error"></param>
        internal Invoice(object data, string extractor, DocumentMeta meta, DocumentError error) : base(data, extractor, meta, error)
        {
            Extractor = extractor ?? "invoice";
        }
    }
}
