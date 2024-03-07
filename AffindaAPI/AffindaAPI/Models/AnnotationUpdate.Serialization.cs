// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class AnnotationUpdate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Rectangles))
            {
                writer.WritePropertyName("rectangles");
                writer.WriteStartArray();
                foreach (var item in Rectangles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Document))
            {
                writer.WritePropertyName("document");
                writer.WriteStringValue(Document);
            }
            if (Optional.IsDefined(PageIndex))
            {
                if (PageIndex != null)
                {
                    writer.WritePropertyName("pageIndex");
                    writer.WriteNumberValue(PageIndex.Value);
                }
                else
                {
                    writer.WriteNull("pageIndex");
                }
            }
            if (Optional.IsDefined(Raw))
            {
                if (Raw != null)
                {
                    writer.WritePropertyName("raw");
                    writer.WriteStringValue(Raw);
                }
                else
                {
                    writer.WriteNull("raw");
                }
            }
            if (Optional.IsDefined(Parsed))
            {
                writer.WritePropertyName("parsed");
                writer.WriteObjectValue(Parsed);
            }
            if (Optional.IsDefined(IsClientVerified))
            {
                writer.WritePropertyName("isClientVerified");
                writer.WriteBooleanValue(IsClientVerified.Value);
            }
            if (Optional.IsDefined(DataPoint))
            {
                writer.WritePropertyName("dataPoint");
                writer.WriteStringValue(DataPoint);
            }
            if (Optional.IsDefined(Parent))
            {
                if (Parent != null)
                {
                    writer.WritePropertyName("parent");
                    writer.WriteNumberValue(Parent.Value);
                }
                else
                {
                    writer.WriteNull("parent");
                }
            }
            if (Optional.IsCollectionDefined(ValidationResults))
            {
                writer.WritePropertyName("validationResults");
                writer.WriteStartArray();
                foreach (var item in ValidationResults)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
