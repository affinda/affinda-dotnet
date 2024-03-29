// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class DataFieldCreate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CategoryLabel))
            {
                writer.WritePropertyName("categoryLabel");
                writer.WriteStringValue(CategoryLabel);
            }
            writer.WritePropertyName("field");
            writer.WriteObjectValue(Field);
            writer.WritePropertyName("dataPoint");
            writer.WriteObjectValue(DataPoint);
            writer.WriteEndObject();
        }
    }
}
