// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Rectangle : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("x0");
            writer.WriteNumberValue(X0);
            writer.WritePropertyName("y0");
            writer.WriteNumberValue(Y0);
            writer.WritePropertyName("x1");
            writer.WriteNumberValue(X1);
            writer.WritePropertyName("y1");
            writer.WriteNumberValue(Y1);
            writer.WriteEndObject();
        }

        internal static Rectangle DeserializeRectangle(JsonElement element)
        {
            float x0 = default;
            float y0 = default;
            float x1 = default;
            float y1 = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("x0"))
                {
                    x0 = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("y0"))
                {
                    y0 = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("x1"))
                {
                    x1 = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("y1"))
                {
                    y1 = property.Value.GetSingle();
                    continue;
                }
            }
            return new Rectangle(x0, y0, x1, y1);
        }
    }
}
