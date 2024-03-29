// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The TableBetaAnnotationParsed. </summary>
    public partial class TableBetaAnnotationParsed
    {
        /// <summary> Initializes a new instance of TableBetaAnnotationParsed. </summary>
        public TableBetaAnnotationParsed()
        {
            Rows = new ChangeTrackingList<RowBetaAnnotation>();
        }

        /// <summary> Initializes a new instance of TableBetaAnnotationParsed. </summary>
        /// <param name="rows"></param>
        internal TableBetaAnnotationParsed(IList<RowBetaAnnotation> rows)
        {
            Rows = rows;
        }

        /// <summary> Gets the rows. </summary>
        public IList<RowBetaAnnotation> Rows { get; }
    }
}
