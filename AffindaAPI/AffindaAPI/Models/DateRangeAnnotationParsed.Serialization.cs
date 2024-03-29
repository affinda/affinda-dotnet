// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class DateRangeAnnotationParsed : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Start))
            {
                if (Start != null)
                {
                    writer.WritePropertyName("start");
                    writer.WriteObjectValue(Start);
                }
                else
                {
                    writer.WriteNull("start");
                }
            }
            if (Optional.IsDefined(End))
            {
                if (End != null)
                {
                    writer.WritePropertyName("end");
                    writer.WriteObjectValue(End);
                }
                else
                {
                    writer.WriteNull("end");
                }
            }
            writer.WriteEndObject();
        }

        internal static DateRangeAnnotationParsed DeserializeDateRangeAnnotationParsed(JsonElement element)
        {
            Optional<DateRangeValue> start = default;
            Optional<DateRangeValue> end = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("start"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        start = null;
                        continue;
                    }
                    start = DateRangeValue.DeserializeDateRangeValue(property.Value);
                    continue;
                }
                if (property.NameEquals("end"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        end = null;
                        continue;
                    }
                    end = DateRangeValue.DeserializeDateRangeValue(property.Value);
                    continue;
                }
            }
            return new DateRangeAnnotationParsed(start.Value, end.Value);
        }
    }
}
