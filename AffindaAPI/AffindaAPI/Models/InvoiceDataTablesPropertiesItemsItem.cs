// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The InvoiceDataTablesPropertiesItemsItem. </summary>
    public partial class InvoiceDataTablesPropertiesItemsItem
    {
        /// <summary> Initializes a new instance of InvoiceDataTablesPropertiesItemsItem. </summary>
        public InvoiceDataTablesPropertiesItemsItem()
        {
            Rows = new ChangeTrackingList<RowAnnotation>();
        }

        /// <summary> Initializes a new instance of InvoiceDataTablesPropertiesItemsItem. </summary>
        /// <param name="rows"></param>
        internal InvoiceDataTablesPropertiesItemsItem(IList<RowAnnotation> rows)
        {
            Rows = rows;
        }

        /// <summary> Gets the rows. </summary>
        public IList<RowAnnotation> Rows { get; }
    }
}
