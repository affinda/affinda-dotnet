// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class FieldDeprecated : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("label");
            writer.WriteStringValue(Label);
            if (Optional.IsDefined(Slug))
            {
                if (Slug != null)
                {
                    writer.WritePropertyName("slug");
                    writer.WriteStringValue(Slug);
                }
                else
                {
                    writer.WriteNull("slug");
                }
            }
            writer.WritePropertyName("fieldType");
            writer.WriteStringValue(FieldType.ToString());
            if (Optional.IsDefined(DataSource))
            {
                if (DataSource != null)
                {
                    writer.WritePropertyName("dataSource");
                    writer.WriteStringValue(DataSource);
                }
                else
                {
                    writer.WriteNull("dataSource");
                }
            }
            if (Optional.IsDefined(Mapping))
            {
                if (Mapping != null)
                {
                    writer.WritePropertyName("mapping");
                    writer.WriteStringValue(Mapping);
                }
                else
                {
                    writer.WriteNull("mapping");
                }
            }
            writer.WritePropertyName("dataPoint");
            writer.WriteStringValue(DataPoint);
            if (Optional.IsDefined(Mandatory))
            {
                writer.WritePropertyName("mandatory");
                writer.WriteBooleanValue(Mandatory.Value);
            }
            if (Optional.IsDefined(Disabled))
            {
                writer.WritePropertyName("disabled");
                writer.WriteBooleanValue(Disabled.Value);
            }
            if (Optional.IsDefined(AutoValidationThreshold))
            {
                if (AutoValidationThreshold != null)
                {
                    writer.WritePropertyName("autoValidationThreshold");
                    writer.WriteNumberValue(AutoValidationThreshold.Value);
                }
                else
                {
                    writer.WriteNull("autoValidationThreshold");
                }
            }
            if (Optional.IsDefined(ShowDropdown))
            {
                writer.WritePropertyName("showDropdown");
                writer.WriteBooleanValue(ShowDropdown.Value);
            }
            if (Optional.IsDefined(DisplayRawText))
            {
                writer.WritePropertyName("displayRawText");
                writer.WriteBooleanValue(DisplayRawText.Value);
            }
            if (Optional.IsDefined(DropNull))
            {
                writer.WritePropertyName("dropNull");
                writer.WriteBooleanValue(DropNull.Value);
            }
            if (Optional.IsDefined(DisplayEnumValue))
            {
                writer.WritePropertyName("displayEnumValue");
                writer.WriteBooleanValue(DisplayEnumValue.Value);
            }
            if (Optional.IsCollectionDefined(Fields))
            {
                writer.WritePropertyName("fields");
                writer.WriteStartArray();
                foreach (var item in Fields)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static FieldDeprecated DeserializeFieldDeprecated(JsonElement element)
        {
            string label = default;
            Optional<string> slug = default;
            AnnotationContentType fieldType = default;
            Optional<string> dataSource = default;
            Optional<string> mapping = default;
            string dataPoint = default;
            Optional<bool> mandatory = default;
            Optional<bool> disabled = default;
            Optional<float?> autoValidationThreshold = default;
            Optional<bool> showDropdown = default;
            Optional<bool> displayRawText = default;
            Optional<bool> dropNull = default;
            Optional<bool> displayEnumValue = default;
            Optional<IList<FieldDeprecated>> fields = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("slug"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        slug = null;
                        continue;
                    }
                    slug = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fieldType"))
                {
                    fieldType = new AnnotationContentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSource"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataSource = null;
                        continue;
                    }
                    dataSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mapping"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        mapping = null;
                        continue;
                    }
                    mapping = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataPoint"))
                {
                    dataPoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mandatory"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mandatory = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("autoValidationThreshold"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        autoValidationThreshold = null;
                        continue;
                    }
                    autoValidationThreshold = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("showDropdown"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    showDropdown = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("displayRawText"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    displayRawText = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dropNull"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dropNull = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("displayEnumValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    displayEnumValue = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("fields"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<FieldDeprecated> array = new List<FieldDeprecated>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeFieldDeprecated(item));
                    }
                    fields = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new FieldDeprecated(label, slug.Value, fieldType, dataSource.Value, mapping.Value, dataPoint, Optional.ToNullable(mandatory), Optional.ToNullable(disabled), Optional.ToNullable(autoValidationThreshold), Optional.ToNullable(showDropdown), Optional.ToNullable(displayRawText), Optional.ToNullable(dropNull), Optional.ToNullable(displayEnumValue), Optional.ToList(fields), additionalProperties);
        }
    }
}
