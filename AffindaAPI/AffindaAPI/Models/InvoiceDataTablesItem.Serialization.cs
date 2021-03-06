// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class InvoiceDataTablesItem
    {
        internal static InvoiceDataTablesItem DeserializeInvoiceDataTablesItem(JsonElement element)
        {
            Optional<IReadOnlyList<RowAnnotation>> rows = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rows"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RowAnnotation> array = new List<RowAnnotation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RowAnnotation.DeserializeRowAnnotation(item));
                    }
                    rows = array;
                    continue;
                }
            }
            return new InvoiceDataTablesItem(Optional.ToList(rows));
        }
    }
}
