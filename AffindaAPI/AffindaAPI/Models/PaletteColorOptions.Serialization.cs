// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class PaletteColorOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("main");
            writer.WriteStringValue(Main);
            if (Optional.IsDefined(Light))
            {
                writer.WritePropertyName("light");
                writer.WriteStringValue(Light);
            }
            if (Optional.IsDefined(Dark))
            {
                writer.WritePropertyName("dark");
                writer.WriteStringValue(Dark);
            }
            if (Optional.IsDefined(ContrastText))
            {
                writer.WritePropertyName("contrastText");
                writer.WriteStringValue(ContrastText);
            }
            writer.WriteEndObject();
        }

        internal static PaletteColorOptions DeserializePaletteColorOptions(JsonElement element)
        {
            string main = default;
            Optional<string> light = default;
            Optional<string> dark = default;
            Optional<string> contrastText = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("main"))
                {
                    main = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("light"))
                {
                    light = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dark"))
                {
                    dark = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contrastText"))
                {
                    contrastText = property.Value.GetString();
                    continue;
                }
            }
            return new PaletteColorOptions(main, light.Value, dark.Value, contrastText.Value);
        }
    }
}
