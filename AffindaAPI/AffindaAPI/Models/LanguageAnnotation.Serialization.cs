// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class LanguageAnnotation
    {
        internal static LanguageAnnotation DeserializeLanguageAnnotation(JsonElement element)
        {
            Optional<string> parsed = default;
            int id = default;
            Rectangle rectangle = default;
            IReadOnlyList<Rectangle> rectangles = default;
            int? pageIndex = default;
            string raw = default;
            float? confidence = default;
            float? classificationConfidence = default;
            float? textExtractionConfidence = default;
            bool isVerified = default;
            bool isClientVerified = default;
            bool isAutoVerified = default;
            string dataPoint = default;
            string contentType = default;
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
                    isClientVerified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isAutoVerified"))
                {
                    isAutoVerified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dataPoint"))
                {
                    dataPoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentType"))
                {
                    contentType = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new LanguageAnnotation(id, rectangle, rectangles, pageIndex, raw, confidence, classificationConfidence, textExtractionConfidence, isVerified, isClientVerified, isAutoVerified, dataPoint, contentType, additionalProperties, parsed.Value);
        }
    }
}
