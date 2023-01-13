// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class InvoiceDataCustomerVat
    {
        internal static InvoiceDataCustomerVat DeserializeInvoiceDataCustomerVat(JsonElement element)
        {
            Optional<string> parsed = default;
            Optional<int?> id = default;
            Rectangle rectangle = default;
            Optional<IReadOnlyList<Rectangle>> rectangles = default;
            int? pageIndex = default;
            string raw = default;
            float? confidence = default;
            float? classificationConfidence = default;
            float? textExtractionConfidence = default;
            bool isVerified = default;
            Optional<bool> isClientVerified = default;
            Optional<bool> isAutoVerified = default;
            string classification = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parsed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        parsed = null;
                        continue;
                    }
                    parsed = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        id = null;
                        continue;
                    }
                    id = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rectangle"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        rectangle = null;
                        continue;
                    }
                    rectangle = Rectangle.DeserializeRectangle(property.Value);
                    continue;
                }
                if (property.NameEquals("rectangles"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        rectangles = null;
                        continue;
                    }
                    List<Rectangle> array = new List<Rectangle>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Rectangle.DeserializeRectangle(item));
                    }
                    rectangles = array;
                    continue;
                }
                if (property.NameEquals("pageIndex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        pageIndex = null;
                        continue;
                    }
                    pageIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("raw"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        raw = null;
                        continue;
                    }
                    raw = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidence"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        confidence = null;
                        continue;
                    }
                    confidence = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("classificationConfidence"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        classificationConfidence = null;
                        continue;
                    }
                    classificationConfidence = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("textExtractionConfidence"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        textExtractionConfidence = null;
                        continue;
                    }
                    textExtractionConfidence = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("isVerified"))
                {
                    isVerified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isClientVerified"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isClientVerified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isAutoVerified"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isAutoVerified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("classification"))
                {
                    classification = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new InvoiceDataCustomerVat(Optional.ToNullable(id), rectangle, Optional.ToList(rectangles), pageIndex, raw, confidence, classificationConfidence, textExtractionConfidence, isVerified, Optional.ToNullable(isClientVerified), Optional.ToNullable(isAutoVerified), classification, additionalProperties, parsed.Value);
        }
    }
}
