// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class ExtractorUpdate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(NamePlural))
            {
                writer.WritePropertyName("namePlural");
                writer.WriteStringValue(NamePlural);
            }
            if (Optional.IsDefined(BaseExtractor))
            {
                writer.WritePropertyName("baseExtractor");
                writer.WriteNumberValue(BaseExtractor.Value);
            }
            if (Optional.IsDefined(Category))
            {
                if (Category != null)
                {
                    writer.WritePropertyName("category");
                    writer.WriteStringValue(Category);
                }
                else
                {
                    writer.WriteNull("category");
                }
            }
            if (Optional.IsDefined(Validatable))
            {
                writer.WritePropertyName("validatable");
                writer.WriteBooleanValue(Validatable.Value);
            }
            if (Optional.IsDefined(FieldGroups))
            {
                if (FieldGroups != null)
                {
                    writer.WritePropertyName("fieldGroups");
                    writer.WriteObjectValue(FieldGroups);
                }
                else
                {
                    writer.WriteNull("fieldGroups");
                }
            }
            writer.WriteEndObject();
        }
    }
}