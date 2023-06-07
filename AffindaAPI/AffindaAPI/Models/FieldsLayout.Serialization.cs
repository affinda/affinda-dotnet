// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class FieldsLayout : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("defaultCategory");
            writer.WriteObjectValue(DefaultCategory);
            writer.WritePropertyName("categories");
            writer.WriteStartArray();
            foreach (var item in Categories)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static FieldsLayout DeserializeFieldsLayout(JsonElement element)
        {
            FieldCategory defaultCategory = default;
            IList<FieldCategory> categories = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultCategory"))
                {
                    defaultCategory = FieldCategory.DeserializeFieldCategory(property.Value);
                    continue;
                }
                if (property.NameEquals("categories"))
                {
                    List<FieldCategory> array = new List<FieldCategory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FieldCategory.DeserializeFieldCategory(item));
                    }
                    categories = array;
                    continue;
                }
            }
            return new FieldsLayout(defaultCategory, categories);
        }
    }
}
