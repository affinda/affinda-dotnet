// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The InvoiceDataTablesItem. </summary>
    public partial class InvoiceDataTablesItem
    {
        /// <summary> Initializes a new instance of InvoiceDataTablesItem. </summary>
        public InvoiceDataTablesItem()
        {
            Parsed = new ChangeTrackingList<InvoiceDataTablesPropertiesItemsItem>();
        }

        /// <summary> Initializes a new instance of InvoiceDataTablesItem. </summary>
        /// <param name="parsed"></param>
        internal InvoiceDataTablesItem(IList<InvoiceDataTablesPropertiesItemsItem> parsed)
        {
            Parsed = parsed;
        }

        /// <summary> Gets the parsed. </summary>
        public IList<InvoiceDataTablesPropertiesItemsItem> Parsed { get; }
    }
}
