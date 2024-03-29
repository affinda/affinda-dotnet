// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class ThemeConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Palette))
            {
                writer.WritePropertyName("palette");
                writer.WriteObjectValue(Palette);
            }
            if (Optional.IsDefined(Typography))
            {
                writer.WritePropertyName("typography");
                writer.WriteObjectValue(Typography);
            }
            if (Optional.IsDefined(BorderRadius))
            {
                writer.WritePropertyName("borderRadius");
                writer.WriteNumberValue(BorderRadius.Value);
            }
            if (Optional.IsDefined(FontUrl))
            {
                writer.WritePropertyName("fontUrl");
                writer.WriteStringValue(FontUrl);
            }
            writer.WriteEndObject();
        }

        internal static ThemeConfig DeserializeThemeConfig(JsonElement element)
        {
            Optional<ThemeConfigPalette> palette = default;
            Optional<ThemeConfigTypography> typography = default;
            Optional<float> borderRadius = default;
            Optional<string> fontUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("palette"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    palette = ThemeConfigPalette.DeserializeThemeConfigPalette(property.Value);
                    continue;
                }
                if (property.NameEquals("typography"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    typography = ThemeConfigTypography.DeserializeThemeConfigTypography(property.Value);
                    continue;
                }
                if (property.NameEquals("borderRadius"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    borderRadius = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("fontUrl"))
                {
                    fontUrl = property.Value.GetString();
                    continue;
                }
            }
            return new ThemeConfig(palette.Value, typography.Value, Optional.ToNullable(borderRadius), fontUrl.Value);
        }
    }
}
