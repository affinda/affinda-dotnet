// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class MappingDataSourceCreate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                if (Name != null)
                {
                    writer.WritePropertyName("name");
                    writer.WriteStringValue(Name);
                }
                else
                {
                    writer.WriteNull("name");
                }
            }
            writer.WritePropertyName("organization");
            writer.WriteStringValue(Organization);
            if (Optional.IsDefined(KeyProperty))
            {
                writer.WritePropertyName("keyProperty");
                writer.WriteStringValue(KeyProperty);
            }
            if (Optional.IsDefined(DisplayProperty))
            {
                writer.WritePropertyName("displayProperty");
                writer.WriteStringValue(DisplayProperty);
            }
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values");
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema");
                writer.WriteObjectValue(Schema);
            }
            writer.WriteEndObject();
        }
    }
}