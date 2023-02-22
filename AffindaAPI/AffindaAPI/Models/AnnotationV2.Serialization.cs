// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class AnnotationV2 : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteNumberValue(Id);
            if (Rectangle != null)
            {
                writer.WritePropertyName("rectangle");
                writer.WriteObjectValue(Rectangle);
            }
            else
            {
                writer.WriteNull("rectangle");
            }
            if (Rectangles != null)
            {
                writer.WritePropertyName("rectangles");
                writer.WriteStartArray();
                foreach (var item in Rectangles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            else
            {
                writer.WriteNull("rectangles");
            }
            if (PageIndex != null)
            {
                writer.WritePropertyName("pageIndex");
                writer.WriteNumberValue(PageIndex.Value);
            }
            else
            {
                writer.WriteNull("pageIndex");
            }
            if (Raw != null)
            {
                writer.WritePropertyName("raw");
                writer.WriteStringValue(Raw);
            }
            else
            {
                writer.WriteNull("raw");
            }
            if (Confidence != null)
            {
                writer.WritePropertyName("confidence");
                writer.WriteNumberValue(Confidence.Value);
            }
            else
            {
                writer.WriteNull("confidence");
            }
            if (ClassificationConfidence != null)
            {
                writer.WritePropertyName("classificationConfidence");
                writer.WriteNumberValue(ClassificationConfidence.Value);
            }
            else
            {
                writer.WriteNull("classificationConfidence");
            }
            if (TextExtractionConfidence != null)
            {
                writer.WritePropertyName("textExtractionConfidence");
                writer.WriteNumberValue(TextExtractionConfidence.Value);
            }
            else
            {
                writer.WriteNull("textExtractionConfidence");
            }
            writer.WritePropertyName("isVerified");
            writer.WriteBooleanValue(IsVerified);
            writer.WritePropertyName("isClientVerified");
            writer.WriteBooleanValue(IsClientVerified);
            writer.WritePropertyName("isAutoVerified");
            writer.WriteBooleanValue(IsAutoVerified);
            if (Optional.IsDefined(DataPoint))
            {
                writer.WritePropertyName("dataPoint");
                writer.WriteStringValue(DataPoint);
            }
            writer.WritePropertyName("contentType");
            writer.WriteStringValue(ContentType);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static AnnotationV2 DeserializeAnnotationV2(JsonElement element)
        {
            int id = default;
            Rectangle rectangle = default;
            IList<Rectangle> rectangles = default;
            int? pageIndex = default;
            string raw = default;
            float? confidence = default;
            float? classificationConfidence = default;
            float? textExtractionConfidence = default;
            bool isVerified = default;
            bool isClientVerified = default;
            bool isAutoVerified = default;
            Optional<string> dataPoint = default;
            string contentType = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
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
            return new AnnotationV2(id, rectangle, rectangles, pageIndex, raw, confidence, classificationConfidence, textExtractionConfidence, isVerified, isClientVerified, isAutoVerified, dataPoint.Value, contentType, additionalProperties);
        }
    }
}
