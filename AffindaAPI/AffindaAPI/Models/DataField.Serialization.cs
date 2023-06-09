// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class DataField
    {
        internal static DataField DeserializeDataField(JsonElement element)
        {
            Optional<string> categoryLabel = default;
            DataFieldField field = default;
            DataFieldDataPoint dataPoint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("categoryLabel"))
                {
                    categoryLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("field"))
                {
                    field = DataFieldField.DeserializeDataFieldField(property.Value);
                    continue;
                }
                if (property.NameEquals("dataPoint"))
                {
                    dataPoint = DataFieldDataPoint.DeserializeDataFieldDataPoint(property.Value);
                    continue;
                }
            }
            return new DataField(categoryLabel.Value, field, dataPoint);
        }
    }
}